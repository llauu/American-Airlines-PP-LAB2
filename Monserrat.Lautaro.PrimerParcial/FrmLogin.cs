using System.Windows.Forms;

namespace Monserrat.Lautaro.PrimerParcial {
    public partial class FrmLogin : Form {
        public FrmLogin() {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (ValidarUsuarioIngresado(String.Empty) || ValidarPassIngresada(String.Empty)) {
                this.imgAlerta.Visible = true;
                this.lblAlerta.Visible = true;
            }
            else {
                if (ValidarUsuarioIngresado("admin") && ValidarPassIngresada("admin")) {

                }
                else {
                    this.imgAlerta.Visible = true;
                    this.lblAlertaError.Visible = true;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            ConfirmarSalida();
        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            ConfirmarSalida();
        }


        private void btnMinimizar_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimizar2_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool ValidarUsuarioIngresado(string usuario) {
            bool rtn = false;

            if (this.txtUsuario.Text == usuario) {
                rtn = true;
            }

            return rtn;
        }

        private bool ValidarPassIngresada(string pass) {
            bool rtn = false;

            if (this.txtPass.Text == pass) {
                rtn = true;
            }

            return rtn;
        }

        private void ConfirmarSalida() {
            DialogResult rta = MessageBox.Show("Estas seguro que deseas salir?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.Yes) {
                this.Close();
            }
        }
    }
}