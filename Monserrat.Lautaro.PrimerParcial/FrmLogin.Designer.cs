namespace Monserrat.Lautaro.PrimerParcial {
    partial class FrmLogin {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            lblUsuario = new Label();
            lblPass = new Label();
            txtUsuario = new TextBox();
            btnLogin = new Button();
            btnCancelar = new Button();
            lblAlerta = new Label();
            imgAlerta = new PictureBox();
            panel1 = new Panel();
            lblAlertaError = new Label();
            panel3 = new Panel();
            txtPass = new TextBox();
            panel2 = new Panel();
            txtInicioSesion = new Label();
            imgPrincipal = new PictureBox();
            btnCerrar = new PictureBox();
            btnMinimizar = new Panel();
            btnMinimizar2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)imgAlerta).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgPrincipal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            btnMinimizar.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(46, 72);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(64, 21);
            lblUsuario.TabIndex = 9;
            lblUsuario.Text = "Usuario";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPass.Location = new Point(46, 137);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(89, 21);
            lblPass.TabIndex = 8;
            lblPass.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(3, 3);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(231, 18);
            txtUsuario.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.CornflowerBlue;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ControlText;
            btnLogin.Location = new Point(189, 208);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 31);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Iniciar sesion";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Silver;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(52, 208);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 31);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblAlerta
            // 
            lblAlerta.AutoSize = true;
            lblAlerta.BackColor = Color.Gainsboro;
            lblAlerta.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlerta.ForeColor = Color.IndianRed;
            lblAlerta.Location = new Point(46, 265);
            lblAlerta.Name = "lblAlerta";
            lblAlerta.Size = new Size(277, 20);
            lblAlerta.TabIndex = 5;
            lblAlerta.Text = "Debes ingresa un usuario y/o contraseña";
            lblAlerta.Visible = false;
            // 
            // imgAlerta
            // 
            imgAlerta.Image = (Image)resources.GetObject("imgAlerta.Image");
            imgAlerta.Location = new Point(21, 262);
            imgAlerta.Name = "imgAlerta";
            imgAlerta.Size = new Size(26, 23);
            imgAlerta.TabIndex = 8;
            imgAlerta.TabStop = false;
            imgAlerta.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(lblAlertaError);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtInicioSesion);
            panel1.Controls.Add(lblPass);
            panel1.Controls.Add(lblAlerta);
            panel1.Controls.Add(imgAlerta);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnLogin);
            panel1.Location = new Point(45, 204);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 308);
            panel1.TabIndex = 9;
            // 
            // lblAlertaError
            // 
            lblAlertaError.AutoSize = true;
            lblAlertaError.BackColor = Color.Gainsboro;
            lblAlertaError.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlertaError.ForeColor = Color.IndianRed;
            lblAlertaError.Location = new Point(46, 265);
            lblAlertaError.Name = "lblAlertaError";
            lblAlertaError.Size = new Size(292, 20);
            lblAlertaError.TabIndex = 16;
            lblAlertaError.Text = "La contraseña o el usuario son incorrectos. ";
            lblAlertaError.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(txtPass);
            panel3.Location = new Point(52, 161);
            panel3.Name = "panel3";
            panel3.Size = new Size(237, 23);
            panel3.TabIndex = 15;
            // 
            // txtPass
            // 
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(3, 3);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '●';
            txtPass.Size = new Size(231, 18);
            txtPass.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtUsuario);
            panel2.Location = new Point(52, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(237, 23);
            panel2.TabIndex = 12;
            // 
            // txtInicioSesion
            // 
            txtInicioSesion.AutoSize = true;
            txtInicioSesion.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            txtInicioSesion.Location = new Point(46, 22);
            txtInicioSesion.Name = "txtInicioSesion";
            txtInicioSesion.Size = new Size(171, 30);
            txtInicioSesion.TabIndex = 10;
            txtInicioSesion.Text = "Inicio de sesion";
            // 
            // imgPrincipal
            // 
            imgPrincipal.Image = (Image)resources.GetObject("imgPrincipal.Image");
            imgPrincipal.Location = new Point(66, 47);
            imgPrincipal.Name = "imgPrincipal";
            imgPrincipal.Size = new Size(297, 113);
            imgPrincipal.TabIndex = 11;
            imgPrincipal.TabStop = false;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(402, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(28, 27);
            btnCerrar.TabIndex = 12;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Controls.Add(btnMinimizar2);
            btnMinimizar.Location = new Point(367, 2);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(29, 29);
            btnMinimizar.TabIndex = 13;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMinimizar2
            // 
            btnMinimizar2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar2.BackColor = SystemColors.WindowFrame;
            btnMinimizar2.Location = new Point(3, 10);
            btnMinimizar2.Name = "btnMinimizar2";
            btnMinimizar2.Size = new Size(20, 5);
            btnMinimizar2.TabIndex = 14;
            btnMinimizar2.Click += btnMinimizar2_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(432, 555);
            Controls.Add(btnMinimizar);
            Controls.Add(btnCerrar);
            Controls.Add(imgPrincipal);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogin";
            ShowIcon = false;
            Text = "American Airlines";
            ((System.ComponentModel.ISupportInitialize)imgAlerta).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgPrincipal).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            btnMinimizar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblUsuario;
        private Label lblPass;
        private TextBox txtUsuario;
        private Button btnLogin;
        private Button btnCancelar;
        private Label lblAlerta;
        private PictureBox imgAlerta;
        private Panel panel1;
        private Label txtInicioSesion;
        private PictureBox imgPrincipal;
        private Panel panel2;
        private TextBox txtPass;
        private Panel panel3;
        private PictureBox btnCerrar;
        private Panel btnMinimizar;
        private Panel btnMinimizar2;
        private Label lblAlertaError;
    }
}