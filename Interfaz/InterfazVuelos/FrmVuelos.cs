using Entidades;
using Interfaz.InterfazAeronaves;
using Interfaz.InterfazViajes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz {
    public partial class FrmVuelos : Form {
        public FrmVuelos() {
            InitializeComponent();

            this.toolTip1.SetToolTip(btnAgregar, "Agregar vuelo");
            this.toolTip1.SetToolTip(btnEliminar, "Eliminar vuelo");
            this.toolTip1.SetToolTip(btnEditar, "Editar vuelo");
            this.toolTip1.SetToolTip(btnInfoAvion, "Informacion detallada del vuelo");
        }

        private void FrmViajes_Load(object sender, EventArgs e) {
            if (Sistema.ListaVuelos != null) {
                FrmVuelosDisponibles.ActualizarDataGridView(this.imgError, this.lblError, dataGridViajes, Sistema.ListaVuelos);
            }
        }

        private void btnInfoAvion_Click(object sender, EventArgs e) {
            FrmVuelosDisponibles.AbrirBotonInfoVuelo(this.imgError, this.lblError, this.dataGridViajes);
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            if (Sistema.ListaAeronaves != null && Sistema.ListaVuelos != null && Sistema.ListaAeronaves.Count > 0) {
                FrmAltaVuelo frmAlta = new FrmAltaVuelo();
                this.imgError.Visible = false;
                this.lblError.Visible = false;

                DialogResult res = frmAlta.ShowDialog();

                if (res == DialogResult.OK) {
                    Sistema.AltaVuelo(frmAlta.VueloAgregado);
                    FrmVuelosDisponibles.ActualizarDataGridView(this.imgError, this.lblError, this.dataGridViajes, Sistema.ListaVuelos);
                }
            }
            else {
                FrmMenuPrincipal.ActualizarMensajeDeError(this.imgError, this.lblError, "No se puede dar de alta un vuelo si no hay aviones cargadados.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (Sistema.ListaVuelos != null && this.dataGridViajes.Rows.Count > 0) {
                Vuelo vueloAEliminar = (Vuelo)dataGridViajes.CurrentRow.DataBoundItem;

                if (vueloAEliminar.EstadoDelVuelo == EEstadoVuelo.EnTierra) {
                    DialogResult res = MessageBox.Show($"Se va a eliminar el vuelo: \n{vueloAEliminar}\nEsta seguro?", "Eliminar vuelo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                    if (res == DialogResult.Yes) {
                        Sistema.BajaVuelo(vueloAEliminar);
                        FrmVuelosDisponibles.ActualizarDataGridView(this.imgError, this.lblError, this.dataGridViajes, Sistema.ListaVuelos);
                    }
                }
                else {
                    FrmMenuPrincipal.ActualizarMensajeDeError(this.imgError, this.lblError, "El vuelo que esta queriendo eliminar se encuentra en curso o finalizado.");
                }
            }
            else {
                FrmMenuPrincipal.ActualizarMensajeDeError(this.imgError, this.lblError, "No hay vuelos cargados para eliminar.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            if (Sistema.ListaVuelos != null && this.dataGridViajes.Rows.Count > 0) {
                this.imgError.Visible = false;
                this.lblError.Visible = false;

                Vuelo vueloAEditar = (Vuelo)dataGridViajes.CurrentRow.DataBoundItem;

                FrmEditarVuelo frmEditar = new FrmEditarVuelo(vueloAEditar);

                DialogResult res = frmEditar.ShowDialog();

                if (res == DialogResult.OK) {
                    FrmVuelosDisponibles.ActualizarDataGridView(this.imgError, this.lblError, this.dataGridViajes, Sistema.ListaVuelos);
                }
            }
            else {
                FrmMenuPrincipal.ActualizarMensajeDeError(this.imgError, this.lblError, "No hay vuelos cargados para editar.");
            }
        }
    }
}
