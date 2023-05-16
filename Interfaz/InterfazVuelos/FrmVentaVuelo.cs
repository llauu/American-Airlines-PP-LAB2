using Entidades;
using Interfaz.InterfazVuelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz.InterfazViajes {
    public partial class FrmVentaVuelo : FrmBotonCancelar {
        private List<Pasaje> pasajesAgregados = new List<Pasaje>();
        private Vuelo vueloSeleccionado;
        private int asientosPremiumOcupados;
        private int asientosTuristaOcupados;

        public FrmVentaVuelo(Vuelo vueloSeleccionado) {
            InitializeComponent();
            this.vueloSeleccionado = vueloSeleccionado;

            this.toolTip1.SetToolTip(btnAgregarEquipaje, "Agregar equipaje al pasajero");
            this.toolTip1.SetToolTip(btnDatosEquipajes, "Mirar equipajes cargados");
        }

        private void FrmVentaVuelo_Load(object sender, EventArgs e) {
            ActualizarDataGridPasajeros();

            asientosPremiumOcupados = vueloSeleccionado.AsientosPremiumOcupados;
            asientosTuristaOcupados = vueloSeleccionado.AsientosTuristaOcupados;
        }

        public List<Pasaje> PasajesAgregados {
            get { return this.pasajesAgregados; }
        }

        private void ActualizarDataGridPasajeros() {
            dataGridPasajeros.DataSource = null;

            if (Sistema.ListaPasajeros != null && Sistema.ListaPasajeros.Count > 0) {
                dataGridPasajeros.DataSource = Sistema.ListaPasajeros;

                dataGridPasajeros.Columns["Apellido"].DisplayIndex = 0;
                dataGridPasajeros.Columns["Nombre"].DisplayIndex = 1;
                dataGridPasajeros.Columns["Dni"].DisplayIndex = 2;
                dataGridPasajeros.Columns["FechaDeNacimiento"].Visible = false;
                dataGridPasajeros.Columns["Edad"].Visible = false;

                dataGridPasajeros.ClearSelection();
            }
        }

        private void ActualizarDataGridPasajesAgregados() {
            dataGridPasajesAgregados.DataSource = null;

            if (pasajesAgregados.Count > 0) {
                dataGridPasajesAgregados.DataSource = pasajesAgregados;

                dataGridPasajesAgregados.Columns["NumeroDeEquipaje"].Visible = false;
                dataGridPasajesAgregados.Columns["EquipajesDeBodega"].Visible = false;
            }
        }

        private void btnAgregarPasajero_Click(object sender, EventArgs e) {
            this.imgError.Visible = false;
            this.lblError.Visible = false;
            Pasajero pasajero;
            bool equipajeDeMano = checkEquipajeMano.Checked;
            bool clasePremium = checkClasePremium.Checked;
            ETipoClase clasePasajero = clasePremium ? ETipoClase.Premium : ETipoClase.Turista;


            if (Sistema.ListaPasajeros != null && Sistema.ListaPasajeros.Count > 0) {
                if (dataGridPasajeros.CurrentRow != null) {
                    pasajero = (Pasajero)dataGridPasajeros.CurrentRow.DataBoundItem;

                    VenderPasaje(pasajero, equipajeDeMano, clasePasajero, vueloSeleccionado);
                }
                else {
                    FrmMenuPrincipal.ActualizarMensajeDeError(this.imgError, this.lblError, "Seleccione un pasajero para venderle el pasaje.");
                }
            }
            else {
                FrmMenuPrincipal.ActualizarMensajeDeError(this.imgError, this.lblError, "La venta de pasajes no esta disponible ya que no hay pasajeros cargados.");
            }
        }

        private void VenderPasaje(Pasajero pasajero, bool equipajeDeMano, ETipoClase clasePasajero, Vuelo vuelo) {
            try {
                Validador.ValidarDisponibilidadAsientos(vuelo, clasePasajero, asientosTuristaOcupados, asientosPremiumOcupados);

                Pasaje pasaje = new Pasaje(pasajero, equipajeDeMano, clasePasajero, vuelo);
                pasajesAgregados.Add(pasaje);

                OcuparAsiento(clasePasajero);

                ActualizarDataGridPasajesAgregados();
            }
            catch(Exception ex) {
                FrmMenuPrincipal.ActualizarMensajeDeError(this.imgError, this.lblError, ex.Message);
            }
        }

        private void OcuparAsiento(ETipoClase clasePasajero) {
            if (clasePasajero == ETipoClase.Turista) {
                asientosTuristaOcupados++;
            }
            else {
                asientosPremiumOcupados++;
            }
        }

        private void btnAgregarEquipaje_Click(object sender, EventArgs e) {
            this.imgError.Visible = false;
            this.lblError.Visible = false;

            if (this.pasajesAgregados.Count > 0) {
                Pasaje pasaje = (Pasaje)dataGridPasajesAgregados.CurrentRow.DataBoundItem;

                FrmAgregarEquipaje frmAgregarEquipaje = new FrmAgregarEquipaje(pasaje);

                if (frmAgregarEquipaje.ShowDialog() == DialogResult.OK) {
                    try {
                        ActualizarDataGridPasajesAgregados();
                    }
                    catch (Exception ex) {
                        FrmMenuPrincipal.ActualizarMensajeDeError(this.imgError, this.lblError, ex.Message);
                    }
                }
            }
            else {
                FrmMenuPrincipal.ActualizarMensajeDeError(this.imgError, this.lblError, "No se puede agregar equipajes si no hay pasajeros agregados al vuelo.");
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDatosEquipajes_Click(object sender, EventArgs e) {

            if (this.pasajesAgregados.Count > 0) {
                Pasaje pasaje = (Pasaje)dataGridPasajesAgregados.CurrentRow.DataBoundItem;

                MessageBox.Show(pasaje.MostrarEquipajes());
            }
            else {
                FrmMenuPrincipal.ActualizarMensajeDeError(this.imgError, this.lblError, "No se puede agregar equipajes si no hay pasajeros agregados al vuelo.");
            }
        }
    }
}

