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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void barrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaBarrios ventanaBarrios = new VentanaBarrios();
            ventanaBarrios.Show();
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaPersona ventanaPersona = new VentanaPersona();
            ventanaPersona.Show();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void servicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaServicio ventanaServicio = new VentanaServicio();
            ventanaServicio.Show();
        }
    }
}
