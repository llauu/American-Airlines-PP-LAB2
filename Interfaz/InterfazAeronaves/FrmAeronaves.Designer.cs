namespace Interfaz {
    partial class FrmAeronaves {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAeronaves));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnEditar = new PictureBox();
            btnEliminar = new PictureBox();
            btnAgregar = new PictureBox();
            dataGridAeronaves = new DataGridView();
            lblError = new Label();
            toolTip1 = new ToolTip(components);
            imgError = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnEditar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridAeronaves).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgError).BeginInit();
            SuspendLayout();
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new Point(640, 191);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(50, 50);
            btnEditar.SizeMode = PictureBoxSizeMode.Zoom;
            btnEditar.TabIndex = 11;
            btnEditar.TabStop = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(640, 135);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(50, 50);
            btnEliminar.SizeMode = PictureBoxSizeMode.Zoom;
            btnEliminar.TabIndex = 10;
            btnEliminar.TabStop = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.BackColor = Color.Gainsboro;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.Location = new Point(640, 79);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(50, 50);
            btnAgregar.SizeMode = PictureBoxSizeMode.Zoom;
            btnAgregar.TabIndex = 9;
            btnAgregar.TabStop = false;
            btnAgregar.Click += btnAgregar_Click;
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
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridAeronaves.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridAeronaves.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAeronaves.EnableHeadersVisualStyles = false;
            dataGridAeronaves.Location = new Point(45, 61);
            dataGridAeronaves.MultiSelect = false;
            dataGridAeronaves.Name = "dataGridAeronaves";
            dataGridAeronaves.ReadOnly = true;
            dataGridAeronaves.RowHeadersVisible = false;
            dataGridAeronaves.RowTemplate.Height = 25;
            dataGridAeronaves.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridAeronaves.Size = new Size(590, 388);
            dataGridAeronaves.TabIndex = 8;
            dataGridAeronaves.TabStop = false;
            dataGridAeronaves.VirtualMode = true;
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.IndianRed;
            lblError.Location = new Point(67, 22);
            lblError.Name = "lblError";
            lblError.Size = new Size(549, 17);
            lblError.TabIndex = 14;
            lblError.Text = "(error)";
            lblError.Visible = false;
            // 
            // imgError
            // 
            imgError.Image = (Image)resources.GetObject("imgError.Image");
            imgError.Location = new Point(43, 22);
            imgError.Name = "imgError";
            imgError.Size = new Size(18, 20);
            imgError.SizeMode = PictureBoxSizeMode.Zoom;
            imgError.TabIndex = 15;
            imgError.TabStop = false;
            imgError.Visible = false;
            // 
            // FrmAeronaves
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(702, 481);
            Controls.Add(imgError);
            Controls.Add(lblError);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridAeronaves);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAeronaves";
            Text = "FrmAeronaves";
            Load += FrmAeronaves_Load;
            ((System.ComponentModel.ISupportInitialize)btnEditar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridAeronaves).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgError).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox btnEditar;
        private PictureBox btnEliminar;
        private PictureBox btnAgregar;
        private DataGridView dataGridAeronaves;
        private Label lblError;
        private ToolTip toolTip1;
        private PictureBox imgError;
    }
}