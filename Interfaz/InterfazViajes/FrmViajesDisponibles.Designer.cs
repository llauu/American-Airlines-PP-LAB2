namespace Interfaz {
    partial class FrmViajesDisponibles {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViajesDisponibles));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel2 = new Panel();
            btnInfoAvion = new PictureBox();
            imgError = new PictureBox();
            lblError = new Label();
            dataGridViajes = new DataGridView();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)btnInfoAvion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViajes).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(57, 57, 57);
            panel2.Location = new Point(641, 117);
            panel2.Name = "panel2";
            panel2.Size = new Size(50, 2);
            panel2.TabIndex = 31;
            // 
            // btnInfoAvion
            // 
            btnInfoAvion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnInfoAvion.Cursor = Cursors.Hand;
            btnInfoAvion.Image = (Image)resources.GetObject("btnInfoAvion.Image");
            btnInfoAvion.Location = new Point(641, 61);
            btnInfoAvion.Name = "btnInfoAvion";
            btnInfoAvion.Size = new Size(50, 50);
            btnInfoAvion.SizeMode = PictureBoxSizeMode.Zoom;
            btnInfoAvion.TabIndex = 30;
            btnInfoAvion.TabStop = false;
            btnInfoAvion.Click += btnInfoAvion_Click;
            // 
            // imgError
            // 
            imgError.Image = (Image)resources.GetObject("imgError.Image");
            imgError.Location = new Point(43, 22);
            imgError.Name = "imgError";
            imgError.Size = new Size(18, 20);
            imgError.SizeMode = PictureBoxSizeMode.Zoom;
            imgError.TabIndex = 29;
            imgError.TabStop = false;
            imgError.Visible = false;
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.IndianRed;
            lblError.Location = new Point(67, 25);
            lblError.Name = "lblError";
            lblError.Size = new Size(525, 17);
            lblError.TabIndex = 28;
            lblError.Text = "(error)";
            lblError.Visible = false;
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
            dataGridViajes.Location = new Point(45, 61);
            dataGridViajes.MultiSelect = false;
            dataGridViajes.Name = "dataGridViajes";
            dataGridViajes.ReadOnly = true;
            dataGridViajes.RowHeadersVisible = false;
            dataGridViajes.RowTemplate.Height = 25;
            dataGridViajes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViajes.Size = new Size(590, 388);
            dataGridViajes.TabIndex = 27;
            dataGridViajes.TabStop = false;
            dataGridViajes.VirtualMode = true;
            // 
            // FrmViajesDisponibles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(702, 481);
            Controls.Add(panel2);
            Controls.Add(btnInfoAvion);
            Controls.Add(imgError);
            Controls.Add(lblError);
            Controls.Add(dataGridViajes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmViajesDisponibles";
            Text = "FrmViajesDisponibles";
            Load += FrmViajesDisponibles_Load;
            ((System.ComponentModel.ISupportInitialize)btnInfoAvion).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgError).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViajes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox btnInfoAvion;
        private ToolTip toolTip1;
        protected PictureBox imgError;
        protected Label lblError;
        protected DataGridView dataGridViajes;
    }
}