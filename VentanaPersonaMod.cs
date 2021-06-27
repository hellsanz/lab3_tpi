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
    public partial class VentanaPersonaMod : Form
    {
        public VentanaPersonaMod()
        {
            InitializeComponent();
        }
        public void ModificarDatos(int dni)
        {
            VentanaPersona vtPadre = Owner as VentanaPersona;                      
            //**********************************************
            Boolean control = true;
            if (control == true)
            {
                //modificar
                MessageBox.Show(textBox1_nombre.Text);
                MessageBox.Show(textBox2_apellido.Text);
                MessageBox.Show(textBox4_dni.Text);
                MessageBox.Show(comboBox1_estado.Text);
                MessageBox.Show(comboBox2_sexo.Text);
            }
            else
            {
                MessageBox.Show("Error! Esa Persona no existe!");
                this.Close();
            }
        }
        private void button2_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_aceptar_Click(object sender, EventArgs e)
        {
            //realiazar la Query de Modificacion
            ModificarDatos(Convert.ToInt32(textBox4_dni.Text));
        }
    }
}

