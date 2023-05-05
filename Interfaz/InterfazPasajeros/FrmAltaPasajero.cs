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


namespace Interfaz.InterfazPasajeros {
    public partial class FrmAltaPasajero : FrmBotonCancelar {
        Pasajero? pasajeroAgregado;

        public Pasajero PasajeroAgregado {
            get { return this.pasajeroAgregado!; }
        }

        public FrmAltaPasajero() {
            InitializeComponent();
        }

        private void FrmAltaPasajero_Load(object sender, EventArgs e) {
            this.dateFechaNacimiento.MaxDate = DateTime.Now;
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            string apellido = this.txtApellido.Text;
            string nombre = this.txtNombre.Text;
            int dni;
            DateTime fechaNacimiento = this.dateFechaNacimiento.Value.Date;

            int.TryParse(this.txtDni.Text, out dni);

            this.imgError.Visible = false;
            this.lblError.Visible = false;

            try {
                this.pasajeroAgregado = new Pasajero(apellido, nombre, dni, fechaNacimiento);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex) {
                this.imgError.Visible = true;
                this.lblError.Visible = true;
                this.lblError.Text = ex.Message;
            }
        }
    }
}
