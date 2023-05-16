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

namespace Interfaz.InterfazViajes {
    public partial class FrmInfoVuelo : FrmBotonCancelar {
        private Vuelo vueloSeleccionado;

        public FrmInfoVuelo(Vuelo vuelo) {
            InitializeComponent();
            this.vueloSeleccionado = vuelo;
        }

        private void FrmInfoVuelo_Load(object sender, EventArgs e) {
            this.dataGridPasajeros.DataSource = vueloSeleccionado.ListaPasajes;

            this.dataGridPasajeros.Columns["EquipajeDeMano"].Visible = false;
            this.dataGridPasajeros.Columns["EquipajesDeBodega"].Visible = false;
            this.dataGridPasajeros.Columns["NumeroDeEquipaje"].Visible = false;
            this.dataGridPasajeros.Columns["Vuelo"].Visible = false;

            this.dataGridPasajeros.Columns["IdPasaje"].HeaderText = "ID pasaje";
            this.dataGridPasajeros.Columns["ClasePasajero"].HeaderText = "Clase pasajero";
            this.dataGridPasajeros.Columns["CostoPasaje"].HeaderText = "Costo del pasaje (en $)";

            this.txtInfoAvion.Text = vueloSeleccionado.Avion.ToString();

            dataGridPasajeros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridPasajeros.AutoResizeColumns();
        }
    }
}
