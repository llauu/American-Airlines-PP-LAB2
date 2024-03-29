﻿using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz.InterfazAeronaves {
    public partial class FrmAltaAeronave : FrmBotonCancelar {
        private Aeronave? aeronaveAgregada;

        public Aeronave AeronaveAgregada {
            get { return this.aeronaveAgregada!; }
        }

        public FrmAltaAeronave() {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            int cantAsientos;
            int cantBanios;
            bool ofreceInternet = this.checkInternet.Checked;
            bool ofreceComida = this.checkComida.Checked;
            float capacidadBodega;

            this.imgError.Visible = false;
            this.lblError.Visible = false;

            try {
                int.TryParse(this.txtCantAsientos.Text, out cantAsientos);
                int.TryParse(this.txtCantBanios.Text, out cantBanios);
                float.TryParse(this.txtCantBodega.Text, out capacidadBodega);

                this.aeronaveAgregada = new Aeronave(cantAsientos, cantBanios, ofreceInternet, ofreceComida, capacidadBodega);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex) {
                FrmMenuPrincipal.ActualizarMensajeDeError(this.imgError, this.lblError, ex.Message);
            }
        }
    }
}
