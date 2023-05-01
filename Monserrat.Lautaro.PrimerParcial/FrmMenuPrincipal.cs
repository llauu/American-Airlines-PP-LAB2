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
        bool cerrandoSesion;

        public FrmMenuPrincipal(Usuario usuarioActivo, FrmLogin formLogin) {
            InitializeComponent();

            cerrandoSesion = false;
            string fechaHoy = DateTime.UtcNow.ToString("d");

            this.StartPosition = FormStartPosition.CenterScreen;
            this.toolTip1.SetToolTip(btnCerrarSesion, "Cerrar sesion");
            this.toolTip1.SetToolTip(imgLogo, "Inicio");

            this.lblFecha.Text = fechaHoy;

            this.MinimumSize = new Size(894, 565);

            lblPerfil.Text = $"{usuarioActivo.nombre} {usuarioActivo.apellido}";
            this.formLogin = formLogin;
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

        private void imgLogo_Click(object sender, EventArgs e) {
            ActualizarTitulo("Inicio");
            ReiniciarFondoOpciones();
        }

        private void FrmMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e) {
            if(!cerrandoSesion) {
                formLogin.Close();
            }
        }
    }
}
