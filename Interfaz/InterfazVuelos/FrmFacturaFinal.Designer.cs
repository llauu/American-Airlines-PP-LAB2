namespace Interfaz.InterfazVuelos {
    partial class FrmFacturaFinal {
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
            rtbFactura = new RichTextBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            panel1 = new Panel();
            lblTotal = new Label();
            lblIVA = new Label();
            lblSubtotal = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            btnAceptar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // rtbFactura
            // 
            rtbFactura.BorderStyle = BorderStyle.None;
            rtbFactura.Enabled = false;
            rtbFactura.Location = new Point(27, 82);
            rtbFactura.Name = "rtbFactura";
            rtbFactura.ReadOnly = true;
            rtbFactura.Size = new Size(207, 184);
            rtbFactura.TabIndex = 0;
            rtbFactura.Text = "";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel4.Dock = DockStyle.Bottom;
            flowLayoutPanel4.Location = new Point(8, 423);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(247, 8);
            flowLayoutPanel4.TabIndex = 67;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel3.Dock = DockStyle.Left;
            flowLayoutPanel3.Location = new Point(0, 8);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(8, 423);
            flowLayoutPanel3.TabIndex = 66;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel2.Dock = DockStyle.Right;
            flowLayoutPanel2.Location = new Point(255, 8);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(8, 423);
            flowLayoutPanel2.TabIndex = 65;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(263, 8);
            flowLayoutPanel1.TabIndex = 64;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(8, 31);
            label1.Name = "label1";
            label1.Size = new Size(247, 32);
            label1.TabIndex = 68;
            label1.Text = "FACTURA FINAL";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(lblIVA);
            panel1.Controls.Add(lblSubtotal);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(27, 265);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 96);
            panel1.TabIndex = 69;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Silver;
            lblTotal.Location = new Point(110, 77);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(13, 15);
            lblTotal.TabIndex = 75;
            lblTotal.Text = "$";
            // 
            // lblIVA
            // 
            lblIVA.AutoSize = true;
            lblIVA.Location = new Point(110, 34);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(13, 15);
            lblIVA.TabIndex = 74;
            lblIVA.Text = "$";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(110, 10);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(13, 15);
            lblSubtotal.TabIndex = 73;
            lblSubtotal.Text = "$";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Silver;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 77);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 72;
            label4.Text = "TOTAL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 34);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 71;
            label3.Text = "IVA 21.0%";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 10);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 70;
            label2.Text = "Subtotal";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Location = new Point(0, 72);
            panel3.Name = "panel3";
            panel3.Size = new Size(207, 24);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Location = new Point(27, 264);
            panel2.Name = "panel2";
            panel2.Size = new Size(207, 2);
            panel2.TabIndex = 0;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.CornflowerBlue;
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = SystemColors.ControlText;
            btnAceptar.Location = new Point(134, 376);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(100, 31);
            btnAceptar.TabIndex = 70;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FrmFacturaFinal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(263, 431);
            Controls.Add(btnAceptar);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(rtbFactura);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmFacturaFinal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmFacturaFinal";
            Load += FrmFacturaFinal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbFactura;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label lblTotal;
        private Label lblIVA;
        private Label lblSubtotal;
        private Button btnAceptar;
        private Panel panel3;
    }
}