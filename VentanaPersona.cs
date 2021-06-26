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
    public partial class VentanaPersona : Form
    {
        public VentanaPersona()
        {
            InitializeComponent();
        }

        private void button1_alta_Click(object sender, EventArgs e)
        {
            VentanaPersonaALTA darAlta = new VentanaPersonaALTA();
            darAlta.ShowDialog();
        }

        private void button1_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_buscar_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txtID.Text);
            if (listView1.Items.Count >0)
            {
                listView1.Items.Remove(listView1.Items[0]);
            }
            if (string.IsNullOrEmpty(textBox1_DNI.Text))
            {
                MessageBox.Show("Ingrese DNI para Buscar");
            }
            else
            {
                Boolean existe = false;//************************** Hacer la query aca
                //Buscar por DNI una Persona
                //y traer todos sus datos
                //en caso de existir ------------> existe = true;
                //en caso de no existir no se cambia nada                
                //******
                if (existe == true)
                {
                    item.SubItems.Add(textBox1_DNI.Text);
                    item.SubItems.Add(txtApellido.Text);
                    item.SubItems.Add(txtNombre.Text);
                    item.SubItems.Add(txtFamilia.Text);
                    listView1.Items.Add(item);
                    textBox1_DNI.Clear();
                }
                else
                {
                    MessageBox.Show("El usuario no existe!");
                }                
            }        
        }
        private void button1_ver_Click(object sender, EventArgs e)
        {
            //Traer toda la tabla de Personas



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
                //Query de Control de existencia
                //**
                    Boolean existe = true;
                    if (existe == true)
                    {
                        control = true;
                    }
                //**
                if (control == true)
                {                    //abre una ventana
                    this.Visible = false;
                    VentanaPersonaBaja darBaja = new VentanaPersonaBaja();
                    AddOwnedForm(darBaja);
                    darBaja.ShowDialog();                    
                }
                else
                {
                    MessageBox.Show("No existe ese Usuario");
                }
            }    
        }
    }
}
