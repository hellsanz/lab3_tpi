
namespace lab3_sanchez_pablo_sn
{
    partial class VentanaAnimal
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
            this.button1_cancelar = new System.Windows.Forms.Button();
            this.button1_modificacion = new System.Windows.Forms.Button();
            this.button1_baja = new System.Windows.Forms.Button();
            this.button1_alta = new System.Windows.Forms.Button();
            this.textBox1_DNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_origen = new System.Windows.Forms.TextBox();
            this.txtIDfamilia = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_ver
            // 
            this.button1_ver.Location = new System.Drawing.Point(255, 33);
            this.button1_ver.Name = "button1_ver";
            this.button1_ver.Size = new System.Drawing.Size(75, 23);
            this.button1_ver.TabIndex = 26;
            this.button1_ver.Text = "Todos";
            this.button1_ver.UseVisualStyleBackColor = true;
            this.button1_ver.Click += new System.EventHandler(this.button1_ver_Click);
            // 
            // button1_buscar
            // 
            this.button1_buscar.Location = new System.Drawing.Point(174, 7);
            this.button1_buscar.Name = "button1_buscar";
            this.button1_buscar.Size = new System.Drawing.Size(156, 20);
            this.button1_buscar.TabIndex = 25;
            this.button1_buscar.Text = "Buscar";
            this.button1_buscar.UseVisualStyleBackColor = true;
            this.button1_buscar.Click += new System.EventHandler(this.button1_buscar_Click);
            // 
            // button1_cancelar
            // 
            this.button1_cancelar.Location = new System.Drawing.Point(255, 242);
            this.button1_cancelar.Name = "button1_cancelar";
            this.button1_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button1_cancelar.TabIndex = 23;
            this.button1_cancelar.Text = "Cancelar";
            this.button1_cancelar.UseVisualStyleBackColor = true;
            this.button1_cancelar.Click += new System.EventHandler(this.button1_cancelar_Click);
            // 
            // button1_modificacion
            // 
            this.button1_modificacion.Location = new System.Drawing.Point(174, 33);
            this.button1_modificacion.Name = "button1_modificacion";
            this.button1_modificacion.Size = new System.Drawing.Size(75, 23);
            this.button1_modificacion.TabIndex = 22;
            this.button1_modificacion.Text = "Modificacion";
            this.button1_modificacion.UseVisualStyleBackColor = true;
            this.button1_modificacion.Click += new System.EventHandler(this.button1_modificacion_Click);
            // 
            // button1_baja
            // 
            this.button1_baja.Location = new System.Drawing.Point(93, 33);
            this.button1_baja.Name = "button1_baja";
            this.button1_baja.Size = new System.Drawing.Size(75, 23);
            this.button1_baja.TabIndex = 21;
            this.button1_baja.Text = "Baja";
            this.button1_baja.UseVisualStyleBackColor = true;
            this.button1_baja.Click += new System.EventHandler(this.button1_baja_Click);
            // 
            // button1_alta
            // 
            this.button1_alta.Location = new System.Drawing.Point(12, 33);
            this.button1_alta.Name = "button1_alta";
            this.button1_alta.Size = new System.Drawing.Size(75, 23);
            this.button1_alta.TabIndex = 20;
            this.button1_alta.Text = "Alta";
            this.button1_alta.UseVisualStyleBackColor = true;
            this.button1_alta.Click += new System.EventHandler(this.button1_alta_Click);
            // 
            // textBox1_DNI
            // 
            this.textBox1_DNI.Location = new System.Drawing.Point(46, 7);
            this.textBox1_DNI.Name = "textBox1_DNI";
            this.textBox1_DNI.Size = new System.Drawing.Size(122, 20);
            this.textBox1_DNI.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "DNI";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(315, 173);
            this.dataGridView1.TabIndex = 27;
            // 
            // txt_origen
            // 
            this.txt_origen.Enabled = false;
            this.txt_origen.Location = new System.Drawing.Point(379, 177);
            this.txt_origen.Name = "txt_origen";
            this.txt_origen.Size = new System.Drawing.Size(100, 20);
            this.txt_origen.TabIndex = 32;
            this.txt_origen.TabStop = false;
            this.txt_origen.Visible = false;
            // 
            // txtIDfamilia
            // 
            this.txtIDfamilia.Enabled = false;
            this.txtIDfamilia.Location = new System.Drawing.Point(379, 70);
            this.txtIDfamilia.Name = "txtIDfamilia";
            this.txtIDfamilia.ShortcutsEnabled = false;
            this.txtIDfamilia.Size = new System.Drawing.Size(100, 20);
            this.txtIDfamilia.TabIndex = 31;
            this.txtIDfamilia.TabStop = false;
            this.txtIDfamilia.Visible = false;
            // 
            // txtTipo
            // 
            this.txtTipo.Enabled = false;
            this.txtTipo.Location = new System.Drawing.Point(379, 150);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ShortcutsEnabled = false;
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 30;
            this.txtTipo.TabStop = false;
            this.txtTipo.Visible = false;
            // 
            // txtEdad
            // 
            this.txtEdad.Enabled = false;
            this.txtEdad.Location = new System.Drawing.Point(379, 123);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ShortcutsEnabled = false;
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 29;
            this.txtEdad.TabStop = false;
            this.txtEdad.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(379, 96);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 28;
            this.txtNombre.TabStop = false;
            this.txtNombre.Visible = false;
            // 
            // VentanaAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 271);
            this.Controls.Add(this.txt_origen);
            this.Controls.Add(this.txtIDfamilia);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1_ver);
            this.Controls.Add(this.button1_buscar);
            this.Controls.Add(this.button1_cancelar);
            this.Controls.Add(this.button1_modificacion);
            this.Controls.Add(this.button1_baja);
            this.Controls.Add(this.button1_alta);
            this.Controls.Add(this.textBox1_DNI);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VentanaAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animales";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_ver;
        private System.Windows.Forms.Button button1_buscar;
        private System.Windows.Forms.Button button1_cancelar;
        private System.Windows.Forms.Button button1_modificacion;
        private System.Windows.Forms.Button button1_baja;
        private System.Windows.Forms.Button button1_alta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox textBox1_DNI;
        public System.Windows.Forms.TextBox txt_origen;
        private System.Windows.Forms.TextBox txtIDfamilia;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNombre;
    }
}