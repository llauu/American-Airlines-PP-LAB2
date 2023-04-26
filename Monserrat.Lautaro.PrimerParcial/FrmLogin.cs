using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using Entidades;

namespace Monserrat.Lautaro.PrimerParcial {
    public partial class FrmLogin : Form {
        string rutaUsuariosJson;
        List<Usuario> listaUsuarios;

        public FrmLogin() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            toolTip1.SetToolTip(btnMostrarClave, "Mostrar contraseña");

            listaUsuarios = new List<Usuario>();

            rutaUsuariosJson = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            rutaUsuariosJson = Path.Combine(rutaUsuariosJson, "MOCK_DATA.json");

            CargarUsuariosJson();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (ValidarCorreoIngresado(String.Empty) || ValidarPassIngresada(String.Empty)) {
                this.lblAlertaError.Visible = false;
                this.imgAlerta.Visible = true;
                this.lblAlerta.Visible = true;
            }
            else {
                if (ValidacionInicioDeSesion(listaUsuarios)) {
                    MessageBox.Show("Sesion iniciada");
                }
                else {
                    this.lblAlerta.Visible = false;
                    this.imgAlerta.Visible = true;
                    this.lblAlertaError.Visible = true;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private DialogResult ConfirmarSalida() {
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

        private bool ValidarCorreoIngresado(string correo) {
            bool rtn = false;

            if (this.txtCorreo.Text == correo) {
                rtn = true;
            }

            return rtn;
        }

        private bool ValidarPassIngresada(string pass) {
            bool rtn = false;

            if (this.txtClave.Text == pass) {
                rtn = true;
            }

            return rtn;
        }

        private void CargarUsuariosJson() {
            try {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(rutaUsuariosJson)) {
                    string json_str = sr.ReadToEnd();

                    listaUsuarios = JsonSerializer.Deserialize<List<Usuario>>(json_str);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private bool ValidacionInicioDeSesion(List<Usuario> listaUsuarios) {
            bool datosCorrectos = false;

            foreach (Usuario usuario in listaUsuarios) {
                if (ValidarCorreoIngresado(usuario.correo) && ValidarPassIngresada(usuario.clave)) {
                    datosCorrectos = true;
                    break;
                }
            }

            return datosCorrectos;
        }

        private void btnMostrarClave_Click(object sender, EventArgs e) {
            if (this.txtClave.PasswordChar == '\u25CF') {
                this.txtClave.PasswordChar = '\0';
            }
            else {
                this.txtClave.PasswordChar = '\u25CF';
            }
        }
    }
}