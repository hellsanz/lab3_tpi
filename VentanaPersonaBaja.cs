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
    public partial class VentanaPersonaBaja : Form
    {
        public VentanaPersonaBaja()
        {
            InitializeComponent();
        }

        private void button1_cancelar_Click(object sender, EventArgs e)
        {
            VentanaPersona vtPadre = Owner as VentanaPersona;
            vtPadre.Visible = true;
            this.Close();
        }

        private void button1_aceptar_Click(object sender, EventArgs e)
        {
            //hacer la baja de la persona
            VentanaPersona vtPadre = Owner as VentanaPersona;
            int dni = Convert.ToInt32(vtPadre.textBox1_DNI.Text);
            vtPadre.Visible = true;
            this.Visible = false;
            this.Close();
            MessageBox.Show("Se ha dado la Baja de la persona Correctamente");
        }
    }
}
