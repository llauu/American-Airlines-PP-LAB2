using Entidades;
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
    public partial class FrmPasajeros : Form {
        public FrmPasajeros() {
            InitializeComponent();

            this.toolTip1.SetToolTip(btnAgregar, "Agregar pasajero");
            this.toolTip1.SetToolTip(btnEliminar, "Eliminar pasajero");
            this.toolTip1.SetToolTip(btnEditar, "Editar pasajero");
            this.toolTip1.SetToolTip(txtBuscar, "Buscar pasajero");
        }

        private void FrmPasajeros_Load(object sender, EventArgs e) {
            ActualizarDataGridView(dataGridPasajeros);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) {
            if (this.txtBuscar.Text.Length > 2) {

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            FrmAltaPasajero frmAlta = new FrmAltaPasajero();

            DialogResult res = frmAlta.ShowDialog();

            if (res == DialogResult.OK) {
                Sistema.AltaPasajero(frmAlta.PasajeroAgregado);
                ActualizarDataGridView(dataGridPasajeros);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (this.dataGridPasajeros.Rows.Count > 0) {
                Pasajero pasajeroAEliminar = (Pasajero)dataGridPasajeros.CurrentRow.DataBoundItem;

                DialogResult res = MessageBox.Show($"Se va a eliminar al cliente: \n{pasajeroAEliminar}\n\nEsta seguro?", "Eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (res == DialogResult.Yes) {
                    Sistema.BajaPasajero(pasajeroAEliminar);
                    ActualizarDataGridView(dataGridPasajeros);
                }
            }
            else {
                this.lblError.Visible = true;
                this.lblError.Text = "No hay pasajeros cargados para eliminar.";
            }
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            if (this.dataGridPasajeros.Rows.Count > 0) {
                FrmEditarPasajero frmEditar = new FrmEditarPasajero((Pasajero)dataGridPasajeros.CurrentRow.DataBoundItem);

                DialogResult res = frmEditar.ShowDialog();

                if (res == DialogResult.OK) {
                    ActualizarDataGridView(dataGridPasajeros);
                }
            }
            else {
                this.lblError.Visible = true;
                this.lblError.Text = "No hay pasajeros cargados para editar.";
            }
        }

        private static void ActualizarDataGridView(DataGridView dataGridView) {
            if (Sistema.ListaPasajeros != null && Sistema.ListaPasajeros.Count > 0) {
                dataGridView.DataSource = null;
                dataGridView.DataSource = Sistema.ListaPasajeros;
            }
            else {
                dataGridView.DataSource = null;
            }
        }
    }
}
