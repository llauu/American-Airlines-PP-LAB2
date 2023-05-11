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
    public partial class FrmAltaViaje : FrmBotonCancelar {
        private Vuelo? vueloAgregado;
        private List<Aeronave> aeronavesDisponibles;

        public Vuelo VueloAgregado {
            get { return this.vueloAgregado!; }
        }


        public FrmAltaViaje() {
            InitializeComponent();
            this.aeronavesDisponibles = new List<Aeronave>();

            // Establezco que la fecha minima en donde se pueda agregar sea la de hoy + 1 dia (osea, maniana)
            this.dateFechaVuelo.MinDate = DateTime.Now.AddDays(1);
        }

        private void FrmAltaViaje_Load(object sender, EventArgs e) {
            ActualizarDataGridView(dataGridAeronaves);

            if (Sistema.ListaCiudades != null) {
                foreach (string ciudad in Sistema.ListaCiudades) {
                    cbCiudadPartida.Items.Add(ciudad);
                    cbCiudadDestino.Items.Add(ciudad);
                }
            }
        }

        private void CargarListaAeronavesDisponibles() {
            if (Sistema.ListaAeronaves != null) {
                foreach (Aeronave aeronave in Sistema.ListaAeronaves) {
                    if (!aeronave.VueloProgramado) {
                        aeronavesDisponibles.Add(aeronave);
                    }
                }
            }
        }

        public void ActualizarMensajeDeError(string mensaje) {
            this.imgError.Visible = true;
            this.lblError.Visible = true;
            this.lblError.Text = mensaje;
        }

        public void ActualizarDataGridView(DataGridView dataGridView) {
            CargarListaAeronavesDisponibles();
            dataGridView.DataSource = null;

            if (aeronavesDisponibles.Count > 0) {
                dataGridView.DataSource = aeronavesDisponibles;

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
                Aeronave aeronave = (Aeronave)dataGridAeronaves.CurrentRow.DataBoundItem;

                this.vueloAgregado = new Vuelo(this.cbCiudadPartida.Text, this.cbCiudadDestino.Text, this.dateFechaVuelo.Value.Date, aeronave);
                aeronave.VueloProgramado = true;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex) {
                ActualizarMensajeDeError(ex.Message);
            }
        }
    }
}
