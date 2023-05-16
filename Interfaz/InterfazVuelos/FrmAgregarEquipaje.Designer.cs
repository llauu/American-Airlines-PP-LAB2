namespace Interfaz.InterfazVuelos {
    partial class FrmAgregarEquipaje {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarEquipaje));
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAceptar = new Button();
            label1 = new Label();
            imgError = new PictureBox();
            lblError = new Label();
            label2 = new Label();
            panel1 = new Panel();
            numPesoEquipaje = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)imgError).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPesoEquipaje).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.Location = new Point(146, 181);
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel4.Dock = DockStyle.Bottom;
            flowLayoutPanel4.Location = new Point(8, 222);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(387, 8);
            flowLayoutPanel4.TabIndex = 67;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel3.Dock = DockStyle.Left;
            flowLayoutPanel3.Location = new Point(0, 8);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(8, 222);
            flowLayoutPanel3.TabIndex = 66;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel2.Dock = DockStyle.Right;
            flowLayoutPanel2.Location = new Point(395, 8);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(8, 222);
            flowLayoutPanel2.TabIndex = 65;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(403, 8);
            flowLayoutPanel1.TabIndex = 64;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.CornflowerBlue;
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = SystemColors.ControlText;
            btnAceptar.Location = new Point(268, 181);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(100, 31);
            btnAceptar.TabIndex = 68;
            btnAceptar.Text = "Agregar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(8, 20);
            label1.Name = "label1";
            label1.Size = new Size(387, 32);
            label1.TabIndex = 71;
            label1.Text = "AGREGAR EQUIPAJE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imgError
            // 
            imgError.Image = (Image)resources.GetObject("imgError.Image");
            imgError.Location = new Point(12, 71);
            imgError.Name = "imgError";
            imgError.Size = new Size(18, 20);
            imgError.SizeMode = PictureBoxSizeMode.Zoom;
            imgError.TabIndex = 70;
            imgError.TabStop = false;
            imgError.Visible = false;
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.IndianRed;
            lblError.Location = new Point(36, 71);
            lblError.Name = "lblError";
            lblError.Size = new Size(290, 20);
            lblError.TabIndex = 69;
            lblError.Text = "(error)";
            lblError.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 16);
            label2.Name = "label2";
            label2.Size = new Size(139, 15);
            label2.TabIndex = 72;
            label2.Text = "Peso del equipaje (en kg)";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(numPesoEquipaje);
            panel1.Controls.Add(imgError);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblError);
            panel1.Location = new Point(33, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 104);
            panel1.TabIndex = 74;
            // 
            // numPesoEquipaje
            // 
            numPesoEquipaje.Location = new Point(12, 34);
            numPesoEquipaje.Name = "numPesoEquipaje";
            numPesoEquipaje.Size = new Size(120, 23);
            numPesoEquipaje.TabIndex = 73;
            // 
            // FrmAgregarEquipaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 230);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "FrmAgregarEquipaje";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmAgregarEquipaje";
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(flowLayoutPanel1, 0);
            Controls.SetChildIndex(flowLayoutPanel2, 0);
            Controls.SetChildIndex(flowLayoutPanel3, 0);
            Controls.SetChildIndex(flowLayoutPanel4, 0);
            Controls.SetChildIndex(btnAceptar, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(label1, 0);
            ((System.ComponentModel.ISupportInitialize)imgError).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPesoEquipaje).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAceptar;
        private Label label1;
        private PictureBox imgError;
        private Label lblError;
        private Label label2;
        private Panel panel1;
        private NumericUpDown numPesoEquipaje;
    }
}