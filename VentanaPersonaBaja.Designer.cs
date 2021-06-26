
namespace lab3_sanchez_pablo_sn
{
    partial class VentanaPersonaBaja
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columDNI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columApellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columFamilia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1_cancelar = new System.Windows.Forms.Button();
            this.button1_aceptar = new System.Windows.Forms.Button();
            this.textBox1_DNI = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.listView1.Location = new System.Drawing.Point(12, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(368, 61);
            this.listView1.TabIndex = 16;
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
            this.columDNI.Width = 75;
            // 
            // columApellido
            // 
            this.columApellido.Text = "Apellido";
            this.columApellido.Width = 105;
            // 
            // columNombre
            // 
            this.columNombre.Text = "Nombre";
            this.columNombre.Width = 107;
            // 
            // columFamilia
            // 
            this.columFamilia.Text = "Familia";
            this.columFamilia.Width = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ud. esta por dar de Baja a esta Persona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Desea Continuar Con la BAJA?";
            // 
            // button1_cancelar
            // 
            this.button1_cancelar.Location = new System.Drawing.Point(92, 138);
            this.button1_cancelar.Name = "button1_cancelar";
            this.button1_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button1_cancelar.TabIndex = 19;
            this.button1_cancelar.Text = "NO";
            this.button1_cancelar.UseVisualStyleBackColor = true;
            this.button1_cancelar.Click += new System.EventHandler(this.button1_cancelar_Click);
            // 
            // button1_aceptar
            // 
            this.button1_aceptar.Location = new System.Drawing.Point(224, 138);
            this.button1_aceptar.Name = "button1_aceptar";
            this.button1_aceptar.Size = new System.Drawing.Size(75, 23);
            this.button1_aceptar.TabIndex = 20;
            this.button1_aceptar.Text = "SI";
            this.button1_aceptar.UseVisualStyleBackColor = true;
            this.button1_aceptar.Click += new System.EventHandler(this.button1_aceptar_Click);
            // 
            // textBox1_DNI
            // 
            this.textBox1_DNI.Enabled = false;
            this.textBox1_DNI.Location = new System.Drawing.Point(419, 61);
            this.textBox1_DNI.Name = "textBox1_DNI";
            this.textBox1_DNI.ShortcutsEnabled = false;
            this.textBox1_DNI.Size = new System.Drawing.Size(100, 20);
            this.textBox1_DNI.TabIndex = 21;
            this.textBox1_DNI.TabStop = false;
            this.textBox1_DNI.Visible = false;
            // 
            // VentanaPersonaBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 173);
            this.Controls.Add(this.textBox1_DNI);
            this.Controls.Add(this.button1_aceptar);
            this.Controls.Add(this.button1_cancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VentanaPersonaBaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advertencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columID;
        private System.Windows.Forms.ColumnHeader columDNI;
        private System.Windows.Forms.ColumnHeader columApellido;
        private System.Windows.Forms.ColumnHeader columNombre;
        private System.Windows.Forms.ColumnHeader columFamilia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1_cancelar;
        private System.Windows.Forms.Button button1_aceptar;
        private System.Windows.Forms.TextBox textBox1_DNI;
    }
}