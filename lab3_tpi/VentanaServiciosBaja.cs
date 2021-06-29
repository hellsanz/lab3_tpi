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
    public partial class VentanaServiciosBaja : Form
    {
        public VentanaServiciosBaja()
        {
            InitializeComponent();
        }
        private int traerPersona(int dni)
        {
            int idFamilia;
            ConexionBD traerPersonaDB = new ConexionBD();
            string query = "SELECT idFamilia from Personas where DNI = @dni";
            using (SqlCommand cmd = new SqlCommand(query, traerPersonaDB.conectarBD))
            {
                traerPersonaDB.abrirBD();
                cmd.Parameters.AddWithValue("@dni", dni);
                idFamilia = Convert.ToInt32(cmd.ExecuteScalar());
            }
            traerPersonaDB.cerrarBD();
            return idFamilia;
        }
        private void eliminarServicio(int idF)
        {
            ConexionBD eliminarDb = new ConexionBD();
            string query = "DELETE FROM Servicios WHERE idFamilia = @idF";
            using (SqlCommand cmd = new SqlCommand(query, eliminarDb.conectarBD))
            {
                eliminarDb.abrirBD();
                cmd.Parameters.AddWithValue("@idF", idF);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha dado la Baja al Servicio Correctamente");
            }
            eliminarDb.cerrarBD();
        }
        private void button1_aceptar_Click(object sender, EventArgs e)
        {
            VentanaServicio vtPadre = Owner as VentanaServicio;
            int dni = Convert.ToInt32(vtPadre.textBox1_DNI.Text); ;
            eliminarServicio(traerPersona(dni));
            vtPadre.Visible = true;
            vtPadre.textBox1_DNI.Clear();
            this.Close();
        }
        private void button1_cancelar_Click(object sender, EventArgs e)
        {
            VentanaServicio vtPadre = Owner as VentanaServicio;
            vtPadre.Visible = true;
            this.Close();
        }
        private void VentanaAnimalBaja_Load(object sender, EventArgs e)
        {
            VentanaServicio vtPadre = Owner as VentanaServicio;
            int dni = Convert.ToInt32(vtPadre.textBox1_DNI.Text);
            traerPersona(dni);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
