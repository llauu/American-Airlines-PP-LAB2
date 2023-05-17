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

namespace Interfaz {
    public partial class FrmMenuPrincipal : Form {
        private FrmLogin? formLogin;
        private Form? formOpcionActiva;
        private Usuario? usuarioActivo;
        private bool cerrandoSesion;

        private FrmMenuPrincipal() {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.toolTip1.SetToolTip(btnCerrarSesion, "Cerrar sesion");
            this.toolTip1.SetToolTip(imgLogo, "Inicio");
        }

        public FrmMenuPrincipal(Usuario usuarioActivo, FrmLogin formLogin) : this() {
            string fechaHoy = DateTime.UtcNow.ToString("d");

            this.usuarioActivo = usuarioActivo;
            CargarPerfilUsuario(usuarioActivo);

            this.lblFecha.Text = fechaHoy;
            this.MinimumSize = new Size(964, 574);
            this.lblPerfil.Text = $"{usuarioActivo.Nombre} {usuarioActivo.Apellido}";
            this.cerrandoSesion = false;
            this.formLogin = formLogin;
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e) {
            try {
                Sistema.CargarArchivos();
                Sistema.RegistrarConexion(usuarioActivo!);
                Sistema.ChequearEstadoVuelos();

                AbrirFormOpcionElegida(new FrmInicio());
            }
            catch (Exception ex) {
                MessageBox.Show($"Error al cargar los archivos. Se cerrara la aplicacion. \n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Application.Exit();
            }
        }

        private void CargarPerfilUsuario(Usuario usuario) {
            switch (usuario.Perfil) {
                case "vendedor":
                    this.btnViajes.Enabled = false;
                    this.btnAeronaves.Enabled = false;
                    break;

                case "supervisor":
                    this.btnViajesDisponibles.Enabled = false;
                    this.btnVenderVuelo.Enabled = false;
                    this.btnViajes.Enabled = false;
                    this.btnAeronaves.Enabled = false;
                    break;

                case "administrador":
                    //this.btnEstadisticas.Enabled = false;
                    //this.btnViajesDisponibles.Enabled = false;
                    //this.btnVenderVuelo.Enabled = false;
                    //this.btnPasajeros.Enabled = false;
                    break;

                default:
                    // Desactivo todos los botones por si se llega a ingresar sin ningun perfil
                    foreach (Control item in panelMenuNav.Controls) {
                        item.Enabled = false;
                    }
                    break;
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e) {
            DialogResult rta = MessageBox.Show("Estas seguro que deseas cerrar sesion?", "Cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.Yes && formLogin != null) {
                cerrandoSesion = true;
                formLogin.Show();
                this.Close();
            }
        }

        private void ActualizarTitulo(string tituloNuevo) {
            lblOpcionActiva.Text = tituloNuevo;
        }

        private void imgLogo_Click(object sender, EventArgs e) {
            ActualizarTitulo("Inicio");
            ReiniciarFondoOpciones();
            AbrirFormOpcionElegida(new FrmInicio());
        }

        private void btnEstadisticas_Click(object sender, EventArgs e) {
            ActualizarOpcionActiva(btnEstadisticas);
            AbrirFormOpcionElegida(new FrmEstadisticas());
        }

        private void btnViajesDisponibles_Click(object sender, EventArgs e) {
            ActualizarOpcionActiva(btnViajesDisponibles);
            AbrirFormOpcionElegida(new FrmVuelosDisponibles());
        }

        private void btnVenderViaje_Click(object sender, EventArgs e) {
            ActualizarOpcionActiva(btnVenderVuelo);
            AbrirFormOpcionElegida(new FrmVenderVuelo());
        }

        private void btnViajes_Click(object sender, EventArgs e) {
            ActualizarOpcionActiva(btnViajes);
            AbrirFormOpcionElegida(new FrmVuelos());
        }

        private void btnPasajeros_Click(object sender, EventArgs e) {
            ActualizarOpcionActiva(btnPasajeros);
            AbrirFormOpcionElegida(new FrmPasajeros());
        }

        private void btnAeronaves_Click(object sender, EventArgs e) {
            ActualizarOpcionActiva(btnAeronaves);
            AbrirFormOpcionElegida(new FrmAeronaves());
        }

        private void FrmMenuPrincipal_Resize(object sender, EventArgs e) {
            if (this.Size.Width > 1000 && this.Size.Height > 800) {
                CambiarTamanioControles(55, 210, 20F, 12F);
            }
            else {
                CambiarTamanioControles(45, 176, 16F, 10F);
            }
        }

        private void ReiniciarFondoOpciones() {
            btnViajesDisponibles.BackColor = Color.Transparent;
            btnVenderVuelo.BackColor = Color.Transparent;
            btnEstadisticas.BackColor = Color.Transparent;
            btnViajes.BackColor = Color.Transparent;
            btnPasajeros.BackColor = Color.Transparent;
            btnAeronaves.BackColor = Color.Transparent;
        }

        private void ActualizarOpcionActiva(Button opcion) {
            ReiniciarFondoOpciones();
            ActualizarTitulo(opcion.Text);
            opcion.BackColor = Color.DarkGray;
        }

        private void RedimensionarFuenteBoton(Button boton, Single tam) {
            boton.Font = new Font("Segoe UI", tam, FontStyle.Regular, GraphicsUnit.Point);
        }

        private void CambiarTamanioControles(int alturaMenuArriba, int anchoMenuNav, Single tamFuenteTitulo, Single tamFuenteBoton) {
            this.panelMenuArriba.Height = alturaMenuArriba;
            this.panelMenuNav.Width = anchoMenuNav;
            this.lblOpcionActiva.Font = new Font("Segoe UI", tamFuenteTitulo, FontStyle.Bold, GraphicsUnit.Point);

            foreach (Control item in this.panelMenuNav.Controls) {
                if (item is Button) {
                    RedimensionarFuenteBoton((Button)item, tamFuenteBoton);
                }
            }
        }

        private void AbrirFormOpcionElegida(Form formOpcion) {
            try {
                if (this.formOpcionActiva != null) {
                    this.panelPantalla.Controls.Remove(formOpcionActiva);
                    this.formOpcionActiva.Close();
                }

                this.formOpcionActiva = formOpcion;
                this.formOpcionActiva.TopLevel = false;
                this.formOpcionActiva.Dock = DockStyle.Fill;
                this.panelPantalla.Controls.Add(formOpcionActiva);
                this.formOpcionActiva.Show();
            }
            catch (Exception ex) {
                MessageBox.Show($"Error inesperado. \n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ActualizarMensajeDeError(PictureBox imgError, Label lblError, string mensaje) {
            imgError.Visible = true;
            lblError.Visible = true;
            lblError.Text = mensaje;
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e) {
            try {
                Sistema.EscribirArchivos();
                Sistema.RegistrarDesconexion(usuarioActivo!);

                if (!cerrandoSesion) {
                    DialogResult res = MessageBox.Show($"Esta seguro que desea salir de la aplicacion?", "Cerrar aplicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (res == DialogResult.Yes) {
                        formLogin!.Close();
                    }

                    // cancelo cierre de la aplicacion
                    e.Cancel = true;
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Error al guardar los archivos. Se cerrara la aplicacion. \n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
