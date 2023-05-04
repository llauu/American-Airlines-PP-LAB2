namespace Interfaz {
    partial class FrmPasajeros {
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPasajeros));
            dataGridPasajeros = new DataGridView();
            btnAgregar = new PictureBox();
            btnEliminar = new PictureBox();
            btnEditar = new PictureBox();
            txtBuscar = new TextBox();
            imgBuscar = new PictureBox();
            panel1 = new Panel();
            toolTip1 = new ToolTip(components);
            lblError = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridPasajeros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEditar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgBuscar).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridPasajeros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridPasajeros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPasajeros.EnableHeadersVisualStyles = false;
            dataGridPasajeros.Location = new Point(12, 79);
            dataGridPasajeros.MultiSelect = false;
            dataGridPasajeros.Name = "dataGridPasajeros";
            dataGridPasajeros.ReadOnly = true;
            dataGridPasajeros.RowHeadersVisible = false;
            dataGridPasajeros.RowTemplate.Height = 25;
            dataGridPasajeros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPasajeros.Size = new Size(622, 390);
            dataGridPasajeros.TabIndex = 0;
            dataGridPasajeros.TabStop = false;
            dataGridPasajeros.VirtualMode = true;
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
            btnAgregar.TabIndex = 1;
            btnAgregar.TabStop = false;
            btnAgregar.Click += btnAgregar_Click;
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
            btnEliminar.TabIndex = 2;
            btnEliminar.TabStop = false;
            btnEliminar.Click += btnEliminar_Click;
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
            btnEditar.TabIndex = 3;
            btnEditar.TabStop = false;
            btnEditar.Click += btnEditar_Click;
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
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // imgBuscar
            // 
            imgBuscar.Image = (Image)resources.GetObject("imgBuscar.Image");
            imgBuscar.Location = new Point(12, 30);
            imgBuscar.Name = "imgBuscar";
            imgBuscar.Size = new Size(26, 25);
            imgBuscar.SizeMode = PictureBoxSizeMode.Zoom;
            imgBuscar.TabIndex = 5;
            imgBuscar.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtBuscar);
            panel1.Location = new Point(44, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 25);
            panel1.TabIndex = 6;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.IndianRed;
            lblError.Location = new Point(393, 36);
            lblError.Name = "lblError";
            lblError.Size = new Size(40, 15);
            lblError.TabIndex = 7;
            lblError.Text = "(error)";
            lblError.Visible = false;
            // 
            // FrmPasajeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(702, 481);
            Controls.Add(lblError);
            Controls.Add(panel1);
            Controls.Add(imgBuscar);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridPasajeros);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPasajeros";
            Text = "FrmPasajeros";
            Load += FrmPasajeros_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridPasajeros).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEditar).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgBuscar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridPasajeros;
        private PictureBox btnAgregar;
        private PictureBox btnEliminar;
        private PictureBox btnEditar;
        private TextBox txtBuscar;
        private PictureBox imgBuscar;
        private Panel panel1;
        private ToolTip toolTip1;
        private Label lblError;
    }
}