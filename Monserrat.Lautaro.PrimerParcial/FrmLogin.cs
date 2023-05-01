using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using Entidades;

namespace Monserrat.Lautaro.PrimerParcial {
    public partial class FrmLogin : Form {
        public FrmLogin() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.toolTip1.SetToolTip(btnMostrarClave, "Mostrar contraseņa");

            try {
                Sistema.CargarUsuariosJson();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            IntentarInicioSesion();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnMostrarClave_Click(object sender, EventArgs e) {
            if (this.txtClave.UseSystemPasswordChar == true) {
                this.txtClave.UseSystemPasswordChar = false;
            }
            else {
                this.txtClave.UseSystemPasswordChar = true;
            }
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                IntentarInicioSesion();
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                IntentarInicioSesion();
            }
        }
        
        private void MostrarMensajeError(string mensaje) {
            this.lblAlerta.Text = mensaje;
            this.imgAlerta.Visible = true;
            this.lblAlerta.Visible = true;
        }

        private void IntentarInicioSesion() {
            string correoIngresado = this.txtCorreo.Text;
            string claveIngresada = this.txtClave.Text;
            int indiceUsuarioIngresado;

            if (correoIngresado == String.Empty || claveIngresada == String.Empty) {
                MostrarMensajeError("Debes ingresar un usuario y/o contraseņa.");
            }
            else {
                indiceUsuarioIngresado = Sistema.IniciarSesion(correoIngresado, claveIngresada);

                if (indiceUsuarioIngresado >= 0) {
                    AccederMenuPrincipal(indiceUsuarioIngresado);
                }
                else {
                    MostrarMensajeError("La contraseņa o el usuario son incorrectos.");
                }
            }
        }

        private void AccederMenuPrincipal(int indiceUsuario) {
            if(Sistema.ListaUsuarios != null) {
                Usuario usuarioIniciado = Sistema.ListaUsuarios[indiceUsuario];
                FrmMenuPrincipal menuPrincipal = new FrmMenuPrincipal(usuarioIniciado, this);

                this.Hide();
                menuPrincipal.Show();
            }
        }
    }
}