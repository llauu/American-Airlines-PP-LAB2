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
            this.dataGridPasajeros.DataSource = vueloSeleccionado.ListaPasajeros;
            this.dataGridPasajeros.Columns["Apellido"].DisplayIndex = 0;
            this.dataGridPasajeros.Columns["Nombre"].DisplayIndex = 1;
            this.dataGridPasajeros.Columns["Dni"].DisplayIndex = 2;
            this.dataGridPasajeros.Columns["FechaDeNacimiento"].DisplayIndex = 3;
            this.dataGridPasajeros.Columns["Edad"].DisplayIndex = 4;
            this.dataGridPasajeros.Columns["FechaDeNacimiento"].HeaderText = "Fecha de nacimiento";

            this.txtInfoAvion.Text = vueloSeleccionado.Avion.ToString();
        }
    }
}
