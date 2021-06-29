
namespace lab3_sanchez_pablo_sn
{
    partial class VentanaAnimalBaja
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1_DNI = new System.Windows.Forms.TextBox();
            this.button1_aceptar = new System.Windows.Forms.Button();
            this.button1_cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(373, 80);
            this.dataGridView1.TabIndex = 28;
            // 
            // textBox1_DNI
            // 
            this.textBox1_DNI.Enabled = false;
            this.textBox1_DNI.Location = new System.Drawing.Point(417, 53);
            this.textBox1_DNI.Name = "textBox1_DNI";
            this.textBox1_DNI.ShortcutsEnabled = false;
            this.textBox1_DNI.Size = new System.Drawing.Size(100, 20);
            this.textBox1_DNI.TabIndex = 27;
            this.textBox1_DNI.TabStop = false;
            this.textBox1_DNI.Visible = false;
            // 
            // button1_aceptar
            // 
            this.button1_aceptar.Location = new System.Drawing.Point(222, 130);
            this.button1_aceptar.Name = "button1_aceptar";
            this.button1_aceptar.Size = new System.Drawing.Size(75, 23);
            this.button1_aceptar.TabIndex = 26;
            this.button1_aceptar.Text = "SI";
            this.button1_aceptar.UseVisualStyleBackColor = true;
            this.button1_aceptar.Click += new System.EventHandler(this.button1_aceptar_Click);
            // 
            // button1_cancelar
            // 
            this.button1_cancelar.Location = new System.Drawing.Point(90, 130);
            this.button1_cancelar.Name = "button1_cancelar";
            this.button1_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button1_cancelar.TabIndex = 25;
            this.button1_cancelar.Text = "NO";
            this.button1_cancelar.UseVisualStyleBackColor = true;
            this.button1_cancelar.Click += new System.EventHandler(this.button1_cancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Desea Continuar Con la BAJA?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ud. esta por dar de Baja a este Animal";
            // 
            // VentanaAnimalBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 161);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1_DNI);
            this.Controls.Add(this.button1_aceptar);
            this.Controls.Add(this.button1_cancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VentanaAnimalBaja";
            this.Text = "Animal Baja";
            this.Load += new System.EventHandler(this.VentanaAnimalBaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1_DNI;
        private System.Windows.Forms.Button button1_aceptar;
        private System.Windows.Forms.Button button1_cancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}