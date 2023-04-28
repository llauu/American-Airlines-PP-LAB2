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

namespace Monserrat.Lautaro.PrimerParcial {
    public partial class FrmMenuPrincipal : Form {
        FrmLogin formLogin;


        public FrmMenuPrincipal(Usuario usuarioActivo, FrmLogin formLogin) {
            Size size = new Size(894, 565);
            string fecha = DateTime.UtcNow.ToString("d");

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.toolTip1.SetToolTip(btnCerrarSesion, "Cerrar sesion");
            this.toolTip1.SetToolTip(imgLogo, "Inicio");

            this.lblFecha.Text = fecha;

            this.MinimumSize = size;

            lblPerfil.Text = $"{usuarioActivo.nombre} {usuarioActivo.apellido}";
            this.formLogin = formLogin;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e) {
            this.Close();
            formLogin.Show();
        }

        private void ActualizarTitulo(string tituloNuevo) {
            lblOpcionActiva.Text = tituloNuevo;
        }

        private void ReiniciarFondoOpciones() {
            btnViajesDisponibles.BackColor = Color.Transparent;
            btnVenderViaje.BackColor = Color.Transparent;
            btnEstadisticas.BackColor = Color.Transparent;
            btnViajes.BackColor = Color.Transparent;
            btnPasajeros.BackColor = Color.Transparent;
            btnAeronaves.BackColor = Color.Transparent;
        }

        private void btnViajesDisponibles_Click(object sender, EventArgs e) {
            ActualizarTitulo(btnViajesDisponibles.Text);
            ReiniciarFondoOpciones();
            btnViajesDisponibles.BackColor = Color.LightSteelBlue;
        }

        private void btnVenderViaje_Click(object sender, EventArgs e) {
            ActualizarTitulo(btnVenderViaje.Text);
            ReiniciarFondoOpciones();
            btnVenderViaje.BackColor = Color.LightSteelBlue;
        }

        private void btnEstadisticas_Click(object sender, EventArgs e) {
            ActualizarTitulo(btnEstadisticas.Text);
            ReiniciarFondoOpciones();
            btnEstadisticas.BackColor = Color.LightSteelBlue;
        }

        private void btnViajes_Click(object sender, EventArgs e) {
            ActualizarTitulo(btnViajes.Text);
            ReiniciarFondoOpciones();
            btnViajes.BackColor = Color.LightSteelBlue;
        }

        private void btnPasajeros_Click(object sender, EventArgs e) {
            ActualizarTitulo(btnPasajeros.Text);
            ReiniciarFondoOpciones();
            btnPasajeros.BackColor = Color.LightSteelBlue;
        }

        private void btnAeronaves_Click(object sender, EventArgs e) {
            ActualizarTitulo(btnAeronaves.Text);
            ReiniciarFondoOpciones();
            btnAeronaves.BackColor = Color.LightSteelBlue;
        }

        private void FrmMenuPrincipal_Resize(object sender, EventArgs e) {
            if (this.Size.Width > 1000 && this.Size.Height > 800) {
                this.panelMenuArriba.Height = 55;
                this.panelMenuNav.Width = 210;
            }
            else {
                if (this.Size.Width < 1000 && this.Size.Height < 800) {
                    this.panelMenuArriba.Height = 45;
                    this.panelMenuNav.Width = 176;
                }
            }
        }

        private void imgLogo_Click(object sender, EventArgs e) {
            ActualizarTitulo("Inicio");
            ReiniciarFondoOpciones();
        }
    }
}
