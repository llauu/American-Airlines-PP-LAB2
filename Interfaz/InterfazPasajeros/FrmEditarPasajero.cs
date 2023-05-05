using Entidades;
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

namespace Interfaz.InterfazPasajeros {
    public partial class FrmEditarPasajero : FrmBotonCancelar {
        Pasajero pasajeroAEditar;

        public FrmEditarPasajero(Pasajero pasajeroAEditar) {
            InitializeComponent();
            this.pasajeroAEditar = pasajeroAEditar;
        }

        private void FrmEditarPasajero_Load(object sender, EventArgs e) {
            this.dateFechaNacimiento.MaxDate = DateTime.Now;

            this.txtApellido.Text = pasajeroAEditar.Apellido;
            this.txtNombre.Text = pasajeroAEditar.Nombre;
            this.txtDni.Text = pasajeroAEditar.Dni.ToString();
            this.dateFechaNacimiento.Value = pasajeroAEditar.FechaDeNacimiento;

            this.txtDni.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            lblError.Visible = false;

            try {
                pasajeroAEditar.Apellido = Validador.ValidarCadena(this.txtApellido.Text);
                pasajeroAEditar.Nombre = Validador.ValidarCadena(this.txtNombre.Text);
                pasajeroAEditar.FechaDeNacimiento = Validador.ValidarFechaDeNacimiento(this.dateFechaNacimiento.Value.Date);
                pasajeroAEditar.Edad = Validador.CalcularEdad(this.dateFechaNacimiento.Value.Date);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex) {
                lblError.Visible = true;
                lblError.Text = ex.Message;
            }
        }
    }
}
