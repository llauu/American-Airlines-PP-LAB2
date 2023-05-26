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
        private List<Pasaje> pasajesAgregados;
        private Vuelo vueloSeleccionado;
        private int asientosPremiumOcupados;
        private int asientosTuristaOcupados;

        public List<Pasaje> PasajesAgregados {
            get { return this.pasajesAgregados; }
        }

        public FrmVentaVuelo(Vuelo vueloSeleccionado) {
            InitializeComponent();

            pasajesAgregados = new List<Pasaje>();
            this.vueloSeleccionado = vueloSeleccionado;

            this.toolTip1.SetToolTip(btnAgregarEquipaje, "Agregar equipaje al pasajero");
            this.toolTip1.SetToolTip(btnDatosEquipajes, "Mirar equipajes cargados");
            this.toolTip1.SetToolTip(btnAgregarPasajero, "Vender pasaje al pasajero");
        }

        private void FrmVentaVuelo_Load(object sender, EventArgs e) {
            ActualizarDataGridPasajeros(Sistema.ListaPasajeros!);

            this.asientosPremiumOcupados = vueloSeleccionado.AsientosPremiumOcupados;
            this.asientosTuristaOcupados = vueloSeleccionado.AsientosTuristaOcupados;

            this.rdbNoLlevaEquipaje.Checked = true;
            this.rdbTurista.Checked = true;
        }

        private void ActualizarDataGridPasajeros(List<Pasajero> pasajeros) {
            dataGridPasajeros.DataSource = null;

            if (pasajeros != null && pasajeros.Count > 0) {
                dataGridPasajeros.DataSource = pasajeros;

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
            Pasajero pasajero;
            bool equipajeDeMano = rdbLlevaEquipaje.Checked;
            bool clasePremium = rdbPremium.Checked;
            ETipoClase clasePasajero = clasePremium ? ETipoClase.Premium : ETipoClase.Turista;

            this.imgError.Visible = false;
            this.lblError.Visible = false;

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
            catch (Exception ex) {
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
            if (pasajesAgregados.Count > 0) {
                FrmFacturaFinal frmFactura = new FrmFacturaFinal(pasajesAgregados);

                if (frmFactura.ShowDialog() == DialogResult.OK) {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else {
                this.Close();
            }
        }

        private void btnDatosEquipajes_Click(object sender, EventArgs e) {
            if (this.pasajesAgregados.Count > 0) {
                Pasaje pasaje = (Pasaje)dataGridPasajesAgregados.CurrentRow.DataBoundItem;

                MessageBox.Show(pasaje.MostrarEquipajes());
            }
            else {
                FrmMenuPrincipal.ActualizarMensajeDeError(this.imgError, this.lblError, "No se puede ver el equipaje si no hay pasajeros agregados al vuelo.");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) {
            if (Sistema.ListaPasajeros != null) {
                if (this.txtBuscar.Text.Length > 2 && !(string.IsNullOrEmpty(this.txtBuscar.Text))) {
                    List<Pasajero> pasajerosEncontrados = new List<Pasajero>();

                    Sistema.BuscarClientes(pasajerosEncontrados, this.txtBuscar.Text.ToUpper());
                    ActualizarDataGridPasajeros(pasajerosEncontrados);
                }
                else {
                    ActualizarDataGridPasajeros(Sistema.ListaPasajeros);
                }
            }
        }
    }
}

