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
    public partial class FrmVuelosDisponibles : Form {
        private List<Vuelo> vuelosDisponibles = new List<Vuelo>();

        public List<Vuelo> VuelosDisponibles { get => vuelosDisponibles; set => vuelosDisponibles = value; }

        public FrmVuelosDisponibles() {
            InitializeComponent();
            this.toolTip1.SetToolTip(btnInfoAvion, "Informacion detallada del vuelo");
        }

        private void FrmViajesDisponibles_Load(object sender, EventArgs e) {
            vuelosDisponibles = Sistema.CargarListaVuelosDisponibles();
            ActualizarDataGridView(this.imgError, this.lblError, dataGridViajes, vuelosDisponibles);
        }

        private void btnInfoAvion_Click(object sender, EventArgs e) {
            AbrirBotonInfoVuelo(this.imgError, this.lblError, this.dataGridViajes);
        }

        public static void ActualizarDataGridView(PictureBox imgError, Label lblError, DataGridView dataGridView, List<Vuelo> listaVuelos) {
            dataGridView.DataSource = null;

            if (listaVuelos != null && listaVuelos.Count > 0) {
                dataGridView.DataSource = listaVuelos;

                dataGridView.Columns["IdVuelo"].HeaderText = "ID";
                dataGridView.Columns["CiudadPartida"].HeaderText = "Ciudad de partida";
                dataGridView.Columns["CiudadDestino"].HeaderText = "Ciudad de destino";
                dataGridView.Columns["FechaDeVuelo"].HeaderText = "Fecha del vuelo";
                dataGridView.Columns["EstadoDelVuelo"].HeaderText = "Estado del vuelo";
                dataGridView.Columns["AsientosPremiumOcupados"].HeaderText = "Asientos premium ocupados";
                dataGridView.Columns["AsientosTuristaOcupados"].HeaderText = "Asientos turista ocupados";
                dataGridView.Columns["DuracionVuelo"].HeaderText = "Duracion del vuelo (hs)";
                dataGridView.Columns["TipoVuelo"].HeaderText = "Tipo de vuelo";
                dataGridView.Columns["PesoBodegaOcupada"].HeaderText = "Kg. cargados en bodega";
                dataGridView.Columns["Avion"].Visible = false;
            }
            else {
                FrmMenuPrincipal.ActualizarMensajeDeError(imgError, lblError, "No hay vuelos disponibles para visualizar.");
            }
        }

        public static void AbrirBotonInfoVuelo(PictureBox imgError, Label lblError, DataGridView dataGridView) {
            if (dataGridView.Rows.Count > 0) {
                FrmInfoVuelo frmInfo = new FrmInfoVuelo((Vuelo)dataGridView.CurrentRow.DataBoundItem);

                frmInfo.ShowDialog();
            }
            else {
                FrmMenuPrincipal.ActualizarMensajeDeError(imgError, lblError, "No hay vuelos cargados para visualizar mas informacion.");
            }
        }
    }
}
