namespace Interfaz {
    partial class FrmAltaViaje {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaViaje));
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            dataGridAeronaves = new DataGridView();
            label4 = new Label();
            comboBox2 = new ComboBox();
            imgError = new PictureBox();
            lblFechaNacimiento = new Label();
            lblError = new Label();
            panel2 = new Panel();
            txtApellido = new TextBox();
            label5 = new Label();
            dateFechaNacimiento = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAceptar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAeronaves).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgError).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.Location = new Point(484, 441);
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel4.Dock = DockStyle.Bottom;
            flowLayoutPanel4.Location = new Point(12, 494);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(746, 12);
            flowLayoutPanel4.TabIndex = 59;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel3.Dock = DockStyle.Left;
            flowLayoutPanel3.Location = new Point(0, 12);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(12, 494);
            flowLayoutPanel3.TabIndex = 58;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel2.Dock = DockStyle.Right;
            flowLayoutPanel2.Location = new Point(758, 12);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(12, 494);
            flowLayoutPanel2.TabIndex = 57;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(770, 12);
            flowLayoutPanel1.TabIndex = 56;
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(23, 105);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(158, 23);
            comboBox1.TabIndex = 60;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(dataGridAeronaves);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(imgError);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(lblFechaNacimiento);
            panel1.Controls.Add(lblError);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dateFechaNacimiento);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(52, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(667, 326);
            panel1.TabIndex = 61;
            // 
            // dataGridAeronaves
            // 
            dataGridAeronaves.AllowUserToAddRows = false;
            dataGridAeronaves.AllowUserToDeleteRows = false;
            dataGridAeronaves.AllowUserToResizeColumns = false;
            dataGridAeronaves.AllowUserToResizeRows = false;
            dataGridAeronaves.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridAeronaves.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridAeronaves.BackgroundColor = SystemColors.Menu;
            dataGridAeronaves.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridAeronaves.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridAeronaves.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridAeronaves.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridAeronaves.EnableHeadersVisualStyles = false;
            dataGridAeronaves.Location = new Point(306, 43);
            dataGridAeronaves.MultiSelect = false;
            dataGridAeronaves.Name = "dataGridAeronaves";
            dataGridAeronaves.ReadOnly = true;
            dataGridAeronaves.RowHeadersVisible = false;
            dataGridAeronaves.RowTemplate.Height = 25;
            dataGridAeronaves.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridAeronaves.Size = new Size(336, 214);
            dataGridAeronaves.TabIndex = 63;
            dataGridAeronaves.TabStop = false;
            dataGridAeronaves.VirtualMode = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Silver;
            label4.Location = new Point(306, 25);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 62;
            label4.Text = "Avion";
            // 
            // comboBox2
            // 
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(23, 168);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(158, 23);
            comboBox2.TabIndex = 61;
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
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.BackColor = Color.Silver;
            lblFechaNacimiento.Location = new Point(23, 216);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(89, 15);
            lblFechaNacimiento.TabIndex = 42;
            lblFechaNacimiento.Text = "Fecha del vuelo";
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
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtApellido);
            panel2.Location = new Point(23, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(158, 23);
            panel2.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(3, 3);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(152, 18);
            txtApellido.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Silver;
            label5.Location = new Point(26, 150);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 43;
            label5.Text = "Ciudad de destino";
            // 
            // dateFechaNacimiento
            // 
            dateFechaNacimiento.Format = DateTimePickerFormat.Short;
            dateFechaNacimiento.Location = new Point(23, 234);
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
            label3.Size = new Size(101, 15);
            label3.TabIndex = 41;
            label3.Text = "Ciudad de partida";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Location = new Point(23, 25);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 39;
            label2.Text = "Cantidad de asientos";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(746, 32);
            label1.TabIndex = 62;
            label1.Text = "AGREGAR VUELO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.CornflowerBlue;
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = SystemColors.ControlText;
            btnAceptar.Location = new Point(619, 441);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(100, 31);
            btnAceptar.TabIndex = 63;
            btnAceptar.Text = "Agregar";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // FrmAltaViaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(770, 506);
            Controls.Add(btnAceptar);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "FrmAltaViaje";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmAltaViaje";
            Load += FrmAltaViaje_Load;
            Controls.SetChildIndex(flowLayoutPanel1, 0);
            Controls.SetChildIndex(flowLayoutPanel2, 0);
            Controls.SetChildIndex(flowLayoutPanel3, 0);
            Controls.SetChildIndex(flowLayoutPanel4, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(btnAceptar, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAeronaves).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgError).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox comboBox1;
        private Panel panel1;
        private PictureBox imgError;
        private Label lblFechaNacimiento;
        private Label lblError;
        private Panel panel2;
        private TextBox txtApellido;
        private Label label5;
        private DateTimePicker dateFechaNacimiento;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox2;
        private Label label4;
        private DataGridView dataGridAeronaves;
        private Button btnAceptar;
    }
}