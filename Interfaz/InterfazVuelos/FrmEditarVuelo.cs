﻿using Entidades;
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
    public partial class FrmEditarVuelo : FrmBotonCancelar {
        private Vuelo vueloAEditar;
        private List<Aeronave> aeronavesDisponibles;


        public FrmEditarVuelo(Vuelo vuelo) {
            this.aeronavesDisponibles = new List<Aeronave>();
            this.vueloAEditar = vuelo;

            InitializeComponent();

            this.dateFechaVuelo.MinDate = DateTime.Now.AddDays(1);
            this.aeronavesDisponibles.Add(vuelo.Avion);
        }

        private void FrmEditarViaje_Load(object sender, EventArgs e) {
            FrmAltaVuelo.ActualizarDataGridView(aeronavesDisponibles, dataGridAeronaves);

            if (Sistema.ListaCiudades != null) {
                foreach (string ciudad in Sistema.ListaCiudades) {
                    cbCiudadPartida.Items.Add(ciudad);
                    cbCiudadDestino.Items.Add(ciudad);
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            this.imgError.Visible = false;
            this.lblError.Visible = false;

            try {
                if (aeronavesDisponibles.Count > 0 && Sistema.ListaVuelos != null) {
                    Aeronave aeronave = (Aeronave)dataGridAeronaves.CurrentRow.DataBoundItem;

                    Vuelo vueloEditado = new Vuelo(this.cbCiudadPartida.Text, this.cbCiudadDestino.Text, this.dateFechaVuelo.Value.Date, aeronave);

                    Sistema.EditarVuelo(this.vueloAEditar, vueloEditado);

                    this.DialogResult = DialogResult.OK;
                }
                else {
                    FrmMenuPrincipal.ActualizarMensajeDeError(this.imgError, this.lblError, "La edicion de vuelos no esta disponible ya que no hay aviones disponibles.");
                }
            }
            catch (Exception ex) {
                FrmMenuPrincipal.ActualizarMensajeDeError(this.imgError, this.lblError, ex.Message);
            }
        }

    }
}
