namespace Interfaz {
    partial class FrmVenderVuelo {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenderVuelo));
            btnVenderPasaje = new PictureBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)imgError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnVenderPasaje).BeginInit();
            SuspendLayout();
            // 
            // lblError
            // 
            lblError.Text = "No hay vuelos disponibles para visualizar.";
            // 
            // btnVenderPasaje
            // 
            btnVenderPasaje.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVenderPasaje.Cursor = Cursors.Hand;
            btnVenderPasaje.Image = (Image)resources.GetObject("btnVenderPasaje.Image");
            btnVenderPasaje.Location = new Point(641, 125);
            btnVenderPasaje.Name = "btnVenderPasaje";
            btnVenderPasaje.Size = new Size(50, 51);
            btnVenderPasaje.SizeMode = PictureBoxSizeMode.Zoom;
            btnVenderPasaje.TabIndex = 32;
            btnVenderPasaje.TabStop = false;
            btnVenderPasaje.Click += btnVenderPasaje_Click;
            // 
            // FrmVenderViaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(702, 481);
            Controls.Add(btnVenderPasaje);
            Name = "FrmVenderViaje";
            Text = "FrmVenderViaje";
            Controls.SetChildIndex(lblError, 0);
            Controls.SetChildIndex(imgError, 0);
            Controls.SetChildIndex(btnVenderPasaje, 0);
            ((System.ComponentModel.ISupportInitialize)imgError).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnVenderPasaje).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btnVenderPasaje;
        private ToolTip toolTip1;
    }
}