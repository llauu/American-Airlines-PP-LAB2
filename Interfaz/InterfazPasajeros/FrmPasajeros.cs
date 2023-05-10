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
                // HACER 
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            FrmAltaPasajero frmAlta = new FrmAltaPasajero();
            this.imgError.Visible = false;
            this.lblError.Visible = false;

            DialogResult res = frmAlta.ShowDialog();

            if (res == DialogResult.OK) {
                Sistema.AltaPasajero(frmAlta.PasajeroAgregado);
                ActualizarDataGridView(dataGridPasajeros);
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
                this.imgError.Visible = true;
                this.lblError.Visible = true;
                this.lblError.Text = "No hay pasajeros cargados para editar.";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (this.dataGridPasajeros.Rows.Count > 0) {
                Pasajero pasajeroAEliminar = (Pasajero)dataGridPasajeros.CurrentRow.DataBoundItem;

                DialogResult res = MessageBox.Show($"Se va a eliminar al cliente: \n{pasajeroAEliminar}\nEsta seguro?", "Eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (res == DialogResult.Yes) {
                    Sistema.BajaPasajero(pasajeroAEliminar);
                    ActualizarDataGridView(dataGridPasajeros);
                }
            }
            else {
                this.imgError.Visible = true;
                this.lblError.Visible = true;
                this.lblError.Text = "No hay pasajeros cargados para eliminar.";
            }
        }

        private static void ActualizarDataGridView(DataGridView dataGridView) {
            dataGridView.DataSource = null;

            if (Sistema.ListaPasajeros != null && Sistema.ListaPasajeros.Count > 0) {
                dataGridView.DataSource = Sistema.ListaPasajeros;

                dataGridView.Columns["Apellido"].DisplayIndex = 0;
                dataGridView.Columns["Nombre"].DisplayIndex = 1;
                dataGridView.Columns["Dni"].DisplayIndex = 2;
                dataGridView.Columns["FechaDeNacimiento"].DisplayIndex = 3;
                dataGridView.Columns["Edad"].DisplayIndex = 4;

                dataGridView.Columns["FechaDeNacimiento"].HeaderText = "Fecha de nacimiento";
            }
        }
    }
}
