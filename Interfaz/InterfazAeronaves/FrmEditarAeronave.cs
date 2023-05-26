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

namespace Interfaz.InterfazAeronaves {
    public partial class FrmEditarAeronave : FrmBotonCancelar {
        Aeronave aeronaveAEditar;

        public FrmEditarAeronave(Aeronave aeronaveAEditar) {
            InitializeComponent();
            this.aeronaveAEditar = aeronaveAEditar;
        }

        private void FrmEditarAeronave_Load(object sender, EventArgs e) {
            this.txtCantAsientos.Text = aeronaveAEditar.CantAsientos.ToString();
            this.txtCantBanios.Text = aeronaveAEditar.CantBanios.ToString();
            this.txtCantBodega.Text = aeronaveAEditar.CapacidadBodega.ToString();
            this.checkInternet.Checked = aeronaveAEditar.OfreceInternet;
            this.checkComida.Checked = aeronaveAEditar.OfreceComida;
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            int cantAsientos;
            int cantBanios;
            int capacidadBodega;

            this.imgError.Visible = false;
            this.lblError.Visible = false;

            try {
                int.TryParse(this.txtCantAsientos.Text, out cantAsientos);
                int.TryParse(this.txtCantBanios.Text, out cantBanios);
                int.TryParse(this.txtCantBodega.Text, out capacidadBodega);

                aeronaveAEditar.CantAsientos = Validador.ValidarNumeroPositivo(cantAsientos);
                aeronaveAEditar.CantBanios = Validador.ValidarNumeroPositivo(cantBanios);
                aeronaveAEditar.OfreceInternet = this.checkInternet.Checked;
                aeronaveAEditar.OfreceComida = this.checkComida.Checked;
                aeronaveAEditar.CapacidadBodega = Validador.ValidarNumeroPositivo(capacidadBodega);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex) {
                FrmMenuPrincipal.ActualizarMensajeDeError(this.imgError, this.lblError, ex.Message);
            }
        }
    }
}
