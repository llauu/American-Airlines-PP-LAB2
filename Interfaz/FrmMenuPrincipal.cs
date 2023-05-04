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
        private FrmLogin formLogin;
        private Form? formOpcionActiva;
        bool cerrandoSesion;

        public FrmMenuPrincipal(Usuario usuarioActivo, FrmLogin formLogin) {
            InitializeComponent();

            string fechaHoy = DateTime.UtcNow.ToString("d");

            this.StartPosition = FormStartPosition.CenterScreen;
            this.toolTip1.SetToolTip(btnCerrarSesion, "Cerrar sesion");
            this.toolTip1.SetToolTip(imgLogo, "Inicio");

            this.lblFecha.Text = fechaHoy;

            this.MinimumSize = new Size(894, 565);

            CargarPerfilUsuario(usuarioActivo);

            this.lblPerfil.Text = $"{usuarioActivo.Nombre} {usuarioActivo.Apellido}";
            this.cerrandoSesion = false;
            this.formLogin = formLogin;
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e) {
            AbrirFormOpcionElegida(new FrmInicio());
        }

        private void CargarPerfilUsuario(Usuario usuario) {
            switch (usuario.Perfil) {
                case "vendedor":
                    this.btnViajes.Enabled = false;
                    this.btnAeronaves.Enabled = false;
                    break;

                case "supervisor":
                    this.btnViajesDisponibles.Enabled = false;
                    this.btnVenderViaje.Enabled = false;
                    this.btnViajes.Enabled = false;
                    this.btnAeronaves.Enabled = false;
                    break;

                case "administrador":
                    //this.btnEstadisticas.Enabled = false;
                    //this.btnViajesDisponibles.Enabled = false;
                    //this.btnVenderViaje.Enabled = false;
                    //this.btnPasajeros.Enabled = false;
                    break;

                default:
                    foreach(Control item in panelMenuNav.Controls) {
                        item.Enabled = false;
                    }
                    break;
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e) {
            DialogResult rta = MessageBox.Show("Estas seguro que deseas cerrar sesion?", "Cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.Yes) {
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
            AbrirFormOpcionElegida(new FrmViajesDisponibles());
        }

        private void btnVenderViaje_Click(object sender, EventArgs e) {
            ActualizarOpcionActiva(btnVenderViaje);
            AbrirFormOpcionElegida(new FrmVenderViaje());
        }

        private void btnViajes_Click(object sender, EventArgs e) {
            ActualizarOpcionActiva(btnViajes);
            AbrirFormOpcionElegida(new FrmViajes());
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
                this.panelMenuArriba.Height = 55;
                this.panelMenuNav.Width = 210;
                this.lblOpcionActiva.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
                this.btnAeronaves.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                this.btnEstadisticas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                this.btnPasajeros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                this.btnVenderViaje.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                this.btnViajes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                this.btnViajesDisponibles.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                this.btnVenderViaje.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            }
            else {
                if (this.Size.Width < 1000 && this.Size.Height < 800) {
                    this.panelMenuArriba.Height = 45;
                    this.panelMenuNav.Width = 176;
                    this.lblOpcionActiva.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
                    this.btnAeronaves.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                    this.btnEstadisticas.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                    this.btnPasajeros.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                    this.btnVenderViaje.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                    this.btnViajes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                    this.btnViajesDisponibles.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                    this.btnVenderViaje.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        private void ReiniciarFondoOpciones() {
            btnViajesDisponibles.BackColor = Color.Transparent;
            btnVenderViaje.BackColor = Color.Transparent;
            btnEstadisticas.BackColor = Color.Transparent;
            btnViajes.BackColor = Color.Transparent;
            btnPasajeros.BackColor = Color.Transparent;
            btnAeronaves.BackColor = Color.Transparent;
        }

        private void ActualizarOpcionActiva(Button opcion) {
            ReiniciarFondoOpciones();
            ActualizarTitulo(opcion.Text);
            opcion.BackColor = Color.LightSteelBlue;
        }

        private void FrmMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e) {
            if (!cerrandoSesion) {
                Application.Exit();
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
    }
}
