using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_sanchez_pablo_sn
{
    public partial class VentanaPersona : Form
    {
        public VentanaPersona()
        {
            InitializeComponent();
        }

        private void button1_alta_Click(object sender, EventArgs e)
        {
            VentanaPersonaALTA darAlta = new VentanaPersonaALTA();
            darAlta.ShowDialog();
        }

        private void button1_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
