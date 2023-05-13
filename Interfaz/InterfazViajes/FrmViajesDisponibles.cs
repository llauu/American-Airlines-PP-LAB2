using Entidades;
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
    public partial class FrmViajesDisponibles : Form {
        public FrmViajesDisponibles() {
            InitializeComponent();
            this.toolTip1.SetToolTip(btnInfoAvion, "Informacion detallada del vuelo");
        }

        private void FrmViajesDisponibles_Load(object sender, EventArgs e) {
            ActualizarDataGridView(dataGridViajes);
        }

        private void btnInfoAvion_Click(object sender, EventArgs e) {
            if (this.dataGridViajes.Rows.Count > 0) {
                FrmInfoVuelo frmInfo = new FrmInfoVuelo((Vuelo)dataGridViajes.CurrentRow.DataBoundItem);

                frmInfo.ShowDialog();
            }
            else {
                FrmMenuPrincipal.ActualizarMensajeDeError(this.imgError, this.lblError, "No hay vuelos cargados para visualizar mas informacion.");
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
    }
}
