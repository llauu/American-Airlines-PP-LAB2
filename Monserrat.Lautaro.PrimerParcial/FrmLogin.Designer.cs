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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            lblCorreo = new Label();
            lblPass = new Label();
            txtCorreo = new TextBox();
            btnLogin = new Button();
            btnCancelar = new Button();
            lblAlerta = new Label();
            imgAlerta = new PictureBox();
            panel1 = new Panel();
            btnMostrarClave = new PictureBox();
            lblAlertaError = new Label();
            panel3 = new Panel();
            txtClave = new TextBox();
            panel2 = new Panel();
            txtInicioSesion = new Label();
            imgPrincipal = new PictureBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)imgAlerta).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMostrarClave).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgPrincipal).BeginInit();
            SuspendLayout();
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorreo.Location = new Point(46, 72);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(138, 21);
            lblCorreo.TabIndex = 9;
            lblCorreo.Text = "Correo electronico";
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
            // txtCorreo
            // 
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(3, 3);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(231, 18);
            txtCorreo.TabIndex = 0;
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
            btnCancelar.Cursor = Cursors.Hand;
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
            lblAlerta.Size = new Size(285, 20);
            lblAlerta.TabIndex = 5;
            lblAlerta.Text = "Debes ingresar un usuario y/o contraseña.";
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
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(btnMostrarClave);
            panel1.Controls.Add(lblAlertaError);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtInicioSesion);
            panel1.Controls.Add(lblPass);
            panel1.Controls.Add(lblAlerta);
            panel1.Controls.Add(imgAlerta);
            panel1.Controls.Add(lblCorreo);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnLogin);
            panel1.Location = new Point(47, 190);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 308);
            panel1.TabIndex = 9;
            // 
            // btnMostrarClave
            // 
            btnMostrarClave.Cursor = Cursors.Hand;
            btnMostrarClave.Image = (Image)resources.GetObject("btnMostrarClave.Image");
            btnMostrarClave.Location = new Point(292, 161);
            btnMostrarClave.Name = "btnMostrarClave";
            btnMostrarClave.Size = new Size(26, 20);
            btnMostrarClave.TabIndex = 17;
            btnMostrarClave.TabStop = false;
            btnMostrarClave.Click += btnMostrarClave_Click;
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
            panel3.Controls.Add(txtClave);
            panel3.Location = new Point(52, 161);
            panel3.Name = "panel3";
            panel3.Size = new Size(237, 23);
            panel3.TabIndex = 15;
            // 
            // txtClave
            // 
            txtClave.BorderStyle = BorderStyle.None;
            txtClave.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtClave.Location = new Point(3, 3);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '●';
            txtClave.Size = new Size(231, 18);
            txtClave.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtCorreo);
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
            imgPrincipal.Anchor = AnchorStyles.None;
            imgPrincipal.Image = (Image)resources.GetObject("imgPrincipal.Image");
            imgPrincipal.Location = new Point(68, 33);
            imgPrincipal.Name = "imgPrincipal";
            imgPrincipal.Size = new Size(297, 113);
            imgPrincipal.TabIndex = 11;
            imgPrincipal.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(436, 543);
            Controls.Add(imgPrincipal);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogin";
            Text = "American Airlines";
            FormClosing += FrmLogin_FormClosing;
            ((System.ComponentModel.ISupportInitialize)imgAlerta).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMostrarClave).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgPrincipal).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblCorreo;
        private Label lblPass;
        private TextBox txtCorreo;
        private Button btnLogin;
        private Button btnCancelar;
        private Label lblAlerta;
        private PictureBox imgAlerta;
        private Panel panel1;
        private Label txtInicioSesion;
        private PictureBox imgPrincipal;
        private Panel panel2;
        private TextBox txtClave;
        private Panel panel3;
        private Label lblAlertaError;
        private PictureBox btnMostrarClave;
        private ToolTip toolTip1;
    }
}