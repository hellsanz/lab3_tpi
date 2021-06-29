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
    public partial class VentanaAnimalMod : Form
    {
        public VentanaAnimalMod()
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
            VentanaAnimal vtPadre = Owner as VentanaAnimal;
            ConexionBD modif = new ConexionBD();
            string query = "UPDATE Animales SET nombre = @nombre, edad = @edad, tipo = @tipo, origen = @origen WHERE idFamilia = @idF";
            using (SqlCommand cmd = new SqlCommand(query, modif.conectarBD))
            {
                modif.abrirBD();
                cmd.Parameters.AddWithValue("@idF", idF);
                cmd.Parameters.AddWithValue("@nombre", textBox1_nombreA.Text);
                cmd.Parameters.AddWithValue("@edad", textBox1_edadA.Text);
                cmd.Parameters.AddWithValue("@tipo", textBox2_tipoA.Text);
                cmd.Parameters.AddWithValue("@origen", textBox1_origenA.Text);                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datos Actualizados!");
                this.Close();
            }
        }
    }
}
