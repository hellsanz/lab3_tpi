using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            if (string.IsNullOrEmpty(textBox1_nombre.Text)) 
            {
                MessageBox.Show("¡Error! debe cargar el nombre");
                control = false;
            }
            if (string.IsNullOrEmpty(textBox2_apellido.Text))
            {
                MessageBox.Show("¡Error! debe cargar el apellido");
                control = false;
            }
            if (string.IsNullOrEmpty(dateTimePicker1_nacimiento.Text))
            {
                MessageBox.Show("¡Error! debe cargar su fecha de nacimiento");
                control = false;
            }
            if (string.IsNullOrEmpty(comboBox1_estado.Text))
            {
                MessageBox.Show("¡Error! debe seleccionar un estado");
                control = false;
            }
            if (string.IsNullOrEmpty(comboBox2_sexo.Text))
            {
                MessageBox.Show("¡Error! debe seleccionar un sexo");
                control = false;
            }
            int existe = controlDeExistencia(Convert.ToInt32(textBox4_dni.Text));
            if (existe == 0)
            {
                MessageBox.Show("¡Error! Ese usuario ya Existe");
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
        
        public void CrudPersonaALTA(string nombre, string apellido, string sexo, DateTime Fnacimiento, int dni, int nroFamilia)
        {
            if (nroFamilia == 0)
            {
                this.Close();
            }
            else
            {
                //Son las variables del Alta en la BD
                MessageBox.Show("Nombre: " + nombre +
                "Apellido: " + apellido+
                "Sexo: " + sexo+
                "Dni: " + Convert.ToString(dni)+
                "Nro Familia: " + Convert.ToString(nroFamilia));
                //ACA SE HACE EL INSERT GENERAL A LA BD
                ConexionBD insPersonaBD = new ConexionBD();
                string query = "INSERT INTO PERSONAS (idFamilia, dni, nombre, apellido, fechaNac, estado, sexo) VALUES (@idFamilia, @dni, @nombre, @apellido, @fechaNac, @estado, @sexo)";
                using (SqlCommand cmd = new SqlCommand(query, insPersonaBD.conectarBD))
                {
                    insPersonaBD.abrirBD();
                    cmd.Parameters.AddWithValue("@idFamilia", nroFamilia);
                    cmd.Parameters.AddWithValue("@dni", dni);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@fechaNac", Fnacimiento);
                    cmd.Parameters.AddWithValue("@estado", comboBox1_estado.SelectedItem);
                    cmd.Parameters.AddWithValue("@sexo", sexo);
                    int result = cmd.ExecuteNonQuery();
                    if (result < 0)
                    {
                        MessageBox.Show("Error en insert!");
                    }
                    else
                    {
                        MessageBox.Show("Nueva Persona Cargada a la Base de Datos");
                        this.Close();
                    }
                }
            }           
        }
        public void familia()
        {
            VentanaFamiliaConsulta vtConsulta = new VentanaFamiliaConsulta();
            AddOwnedForm(vtConsulta);
            vtConsulta.ShowDialog();
        }
        public int nroFamiliaNuevo()
        {
            int nuevoNro;            
            //QUERY CONSULTA ULTIMO NUMERO FAMILIA
            ConexionBD queryBD = new ConexionBD();
            string query = "SELECT ISNULL(MAX(idFamilia), 0) AS nuevoNro from Personas";
            using (SqlCommand cmd = new SqlCommand(query, queryBD.conectarBD))
            {
                queryBD.abrirBD();
                nuevoNro = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                queryBD.cerrarBD();
            }            
            return nuevoNro;
        }
        public int nroFamiliaPorDNI(int dni)
        {
            int NroFamilia;
            //Busca en la BD una persona con ese DNI
            //Devolve el valor del campo NroFamilia
            ConexionBD selNroFamBD = new ConexionBD();
            string query = "SELECT idFamilia from Personas where DNI = @dni";
            using (SqlCommand cmd = new SqlCommand(query, selNroFamBD.conectarBD))
            {
                selNroFamBD.abrirBD();
                cmd.Parameters.AddWithValue("@dni", dni);
                NroFamilia = Convert.ToInt32( cmd.ExecuteScalar());
                if (NroFamilia != 0)
                {
                    MessageBox.Show("Correcto!");
                    
                }
                else { MessageBox.Show("DNI No Existe!");
                    this.Close();
                } 
                selNroFamBD.cerrarBD();
            }
            return NroFamilia;
        }
        public int controlDeExistencia(int dni)
        {
            ConexionBD buscar = new ConexionBD();
            string query = "SELECT dni from Personas WHERE dni = @dni";
            using (SqlCommand cmd = new SqlCommand(query, buscar.conectarBD))
            {
                buscar.abrirBD();
                cmd.Parameters.AddWithValue("@dni",dni);
                int control = Convert.ToInt32(cmd.ExecuteScalar());
                if (control == 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }                
            }
            buscar.cerrarBD();            
        }

        private void comboBox1_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VentanaPersonaALTA_Load(object sender, EventArgs e)
        {

        }
    }
}
