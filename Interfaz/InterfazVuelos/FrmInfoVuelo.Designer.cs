namespace Interfaz.InterfazViajes {
    partial class FrmInfoVuelo {
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            txtInfoAvion = new Label();
            dataGridPasajeros = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPasajeros).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.Location = new Point(644, 370);
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel4.Dock = DockStyle.Bottom;
            flowLayoutPanel4.Location = new Point(8, 417);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(792, 8);
            flowLayoutPanel4.TabIndex = 63;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel3.Dock = DockStyle.Left;
            flowLayoutPanel3.Location = new Point(0, 8);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(8, 417);
            flowLayoutPanel3.TabIndex = 62;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel2.Dock = DockStyle.Right;
            flowLayoutPanel2.Location = new Point(800, 8);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(8, 417);
            flowLayoutPanel2.TabIndex = 61;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(808, 8);
            flowLayoutPanel1.TabIndex = 60;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dataGridPasajeros);
            panel1.Location = new Point(44, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(719, 313);
            panel1.TabIndex = 64;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(496, 24);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 67;
            label2.Text = "Avion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 24);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 66;
            label1.Text = "Lista pasajeros";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Menu;
            panel2.Controls.Add(txtInfoAvion);
            panel2.Location = new Point(496, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 236);
            panel2.TabIndex = 65;
            // 
            // txtInfoAvion
            // 
            txtInfoAvion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtInfoAvion.Location = new Point(12, 19);
            txtInfoAvion.Name = "txtInfoAvion";
            txtInfoAvion.Size = new Size(175, 205);
            txtInfoAvion.TabIndex = 65;
            txtInfoAvion.Text = "info avion";
            // 
            // dataGridPasajeros
            // 
            dataGridPasajeros.AllowUserToAddRows = false;
            dataGridPasajeros.AllowUserToDeleteRows = false;
            dataGridPasajeros.AllowUserToResizeColumns = false;
            dataGridPasajeros.AllowUserToResizeRows = false;
            dataGridPasajeros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridPasajeros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridPasajeros.BackgroundColor = SystemColors.Menu;
            dataGridPasajeros.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridPasajeros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridPasajeros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridPasajeros.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridPasajeros.EnableHeadersVisualStyles = false;
            dataGridPasajeros.Location = new Point(24, 53);
            dataGridPasajeros.MultiSelect = false;
            dataGridPasajeros.Name = "dataGridPasajeros";
            dataGridPasajeros.ReadOnly = true;
            dataGridPasajeros.RowHeadersVisible = false;
            dataGridPasajeros.RowTemplate.Height = 25;
            dataGridPasajeros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPasajeros.Size = new Size(434, 236);
            dataGridPasajeros.TabIndex = 63;
            dataGridPasajeros.TabStop = false;
            dataGridPasajeros.VirtualMode = true;
            // 
            // FrmInfoVuelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(808, 425);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "FrmInfoVuelo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmInfoVuelo";
            Load += FrmInfoVuelo_Load;
            Controls.SetChildIndex(flowLayoutPanel1, 0);
            Controls.SetChildIndex(flowLayoutPanel2, 0);
            Controls.SetChildIndex(flowLayoutPanel3, 0);
            Controls.SetChildIndex(flowLayoutPanel4, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridPasajeros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private DataGridView dataGridPasajeros;
        private Label txtInfoAvion;
    }
}