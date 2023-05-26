namespace Interfaz.InterfazViajes {
    partial class FrmVentaVuelo {
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentaVuelo));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            btnDatosEquipajes = new PictureBox();
            panel3 = new Panel();
            btnAgregarPasajero = new PictureBox();
            btnAgregarEquipaje = new PictureBox();
            label2 = new Label();
            dataGridPasajesAgregados = new DataGridView();
            panel2 = new Panel();
            txtBuscar = new TextBox();
            imgBuscar = new PictureBox();
            dataGridPasajeros = new DataGridView();
            imgError = new PictureBox();
            lblError = new Label();
            btnAceptar = new Button();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            rdbPremium = new RadioButton();
            rdbTurista = new RadioButton();
            gbClase = new GroupBox();
            groupBox1 = new GroupBox();
            rdbLlevaEquipaje = new RadioButton();
            rdbNoLlevaEquipaje = new RadioButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnDatosEquipajes).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAgregarPasajero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAgregarEquipaje).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridPasajesAgregados).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridPasajeros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgError).BeginInit();
            gbClase.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.Location = new Point(544, 383);
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel4.Dock = DockStyle.Bottom;
            flowLayoutPanel4.Location = new Point(8, 432);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(819, 8);
            flowLayoutPanel4.TabIndex = 63;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel3.Dock = DockStyle.Left;
            flowLayoutPanel3.Location = new Point(0, 8);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(8, 432);
            flowLayoutPanel3.TabIndex = 62;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel2.Dock = DockStyle.Right;
            flowLayoutPanel2.Location = new Point(827, 8);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(8, 432);
            flowLayoutPanel2.TabIndex = 61;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(57, 57, 57);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(835, 8);
            flowLayoutPanel1.TabIndex = 60;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(btnDatosEquipajes);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnAgregarEquipaje);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dataGridPasajesAgregados);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(imgBuscar);
            panel1.Controls.Add(dataGridPasajeros);
            panel1.Location = new Point(52, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(727, 282);
            panel1.TabIndex = 64;
            // 
            // btnDatosEquipajes
            // 
            btnDatosEquipajes.Cursor = Cursors.Hand;
            btnDatosEquipajes.Image = (Image)resources.GetObject("btnDatosEquipajes.Image");
            btnDatosEquipajes.Location = new Point(668, 189);
            btnDatosEquipajes.Name = "btnDatosEquipajes";
            btnDatosEquipajes.Size = new Size(49, 37);
            btnDatosEquipajes.SizeMode = PictureBoxSizeMode.Zoom;
            btnDatosEquipajes.TabIndex = 71;
            btnDatosEquipajes.TabStop = false;
            btnDatosEquipajes.Click += btnDatosEquipajes_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(gbClase);
            panel3.Controls.Add(btnAgregarPasajero);
            panel3.Location = new Point(259, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(82, 219);
            panel3.TabIndex = 66;
            // 
            // btnAgregarPasajero
            // 
            btnAgregarPasajero.Cursor = Cursors.Hand;
            btnAgregarPasajero.Image = (Image)resources.GetObject("btnAgregarPasajero.Image");
            btnAgregarPasajero.Location = new Point(18, 167);
            btnAgregarPasajero.Name = "btnAgregarPasajero";
            btnAgregarPasajero.Size = new Size(43, 37);
            btnAgregarPasajero.SizeMode = PictureBoxSizeMode.Zoom;
            btnAgregarPasajero.TabIndex = 71;
            btnAgregarPasajero.TabStop = false;
            btnAgregarPasajero.Click += btnAgregarPasajero_Click;
            // 
            // btnAgregarEquipaje
            // 
            btnAgregarEquipaje.Cursor = Cursors.Hand;
            btnAgregarEquipaje.Image = (Image)resources.GetObject("btnAgregarEquipaje.Image");
            btnAgregarEquipaje.Location = new Point(668, 232);
            btnAgregarEquipaje.Name = "btnAgregarEquipaje";
            btnAgregarEquipaje.Size = new Size(49, 37);
            btnAgregarEquipaje.SizeMode = PictureBoxSizeMode.Zoom;
            btnAgregarEquipaje.TabIndex = 66;
            btnAgregarEquipaje.TabStop = false;
            btnAgregarEquipaje.Click += btnAgregarEquipaje_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(356, 27);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 70;
            label2.Text = "Pasajes agregados";
            // 
            // dataGridPasajesAgregados
            // 
            dataGridPasajesAgregados.AllowUserToAddRows = false;
            dataGridPasajesAgregados.AllowUserToDeleteRows = false;
            dataGridPasajesAgregados.AllowUserToResizeColumns = false;
            dataGridPasajesAgregados.AllowUserToResizeRows = false;
            dataGridPasajesAgregados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridPasajesAgregados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridPasajesAgregados.BackgroundColor = SystemColors.Menu;
            dataGridPasajesAgregados.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridPasajesAgregados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridPasajesAgregados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridPasajesAgregados.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridPasajesAgregados.EnableHeadersVisualStyles = false;
            dataGridPasajesAgregados.Location = new Point(356, 50);
            dataGridPasajesAgregados.MultiSelect = false;
            dataGridPasajesAgregados.Name = "dataGridPasajesAgregados";
            dataGridPasajesAgregados.ReadOnly = true;
            dataGridPasajesAgregados.RowHeadersVisible = false;
            dataGridPasajesAgregados.RowTemplate.Height = 25;
            dataGridPasajesAgregados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPasajesAgregados.Size = new Size(301, 219);
            dataGridPasajesAgregados.TabIndex = 69;
            dataGridPasajesAgregados.TabStop = false;
            dataGridPasajesAgregados.VirtualMode = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtBuscar);
            panel2.Location = new Point(41, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(203, 20);
            panel2.TabIndex = 67;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.White;
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscar.Location = new Point(3, 3);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(197, 15);
            txtBuscar.TabIndex = 4;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // imgBuscar
            // 
            imgBuscar.Image = (Image)resources.GetObject("imgBuscar.Image");
            imgBuscar.Location = new Point(14, 24);
            imgBuscar.Name = "imgBuscar";
            imgBuscar.Size = new Size(21, 20);
            imgBuscar.SizeMode = PictureBoxSizeMode.Zoom;
            imgBuscar.TabIndex = 66;
            imgBuscar.TabStop = false;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridPasajeros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridPasajeros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridPasajeros.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridPasajeros.EnableHeadersVisualStyles = false;
            dataGridPasajeros.Location = new Point(14, 50);
            dataGridPasajeros.MultiSelect = false;
            dataGridPasajeros.Name = "dataGridPasajeros";
            dataGridPasajeros.ReadOnly = true;
            dataGridPasajeros.RowHeadersVisible = false;
            dataGridPasajeros.RowTemplate.Height = 25;
            dataGridPasajeros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPasajeros.Size = new Size(230, 219);
            dataGridPasajeros.TabIndex = 63;
            dataGridPasajeros.TabStop = false;
            dataGridPasajeros.VirtualMode = true;
            // 
            // imgError
            // 
            imgError.Image = (Image)resources.GetObject("imgError.Image");
            imgError.Location = new Point(52, 390);
            imgError.Name = "imgError";
            imgError.Size = new Size(18, 20);
            imgError.SizeMode = PictureBoxSizeMode.Zoom;
            imgError.TabIndex = 56;
            imgError.TabStop = false;
            imgError.Visible = false;
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.IndianRed;
            lblError.Location = new Point(76, 390);
            lblError.Name = "lblError";
            lblError.Size = new Size(374, 20);
            lblError.TabIndex = 47;
            lblError.Text = "(error)";
            lblError.Visible = false;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.CornflowerBlue;
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = SystemColors.ControlText;
            btnAceptar.Location = new Point(679, 383);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(100, 31);
            btnAceptar.TabIndex = 65;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(8, 28);
            label1.Name = "label1";
            label1.Size = new Size(819, 32);
            label1.TabIndex = 64;
            label1.Text = "VENTA DE PASAJES";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rdbPremium
            // 
            rdbPremium.AutoSize = true;
            rdbPremium.Location = new Point(2, 22);
            rdbPremium.Name = "rdbPremium";
            rdbPremium.Size = new Size(74, 19);
            rdbPremium.TabIndex = 73;
            rdbPremium.TabStop = true;
            rdbPremium.Text = "Premium";
            rdbPremium.UseVisualStyleBackColor = true;
            // 
            // rdbTurista
            // 
            rdbTurista.AutoSize = true;
            rdbTurista.Location = new Point(2, 39);
            rdbTurista.Name = "rdbTurista";
            rdbTurista.Size = new Size(60, 19);
            rdbTurista.TabIndex = 74;
            rdbTurista.TabStop = true;
            rdbTurista.Text = "Turista";
            rdbTurista.UseVisualStyleBackColor = true;
            // 
            // gbClase
            // 
            gbClase.Controls.Add(rdbPremium);
            gbClase.Controls.Add(rdbTurista);
            gbClase.Location = new Point(3, 91);
            gbClase.Name = "gbClase";
            gbClase.Size = new Size(74, 61);
            gbClase.TabIndex = 72;
            gbClase.TabStop = false;
            gbClase.Text = "Clase";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbLlevaEquipaje);
            groupBox1.Controls.Add(rdbNoLlevaEquipaje);
            groupBox1.Location = new Point(3, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(74, 72);
            groupBox1.TabIndex = 73;
            groupBox1.TabStop = false;
            groupBox1.Text = "Equipaje de mano";
            // 
            // rdbLlevaEquipaje
            // 
            rdbLlevaEquipaje.AutoSize = true;
            rdbLlevaEquipaje.Location = new Point(0, 35);
            rdbLlevaEquipaje.Name = "rdbLlevaEquipaje";
            rdbLlevaEquipaje.Size = new Size(34, 19);
            rdbLlevaEquipaje.TabIndex = 73;
            rdbLlevaEquipaje.TabStop = true;
            rdbLlevaEquipaje.Text = "Si";
            rdbLlevaEquipaje.UseVisualStyleBackColor = true;
            // 
            // rdbNoLlevaEquipaje
            // 
            rdbNoLlevaEquipaje.AutoSize = true;
            rdbNoLlevaEquipaje.Location = new Point(0, 51);
            rdbNoLlevaEquipaje.Name = "rdbNoLlevaEquipaje";
            rdbNoLlevaEquipaje.Size = new Size(41, 19);
            rdbNoLlevaEquipaje.TabIndex = 74;
            rdbNoLlevaEquipaje.TabStop = true;
            rdbNoLlevaEquipaje.Text = "No";
            rdbNoLlevaEquipaje.UseVisualStyleBackColor = true;
            // 
            // FrmVentaVuelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(835, 440);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Controls.Add(panel1);
            Controls.Add(imgError);
            Controls.Add(lblError);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "FrmVentaVuelo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmVentaVuelo";
            Load += FrmVentaVuelo_Load;
            Controls.SetChildIndex(flowLayoutPanel1, 0);
            Controls.SetChildIndex(flowLayoutPanel2, 0);
            Controls.SetChildIndex(flowLayoutPanel3, 0);
            Controls.SetChildIndex(flowLayoutPanel4, 0);
            Controls.SetChildIndex(lblError, 0);
            Controls.SetChildIndex(imgError, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(btnAceptar, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnDatosEquipajes).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnAgregarPasajero).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAgregarEquipaje).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridPasajesAgregados).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridPasajeros).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgError).EndInit();
            gbClase.ResumeLayout(false);
            gbClase.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private DataGridView dataGridPasajeros;
        private PictureBox imgError;
        private Label lblError;
        private Button btnAceptar;
        private Label label1;
        private Label label2;
        private DataGridView dataGridPasajesAgregados;
        private Panel panel2;
        private TextBox txtBuscar;
        private PictureBox imgBuscar;
        private PictureBox btnAgregarPasajero;
        private PictureBox btnAgregarEquipaje;
        private ToolTip toolTip1;
        private Panel panel3;
        private PictureBox btnDatosEquipajes;
        private RadioButton rdbTurista;
        private RadioButton rdbPremium;
        private GroupBox groupBox1;
        private RadioButton rdbLlevaEquipaje;
        private RadioButton rdbNoLlevaEquipaje;
        private GroupBox gbClase;
    }
}