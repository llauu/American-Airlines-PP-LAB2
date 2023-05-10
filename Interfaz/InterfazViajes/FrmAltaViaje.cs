using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz {
    public partial class FrmAltaViaje : FrmBotonCancelar {
        public FrmAltaViaje() {
            InitializeComponent();
        }

        private void FrmAltaViaje_Load(object sender, EventArgs e) {
            FrmAeronaves.ActualizarDataGridView(dataGridAeronaves);
        }
    }
}
