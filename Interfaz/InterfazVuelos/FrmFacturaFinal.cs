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

namespace Interfaz.InterfazVuelos {
    public partial class FrmFacturaFinal : Form {
        List<Pasaje> pasajesAgregados;

        public FrmFacturaFinal(List<Pasaje> pasajesAgregados) {
            InitializeComponent();
            this.pasajesAgregados = pasajesAgregados;
        }

        private void FrmFacturaFinal_Load(object sender, EventArgs e) {
            CalcularFactura();
        }

        public void CalcularFactura() {
            StringBuilder sb = new StringBuilder();
            double precioSubtotal = 0;
            double IVA;

            foreach (Pasaje pasaje in this.pasajesAgregados) {
                sb.AppendLine($"Pasaje {pasaje.ClasePasajero}        ${pasaje.CostoPasaje.ToString()}");
                precioSubtotal += pasaje.CostoPasaje;
            }

            IVA = precioSubtotal * 0.21;

            rtbFactura.Text = sb.ToString();

            lblSubtotal.Text = "$" + precioSubtotal.ToString();
            lblIVA.Text = "$" + IVA.ToString();
            lblTotal.Text = "$" + (precioSubtotal + IVA).ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
