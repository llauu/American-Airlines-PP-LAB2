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
    public partial class FrmVenderVuelo : FrmVuelosDisponibles {
        public FrmVenderVuelo() {
            InitializeComponent();

            this.toolTip1.SetToolTip(this.btnVenderPasaje, "Vender pasajes");
        }

        private void btnVenderPasaje_Click(object sender, EventArgs e) {
            if(Sistema.CargarListaVuelosDisponibles().Count > 0) {
                Vuelo vueloSeleccionado = (Vuelo)dataGridViajes.CurrentRow.DataBoundItem;
                FrmVentaVuelo frmVenta = new FrmVentaVuelo(vueloSeleccionado);

                if (frmVenta.ShowDialog() == DialogResult.OK) {
                    vueloSeleccionado.ListaPasajes.AddRange(frmVenta.PasajesAgregados);
                    vueloSeleccionado.ContarAsientosOcupados();

                    FrmVuelosDisponibles.ActualizarDataGridView(base.imgError, base.lblError, base.dataGridViajes, base.VuelosDisponibles);
                }
            }
            else {
                FrmMenuPrincipal.ActualizarMensajeDeError(base.imgError, base.lblError, "No hay vuelos disponibles para vender pasajes.");
            }
        }
    }
}
