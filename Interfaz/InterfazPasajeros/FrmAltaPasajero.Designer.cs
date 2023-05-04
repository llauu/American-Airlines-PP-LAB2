namespace Interfaz.InterfazPasajeros {
    partial class FrmAltaPasajero {
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
            lblFechaNacimiento = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtApellido = new TextBox();
            label1 = new Label();
            dateFechaNacimiento = new DateTimePicker();
            SuspendLayout();
            // 
            // txtDni
            // 
            txtDni.BorderStyle = BorderStyle.None;
            txtDni.Location = new Point(58, 237);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(195, 16);
            txtDni.TabIndex = 48;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.IndianRed;
            lblError.Location = new Point(58, 446);
            lblError.Name = "lblError";
            lblError.Size = new Size(55, 21);
            lblError.TabIndex = 47;
            lblError.Text = "(error)";
            lblError.Visible = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(86, 492);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 46;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(276, 492);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 45;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 219);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 43;
            label5.Text = "DNI";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(58, 270);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(117, 15);
            lblFechaNacimiento.TabIndex = 42;
            lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 157);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 41;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Location = new Point(58, 175);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(195, 16);
            txtNombre.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 95);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 39;
            label2.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Location = new Point(58, 113);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(195, 16);
            txtApellido.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(106, 21);
            label1.Name = "label1";
            label1.Size = new Size(194, 32);
            label1.TabIndex = 36;
            label1.Text = "Agregar pasajero";
            // 
            // dateFechaNacimiento
            // 
            dateFechaNacimiento.Format = DateTimePickerFormat.Short;
            dateFechaNacimiento.Location = new Point(58, 298);
            dateFechaNacimiento.Name = "dateFechaNacimiento";
            dateFechaNacimiento.Size = new Size(200, 23);
            dateFechaNacimiento.TabIndex = 49;
            // 
            // FrmAltaPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(408, 530);
            Controls.Add(dateFechaNacimiento);
            Controls.Add(txtDni);
            Controls.Add(lblError);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label5);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtApellido);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAltaPasajero";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmAltaPasajero";
            Load += FrmAltaPasajero_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtDni;
        private Label lblError;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label label5;
        private Label lblFechaNacimiento;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtApellido;
        private Label label1;
        private DateTimePicker dateFechaNacimiento;
    }
}