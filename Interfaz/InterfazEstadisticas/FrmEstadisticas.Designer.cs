namespace Interfaz {
    partial class FrmEstadisticas {
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstadisticas));
            dataGridFacturacionDestinos = new DataGridView();
            lblDestinoTexto = new Label();
            panel1 = new Panel();
            btnDescargar = new PictureBox();
            lblGananciasNacionales = new Label();
            label6 = new Label();
            lblGananciasInternacionales = new Label();
            label4 = new Label();
            lblGananciasTotales = new Label();
            label2 = new Label();
            panel2 = new Panel();
            lblDestinoMasElegido = new Label();
            dataGridPasajerosFrecuentes = new DataGridView();
            dataGridHorasDeVuelo = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridFacturacionDestinos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnDescargar).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPasajerosFrecuentes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridHorasDeVuelo).BeginInit();
            SuspendLayout();
            // 
            // dataGridFacturacionDestinos
            // 
            dataGridFacturacionDestinos.AllowUserToAddRows = false;
            dataGridFacturacionDestinos.AllowUserToDeleteRows = false;
            dataGridFacturacionDestinos.AllowUserToResizeColumns = false;
            dataGridFacturacionDestinos.AllowUserToResizeRows = false;
            dataGridFacturacionDestinos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridFacturacionDestinos.BackgroundColor = Color.WhiteSmoke;
            dataGridFacturacionDestinos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridFacturacionDestinos.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridFacturacionDestinos.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridFacturacionDestinos.Location = new Point(15, 98);
            dataGridFacturacionDestinos.Name = "dataGridFacturacionDestinos";
            dataGridFacturacionDestinos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridFacturacionDestinos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridFacturacionDestinos.RowHeadersVisible = false;
            dataGridFacturacionDestinos.RowTemplate.Height = 25;
            dataGridFacturacionDestinos.Size = new Size(163, 344);
            dataGridFacturacionDestinos.TabIndex = 0;
            // 
            // lblDestinoTexto
            // 
            lblDestinoTexto.AutoSize = true;
            lblDestinoTexto.BackColor = Color.DarkGray;
            lblDestinoTexto.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblDestinoTexto.Location = new Point(3, 20);
            lblDestinoTexto.Name = "lblDestinoTexto";
            lblDestinoTexto.Size = new Size(159, 20);
            lblDestinoTexto.TabIndex = 1;
            lblDestinoTexto.Text = "Destino mas elegido: ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(btnDescargar);
            panel1.Controls.Add(lblGananciasNacionales);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblGananciasInternacionales);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblGananciasTotales);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(585, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(187, 490);
            panel1.TabIndex = 2;
            // 
            // btnDescargar
            // 
            btnDescargar.Cursor = Cursors.Hand;
            btnDescargar.Image = (Image)resources.GetObject("btnDescargar.Image");
            btnDescargar.Location = new Point(127, 443);
            btnDescargar.Name = "btnDescargar";
            btnDescargar.Size = new Size(48, 35);
            btnDescargar.SizeMode = PictureBoxSizeMode.Zoom;
            btnDescargar.TabIndex = 8;
            btnDescargar.TabStop = false;
            btnDescargar.Click += btnDescargar_Click;
            // 
            // lblGananciasNacionales
            // 
            lblGananciasNacionales.AutoSize = true;
            lblGananciasNacionales.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblGananciasNacionales.Location = new Point(10, 280);
            lblGananciasNacionales.Name = "lblGananciasNacionales";
            lblGananciasNacionales.Size = new Size(85, 20);
            lblGananciasNacionales.TabIndex = 8;
            lblGananciasNacionales.Text = "(ganancias)";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(7, 237);
            label6.Name = "label6";
            label6.Size = new Size(218, 43);
            label6.TabIndex = 7;
            label6.Text = "Ganancias por vuelos nacionales:";
            // 
            // lblGananciasInternacionales
            // 
            lblGananciasInternacionales.AutoSize = true;
            lblGananciasInternacionales.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblGananciasInternacionales.Location = new Point(7, 204);
            lblGananciasInternacionales.Name = "lblGananciasInternacionales";
            lblGananciasInternacionales.Size = new Size(85, 20);
            lblGananciasInternacionales.TabIndex = 6;
            lblGananciasInternacionales.Text = "(ganancias)";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(7, 160);
            label4.Name = "label4";
            label4.Size = new Size(197, 44);
            label4.TabIndex = 5;
            label4.Text = "Ganancias por vuelos internacionales:";
            // 
            // lblGananciasTotales
            // 
            lblGananciasTotales.AutoSize = true;
            lblGananciasTotales.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblGananciasTotales.Location = new Point(7, 127);
            lblGananciasTotales.Name = "lblGananciasTotales";
            lblGananciasTotales.Size = new Size(85, 20);
            lblGananciasTotales.TabIndex = 4;
            lblGananciasTotales.Text = "(ganancias)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(7, 107);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 3;
            label2.Text = "Ganancias totales:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Controls.Add(lblDestinoTexto);
            panel2.Controls.Add(lblDestinoMasElegido);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(187, 82);
            panel2.TabIndex = 3;
            // 
            // lblDestinoMasElegido
            // 
            lblDestinoMasElegido.AutoSize = true;
            lblDestinoMasElegido.BackColor = Color.DarkGray;
            lblDestinoMasElegido.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDestinoMasElegido.Location = new Point(3, 40);
            lblDestinoMasElegido.Name = "lblDestinoMasElegido";
            lblDestinoMasElegido.Size = new Size(68, 20);
            lblDestinoMasElegido.TabIndex = 2;
            lblDestinoMasElegido.Text = "(destino)";
            // 
            // dataGridPasajerosFrecuentes
            // 
            dataGridPasajerosFrecuentes.AllowUserToAddRows = false;
            dataGridPasajerosFrecuentes.AllowUserToDeleteRows = false;
            dataGridPasajerosFrecuentes.AllowUserToResizeColumns = false;
            dataGridPasajerosFrecuentes.AllowUserToResizeRows = false;
            dataGridPasajerosFrecuentes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridPasajerosFrecuentes.BackgroundColor = Color.WhiteSmoke;
            dataGridPasajerosFrecuentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPasajerosFrecuentes.ColumnHeadersVisible = false;
            dataGridPasajerosFrecuentes.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridPasajerosFrecuentes.Location = new Point(196, 98);
            dataGridPasajerosFrecuentes.Name = "dataGridPasajerosFrecuentes";
            dataGridPasajerosFrecuentes.ReadOnly = true;
            dataGridPasajerosFrecuentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridPasajerosFrecuentes.RowHeadersVisible = false;
            dataGridPasajerosFrecuentes.RowTemplate.Height = 25;
            dataGridPasajerosFrecuentes.Size = new Size(227, 344);
            dataGridPasajerosFrecuentes.TabIndex = 3;
            // 
            // dataGridHorasDeVuelo
            // 
            dataGridHorasDeVuelo.AllowUserToAddRows = false;
            dataGridHorasDeVuelo.AllowUserToDeleteRows = false;
            dataGridHorasDeVuelo.AllowUserToResizeColumns = false;
            dataGridHorasDeVuelo.AllowUserToResizeRows = false;
            dataGridHorasDeVuelo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridHorasDeVuelo.BackgroundColor = Color.WhiteSmoke;
            dataGridHorasDeVuelo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridHorasDeVuelo.ColumnHeadersVisible = false;
            dataGridHorasDeVuelo.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridHorasDeVuelo.Location = new Point(441, 98);
            dataGridHorasDeVuelo.Name = "dataGridHorasDeVuelo";
            dataGridHorasDeVuelo.ReadOnly = true;
            dataGridHorasDeVuelo.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridHorasDeVuelo.RowHeadersVisible = false;
            dataGridHorasDeVuelo.RowTemplate.Height = 25;
            dataGridHorasDeVuelo.Size = new Size(129, 344);
            dataGridHorasDeVuelo.TabIndex = 4;
            // 
            // label1
            // 
            label1.BackColor = Color.Silver;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 53);
            label1.Name = "label1";
            label1.Size = new Size(163, 46);
            label1.TabIndex = 5;
            label1.Text = "Destinos ordenados por facturacion";
            // 
            // label3
            // 
            label3.BackColor = Color.Silver;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(196, 53);
            label3.Name = "label3";
            label3.Size = new Size(227, 46);
            label3.TabIndex = 6;
            label3.Text = "Cantidad de vuelos de los pasajeros";
            // 
            // label5
            // 
            label5.BackColor = Color.Silver;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(441, 53);
            label5.Name = "label5";
            label5.Size = new Size(129, 46);
            label5.TabIndex = 7;
            label5.Text = "Horas de vuelo de cada avion";
            // 
            // FrmEstadisticas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(772, 490);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dataGridHorasDeVuelo);
            Controls.Add(dataGridPasajerosFrecuentes);
            Controls.Add(panel1);
            Controls.Add(dataGridFacturacionDestinos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEstadisticas";
            Text = "FrmEstadisticas";
            Load += FrmEstadisticas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridFacturacionDestinos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnDescargar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPasajerosFrecuentes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridHorasDeVuelo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridFacturacionDestinos;
        private Label lblDestinoTexto;
        private Panel panel1;
        private Label lblDestinoMasElegido;
        private Label lblGananciasNacionales;
        private Label label6;
        private Label lblGananciasInternacionales;
        private Label label4;
        private Label lblGananciasTotales;
        private Label label2;
        private Panel panel2;
        private DataGridView dataGridPasajerosFrecuentes;
        private DataGridView dataGridHorasDeVuelo;
        private Label label1;
        private Label label3;
        private Label label5;
        private PictureBox btnDescargar;
        private ToolTip toolTip1;
    }
}