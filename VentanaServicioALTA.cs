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
    public partial class VentanaServicioALTA : Form
    {
        public VentanaServicioALTA()
        {
            InitializeComponent();
        }

        private void button2_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
