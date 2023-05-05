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
            this.toolTip1.SetToolTip(txtBuscar, "Buscar aeronave");
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
                FrmEditarAeronave frmEditar = new FrmEditarAeronave((Aeronave)dataGridAeronaves.CurrentRow.DataBoundItem);

                DialogResult res = frmEditar.ShowDialog();

                if (res == DialogResult.OK) {
                    ActualizarDataGridView(dataGridAeronaves);
                }
            }
            else {
                this.imgError.Visible = true;
                this.lblError.Visible = true;
                this.lblError.Text = "No hay pasajeros cargados para editar.";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (this.dataGridAeronaves.Rows.Count > 0) {
                Aeronave aeronaveAEliminar = (Aeronave)dataGridAeronaves.CurrentRow.DataBoundItem;

                DialogResult res = MessageBox.Show($"Se va a eliminar la aeronave: \n{aeronaveAEliminar}\nEsta seguro?", "Eliminar aeronave", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (res == DialogResult.Yes) {
                    Sistema.BajaAeronave(aeronaveAEliminar);
                    ActualizarDataGridView(dataGridAeronaves);
                }
            }
            else {
                this.imgError.Visible = true;
                this.lblError.Visible = true;
                this.lblError.Text = "No hay pasajeros cargados para eliminar.";
            }
        }

        private static void ActualizarDataGridView(DataGridView dataGridView) {
            if (Sistema.ListaAeronaves != null && Sistema.ListaAeronaves.Count > 0) {
                dataGridView.DataSource = null;
                dataGridView.DataSource = Sistema.ListaAeronaves;

                dataGridView.Columns["CantAsientos"].HeaderText = "Cantidad de asientos";
                dataGridView.Columns["CantBanios"].HeaderText = "Cantidad de baños";
                dataGridView.Columns["OfreceInternet"].HeaderText = "Ofrece internet";
                dataGridView.Columns["OfreceComida"].HeaderText = "Ofrece comida";
                dataGridView.Columns["CapacidadBodega"].HeaderText = "Capacidad de bodega (kg)";
            }
            else {
                dataGridView.DataSource = null;
            }
        }
    }
}
