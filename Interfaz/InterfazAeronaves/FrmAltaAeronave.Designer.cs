namespace Interfaz.InterfazAeronaves {
    partial class FrmAltaAeronave {
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            checkInternet = new CheckBox();
            checkComida = new CheckBox();
            txtCantAsientos = new TextBox();
            txtCantBanios = new TextBox();
            txtCantBodega = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            lblError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(142, 33);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 0;
            label1.Text = "Alta aeronave";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 94);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 1;
            label2.Text = "Cantidad de asientos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 149);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 2;
            label3.Text = "Cantidad banios";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 206);
            label4.Name = "label4";
            label4.Size = new Size(154, 15);
            label4.TabIndex = 3;
            label4.Text = "Cantidad de bodega (en kg)";
            // 
            // checkInternet
            // 
            checkInternet.AutoSize = true;
            checkInternet.Location = new Point(48, 263);
            checkInternet.Name = "checkInternet";
            checkInternet.Size = new Size(98, 19);
            checkInternet.TabIndex = 4;
            checkInternet.Text = "Tiene internet";
            checkInternet.UseVisualStyleBackColor = true;
            // 
            // checkComida
            // 
            checkComida.AutoSize = true;
            checkComida.Location = new Point(48, 298);
            checkComida.Name = "checkComida";
            checkComida.Size = new Size(97, 19);
            checkComida.TabIndex = 5;
            checkComida.Text = "Tiene comida";
            checkComida.UseVisualStyleBackColor = true;
            // 
            // txtCantAsientos
            // 
            txtCantAsientos.Location = new Point(48, 112);
            txtCantAsientos.Name = "txtCantAsientos";
            txtCantAsientos.Size = new Size(200, 23);
            txtCantAsientos.TabIndex = 6;
            // 
            // txtCantBanios
            // 
            txtCantBanios.Location = new Point(48, 167);
            txtCantBanios.Name = "txtCantBanios";
            txtCantBanios.Size = new Size(200, 23);
            txtCantBanios.TabIndex = 7;
            // 
            // txtCantBodega
            // 
            txtCantBodega.Location = new Point(48, 224);
            txtCantBodega.Name = "txtCantBodega";
            txtCantBodega.Size = new Size(200, 23);
            txtCantBodega.TabIndex = 8;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(57, 426);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(233, 426);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.IndianRed;
            lblError.Location = new Point(48, 367);
            lblError.Name = "lblError";
            lblError.Size = new Size(40, 15);
            lblError.TabIndex = 11;
            lblError.Text = "(error)";
            // 
            // FrmAltaAeronave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(392, 491);
            Controls.Add(lblError);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(txtCantBodega);
            Controls.Add(txtCantBanios);
            Controls.Add(txtCantAsientos);
            Controls.Add(checkComida);
            Controls.Add(checkInternet);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAltaAeronave";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmAltaAeronave";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox checkInternet;
        private CheckBox checkComida;
        private TextBox txtCantAsientos;
        private TextBox txtCantBanios;
        private TextBox txtCantBodega;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label lblError;
    }
}