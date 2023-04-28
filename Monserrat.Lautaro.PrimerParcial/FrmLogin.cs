using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using Entidades;

namespace Monserrat.Lautaro.PrimerParcial {
    public partial class FrmLogin : Form {
        public FrmLogin() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.toolTip1.SetToolTip(btnMostrarClave, "Mostrar contraseña");

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

        private static DialogResult ConfirmarSalida() {
            DialogResult rta = MessageBox.Show("Estas seguro que deseas salir?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            return rta;
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e) {
            if (ConfirmarSalida() == DialogResult.Yes) {
                e.Cancel = false;
            }
            else {
                e.Cancel = true;
            }
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

        private bool IntentarInicioSesion() {
            bool sesionIniciada = false;
            string correoIngresado = this.txtCorreo.Text;
            string claveIngresada = this.txtClave.Text;
            int indiceUsuarioIngresado;

            if (correoIngresado == String.Empty || claveIngresada == String.Empty) {
                this.lblAlertaError.Visible = false;
                this.imgAlerta.Visible = true;
                this.lblAlerta.Visible = true;
            }
            else {
                indiceUsuarioIngresado = Sistema.IniciarSesion(correoIngresado, claveIngresada);

                if (indiceUsuarioIngresado >= 0 && Sistema.ListaUsuarios != null) {
                    Usuario usuarioIniciado = Sistema.ListaUsuarios[indiceUsuarioIngresado];
                    FrmMenuPrincipal menuPrincipal = new FrmMenuPrincipal(usuarioIniciado, this);
                    sesionIniciada = true;

                    this.Hide();
                    menuPrincipal.Show();
                }
                else {
                    this.lblAlerta.Visible = false;
                    this.imgAlerta.Visible = true;
                    this.lblAlertaError.Visible = true;
                }
            }

            return sesionIniciada;
        }
    }
}