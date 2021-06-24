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
    public partial class VentanaPersonaALTA : Form
    {
        public VentanaPersonaALTA()
        {
            InitializeComponent();
        }        

        private void button2_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_aceptar_Click(object sender, EventArgs e)
        {
            cargaDatos();
        }

        public void cargaDatos()
        {
            string nombre = textBox1_nombre.Text;
            string apellido = textBox2_apellido.Text;
            string sexo = comboBox2_sexo.Text;

            DateTime Fnacimiento = dateTimePicker1_nacimiento.Value;
            int edad = calculoEdad(Fnacimiento);            

            string dni2 = textBox4_dni.Text;
            int dni = Convert.ToInt32(dni2);


            Persona persona = new Persona(nombre,apellido,sexo,edad, Fnacimiento, dni);
            SqlAltaPersona(nombre, apellido, sexo, edad, Fnacimiento, dni);
        }
        private void textBox4_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public int calculoEdad(DateTime Fnacimiento)
        {


            return 0;
        }
        public void SqlAltaPersona(string nombre, string apellido, string sexo, int edad, DateTime Fnacimiento, int dni)
        {




            //Hacer el query
        }

    }
}
