﻿
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
            this.columID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columDNI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columApellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columFamilia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1_cancelar = new System.Windows.Forms.Button();
            this.button1_modificacion = new System.Windows.Forms.Button();
            this.button1_baja = new System.Windows.Forms.Button();
            this.button1_alta = new System.Windows.Forms.Button();
            this.textBox1_DNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtFamilia = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1_ver
            // 
            this.button1_ver.Location = new System.Drawing.Point(255, 38);
            this.button1_ver.Name = "button1_ver";
            this.button1_ver.Size = new System.Drawing.Size(75, 23);
            this.button1_ver.TabIndex = 17;
            this.button1_ver.Text = "Todos";
            this.button1_ver.UseVisualStyleBackColor = true;
            this.button1_ver.Click += new System.EventHandler(this.button1_ver_Click);
            // 
            // button1_buscar
            // 
            this.button1_buscar.Location = new System.Drawing.Point(174, 12);
            this.button1_buscar.Name = "button1_buscar";
            this.button1_buscar.Size = new System.Drawing.Size(156, 20);
            this.button1_buscar.TabIndex = 16;
            this.button1_buscar.Text = "Buscar";
            this.button1_buscar.UseVisualStyleBackColor = true;
            this.button1_buscar.Click += new System.EventHandler(this.button1_buscar_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columID,
            this.columDNI,
            this.columApellido,
            this.columNombre,
            this.columFamilia});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(318, 174);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columID
            // 
            this.columID.Text = "ID";
            this.columID.Width = 29;
            // 
            // columDNI
            // 
            this.columDNI.Text = "DNI";
            this.columDNI.Width = 68;
            // 
            // columApellido
            // 
            this.columApellido.Text = "Apellido";
            this.columApellido.Width = 75;
            // 
            // columNombre
            // 
            this.columNombre.Text = "Nombre";
            this.columNombre.Width = 75;
            // 
            // columFamilia
            // 
            this.columFamilia.Text = "Familia";
            this.columFamilia.Width = 48;
            // 
            // button1_cancelar
            // 
            this.button1_cancelar.Location = new System.Drawing.Point(255, 247);
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
            this.button1_baja.Click += new System.EventHandler(this.button1_baja_Click);
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
            // textBox1_DNI
            // 
            this.textBox1_DNI.Location = new System.Drawing.Point(41, 12);
            this.textBox1_DNI.Name = "textBox1_DNI";
            this.textBox1_DNI.Size = new System.Drawing.Size(127, 20);
            this.textBox1_DNI.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "DNI";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(379, 124);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 18;
            this.txtNombre.TabStop = false;
            this.txtNombre.Visible = false;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(379, 151);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ShortcutsEnabled = false;
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 19;
            this.txtApellido.TabStop = false;
            this.txtApellido.Visible = false;
            // 
            // txtFamilia
            // 
            this.txtFamilia.Enabled = false;
            this.txtFamilia.Location = new System.Drawing.Point(379, 178);
            this.txtFamilia.Name = "txtFamilia";
            this.txtFamilia.ShortcutsEnabled = false;
            this.txtFamilia.Size = new System.Drawing.Size(100, 20);
            this.txtFamilia.TabIndex = 20;
            this.txtFamilia.TabStop = false;
            this.txtFamilia.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(379, 98);
            this.txtID.Name = "txtID";
            this.txtID.ShortcutsEnabled = false;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 21;
            this.txtID.TabStop = false;
            this.txtID.Visible = false;
            // 
            // VentanaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 280);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtFamilia);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.button1_ver);
            this.Controls.Add(this.button1_buscar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1_cancelar);
            this.Controls.Add(this.button1_modificacion);
            this.Controls.Add(this.button1_baja);
            this.Controls.Add(this.button1_alta);
            this.Controls.Add(this.textBox1_DNI);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VentanaPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personas";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columID;
        private System.Windows.Forms.ColumnHeader columDNI;
        private System.Windows.Forms.ColumnHeader columApellido;
        private System.Windows.Forms.ColumnHeader columNombre;
        private System.Windows.Forms.ColumnHeader columFamilia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtFamilia;
        private System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.TextBox textBox1_DNI;
    }
}