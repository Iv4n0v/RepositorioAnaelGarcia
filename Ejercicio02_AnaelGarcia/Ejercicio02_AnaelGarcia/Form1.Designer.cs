namespace Ejercicio02_AnaelGarcia
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreTextBox1 = new System.Windows.Forms.TextBox();
            this.edadTextBox2 = new System.Windows.Forms.TextBox();
            this.añadirButton1 = new System.Windows.Forms.Button();
            this.mostrarButton1 = new System.Windows.Forms.Button();
            this.estudiantesListBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad";
            // 
            // nombreTextBox1
            // 
            this.nombreTextBox1.Location = new System.Drawing.Point(131, 26);
            this.nombreTextBox1.Name = "nombreTextBox1";
            this.nombreTextBox1.Size = new System.Drawing.Size(220, 20);
            this.nombreTextBox1.TabIndex = 2;
            // 
            // edadTextBox2
            // 
            this.edadTextBox2.Location = new System.Drawing.Point(131, 59);
            this.edadTextBox2.Name = "edadTextBox2";
            this.edadTextBox2.Size = new System.Drawing.Size(100, 20);
            this.edadTextBox2.TabIndex = 3;
            // 
            // añadirButton1
            // 
            this.añadirButton1.Location = new System.Drawing.Point(276, 57);
            this.añadirButton1.Name = "añadirButton1";
            this.añadirButton1.Size = new System.Drawing.Size(75, 23);
            this.añadirButton1.TabIndex = 4;
            this.añadirButton1.Text = "Añadir";
            this.añadirButton1.UseVisualStyleBackColor = true;
            this.añadirButton1.Click += new System.EventHandler(this.añadirButton1_Click);
            // 
            // mostrarButton1
            // 
            this.mostrarButton1.Location = new System.Drawing.Point(159, 343);
            this.mostrarButton1.Name = "mostrarButton1";
            this.mostrarButton1.Size = new System.Drawing.Size(75, 23);
            this.mostrarButton1.TabIndex = 5;
            this.mostrarButton1.Text = "Mostrar";
            this.mostrarButton1.UseVisualStyleBackColor = true;
            this.mostrarButton1.Click += new System.EventHandler(this.mostrarButton1_Click);
            // 
            // estudiantesListBox1
            // 
            this.estudiantesListBox1.Enabled = false;
            this.estudiantesListBox1.FormattingEnabled = true;
            this.estudiantesListBox1.Location = new System.Drawing.Point(30, 86);
            this.estudiantesListBox1.Name = "estudiantesListBox1";
            this.estudiantesListBox1.Size = new System.Drawing.Size(324, 251);
            this.estudiantesListBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 374);
            this.Controls.Add(this.estudiantesListBox1);
            this.Controls.Add(this.mostrarButton1);
            this.Controls.Add(this.añadirButton1);
            this.Controls.Add(this.edadTextBox2);
            this.Controls.Add(this.nombreTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombreTextBox1;
        private System.Windows.Forms.TextBox edadTextBox2;
        private System.Windows.Forms.Button añadirButton1;
        private System.Windows.Forms.Button mostrarButton1;
        private System.Windows.Forms.ListBox estudiantesListBox1;
    }
}

