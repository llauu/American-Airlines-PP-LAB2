using Entidades;
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
    public partial class FrmAltaVuelo : FrmBotonCancelar {
        private Vuelo? vueloAgregado;
        private List<Aeronave> aeronavesDisponibles;

        public Vuelo VueloAgregado {
            get { return this.vueloAgregado!; }
        }


        public FrmAltaVuelo() {
            InitializeComponent();
            this.aeronavesDisponibles = new List<Aeronave>();

            // Establezco que la fecha minima en donde se pueda agregar sea la de hoy + 1 dia (osea, maniana)
            this.dateFechaVuelo.MinDate = DateTime.Now.AddDays(1);
        }

        private void FrmAltaViaje_Load(object sender, EventArgs e) {
            ActualizarDataGridView(aeronavesDisponibles, dataGridAeronaves);

            if (Sistema.ListaCiudades != null) {
                foreach (string ciudad in Sistema.ListaCiudades) {
                    cbCiudadPartida.Items.Add(ciudad);
                    cbCiudadDestino.Items.Add(ciudad);
                }
            }
        }


        public static void ActualizarDataGridView(List<Aeronave> listaAeronavesDisponibles, DataGridView dataGridView) {
            Sistema.CargarListaAeronavesDisponibles(listaAeronavesDisponibles);
            dataGridView.DataSource = null;

            if (listaAeronavesDisponibles.Count > 0) {
                dataGridView.DataSource = listaAeronavesDisponibles;

                dataGridView.Columns["CantAsientos"].HeaderText = "Cant. de asientos";
                dataGridView.Columns["CantBanios"].HeaderText = "Cant. de baños";
                dataGridView.Columns["OfreceInternet"].HeaderText = "Ofrece internet";
                dataGridView.Columns["OfreceComida"].HeaderText = "Ofrece comida";
                dataGridView.Columns["CapacidadBodega"].HeaderText = "Cap. de bodega (kg)";
                dataGridView.Columns["VueloProgramado"].HeaderText = "Vuelo programado";
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            this.imgError.Visible = false;
            this.lblError.Visible = false;

            try {
                if (aeronavesDisponibles.Count > 0) {
                    Aeronave aeronave = (Aeronave)dataGridAeronaves.CurrentRow.DataBoundItem;

                    this.vueloAgregado = new Vuelo(this.cbCiudadPartida.Text, this.cbCiudadDestino.Text, this.dateFechaVuelo.Value.Date, aeronave);
                    aeronave.VueloProgramado = true;
                    this.DialogResult = DialogResult.OK;
                }
                else {
                    FrmMenuPrincipal.ActualizarMensajeDeError(imgError, lblError, "La alta de vuelos no esta disponible ya que no hay aviones disponibles.");
                }
            }
            catch (Exception ex) {
                FrmMenuPrincipal.ActualizarMensajeDeError(imgError, lblError, ex.Message);
            }
        }
    }
}
