using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Interfaz {
    public partial class FrmEstadisticas : Form {
        BindingSource bsDestinos;
        BindingSource bsPasajeros;
        BindingSource bsAviones;

        Dictionary<string, string> DestinosOrdenadosPorFacturacion;
        Dictionary<string, int> PasajerosOrdenadosPorCantVuelos;
        Dictionary<string, string> AvionesConSusHorasDeVuelo;

        string destinoMasPedido;
        string gananciasTotales;
        string gananciasInternacionales;
        string gananciasNacionales;

        public FrmEstadisticas() {
            InitializeComponent();

            bsDestinos = new BindingSource();
            bsPasajeros = new BindingSource();
            bsAviones = new BindingSource();

            DestinosOrdenadosPorFacturacion = Sistema.ObtenerDestinosOrdenadosPorSuFacturacion();
            PasajerosOrdenadosPorCantVuelos = Sistema.ObtenerPasajerosOrdenadosPorCantidadDeVuelos();
            AvionesConSusHorasDeVuelo = Sistema.CargarAvionesConSusHorasDeVuelos();

            destinoMasPedido = Sistema.BuscarDestinoMasPedido();
            gananciasTotales = $"${Sistema.CalcularGananciasTotales().ToString("0")}";
            gananciasInternacionales = $"${Sistema.CalcularGananciasVuelosInternacionales().ToString("0")}";
            gananciasNacionales = $"${Sistema.CalcularGananciasVuelosNacionales().ToString("0")}";

            toolTip1.SetToolTip(this.btnDescargar, "Descargar estadisticas");
        }

        private void FrmEstadisticas_Load(object sender, EventArgs e) {
            bsDestinos.DataSource = DestinosOrdenadosPorFacturacion;
            CargarDataGrids(dataGridFacturacionDestinos, bsDestinos);

            if(PasajerosOrdenadosPorCantVuelos.Count > 0) {
                bsPasajeros.DataSource = PasajerosOrdenadosPorCantVuelos;
                CargarDataGrids(dataGridPasajerosFrecuentes, bsPasajeros);
            }

            if(AvionesConSusHorasDeVuelo.Count > 0) {
                bsAviones.DataSource = AvionesConSusHorasDeVuelo;
                CargarDataGrids(dataGridHorasDeVuelo, bsAviones);
            }

            lblDestinoMasElegido.Text = destinoMasPedido;
            lblGananciasTotales.Text = gananciasTotales;
            lblGananciasInternacionales.Text = gananciasInternacionales;
            lblGananciasNacionales.Text = gananciasNacionales;
        }

        private void CargarDataGrids(DataGridView dataGridView, BindingSource bindingSource) {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoResizeColumns();
            dataGridView.DataSource = bindingSource;
        }

        private void btnDescargar_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            saveFileDialog.DefaultExt = ".csv";
            saveFileDialog.FileName = "estadisticas_historicas_american_airlines";

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                string estadisticas = Sistema.EscribirEstadisticasAGuardar(destinoMasPedido, gananciasTotales,
                                      gananciasInternacionales, gananciasNacionales, DestinosOrdenadosPorFacturacion,
                                      PasajerosOrdenadosPorCantVuelos, AvionesConSusHorasDeVuelo);

                if (Archivos.EscribirEstadisticasCsv(estadisticas, saveFileDialog.FileName)) {
                    MessageBox.Show($"Archivo descargado con exito!\n\nGuardado en: \n{saveFileDialog.FileName}", "Archivo descargado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
