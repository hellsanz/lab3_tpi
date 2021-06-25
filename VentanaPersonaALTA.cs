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
            Boolean control = true;
            if (textBox1_nombre.Text == "")
            {
                MessageBox.Show("¡Error! debe cargar el nombre");
                control = false;
            }
            if (textBox2_apellido.Text == "")
            {
                MessageBox.Show("¡Error! debe cargar el apellido");
                control = false;
            }
            if (dateTimePicker1_nacimiento.Text == "")
            {
                MessageBox.Show("¡Error! debe cargar su fecha de nacimiento");
                control = false;
            }
            if (comboBox1_estado.Text == "")
            {
                MessageBox.Show("¡Error! debe seleccionar un estado");
                control = false;
            }
            if (comboBox2_sexo.Text == "")
            {
                MessageBox.Show("¡Error! debe seleccionar un sexo");
                control = false;
            }
            if (control == true)
            {
                cargaDatos();
            }            
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
            
            CrudPersona(nombre, apellido, sexo, edad, Fnacimiento, dni);            
            this.Close();
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
        public void CrudPersona(string nombre, string apellido, string sexo, int edad, DateTime Fnacimiento, int dni)
        {



            MessageBox.Show("Nueva Persona Cargada a la Base de Datos");
            //Hacer el query
        }

    }
}
