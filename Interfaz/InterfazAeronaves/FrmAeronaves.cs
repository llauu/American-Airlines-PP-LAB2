using Entidades;
using Interfaz.InterfazAeronaves;
using Interfaz.InterfazPasajeros;
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
    public partial class FrmAeronaves : Form {
        public FrmAeronaves() {
            InitializeComponent();

            this.toolTip1.SetToolTip(btnAgregar, "Agregar aeronave");
            this.toolTip1.SetToolTip(btnEliminar, "Eliminar aeronave");
            this.toolTip1.SetToolTip(btnEditar, "Editar aeronave");
        }

        private void FrmAeronaves_Load(object sender, EventArgs e) {
            ActualizarDataGridView(dataGridAeronaves);
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            FrmAltaAeronave frmAlta = new FrmAltaAeronave();
            this.imgError.Visible = false;
            this.lblError.Visible = false;

            DialogResult res = frmAlta.ShowDialog();

            if (res == DialogResult.OK) {
                Sistema.AltaAeronave(frmAlta.AeronaveAgregada);
                ActualizarDataGridView(dataGridAeronaves);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            if (this.dataGridAeronaves.Rows.Count > 0) {
                Aeronave aeronaveAEditar = (Aeronave)dataGridAeronaves.CurrentRow.DataBoundItem;

                if (!aeronaveAEditar.VueloProgramado) {
                    FrmEditarAeronave frmEditar = new FrmEditarAeronave(aeronaveAEditar);

                    DialogResult res = frmEditar.ShowDialog();

                    if (res == DialogResult.OK) {
                        ActualizarDataGridView(dataGridAeronaves);
                    }
                }
                else {
                    FrmMenuPrincipal.ActualizarMensajeDeError(this.imgError, this.lblError, "La aeronave que se esta queriendo editar tiene un vuelo programado.");
                }
            }
            else {
                FrmMenuPrincipal.ActualizarMensajeDeError(this.imgError, this.lblError, "No hay aeronaves cargadas para editar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (this.dataGridAeronaves.Rows.Count > 0) {
                Aeronave aeronaveAEliminar = (Aeronave)dataGridAeronaves.CurrentRow.DataBoundItem;

                if (!aeronaveAEliminar.VueloProgramado) {
                    DialogResult res = MessageBox.Show($"Se va a eliminar la aeronave: \n{aeronaveAEliminar}\nEsta seguro?", "Eliminar aeronave", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                    if (res == DialogResult.Yes) {
                        Sistema.BajaAeronave(aeronaveAEliminar);
                        ActualizarDataGridView(dataGridAeronaves);
                    }
                }
                else {
                    FrmMenuPrincipal.ActualizarMensajeDeError(this.imgError, this.lblError, "La aeronave que se esta queriendo eliminar tiene un vuelo programado.");
                }
            }
            else {
                FrmMenuPrincipal.ActualizarMensajeDeError(this.imgError, this.lblError, "No hay aeronaves cargadas para eliminar.");
            }
        }

        public void ActualizarDataGridView(DataGridView dataGridView) {
            dataGridView.DataSource = null;

            if (Sistema.ListaAeronaves != null && Sistema.ListaAeronaves.Count > 0) {
                dataGridView.DataSource = Sistema.ListaAeronaves;

                dataGridView.Columns["CantAsientos"].HeaderText = "Cantidad de asientos";
                dataGridView.Columns["cantAsientosPremium"].HeaderText = "Asientos para premium";
                dataGridView.Columns["cantAsientosTurista"].HeaderText = "Asientos para turista";
                dataGridView.Columns["CantBanios"].HeaderText = "Cantidad de baños";
                dataGridView.Columns["OfreceInternet"].HeaderText = "Ofrece internet";
                dataGridView.Columns["OfreceComida"].HeaderText = "Ofrece comida";
                dataGridView.Columns["CapacidadBodega"].HeaderText = "Capacidad de bodega (kg)";
                dataGridView.Columns["VueloProgramado"].HeaderText = "Vuelo programado";
            }
            else {
                FrmMenuPrincipal.ActualizarMensajeDeError(this.imgError, this.lblError, "No hay aeronaves cargadas para mostrar.");
            }
        }
    }
}
