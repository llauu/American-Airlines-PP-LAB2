namespace Interfaz {
    partial class FrmMenuPrincipal {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            panelMenuNav = new Panel();
            btnEstadisticas = new Button();
            barraSeparadora5 = new Panel();
            barraSeparadora1 = new Panel();
            btnAeronaves = new Button();
            btnPasajeros = new Button();
            btnViajes = new Button();
            btnViajesDisponibles = new Button();
            btnVenderViaje = new Button();
            imgLogo = new PictureBox();
            lblPerfil = new Label();
            panelMenuArriba = new Panel();
            lblFecha = new Label();
            imgPerfil = new PictureBox();
            lblOpcionActiva = new Label();
            btnCerrarSesion = new PictureBox();
            toolTip1 = new ToolTip(components);
            panelPantalla = new Panel();
            panelMenuNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            panelMenuArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgPerfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrarSesion).BeginInit();
            SuspendLayout();
            // 
            // panelMenuNav
            // 
            panelMenuNav.BackColor = Color.White;
            panelMenuNav.Controls.Add(btnEstadisticas);
            panelMenuNav.Controls.Add(barraSeparadora5);
            panelMenuNav.Controls.Add(barraSeparadora1);
            panelMenuNav.Controls.Add(btnAeronaves);
            panelMenuNav.Controls.Add(btnPasajeros);
            panelMenuNav.Controls.Add(btnViajes);
            panelMenuNav.Controls.Add(btnViajesDisponibles);
            panelMenuNav.Controls.Add(btnVenderViaje);
            panelMenuNav.Controls.Add(imgLogo);
            panelMenuNav.Dock = DockStyle.Left;
            panelMenuNav.Location = new Point(0, 0);
            panelMenuNav.Name = "panelMenuNav";
            panelMenuNav.Size = new Size(176, 526);
            panelMenuNav.TabIndex = 0;
            // 
            // btnEstadisticas
            // 
            btnEstadisticas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnEstadisticas.BackColor = Color.Transparent;
            btnEstadisticas.Cursor = Cursors.Hand;
            btnEstadisticas.FlatAppearance.BorderSize = 0;
            btnEstadisticas.FlatStyle = FlatStyle.Flat;
            btnEstadisticas.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEstadisticas.ForeColor = Color.Black;
            btnEstadisticas.Location = new Point(0, 124);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Size = new Size(176, 52);
            btnEstadisticas.TabIndex = 1;
            btnEstadisticas.Text = "Estadisticas historicas";
            btnEstadisticas.UseVisualStyleBackColor = false;
            btnEstadisticas.Click += btnEstadisticas_Click;
            // 
            // barraSeparadora5
            // 
            barraSeparadora5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            barraSeparadora5.AutoSize = true;
            barraSeparadora5.BackColor = Color.FromArgb(57, 57, 57);
            barraSeparadora5.Location = new Point(17, 472);
            barraSeparadora5.Name = "barraSeparadora5";
            barraSeparadora5.Size = new Size(140, 2);
            barraSeparadora5.TabIndex = 5;
            // 
            // barraSeparadora1
            // 
            barraSeparadora1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            barraSeparadora1.BackColor = Color.FromArgb(57, 57, 57);
            barraSeparadora1.Location = new Point(17, 116);
            barraSeparadora1.Name = "barraSeparadora1";
            barraSeparadora1.Size = new Size(140, 2);
            barraSeparadora1.TabIndex = 4;
            // 
            // btnAeronaves
            // 
            btnAeronaves.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAeronaves.BackColor = Color.Transparent;
            btnAeronaves.Cursor = Cursors.Hand;
            btnAeronaves.FlatAppearance.BorderSize = 0;
            btnAeronaves.FlatStyle = FlatStyle.Flat;
            btnAeronaves.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAeronaves.ForeColor = Color.Black;
            btnAeronaves.Location = new Point(0, 414);
            btnAeronaves.Name = "btnAeronaves";
            btnAeronaves.Size = new Size(176, 52);
            btnAeronaves.TabIndex = 6;
            btnAeronaves.Text = "Aeronaves";
            btnAeronaves.UseVisualStyleBackColor = false;
            btnAeronaves.Click += btnAeronaves_Click;
            // 
            // btnPasajeros
            // 
            btnPasajeros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPasajeros.BackColor = Color.Transparent;
            btnPasajeros.Cursor = Cursors.Hand;
            btnPasajeros.FlatAppearance.BorderSize = 0;
            btnPasajeros.FlatStyle = FlatStyle.Flat;
            btnPasajeros.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnPasajeros.ForeColor = Color.Black;
            btnPasajeros.Location = new Point(0, 356);
            btnPasajeros.Name = "btnPasajeros";
            btnPasajeros.Size = new Size(176, 52);
            btnPasajeros.TabIndex = 2;
            btnPasajeros.Text = "Pasajeros";
            btnPasajeros.UseVisualStyleBackColor = false;
            btnPasajeros.Click += btnPasajeros_Click;
            // 
            // btnViajes
            // 
            btnViajes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnViajes.BackColor = Color.Transparent;
            btnViajes.Cursor = Cursors.Hand;
            btnViajes.FlatAppearance.BorderSize = 0;
            btnViajes.FlatStyle = FlatStyle.Flat;
            btnViajes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnViajes.ForeColor = Color.Black;
            btnViajes.Location = new Point(0, 298);
            btnViajes.Name = "btnViajes";
            btnViajes.Size = new Size(176, 52);
            btnViajes.TabIndex = 5;
            btnViajes.Text = "Viajes";
            btnViajes.UseVisualStyleBackColor = false;
            btnViajes.Click += btnViajes_Click;
            // 
            // btnViajesDisponibles
            // 
            btnViajesDisponibles.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnViajesDisponibles.BackColor = Color.Transparent;
            btnViajesDisponibles.Cursor = Cursors.Hand;
            btnViajesDisponibles.FlatAppearance.BorderSize = 0;
            btnViajesDisponibles.FlatStyle = FlatStyle.Flat;
            btnViajesDisponibles.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnViajesDisponibles.ForeColor = Color.Black;
            btnViajesDisponibles.Location = new Point(0, 182);
            btnViajesDisponibles.Name = "btnViajesDisponibles";
            btnViajesDisponibles.Size = new Size(176, 52);
            btnViajesDisponibles.TabIndex = 3;
            btnViajesDisponibles.Text = "Viajes disponibles";
            btnViajesDisponibles.UseVisualStyleBackColor = false;
            btnViajesDisponibles.Click += btnViajesDisponibles_Click;
            // 
            // btnVenderViaje
            // 
            btnVenderViaje.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnVenderViaje.BackColor = Color.Transparent;
            btnVenderViaje.Cursor = Cursors.Hand;
            btnVenderViaje.FlatAppearance.BorderSize = 0;
            btnVenderViaje.FlatStyle = FlatStyle.Flat;
            btnVenderViaje.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnVenderViaje.ForeColor = Color.Black;
            btnVenderViaje.Location = new Point(0, 240);
            btnVenderViaje.Name = "btnVenderViaje";
            btnVenderViaje.Size = new Size(176, 52);
            btnVenderViaje.TabIndex = 4;
            btnVenderViaje.Text = "Vender viaje";
            btnVenderViaje.UseVisualStyleBackColor = false;
            btnVenderViaje.Click += btnVenderViaje_Click;
            // 
            // imgLogo
            // 
            imgLogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            imgLogo.BackgroundImageLayout = ImageLayout.None;
            imgLogo.Cursor = Cursors.Hand;
            imgLogo.Image = (Image)resources.GetObject("imgLogo.Image");
            imgLogo.Location = new Point(12, 12);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(151, 68);
            imgLogo.SizeMode = PictureBoxSizeMode.Zoom;
            imgLogo.TabIndex = 0;
            imgLogo.TabStop = false;
            imgLogo.Click += imgLogo_Click;
            // 
            // lblPerfil
            // 
            lblPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblPerfil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPerfil.ForeColor = Color.White;
            lblPerfil.ImageAlign = ContentAlignment.MiddleLeft;
            lblPerfil.Location = new Point(511, 0);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(154, 45);
            lblPerfil.TabIndex = 21;
            lblPerfil.Text = "Nombre Apellido";
            lblPerfil.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelMenuArriba
            // 
            panelMenuArriba.BackColor = Color.FromArgb(57, 57, 57);
            panelMenuArriba.Controls.Add(lblFecha);
            panelMenuArriba.Controls.Add(imgPerfil);
            panelMenuArriba.Controls.Add(lblOpcionActiva);
            panelMenuArriba.Controls.Add(btnCerrarSesion);
            panelMenuArriba.Controls.Add(lblPerfil);
            panelMenuArriba.Dock = DockStyle.Top;
            panelMenuArriba.Location = new Point(176, 0);
            panelMenuArriba.Name = "panelMenuArriba";
            panelMenuArriba.Size = new Size(702, 45);
            panelMenuArriba.TabIndex = 2;
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.White;
            lblFecha.ImageAlign = ContentAlignment.MiddleRight;
            lblFecha.Location = new Point(371, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(111, 45);
            lblFecha.TabIndex = 22;
            lblFecha.Text = "dd/mm/yy";
            lblFecha.TextAlign = ContentAlignment.MiddleRight;
            // 
            // imgPerfil
            // 
            imgPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            imgPerfil.Image = (Image)resources.GetObject("imgPerfil.Image");
            imgPerfil.Location = new Point(488, 12);
            imgPerfil.Name = "imgPerfil";
            imgPerfil.Size = new Size(24, 25);
            imgPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            imgPerfil.TabIndex = 3;
            imgPerfil.TabStop = false;
            // 
            // lblOpcionActiva
            // 
            lblOpcionActiva.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblOpcionActiva.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpcionActiva.ForeColor = Color.White;
            lblOpcionActiva.Location = new Point(15, 0);
            lblOpcionActiva.Name = "lblOpcionActiva";
            lblOpcionActiva.Size = new Size(374, 45);
            lblOpcionActiva.TabIndex = 0;
            lblOpcionActiva.Text = "Inicio";
            lblOpcionActiva.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.Image = (Image)resources.GetObject("btnCerrarSesion.Image");
            btnCerrarSesion.Location = new Point(665, 12);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(25, 21);
            btnCerrarSesion.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrarSesion.TabIndex = 3;
            btnCerrarSesion.TabStop = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // panelPantalla
            // 
            panelPantalla.BackColor = Color.Transparent;
            panelPantalla.Dock = DockStyle.Fill;
            panelPantalla.Location = new Point(176, 45);
            panelPantalla.Name = "panelPantalla";
            panelPantalla.Size = new Size(702, 481);
            panelPantalla.TabIndex = 3;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(878, 526);
            Controls.Add(panelPantalla);
            Controls.Add(panelMenuArriba);
            Controls.Add(panelMenuNav);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "FrmMenuPrincipal";
            Text = "American Airlines";
            FormClosed += FrmMenuPrincipal_FormClosed;
            Load += FrmMenuPrincipal_Load;
            Resize += FrmMenuPrincipal_Resize;
            panelMenuNav.ResumeLayout(false);
            panelMenuNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            panelMenuArriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgPerfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrarSesion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenuNav;
        private PictureBox imgLogo;
        private Label lblPerfil;
        private Panel panelMenuArriba;
        private PictureBox btnCerrarSesion;
        private ToolTip toolTip1;
        private Button btnViajes;
        private Button btnVenderViaje;
        private Button btnViajesDisponibles;
        private Button btnPasajeros;
        private Button btnEstadisticas;
        private Label lblOpcionActiva;
        private PictureBox imgPerfil;
        private Panel barraSeparadora1;
        private Panel barraSeparadora5;
        private Label lblFecha;
        private Panel panelPantalla;
        private Button btnAeronaves;
    }
}