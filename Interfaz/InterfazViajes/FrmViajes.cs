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
    public partial class FrmViajes : Form {
        public FrmViajes() {
            InitializeComponent();

            this.toolTip1.SetToolTip(btnAgregar, "Agregar vuelo");
            this.toolTip1.SetToolTip(btnEliminar, "Eliminar vuelo");
            this.toolTip1.SetToolTip(btnInfoAvion, "Informacion del avion");
            this.toolTip1.SetToolTip(btnEditar, "Editar vuelo");
            this.toolTip1.SetToolTip(txtBuscar, "Buscar vuelo");
        }

        private void FrmViajes_Load(object sender, EventArgs e) {
            ActualizarDataGridView(dataGridViajes);
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            FrmAltaViaje frmAlta = new FrmAltaViaje();
            this.imgError.Visible = false;
            this.lblError.Visible = false;

            DialogResult res = frmAlta.ShowDialog();

            if (res == DialogResult.OK) {
                Sistema.AltaVuelo(frmAlta.VueloAgregado);
                ActualizarDataGridView(dataGridViajes);
            }
        }

        private void btnInfoAvion_Click(object sender, EventArgs e) {
            if (this.dataGridViajes.Rows.Count > 0) {
                FrmInfoVuelo frmInfo = new FrmInfoVuelo((Vuelo)dataGridViajes.CurrentRow.DataBoundItem);

                frmInfo.ShowDialog();
            }
            else {
                ActualizarMensajeDeError("No hay vuelos cargados para visualizar mas informacion.");
            }
        }


        private static void ActualizarDataGridView(DataGridView dataGridView) {
            dataGridView.DataSource = null;

            if (Sistema.ListaVuelos != null && Sistema.ListaVuelos.Count > 0) {
                dataGridView.DataSource = Sistema.ListaVuelos;

                dataGridView.Columns["IdVuelo"].HeaderText = "ID";
                dataGridView.Columns["CiudadPartida"].HeaderText = "Ciudad de partida";
                dataGridView.Columns["CiudadDestino"].HeaderText = "Ciudad de destino";
                dataGridView.Columns["FechaDeVuelo"].HeaderText = "Fecha del vuelo";
                dataGridView.Columns["EstadoDelVuelo"].HeaderText = "Estado del vuelo";
                dataGridView.Columns["CantAsientosPremium"].HeaderText = "Cant. asientos premium";
                dataGridView.Columns["CantAsientosTurista"].HeaderText = "Cant. asientos turista";
                dataGridView.Columns["DuracionVuelo"].HeaderText = "Duracion del vuelo";
                dataGridView.Columns["Avion"].Visible = false;
                //dataGridView.Columns["ListaPasajeros"].Visible = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (this.dataGridViajes.Rows.Count > 0) {
                Vuelo vueloAEliminar = (Vuelo)dataGridViajes.CurrentRow.DataBoundItem;

                if (vueloAEliminar.EstadoDelVuelo == EEstadoVuelo.EnTierra) {
                    DialogResult res = MessageBox.Show($"Se va a eliminar el vuelo: \n{vueloAEliminar}\nEsta seguro?", "Eliminar vuelo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                    if (res == DialogResult.Yes) {
                        Sistema.BajaVuelo(vueloAEliminar);
                        ActualizarDataGridView(dataGridViajes);
                    }
                }
                else {
                    ActualizarMensajeDeError("El vuelo que esta queriendo eliminar se encuentra en curso o finalizado.");
                }
            }
            else {
                ActualizarMensajeDeError("No hay vuelos cargados para eliminar.");
            }
        }

        public void ActualizarMensajeDeError(string mensaje) {
            this.imgError.Visible = true;
            this.lblError.Visible = true;
            this.lblError.Text = mensaje;
        }
    }
}
