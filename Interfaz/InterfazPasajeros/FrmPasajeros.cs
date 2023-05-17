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
            if (Sistema.ListaPasajeros != null) {
                ActualizarDataGridView(dataGridPasajeros, Sistema.ListaPasajeros);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) {
            if (Sistema.ListaPasajeros != null) {
                if (this.txtBuscar.Text.Length > 2 && !(string.IsNullOrEmpty(this.txtBuscar.Text))) {
                    List<Pasajero> pasajerosEncontrados = new List<Pasajero>();

                    Sistema.BuscarClientes(pasajerosEncontrados, this.txtBuscar.Text.ToUpper());
                    ActualizarDataGridView(dataGridPasajeros, pasajerosEncontrados);
                }
                else {
                    ActualizarDataGridView(dataGridPasajeros, Sistema.ListaPasajeros);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            FrmAltaPasajero frmAlta = new FrmAltaPasajero();
            this.imgError.Visible = false;
            this.lblError.Visible = false;

            DialogResult res = frmAlta.ShowDialog();

            if (res == DialogResult.OK && Sistema.ListaPasajeros != null) {
                Sistema.AltaPasajero(frmAlta.PasajeroAgregado);
                ActualizarDataGridView(dataGridPasajeros, Sistema.ListaPasajeros);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            if (this.dataGridPasajeros.Rows.Count > 0) {
                Pasajero pasajeroAEditar = (Pasajero)dataGridPasajeros.CurrentRow.DataBoundItem;

                if (Validador.ValidarModificacionDePasajero(pasajeroAEditar)) {
                    FrmEditarPasajero frmEditar = new FrmEditarPasajero(pasajeroAEditar);

                    DialogResult res = frmEditar.ShowDialog();

                    if (res == DialogResult.OK && Sistema.ListaPasajeros != null) {
                        ActualizarDataGridView(dataGridPasajeros, Sistema.ListaPasajeros);
                    }
                }
                else {
                    FrmMenuPrincipal.ActualizarMensajeDeError(this.imgError, this.lblError, "No se puede editar el pasajero seleccionado ya que se encuentra en vuelo.");
                }
            }
            else {
                FrmMenuPrincipal.ActualizarMensajeDeError(this.imgError, this.lblError, "No hay pasajeros cargados para editar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (this.dataGridPasajeros.Rows.Count > 0) {
                Pasajero pasajeroAEliminar = (Pasajero)dataGridPasajeros.CurrentRow.DataBoundItem;

                if (Validador.ValidarBajaDePasajero(pasajeroAEliminar)) {
                    DialogResult res = MessageBox.Show($"Se va a eliminar al cliente: \n{pasajeroAEliminar}\nEsta seguro?", "Eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                    if (res == DialogResult.Yes && Sistema.ListaPasajeros != null) {
                        Sistema.BajaPasajero(pasajeroAEliminar);
                        ActualizarDataGridView(dataGridPasajeros, Sistema.ListaPasajeros);
                    }
                }
                else {
                    FrmMenuPrincipal.ActualizarMensajeDeError(this.imgError, this.lblError, "El pasajero seleccionado no puede ser eliminado debido a que ya realizo un vuelo.");
                }
            }
            else {
                FrmMenuPrincipal.ActualizarMensajeDeError(this.imgError, this.lblError, "No hay pasajeros cargados para eliminar.");
            }
        }

        private static void ActualizarDataGridView(DataGridView dataGridView, List<Pasajero> listaPasajeros) {
            dataGridView.DataSource = null;

            if (listaPasajeros != null && listaPasajeros.Count > 0) {
                dataGridView.DataSource = listaPasajeros;

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
