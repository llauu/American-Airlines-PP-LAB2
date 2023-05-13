namespace Interfaz.InterfazViajes {
    partial class FrmEditarViaje {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarViaje));
            btnAceptar = new Button();
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            panel1 = new Panel();
            dataGridAeronaves = new DataGridView();
            label4 = new Label();
            cbCiudadDestino = new ComboBox();
            imgError = new PictureBox();
            cbCiudadPartida = new ComboBox();
            lblFechaNacimiento = new Label();
            lblError = new Label();
            label5 = new Label();
            dateFechaVuelo = new DateTimePicker();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAeronaves).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgError).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.Location = new Point(484, 383);
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.CornflowerBlue;
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = SystemColors.ControlText;
            btnAceptar.Location = new Point(619, 383);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(100, 31);
            btnAceptar.TabIndex = 68;
            btnAceptar.Text = "Editar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel4.Dock = DockStyle.Bottom;
            flowLayoutPanel4.Location = new Point(8, 429);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(754, 8);
            flowLayoutPanel4.TabIndex = 67;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel3.Dock = DockStyle.Left;
            flowLayoutPanel3.Location = new Point(0, 8);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(8, 429);
            flowLayoutPanel3.TabIndex = 66;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel2.Dock = DockStyle.Right;
            flowLayoutPanel2.Location = new Point(762, 8);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(8, 429);
            flowLayoutPanel2.TabIndex = 65;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(770, 8);
            flowLayoutPanel1.TabIndex = 64;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(746, 32);
            label1.TabIndex = 69;
            label1.Text = "EDITAR VUELO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(dataGridAeronaves);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cbCiudadDestino);
            panel1.Controls.Add(imgError);
            panel1.Controls.Add(cbCiudadPartida);
            panel1.Controls.Add(lblFechaNacimiento);
            panel1.Controls.Add(lblError);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dateFechaVuelo);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(52, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(667, 274);
            panel1.TabIndex = 70;
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
            dataGridAeronaves.Size = new Size(336, 205);
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
            // cbCiudadDestino
            // 
            cbCiudadDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCiudadDestino.FlatStyle = FlatStyle.Flat;
            cbCiudadDestino.FormattingEnabled = true;
            cbCiudadDestino.Location = new Point(20, 106);
            cbCiudadDestino.Name = "cbCiudadDestino";
            cbCiudadDestino.Size = new Size(158, 23);
            cbCiudadDestino.TabIndex = 61;
            // 
            // imgError
            // 
            imgError.Image = (Image)resources.GetObject("imgError.Image");
            imgError.Location = new Point(23, 216);
            imgError.Name = "imgError";
            imgError.Size = new Size(18, 20);
            imgError.SizeMode = PictureBoxSizeMode.Zoom;
            imgError.TabIndex = 56;
            imgError.TabStop = false;
            imgError.Visible = false;
            // 
            // cbCiudadPartida
            // 
            cbCiudadPartida.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCiudadPartida.FlatStyle = FlatStyle.Flat;
            cbCiudadPartida.FormattingEnabled = true;
            cbCiudadPartida.Location = new Point(21, 43);
            cbCiudadPartida.Name = "cbCiudadPartida";
            cbCiudadPartida.Size = new Size(158, 23);
            cbCiudadPartida.TabIndex = 60;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.BackColor = Color.Silver;
            lblFechaNacimiento.Location = new Point(21, 152);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(89, 15);
            lblFechaNacimiento.TabIndex = 42;
            lblFechaNacimiento.Text = "Fecha del vuelo";
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.IndianRed;
            lblError.Location = new Point(47, 216);
            lblError.Name = "lblError";
            lblError.Size = new Size(232, 43);
            lblError.TabIndex = 47;
            lblError.Text = "(error)";
            lblError.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Silver;
            label5.Location = new Point(23, 88);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 43;
            label5.Text = "Ciudad de destino";
            // 
            // dateFechaVuelo
            // 
            dateFechaVuelo.Format = DateTimePickerFormat.Short;
            dateFechaVuelo.Location = new Point(21, 170);
            dateFechaVuelo.Name = "dateFechaVuelo";
            dateFechaVuelo.Size = new Size(231, 23);
            dateFechaVuelo.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.Location = new Point(21, 25);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 41;
            label3.Text = "Ciudad de partida";
            // 
            // FrmEditarViaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(770, 437);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "FrmEditarViaje";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmEditarViaje";
            Load += FrmEditarViaje_Load;
            Controls.SetChildIndex(flowLayoutPanel1, 0);
            Controls.SetChildIndex(flowLayoutPanel2, 0);
            Controls.SetChildIndex(flowLayoutPanel3, 0);
            Controls.SetChildIndex(flowLayoutPanel4, 0);
            Controls.SetChildIndex(btnAceptar, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAeronaves).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgError).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAceptar;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Panel panel1;
        private DataGridView dataGridAeronaves;
        private Label label4;
        private ComboBox cbCiudadDestino;
        private PictureBox imgError;
        private ComboBox cbCiudadPartida;
        private Label lblFechaNacimiento;
        private Label lblError;
        private Label label5;
        private DateTimePicker dateFechaVuelo;
        private Label label3;
    }
}