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
    public partial class VentanaAnimalAlta : Form
    {
        public VentanaAnimalAlta()
        {
            InitializeComponent();
        }

        private void button2_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //HACER EL ALTA de ANIMAL
        private void button1_aceptar_Click(object sender, EventArgs e)
        {
            Boolean control = true;
            if (textBox1_nombre.Text == "")
            {
                MessageBox.Show("¡Error! debe cargar el nombre del animal");
                control = false;
            }
            if (textBox2_tipo.Text == "")
            {
                MessageBox.Show("¡Error! debe cargar el tipo de animal");
                control = false;
            }
            if (textBox1_origen.Text == "")
            {
                MessageBox.Show("¡Error! debe cargar su origen");
                control = false;
            }            
            if (textBox1_edad.Text == "")
            {
                MessageBox.Show("¡Error! debe cargar la edad del animal");
                control = false;
            }
            if (control == true)
            {
                cargarDatos();
            }
        }


        //Captura de datos para el Alta de Animal
        public void cargarDatos()
        {
            string nombre = textBox1_nombre.Text;
            string tipo = textBox2_tipo.Text;
            string origen = textBox1_origen.Text;
            string edad = textBox1_edad.Text;  

            CrudAnimalAlta(nombre, tipo,origen,edad);            
            this.Close();
        }
        //hacer el Alta de Animal
        public void CrudAnimalAlta(string nombre, string tipo, string origen, string edad)
        {



            MessageBox.Show("Nuevo Animal Cargado a la Base de Datos");
        }
    }
}
