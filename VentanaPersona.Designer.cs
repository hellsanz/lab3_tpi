
namespace lab3_sanchez_pablo_sn
{
    partial class VentanaPersona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1_ver = new System.Windows.Forms.Button();
            this.button1_buscar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1_cancelar = new System.Windows.Forms.Button();
            this.button1_modificacion = new System.Windows.Forms.Button();
            this.button1_baja = new System.Windows.Forms.Button();
            this.button1_alta = new System.Windows.Forms.Button();
            this.textBox1_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1_ver
            // 
            this.button1_ver.Location = new System.Drawing.Point(255, 38);
            this.button1_ver.Name = "button1_ver";
            this.button1_ver.Size = new System.Drawing.Size(56, 23);
            this.button1_ver.TabIndex = 17;
            this.button1_ver.Text = "ver";
            this.button1_ver.UseVisualStyleBackColor = true;
            // 
            // button1_buscar
            // 
            this.button1_buscar.Location = new System.Drawing.Point(255, 12);
            this.button1_buscar.Name = "button1_buscar";
            this.button1_buscar.Size = new System.Drawing.Size(56, 20);
            this.button1_buscar.TabIndex = 16;
            this.button1_buscar.Text = "Buscar";
            this.button1_buscar.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(299, 174);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1_cancelar
            // 
            this.button1_cancelar.Location = new System.Drawing.Point(236, 247);
            this.button1_cancelar.Name = "button1_cancelar";
            this.button1_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button1_cancelar.TabIndex = 14;
            this.button1_cancelar.Text = "Cancelar";
            this.button1_cancelar.UseVisualStyleBackColor = true;
            this.button1_cancelar.Click += new System.EventHandler(this.button1_cancelar_Click);
            // 
            // button1_modificacion
            // 
            this.button1_modificacion.Location = new System.Drawing.Point(174, 38);
            this.button1_modificacion.Name = "button1_modificacion";
            this.button1_modificacion.Size = new System.Drawing.Size(75, 23);
            this.button1_modificacion.TabIndex = 13;
            this.button1_modificacion.Text = "Modificacion";
            this.button1_modificacion.UseVisualStyleBackColor = true;
            // 
            // button1_baja
            // 
            this.button1_baja.Location = new System.Drawing.Point(93, 38);
            this.button1_baja.Name = "button1_baja";
            this.button1_baja.Size = new System.Drawing.Size(75, 23);
            this.button1_baja.TabIndex = 12;
            this.button1_baja.Text = "Baja";
            this.button1_baja.UseVisualStyleBackColor = true;
            // 
            // button1_alta
            // 
            this.button1_alta.Location = new System.Drawing.Point(12, 38);
            this.button1_alta.Name = "button1_alta";
            this.button1_alta.Size = new System.Drawing.Size(75, 23);
            this.button1_alta.TabIndex = 11;
            this.button1_alta.Text = "Alta";
            this.button1_alta.UseVisualStyleBackColor = true;
            this.button1_alta.Click += new System.EventHandler(this.button1_alta_Click);
            // 
            // textBox1_nombre
            // 
            this.textBox1_nombre.Location = new System.Drawing.Point(59, 12);
            this.textBox1_nombre.Name = "textBox1_nombre";
            this.textBox1_nombre.Size = new System.Drawing.Size(190, 20);
            this.textBox1_nombre.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // VentanaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 280);
            this.Controls.Add(this.button1_ver);
            this.Controls.Add(this.button1_buscar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1_cancelar);
            this.Controls.Add(this.button1_modificacion);
            this.Controls.Add(this.button1_baja);
            this.Controls.Add(this.button1_alta);
            this.Controls.Add(this.textBox1_nombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VentanaPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Persona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_ver;
        private System.Windows.Forms.Button button1_buscar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1_cancelar;
        private System.Windows.Forms.Button button1_modificacion;
        private System.Windows.Forms.Button button1_baja;
        private System.Windows.Forms.Button button1_alta;
        private System.Windows.Forms.TextBox textBox1_nombre;
        private System.Windows.Forms.Label label1;
    }
}