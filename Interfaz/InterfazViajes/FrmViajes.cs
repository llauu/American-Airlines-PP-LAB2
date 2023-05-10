using Entidades;
using Interfaz.InterfazAeronaves;
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
                //Sistema.AltaAeronave(frmAlta.AeronaveAgregada);
                ActualizarDataGridView(dataGridViajes);
            }
        }




        private static void ActualizarDataGridView(DataGridView dataGridView) {
            dataGridView.DataSource = null;

            if (Sistema.ListaVuelos != null && Sistema.ListaVuelos.Count > 0) {
                dataGridView.DataSource = Sistema.ListaVuelos;

                dataGridView.Columns["CantAsientos"].HeaderText = "Cantidad de asientos";
                dataGridView.Columns["CantBanios"].HeaderText = "Cantidad de baños";
                dataGridView.Columns["OfreceInternet"].HeaderText = "Ofrece internet";
                dataGridView.Columns["OfreceComida"].HeaderText = "Ofrece comida";
                dataGridView.Columns["CapacidadBodega"].HeaderText = "Capacidad de bodega (kg)";
            }
        }
    }
}
