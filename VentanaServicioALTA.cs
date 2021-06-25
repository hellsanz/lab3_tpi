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

        private void button1_aceptar_Click(object sender, EventArgs e)
        {
            Boolean control = true;
            if (textBox1_nombre.Text == "")//nombre
            {
                MessageBox.Show("¡Error! debe cargar el nombre de la empresa");
                control = false;
            }
            if (comboBox1_servicio.Text == "")//servicio
            {
                MessageBox.Show("¡Error! debe seleccionar el Servicio");
                control = false;
            }
            if (textBox3_costo.Text == "")//costo
            {
                MessageBox.Show("¡Error! debe cargar el costo del servicio en $");
                control = false;
            }                       
            if (control == true)
            {
                cargaDatos();
            }
        }
        //Captura de datos para el Alta de un Servicio
        public void cargaDatos()
        {
            string nombreEmpresa = textBox1_nombre.Text;
            string servicio = comboBox1_servicio.Text;
            string costo = textBox3_costo.Text;
            Boolean premium = checkBox1_premium.Checked;
            CrudServicioAlta(nombreEmpresa, servicio, costo, premium);            
            this.Close();
        }
        //hacer el Alta de Servicio
        public void CrudServicioAlta(string nombreEmpresa, string servicio, string costo, Boolean premium)
        {



            MessageBox.Show("Nuevo Servicio Cargado a la Base de Datos");
        }
    }
}
