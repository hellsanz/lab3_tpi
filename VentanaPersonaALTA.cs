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
            textBox1_ConsultaDNI.Text = "";
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
                this.Visible = false;
                familia();//recien se ingresa dni familiar
                this.Visible = true;
                int nroFamilia;
                if (textBox1_ConsultaDNI.Text == "")
                {//Asigna Nro familia NUEVO       
                    nroFamilia = nroFamiliaNuevo();
                }
                else
                {//Busca en BD Persona que tenga este DNI y traer Nro campo Familia                   
                    nroFamilia = nroFamiliaPorDNI(Convert.ToInt32(textBox1_ConsultaDNI.Text));
                }
                cargaDatos(nroFamilia);
            }            
        }

        public void cargaDatos(int nroFamilia)
        {
            string nombre = textBox1_nombre.Text;
            string apellido = textBox2_apellido.Text;
            string sexo = comboBox2_sexo.Text;
            DateTime Fnacimiento = dateTimePicker1_nacimiento.Value;                
            string dni2 = textBox4_dni.Text;
            int dni = Convert.ToInt32(dni2);
            int nroFamily = nroFamilia;
            CrudPersonaALTA(nombre,apellido,sexo,Fnacimiento,dni,nroFamilia);//Metodo Create Persona
        }
        //private void textBox4_dni_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        //        (e.KeyChar != '.'))
        //    {
        //        e.Handled = true;
        //    }

        //    // only allow one decimal point
        //    if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
        //    {
        //        e.Handled = true;
        //    }
        //}
        public void CrudPersonaALTA(string nombre, string apellido, string sexo, DateTime Fnacimiento, int dni, int nroFamilia)
        {
            //Los mensajes estos son para testear
            //*********************
            MessageBox.Show("Nombre:\n"+nombre);
            MessageBox.Show("Apellido:\n" + apellido);
            MessageBox.Show("Sexo:\n" + sexo);
            MessageBox.Show("Dni:\n" + Convert.ToString(dni));
            MessageBox.Show("Nro Familia:\n" + Convert.ToString(nroFamilia));  
            //*********************
            //HACER LA CARGA DE ESTA PERSONA
            MessageBox.Show("Nueva Persona Cargada a la Base de Datos");
            this.Close();
        }
        public void familia()
        {
            VentanaFamiliaConsulta vtConsulta = new VentanaFamiliaConsulta();
            AddOwnedForm(vtConsulta);
            vtConsulta.ShowDialog();
        }
        public int nroFamiliaNuevo()
        {
            int nuevoNro = 0;//Arreglar esto
            //Asignar Nuevo NroFamilia en tabla Persona
            return nuevoNro;
        }
        public int nroFamiliaPorDNI(int dni)
        {
            int NroFamilia = 1;//Arreglar esto
            //Busca en la BD una persona con ese DNI
            //Devolve el valor del campo NroFamilia
            return NroFamilia;
        }
    }
}
