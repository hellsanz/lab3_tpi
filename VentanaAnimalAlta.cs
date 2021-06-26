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
            if (string.IsNullOrEmpty(textBox1_nombre.Text)) 
            {
                MessageBox.Show("¡Error! debe cargar el nombre del animal");
                control = false;
            }
            if (string.IsNullOrEmpty(textBox2_tipo.Text))
            {
                MessageBox.Show("¡Error! debe cargar el tipo de animal");
                control = false;
            }
            if (string.IsNullOrEmpty(textBox1_origen.Text))
            {
                MessageBox.Show("¡Error! debe cargar su origen");
                control = false;
            }            
            if (string.IsNullOrEmpty(textBox1_edad.Text))
            {
                MessageBox.Show("¡Error! debe cargar la edad del animal");
                control = false;
            }
            if (string.IsNullOrEmpty(textBox1_DNI_titular.Text))
            {
                MessageBox.Show("Ingrese DNI del Dueño!");
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
            int titularDNI = Convert.ToInt32(textBox1_DNI_titular.Text);
            Boolean CrudControl = existeTitular(titularDNI);// que consulte si existe ese DNI en la BD
            if (CrudControl == true)
            {
                CrudAnimalAlta(nombre, tipo, origen, edad, titularDNI);//agregar un parametro
                this.Close();
            }
            else
            {
                MessageBox.Show("No existe esa Persona, Intente otra vez!");
            }
        }
        public Boolean existeTitular(int dni)
        {
            //hacer consulta de la existencia de
            //un dueño por su DNI en tabla Persona
            //Boolean control = false;//variable de control

            if (dni == 1)
            {
                return true;//existe
            }
            else
            {
                return false;//no existe
            }

            //if (control == true)
            //{
            //    return true;//existe
            //}
            //else
            //{
            //    return false;//no existe
            //}
        }
        //hacer el Alta de Animal
        public void CrudAnimalAlta(string nombre, string tipo, string origen, string edad,int titularDNI)
        {



            MessageBox.Show("Nuevo Animal Cargado a la Base de Datos");
        }
    }
}
