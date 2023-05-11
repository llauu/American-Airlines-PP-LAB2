namespace Interfaz.InterfazAeronaves {
    partial class FrmEditarAeronave {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarAeronave));
            panel1 = new Panel();
            panel4 = new Panel();
            txtCantBodega = new TextBox();
            panel3 = new Panel();
            txtCantBanios = new TextBox();
            panel2 = new Panel();
            txtCantAsientos = new TextBox();
            imgError = new PictureBox();
            lblError = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkInternet = new CheckBox();
            checkComida = new CheckBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            btnAceptar = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgError).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.Location = new Point(66, 446);
            btnCancelar.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(imgError);
            panel1.Controls.Add(lblError);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(checkInternet);
            panel1.Controls.Add(checkComida);
            panel1.Location = new Point(66, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 326);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(txtCantBodega);
            panel4.Location = new Point(23, 172);
            panel4.Name = "panel4";
            panel4.Size = new Size(231, 23);
            panel4.TabIndex = 5;
            // 
            // txtCantBodega
            // 
            txtCantBodega.BorderStyle = BorderStyle.None;
            txtCantBodega.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantBodega.Location = new Point(3, 3);
            txtCantBodega.Name = "txtCantBodega";
            txtCantBodega.Size = new Size(225, 18);
            txtCantBodega.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(txtCantBanios);
            panel3.Location = new Point(23, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(231, 23);
            panel3.TabIndex = 3;
            // 
            // txtCantBanios
            // 
            txtCantBanios.BorderStyle = BorderStyle.None;
            txtCantBanios.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantBanios.Location = new Point(3, 3);
            txtCantBanios.Name = "txtCantBanios";
            txtCantBanios.Size = new Size(225, 18);
            txtCantBanios.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtCantAsientos);
            panel2.Location = new Point(23, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(231, 23);
            panel2.TabIndex = 1;
            // 
            // txtCantAsientos
            // 
            txtCantAsientos.BorderStyle = BorderStyle.None;
            txtCantAsientos.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantAsientos.Location = new Point(3, 3);
            txtCantAsientos.Name = "txtCantAsientos";
            txtCantAsientos.Size = new Size(225, 18);
            txtCantAsientos.TabIndex = 2;
            // 
            // imgError
            // 
            imgError.Image = (Image)resources.GetObject("imgError.Image");
            imgError.Location = new Point(20, 286);
            imgError.Name = "imgError";
            imgError.Size = new Size(18, 20);
            imgError.SizeMode = PictureBoxSizeMode.Zoom;
            imgError.TabIndex = 56;
            imgError.TabStop = false;
            imgError.Visible = false;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.IndianRed;
            lblError.Location = new Point(44, 286);
            lblError.Name = "lblError";
            lblError.Size = new Size(47, 19);
            lblError.TabIndex = 47;
            lblError.Text = "(error)";
            lblError.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 154);
            label4.Name = "label4";
            label4.Size = new Size(154, 15);
            label4.TabIndex = 3;
            label4.Text = "Cantidad de bodega (en kg)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 25);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 1;
            label2.Text = "Cantidad de asientos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 87);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 2;
            label3.Text = "Cantidad banios";
            // 
            // checkInternet
            // 
            checkInternet.AutoSize = true;
            checkInternet.Location = new Point(23, 244);
            checkInternet.Name = "checkInternet";
            checkInternet.Size = new Size(98, 19);
            checkInternet.TabIndex = 8;
            checkInternet.Text = "Tiene internet";
            checkInternet.UseVisualStyleBackColor = true;
            // 
            // checkComida
            // 
            checkComida.AutoSize = true;
            checkComida.Location = new Point(23, 219);
            checkComida.Name = "checkComida";
            checkComida.Size = new Size(97, 19);
            checkComida.TabIndex = 7;
            checkComida.Text = "Tiene comida";
            checkComida.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel4.Dock = DockStyle.Bottom;
            flowLayoutPanel4.Location = new Point(8, 505);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(397, 8);
            flowLayoutPanel4.TabIndex = 68;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel3.Dock = DockStyle.Left;
            flowLayoutPanel3.Location = new Point(0, 8);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(8, 505);
            flowLayoutPanel3.TabIndex = 67;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel2.Dock = DockStyle.Right;
            flowLayoutPanel2.Location = new Point(405, 8);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(8, 505);
            flowLayoutPanel2.TabIndex = 66;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(413, 8);
            flowLayoutPanel1.TabIndex = 65;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(86, 33);
            label1.Name = "label1";
            label1.Size = new Size(233, 32);
            label1.TabIndex = 38;
            label1.Text = "EDITAR AERONAVE";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.CornflowerBlue;
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = SystemColors.ControlText;
            btnAceptar.Location = new Point(245, 446);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(100, 31);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Editar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FrmEditarAeronave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(413, 513);
            Controls.Add(btnAceptar);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "FrmEditarAeronave";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmEditarAeronave";
            Load += FrmEditarAeronave_Load;
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(flowLayoutPanel1, 0);
            Controls.SetChildIndex(flowLayoutPanel2, 0);
            Controls.SetChildIndex(flowLayoutPanel3, 0);
            Controls.SetChildIndex(flowLayoutPanel4, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(btnAceptar, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Panel panel4;
        private TextBox txtCantBodega;
        private Panel panel3;
        private TextBox txtCantBanios;
        private Panel panel2;
        private TextBox txtCantAsientos;
        private PictureBox imgError;
        private Label lblError;
        private Label label4;
        private Label label2;
        private Label label3;
        private CheckBox checkInternet;
        private CheckBox checkComida;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Button btnAceptar;
    }
}