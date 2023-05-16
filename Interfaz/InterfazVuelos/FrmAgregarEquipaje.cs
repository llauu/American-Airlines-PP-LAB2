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
    public partial class FrmAgregarEquipaje : FrmBotonCancelar {
        private Pasaje pasajeSeleccionado;

        public FrmAgregarEquipaje(Pasaje pasajeSeleccionado) {
            InitializeComponent();
            this.pasajeSeleccionado = pasajeSeleccionado;
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            if (this.numPesoEquipaje != null) {
                try {
                    float pesoEquipaje = (float)this.numPesoEquipaje.Value;

                    pasajeSeleccionado.CargarEquipajeDeBodega(pesoEquipaje);

                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex) {
                    FrmMenuPrincipal.ActualizarMensajeDeError(this.imgError, this.lblError, ex.Message);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {

        }
    }
}
