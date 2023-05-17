using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Interfaz {
    public partial class FrmEstadisticas : Form {
        BindingSource bsDestinos;
        BindingSource bsPasajeros;
        BindingSource bsAviones;

        public FrmEstadisticas() {
            InitializeComponent();

            bsDestinos = new BindingSource();
            bsPasajeros = new BindingSource();
            bsAviones = new BindingSource();
        }

        private void FrmEstadisticas_Load(object sender, EventArgs e) {
            bsDestinos.DataSource = Sistema.ObtenerDestinosOrdenadosPorSuFacturacion();
            CargarDataGrids(dataGridFacturacionDestinos, bsDestinos);

            bsPasajeros.DataSource = Sistema.ObtenerPasajerosOrdenadosPorCantidadDeVuelos();
            CargarDataGrids(dataGridPasajerosFrecuentes, bsPasajeros);

            bsAviones.DataSource = Sistema.CargarAvionesConSusHorasDeVuelos();
            CargarDataGrids(dataGridHorasDeVuelo, bsAviones);


            lblDestinoMasElegido.Text = Sistema.BuscarDestinoMasPedido();
            lblGananciasTotales.Text = $"${Sistema.CalcularGananciasTotales()}";
            lblGananciasInternacionales.Text = $"${Sistema.CalcularGananciasVuelosInternacionales()}";
            lblGananciasNacionales.Text = $"${Sistema.CalcularGananciasVuelosNacionales()}";
        }

        private void CargarDataGrids(DataGridView dataGridView, BindingSource bindingSource) {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoResizeColumns();
            dataGridView.DataSource = bindingSource;
        }
    }
}
