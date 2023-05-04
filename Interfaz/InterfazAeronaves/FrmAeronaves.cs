using Entidades;
using Interfaz.InterfazAeronaves;
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
    public partial class FrmAeronaves : Form {
        public FrmAeronaves() {
            InitializeComponent();

            this.toolTip1.SetToolTip(btnAgregar, "Agregar aeronave");
            this.toolTip1.SetToolTip(btnEliminar, "Eliminar aeronave");
            this.toolTip1.SetToolTip(btnEditar, "Editar aeronave");
            this.toolTip1.SetToolTip(txtBuscar, "Buscar aeronave");
        }

        private void FrmAeronaves_Load(object sender, EventArgs e) {
            ActualizarDataGridView(dataGridAeronaves);
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            FrmAltaAeronave frmAlta = new FrmAltaAeronave();

            DialogResult res = frmAlta.ShowDialog();

            if (res == DialogResult.OK) {
                Sistema.AltaAeronave(frmAlta.AeronaveAgregada);
                ActualizarDataGridView(dataGridAeronaves);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {

        }

        private void btnEditar_Click(object sender, EventArgs e) {

        }

        private static void ActualizarDataGridView(DataGridView dataGridView) {
            if (Sistema.ListaAeronaves != null && Sistema.ListaAeronaves.Count > 0) {
                dataGridView.DataSource = null;
                dataGridView.DataSource = Sistema.ListaAeronaves;
            }
            else {
                dataGridView.DataSource = null;
            }
        }
    }
}
