namespace Interfaz.InterfazPasajeros {
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
            txtDni = new TextBox();
            lblError = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            label5 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtApellido = new TextBox();
            label1 = new Label();
            dateFechaNacimiento = new DateTimePicker();
            lblFechaNacimiento = new Label();
            SuspendLayout();
            // 
            // txtDni
            // 
            txtDni.BorderStyle = BorderStyle.None;
            txtDni.Location = new Point(42, 230);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(195, 16);
            txtDni.TabIndex = 33;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.IndianRed;
            lblError.Location = new Point(42, 439);
            lblError.Name = "lblError";
            lblError.Size = new Size(55, 21);
            lblError.TabIndex = 32;
            lblError.Text = "(error)";
            lblError.Visible = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(70, 485);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(260, 485);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 30;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 212);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 28;
            label5.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 150);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 26;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Location = new Point(42, 168);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(195, 16);
            txtNombre.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 88);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 24;
            label2.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Location = new Point(42, 106);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(195, 16);
            txtApellido.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(110, 9);
            label1.Name = "label1";
            label1.Size = new Size(170, 32);
            label1.TabIndex = 21;
            label1.Text = "Editar pasajero";
            // 
            // dateFechaNacimiento
            // 
            dateFechaNacimiento.Format = DateTimePickerFormat.Short;
            dateFechaNacimiento.Location = new Point(42, 297);
            dateFechaNacimiento.Name = "dateFechaNacimiento";
            dateFechaNacimiento.Size = new Size(200, 23);
            dateFechaNacimiento.TabIndex = 51;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(42, 269);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(117, 15);
            lblFechaNacimiento.TabIndex = 50;
            lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // FrmEditarPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(408, 530);
            Controls.Add(dateFechaNacimiento);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(txtDni);
            Controls.Add(lblError);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtApellido);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEditarPasajero";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmEditarPasajero";
            Load += FrmEditarPasajero_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtDni;
        private Label lblError;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label label5;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtApellido;
        private Label label1;
        private DateTimePicker dateFechaNacimiento;
        private Label lblFechaNacimiento;
    }
}