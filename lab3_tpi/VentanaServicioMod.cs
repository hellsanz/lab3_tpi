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
    public partial class VentanaServicioMod : Form
    {
        public VentanaServicioMod()
        {
            InitializeComponent();
        }

        private void button1_aceptar_Click(object sender, EventArgs e)
        {
            ModificarDatos(Convert.ToInt32(textBox1_idFamilia.Text));
        }

        private void button2_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ModificarDatos(int idF)
        {
            VentanaServicio vtPadre = Owner as VentanaServicio;
            ConexionBD modif = new ConexionBD();
            string query = "UPDATE Servicios SET servicio = @servicio, empresa = @empresa, costo = @costo, premium = @premium WHERE idFamilia = @idF";
            using (SqlCommand cmd = new SqlCommand(query, modif.conectarBD))
            {
                modif.abrirBD();
                cmd.Parameters.AddWithValue("@idF", idF);
                cmd.Parameters.AddWithValue("@servicio", textBox1_Servicio.Text);
                cmd.Parameters.AddWithValue("@empresa", textBox1_Empresa.Text);
                cmd.Parameters.AddWithValue("@costo", textBox2_Costo.Text);
                cmd.Parameters.AddWithValue("@premium", textBox1_Premium.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datos Actualizados!");
                this.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_nombreS_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Premium_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
