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
    public partial class VentanaServicio : Form
    {
        public VentanaServicio()
        {
            InitializeComponent();
        }

        private void button1_alta_Click(object sender, EventArgs e)
        {
            VentanaServicioALTA darAlta = new VentanaServicioALTA();
            darAlta.ShowDialog();
        }

        private void button1_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_baja_Click(object sender, EventArgs e)
        {
            //hacer la baja de una Persona por DNI
            Boolean control = false;
            if (string.IsNullOrEmpty(textBox1_DNI.Text))
            {
                MessageBox.Show("Ingrese un DNI para dar Baja!");
                control = false;
            }
            else
            {
                int dni = Convert.ToInt32(textBox1_DNI.Text);
                if (existeDni(dni) == true)
                {
                    control = true;
                }
                if (control == true)
                {
                    this.Visible = false;
                    VentanaServiciosBaja darBaja = new VentanaServiciosBaja();
                    AddOwnedForm(darBaja);
                    darBaja.ShowDialog();   //abre una ventana                 
                }
                else
                {
                    MessageBox.Show("No existe ese Usuario");
                    this.Close();
                }
            }
        }
        private Boolean existeDni(int dni)
        {
            Boolean existe;
            ConexionBD DniBD = new ConexionBD();
            string query = "SELECT dni from Personas where DNI = @dni";
            using (SqlCommand cmd = new SqlCommand(query, DniBD.conectarBD))
            {
                DniBD.abrirBD();
                cmd.Parameters.AddWithValue("@dni", dni);
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result != 0)
                {
                    existe = true;
                    return existe;
                }
                else
                {
                    existe = false;
                    return existe;
                }
            }
        }


        private void button1_ver_Click(object sender, EventArgs e)
        {
            {
                //Traer toda la tabla de Personas
                ConexionBD servicios = new ConexionBD();
                string query = "SELECT * from Servicios order by idFamilia";
                using (SqlCommand cmd = new SqlCommand(query, servicios.conectarBD))
                {
                    servicios.abrirBD();
                    SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
                    DataTable dtRecord = new DataTable();
                    sqlDataAdap.Fill(dtRecord);
                    dataGridView1.DataSource = dtRecord;
                    dataGridView1.AllowUserToAddRows = false;
                }
                servicios.cerrarBD();
            }
        }



        private void button1_buscar_Click_1(object sender, EventArgs e)
        {
            int idF;
            if (string.IsNullOrEmpty(textBox1_DNI.Text))
            {
                MessageBox.Show("¡Error! debe cargar el DNI");
            }
            else
            {
                int dni = Convert.ToInt32(textBox1_DNI.Text);
                ConexionBD personas = new ConexionBD();
                string query = "SELECT idFamilia from Personas where DNI = @dni";
                using (SqlCommand cmd = new SqlCommand(query, personas.conectarBD))
                {
                    personas.abrirBD();
                    cmd.Parameters.AddWithValue("@dni", dni);
                    idF = Convert.ToInt32(cmd.ExecuteScalar());
                }
                personas.cerrarBD();

                ConexionBD servicios = new ConexionBD();
                string query2 = "SELECT * from Servicios where idFamilia = @idF";
                using (SqlCommand cmd = new SqlCommand(query2, servicios.conectarBD))
                {
                    servicios.abrirBD();
                    cmd.Parameters.AddWithValue("@idF", idF);

                    SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
                    DataTable dtRecord = new DataTable();
                    sqlDataAdap.Fill(dtRecord);
                    dataGridView1.DataSource = dtRecord;
                    dataGridView1.AllowUserToAddRows = false;
                    if (dataGridView1.RowCount == 0)
                    {
                        MessageBox.Show("Sin datos para mostrar");
                    }

                }
                servicios.cerrarBD();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_modificacion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1_DNI.Text))
            {
                MessageBox.Show("Error! Debe ingresar un DNI");
            }
            else
            {

                int idF = buscarServicio(BuscarTitular(Convert.ToInt32(textBox1_DNI.Text)));//id familia);
                this.Visible = false;
                VentanaServicioMod modificar = new VentanaServicioMod();
                AddOwnedForm(modificar);
                modificar.textBox1_idFamilia.Text = Convert.ToString(idF);
                modificar.textBox1_DNI_titular.Text = textBox1_DNI.Text;
                modificar.textBox1_Servicio.Text = txtservicio.Text;
                modificar.textBox1_Empresa.Text = txtempresa.Text;
                modificar.textBox2_Costo.Text = txtcosto.Text;
                modificar.textBox1_Premium.Text = txt_premium.Text;
                modificar.ShowDialog();
                // string query = "SELECT idFamilia, nombre, edad, tipo, origen from Animales WHERE idFamilia = @idF";
            }
        }
        public int BuscarTitular(int dni)
        {
            //QUERY TABLA PERSONA * DNI 
            int idFamilia;
            ConexionBD buscar = new ConexionBD();
            string query = "SELECT idFamilia FROM Personas WHERE dni = @dni";
            using (SqlCommand cmd = new SqlCommand(query, buscar.conectarBD))
            {
                buscar.abrirBD();
                cmd.Parameters.AddWithValue("@dni", dni);
                idFamilia = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return idFamilia;
        }
        public int buscarServicio(int idf)
        {
            //QUERY TABLA PERSONA * DNI 
            int idfamilia;
            ConexionBD buscar = new ConexionBD();
            string query = "SELECT idFamilia, servicio, empresa, costo, premium From SERVICIOS WHERE idFamilia = @idf";
            using (SqlCommand cmd = new SqlCommand(query, buscar.conectarBD))
            {
                buscar.abrirBD();
                cmd.Parameters.AddWithValue("@idf", idf);
                idfamilia = Convert.ToInt32(cmd.ExecuteScalar());
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    txtIDfamilia.Text = sdr["idFamilia"].ToString();
                    txtservicio.Text = sdr["servicio"].ToString();
                    txtempresa.Text = sdr["empresa"].ToString();
                    txtcosto.Text = sdr["costo"].ToString();
                    txt_premium.Text = sdr["premium"].ToString();
                }
            }
            return idfamilia;
        }

        private void button1_buscar_Click(object sender, EventArgs e)
        {

            int idF;
            if (string.IsNullOrEmpty(textBox1_DNI.Text))
            {
                MessageBox.Show("¡Error! debe cargar el DNI");
            }
            else
            {
                int dni = Convert.ToInt32(textBox1_DNI.Text);
                ConexionBD personas = new ConexionBD();
                string query = "SELECT idFamilia from Personas where DNI = @dni";
                using (SqlCommand cmd = new SqlCommand(query, personas.conectarBD))
                {
                    personas.abrirBD();
                    cmd.Parameters.AddWithValue("@dni", dni);
                    idF = Convert.ToInt32(cmd.ExecuteScalar());
                }
                personas.cerrarBD();

                ConexionBD servicios = new ConexionBD();
                string query2 = "SELECT * from Servicios where idFamilia = @idF";
                using (SqlCommand cmd = new SqlCommand(query2, servicios.conectarBD))
                {
                    servicios.abrirBD();
                    cmd.Parameters.AddWithValue("@idF", idF);

                    SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);
                    DataTable dtRecord = new DataTable();
                    sqlDataAdap.Fill(dtRecord);
                    dataGridView1.DataSource = dtRecord;
                    dataGridView1.AllowUserToAddRows = false;
                    if (dataGridView1.RowCount == 0)
                    {
                        MessageBox.Show("Sin datos para mostrar");
                    }
                }
                servicios.cerrarBD();
            }
        }
    }
}
