﻿
namespace lab3_sanchez_pablo_sn
{
    partial class VentanaPersonaALTA
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
            this.textBox1_nombre = new System.Windows.Forms.TextBox();
            this.textBox2_apellido = new System.Windows.Forms.TextBox();
            this.textBox4_dni = new System.Windows.Forms.TextBox();
            this.comboBox1_estado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2_sexo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1_aceptar = new System.Windows.Forms.Button();
            this.button2_cancelar = new System.Windows.Forms.Button();
            this.dateTimePicker1_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1_nombre
            // 
            this.textBox1_nombre.Location = new System.Drawing.Point(12, 28);
            this.textBox1_nombre.Name = "textBox1_nombre";
            this.textBox1_nombre.Size = new System.Drawing.Size(156, 20);
            this.textBox1_nombre.TabIndex = 0;
            // 
            // textBox2_apellido
            // 
            this.textBox2_apellido.Location = new System.Drawing.Point(177, 28);
            this.textBox2_apellido.Name = "textBox2_apellido";
            this.textBox2_apellido.Size = new System.Drawing.Size(156, 20);
            this.textBox2_apellido.TabIndex = 1;
            // 
            // textBox4_dni
            // 
            this.textBox4_dni.Location = new System.Drawing.Point(12, 76);
            this.textBox4_dni.Name = "textBox4_dni";
            this.textBox4_dni.Size = new System.Drawing.Size(156, 20);
            this.textBox4_dni.TabIndex = 3;
            // 
            // comboBox1_estado
            // 
            this.comboBox1_estado.FormattingEnabled = true;
            this.comboBox1_estado.Items.AddRange(new object[] {
            "Trabaja",
            "Estudia"});
            this.comboBox1_estado.Location = new System.Drawing.Point(177, 119);
            this.comboBox1_estado.Name = "comboBox1_estado";
            this.comboBox1_estado.Size = new System.Drawing.Size(156, 21);
            this.comboBox1_estado.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sexo";
            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "DNI";
            // 
            // comboBox2_sexo
            // 
            this.comboBox2_sexo.FormattingEnabled = true;
            this.comboBox2_sexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBox2_sexo.Location = new System.Drawing.Point(177, 76);
            this.comboBox2_sexo.Name = "comboBox2_sexo";
            this.comboBox2_sexo.Size = new System.Drawing.Size(156, 21);
            this.comboBox2_sexo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Estado";
            // 
            // button1_aceptar
            // 
            this.button1_aceptar.Location = new System.Drawing.Point(258, 158);
            this.button1_aceptar.Name = "button1_aceptar";
            this.button1_aceptar.Size = new System.Drawing.Size(75, 23);
            this.button1_aceptar.TabIndex = 13;
            this.button1_aceptar.Text = "Aceptar";
            this.button1_aceptar.UseVisualStyleBackColor = true;
            this.button1_aceptar.Click += new System.EventHandler(this.button1_aceptar_Click);
            // 
            // button2_cancelar
            // 
            this.button2_cancelar.Location = new System.Drawing.Point(12, 158);
            this.button2_cancelar.Name = "button2_cancelar";
            this.button2_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button2_cancelar.TabIndex = 14;
            this.button2_cancelar.Text = "Cancelar";
            this.button2_cancelar.UseVisualStyleBackColor = true;
            this.button2_cancelar.Click += new System.EventHandler(this.button2_cancelar_Click);
            // 
            // dateTimePicker1_nacimiento
            // 
            this.dateTimePicker1_nacimiento.AllowDrop = true;
            this.dateTimePicker1_nacimiento.CustomFormat = "dd/mm/yyyy";
            this.dateTimePicker1_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1_nacimiento.Location = new System.Drawing.Point(12, 120);
            this.dateTimePicker1_nacimiento.Name = "dateTimePicker1_nacimiento";
            this.dateTimePicker1_nacimiento.Size = new System.Drawing.Size(156, 20);
            this.dateTimePicker1_nacimiento.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Fecha de Nacimiento";
            // 
            // VentanaPersonaALTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 192);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1_nacimiento);
            this.Controls.Add(this.button2_cancelar);
            this.Controls.Add(this.button1_aceptar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2_sexo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1_estado);
            this.Controls.Add(this.textBox4_dni);
            this.Controls.Add(this.textBox2_apellido);
            this.Controls.Add(this.textBox1_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VentanaPersonaALTA";
            this.Text = "VentanaPersonaALTA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_nombre;
        private System.Windows.Forms.TextBox textBox2_apellido;
        private System.Windows.Forms.TextBox textBox4_dni;
        private System.Windows.Forms.ComboBox comboBox1_estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2_sexo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1_aceptar;
        private System.Windows.Forms.Button button2_cancelar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_nacimiento;
        private System.Windows.Forms.Label label7;
    }
}