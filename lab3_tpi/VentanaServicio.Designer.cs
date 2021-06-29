
namespace lab3_sanchez_pablo_sn
{
    partial class VentanaServicio
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
            this.button1_cancelar = new System.Windows.Forms.Button();
            this.button1_modificacion = new System.Windows.Forms.Button();
            this.button1_baja = new System.Windows.Forms.Button();
            this.button1_alta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1_buscar = new System.Windows.Forms.Button();
            this.textBox1_DNI = new System.Windows.Forms.TextBox();
            this.txt_premium = new System.Windows.Forms.TextBox();
            this.txtIDfamilia = new System.Windows.Forms.TextBox();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.txtempresa = new System.Windows.Forms.TextBox();
            this.txtservicio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_ver
            // 
            this.button1_ver.Location = new System.Drawing.Point(255, 36);
            this.button1_ver.Name = "button1_ver";
            this.button1_ver.Size = new System.Drawing.Size(75, 23);
            this.button1_ver.TabIndex = 26;
            this.button1_ver.Text = "Todos";
            this.button1_ver.UseVisualStyleBackColor = true;
            this.button1_ver.Click += new System.EventHandler(this.button1_ver_Click);
            // 
            // button1_cancelar
            // 
            this.button1_cancelar.Location = new System.Drawing.Point(255, 244);
            this.button1_cancelar.Name = "button1_cancelar";
            this.button1_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button1_cancelar.TabIndex = 23;
            this.button1_cancelar.Text = "Cancelar";
            this.button1_cancelar.UseVisualStyleBackColor = true;
            this.button1_cancelar.Click += new System.EventHandler(this.button1_cancelar_Click);
            // 
            // button1_modificacion
            // 
            this.button1_modificacion.Location = new System.Drawing.Point(174, 36);
            this.button1_modificacion.Name = "button1_modificacion";
            this.button1_modificacion.Size = new System.Drawing.Size(75, 23);
            this.button1_modificacion.TabIndex = 22;
            this.button1_modificacion.Text = "Modificacion";
            this.button1_modificacion.UseVisualStyleBackColor = true;
            this.button1_modificacion.Click += new System.EventHandler(this.button1_modificacion_Click);
            // 
            // button1_baja
            // 
            this.button1_baja.Location = new System.Drawing.Point(93, 36);
            this.button1_baja.Name = "button1_baja";
            this.button1_baja.Size = new System.Drawing.Size(75, 23);
            this.button1_baja.TabIndex = 21;
            this.button1_baja.Text = "Baja";
            this.button1_baja.UseVisualStyleBackColor = true;
            this.button1_baja.Click += new System.EventHandler(this.button1_baja_Click);
            // 
            // button1_alta
            // 
            this.button1_alta.Location = new System.Drawing.Point(12, 36);
            this.button1_alta.Name = "button1_alta";
            this.button1_alta.Size = new System.Drawing.Size(75, 23);
            this.button1_alta.TabIndex = 20;
            this.button1_alta.Text = "Alta";
            this.button1_alta.UseVisualStyleBackColor = true;
            this.button1_alta.Click += new System.EventHandler(this.button1_alta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "DNI";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(315, 173);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1_buscar
            // 
            this.button1_buscar.Location = new System.Drawing.Point(175, 10);
            this.button1_buscar.Name = "button1_buscar";
            this.button1_buscar.Size = new System.Drawing.Size(156, 20);
            this.button1_buscar.TabIndex = 29;
            this.button1_buscar.Text = "Buscar";
            this.button1_buscar.UseVisualStyleBackColor = true;
            this.button1_buscar.Click += new System.EventHandler(this.button1_buscar_Click);
            // 
            // textBox1_DNI
            // 
            this.textBox1_DNI.Location = new System.Drawing.Point(47, 10);
            this.textBox1_DNI.Name = "textBox1_DNI";
            this.textBox1_DNI.Size = new System.Drawing.Size(122, 20);
            this.textBox1_DNI.TabIndex = 30;
            // 
            // txt_premium
            // 
            this.txt_premium.Enabled = false;
            this.txt_premium.Location = new System.Drawing.Point(433, 172);
            this.txt_premium.Name = "txt_premium";
            this.txt_premium.Size = new System.Drawing.Size(100, 20);
            this.txt_premium.TabIndex = 37;
            this.txt_premium.TabStop = false;
            this.txt_premium.Visible = false;
            // 
            // txtIDfamilia
            // 
            this.txtIDfamilia.Enabled = false;
            this.txtIDfamilia.Location = new System.Drawing.Point(433, 65);
            this.txtIDfamilia.Name = "txtIDfamilia";
            this.txtIDfamilia.ShortcutsEnabled = false;
            this.txtIDfamilia.Size = new System.Drawing.Size(100, 20);
            this.txtIDfamilia.TabIndex = 36;
            this.txtIDfamilia.TabStop = false;
            this.txtIDfamilia.Visible = false;
            // 
            // txtcosto
            // 
            this.txtcosto.Enabled = false;
            this.txtcosto.Location = new System.Drawing.Point(433, 145);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.ShortcutsEnabled = false;
            this.txtcosto.Size = new System.Drawing.Size(100, 20);
            this.txtcosto.TabIndex = 35;
            this.txtcosto.TabStop = false;
            this.txtcosto.Visible = false;
            // 
            // txtempresa
            // 
            this.txtempresa.Enabled = false;
            this.txtempresa.Location = new System.Drawing.Point(433, 118);
            this.txtempresa.Name = "txtempresa";
            this.txtempresa.ShortcutsEnabled = false;
            this.txtempresa.Size = new System.Drawing.Size(100, 20);
            this.txtempresa.TabIndex = 34;
            this.txtempresa.TabStop = false;
            this.txtempresa.Visible = false;
            // 
            // txtservicio
            // 
            this.txtservicio.Enabled = false;
            this.txtservicio.Location = new System.Drawing.Point(433, 91);
            this.txtservicio.Name = "txtservicio";
            this.txtservicio.ShortcutsEnabled = false;
            this.txtservicio.Size = new System.Drawing.Size(100, 20);
            this.txtservicio.TabIndex = 33;
            this.txtservicio.TabStop = false;
            this.txtservicio.Visible = false;
            // 
            // VentanaServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 278);
            this.Controls.Add(this.txt_premium);
            this.Controls.Add(this.txtIDfamilia);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.txtempresa);
            this.Controls.Add(this.txtservicio);
            this.Controls.Add(this.textBox1_DNI);
            this.Controls.Add(this.button1_buscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1_ver);
            this.Controls.Add(this.button1_cancelar);
            this.Controls.Add(this.button1_modificacion);
            this.Controls.Add(this.button1_baja);
            this.Controls.Add(this.button1_alta);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VentanaServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_ver;
        private System.Windows.Forms.Button button1_cancelar;
        private System.Windows.Forms.Button button1_modificacion;
        private System.Windows.Forms.Button button1_baja;
        private System.Windows.Forms.Button button1_alta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1_buscar;
        public System.Windows.Forms.TextBox textBox1_DNI;
        public System.Windows.Forms.TextBox txt_premium;
        public System.Windows.Forms.TextBox txtIDfamilia;
        public System.Windows.Forms.TextBox txtcosto;
        public System.Windows.Forms.TextBox txtempresa;
        public System.Windows.Forms.TextBox txtservicio;
    }
}