﻿namespace Interfaz.InterfazPasajeros {
    partial class FrmEditarPasajero {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarPasajero));
            panel1 = new Panel();
            imgError = new PictureBox();
            panel4 = new Panel();
            txtDni = new TextBox();
            lblFechaNacimiento = new Label();
            lblError = new Label();
            panel3 = new Panel();
            txtNombre = new TextBox();
            panel2 = new Panel();
            txtApellido = new TextBox();
            label5 = new Label();
            dateFechaNacimiento = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAceptar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgError).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.Location = new Point(66, 446);
            btnCancelar.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(imgError);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(lblFechaNacimiento);
            panel1.Controls.Add(lblError);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dateFechaNacimiento);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(66, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 326);
            panel1.TabIndex = 0;
            // 
            // imgError
            // 
            imgError.Image = (Image)resources.GetObject("imgError.Image");
            imgError.Location = new Point(21, 285);
            imgError.Name = "imgError";
            imgError.Size = new Size(18, 20);
            imgError.SizeMode = PictureBoxSizeMode.Zoom;
            imgError.TabIndex = 56;
            imgError.TabStop = false;
            imgError.Visible = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(txtDni);
            panel4.Location = new Point(23, 172);
            panel4.Name = "panel4";
            panel4.Size = new Size(231, 23);
            panel4.TabIndex = 5;
            // 
            // txtDni
            // 
            txtDni.BorderStyle = BorderStyle.None;
            txtDni.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(3, 2);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(225, 18);
            txtDni.TabIndex = 6;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.BackColor = Color.Silver;
            lblFechaNacimiento.Location = new Point(23, 222);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(117, 15);
            lblFechaNacimiento.TabIndex = 42;
            lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.IndianRed;
            lblError.Location = new Point(45, 285);
            lblError.Name = "lblError";
            lblError.Size = new Size(47, 19);
            lblError.TabIndex = 47;
            lblError.Text = "(error)";
            lblError.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(txtNombre);
            panel3.Location = new Point(23, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(231, 23);
            panel3.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(3, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(225, 18);
            txtNombre.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtApellido);
            panel2.Location = new Point(23, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(231, 23);
            panel2.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(3, 3);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(225, 18);
            txtApellido.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Silver;
            label5.Location = new Point(23, 154);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 43;
            label5.Text = "DNI";
            // 
            // dateFechaNacimiento
            // 
            dateFechaNacimiento.Format = DateTimePickerFormat.Short;
            dateFechaNacimiento.Location = new Point(23, 240);
            dateFechaNacimiento.Name = "dateFechaNacimiento";
            dateFechaNacimiento.Size = new Size(231, 23);
            dateFechaNacimiento.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.Location = new Point(23, 87);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 41;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Silver;
            label4.Location = new Point(23, 25);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 39;
            label4.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(89, 37);
            label1.Name = "label1";
            label1.Size = new Size(225, 32);
            label1.TabIndex = 57;
            label1.Text = "EDITAR PASAJERO";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel4.Dock = DockStyle.Bottom;
            flowLayoutPanel4.Location = new Point(8, 505);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(397, 8);
            flowLayoutPanel4.TabIndex = 61;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel3.Dock = DockStyle.Left;
            flowLayoutPanel3.Location = new Point(0, 8);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(8, 505);
            flowLayoutPanel3.TabIndex = 60;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel2.Dock = DockStyle.Right;
            flowLayoutPanel2.Location = new Point(405, 8);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(8, 505);
            flowLayoutPanel2.TabIndex = 59;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(413, 8);
            flowLayoutPanel1.TabIndex = 58;
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
            btnAceptar.TabIndex = 9;
            btnAceptar.Text = "Editar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FrmEditarPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(413, 513);
            Controls.Add(btnAceptar);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FrmEditarPasajero";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmEditarPasajero";
            Load += FrmEditarPasajero_Load;
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(flowLayoutPanel1, 0);
            Controls.SetChildIndex(flowLayoutPanel2, 0);
            Controls.SetChildIndex(flowLayoutPanel3, 0);
            Controls.SetChildIndex(flowLayoutPanel4, 0);
            Controls.SetChildIndex(btnAceptar, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgError).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private PictureBox imgError;
        private Panel panel4;
        private TextBox txtDni;
        private Label lblFechaNacimiento;
        private Label lblError;
        private Panel panel3;
        private TextBox txtNombre;
        private Panel panel2;
        private TextBox txtApellido;
        private Label label5;
        private DateTimePicker dateFechaNacimiento;
        private Label label3;
        private Label label4;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAceptar;
    }
}