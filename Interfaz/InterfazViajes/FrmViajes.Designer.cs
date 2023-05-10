namespace Interfaz {
    partial class FrmViajes {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViajes));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            imgBuscar = new PictureBox();
            txtBuscar = new TextBox();
            imgError = new PictureBox();
            lblError = new Label();
            panel1 = new Panel();
            btnEditar = new PictureBox();
            btnEliminar = new PictureBox();
            btnAgregar = new PictureBox();
            dataGridViajes = new DataGridView();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)imgBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgError).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnEditar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViajes).BeginInit();
            SuspendLayout();
            // 
            // imgBuscar
            // 
            imgBuscar.Image = (Image)resources.GetObject("imgBuscar.Image");
            imgBuscar.Location = new Point(44, 30);
            imgBuscar.Name = "imgBuscar";
            imgBuscar.Size = new Size(26, 25);
            imgBuscar.SizeMode = PictureBoxSizeMode.Zoom;
            imgBuscar.TabIndex = 21;
            imgBuscar.TabStop = false;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.White;
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscar.Location = new Point(3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(331, 18);
            txtBuscar.TabIndex = 4;
            // 
            // imgError
            // 
            imgError.Image = (Image)resources.GetObject("imgError.Image");
            imgError.Location = new Point(415, 34);
            imgError.Name = "imgError";
            imgError.Size = new Size(18, 20);
            imgError.SizeMode = PictureBoxSizeMode.Zoom;
            imgError.TabIndex = 24;
            imgError.TabStop = false;
            imgError.Visible = false;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.IndianRed;
            lblError.Location = new Point(439, 37);
            lblError.Name = "lblError";
            lblError.Size = new Size(40, 15);
            lblError.TabIndex = 23;
            lblError.Text = "(error)";
            lblError.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtBuscar);
            panel1.Location = new Point(75, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 25);
            panel1.TabIndex = 22;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new Point(641, 194);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(50, 50);
            btnEditar.SizeMode = PictureBoxSizeMode.Zoom;
            btnEditar.TabIndex = 20;
            btnEditar.TabStop = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(641, 138);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(50, 50);
            btnEliminar.SizeMode = PictureBoxSizeMode.Zoom;
            btnEliminar.TabIndex = 19;
            btnEliminar.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.BackColor = Color.Gainsboro;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.Location = new Point(641, 82);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(50, 50);
            btnAgregar.SizeMode = PictureBoxSizeMode.Zoom;
            btnAgregar.TabIndex = 18;
            btnAgregar.TabStop = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dataGridViajes
            // 
            dataGridViajes.AllowUserToAddRows = false;
            dataGridViajes.AllowUserToDeleteRows = false;
            dataGridViajes.AllowUserToResizeColumns = false;
            dataGridViajes.AllowUserToResizeRows = false;
            dataGridViajes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViajes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViajes.BackgroundColor = SystemColors.Menu;
            dataGridViajes.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViajes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViajes.EnableHeadersVisualStyles = false;
            dataGridViajes.Location = new Point(45, 82);
            dataGridViajes.MultiSelect = false;
            dataGridViajes.Name = "dataGridViajes";
            dataGridViajes.ReadOnly = true;
            dataGridViajes.RowHeadersVisible = false;
            dataGridViajes.RowTemplate.Height = 25;
            dataGridViajes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViajes.Size = new Size(590, 378);
            dataGridViajes.TabIndex = 17;
            dataGridViajes.TabStop = false;
            dataGridViajes.VirtualMode = true;
            // 
            // FrmViajes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(702, 481);
            Controls.Add(imgBuscar);
            Controls.Add(imgError);
            Controls.Add(lblError);
            Controls.Add(panel1);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridViajes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmViajes";
            Text = "FrmViajes";
            Load += FrmViajes_Load;
            ((System.ComponentModel.ISupportInitialize)imgBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgError).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnEditar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViajes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imgBuscar;
        private TextBox txtBuscar;
        private PictureBox imgError;
        private Label lblError;
        private Panel panel1;
        private PictureBox btnEditar;
        private PictureBox btnEliminar;
        private PictureBox btnAgregar;
        private DataGridView dataGridViajes;
        private ToolTip toolTip1;
    }
}