namespace MiniPracticaBotonera
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.anterior = new System.Windows.Forms.Button();
            this.siguiente = new System.Windows.Forms.Button();
            this.nuevo = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guardar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.pagActual = new System.Windows.Forms.Label();
            this.pagTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.modificar);
            this.panel1.Controls.Add(this.borrar);
            this.panel1.Controls.Add(this.nuevo);
            this.panel1.Controls.Add(this.siguiente);
            this.panel1.Controls.Add(this.anterior);
            this.panel1.Location = new System.Drawing.Point(0, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 50);
            this.panel1.TabIndex = 2;
            // 
            // anterior
            // 
            this.anterior.Location = new System.Drawing.Point(12, 8);
            this.anterior.Name = "anterior";
            this.anterior.Size = new System.Drawing.Size(60, 32);
            this.anterior.TabIndex = 0;
            this.anterior.Text = "Anterior";
            this.anterior.UseVisualStyleBackColor = true;
            this.anterior.Click += new System.EventHandler(this.anterior_Click);
            // 
            // siguiente
            // 
            this.siguiente.Location = new System.Drawing.Point(416, 8);
            this.siguiente.Name = "siguiente";
            this.siguiente.Size = new System.Drawing.Size(59, 32);
            this.siguiente.TabIndex = 1;
            this.siguiente.Text = "Siguiente";
            this.siguiente.UseVisualStyleBackColor = true;
            this.siguiente.Click += new System.EventHandler(this.siguiente_Click);
            // 
            // nuevo
            // 
            this.nuevo.Location = new System.Drawing.Point(95, 13);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(75, 23);
            this.nuevo.TabIndex = 2;
            this.nuevo.Text = "Nuevo";
            this.nuevo.UseVisualStyleBackColor = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // borrar
            // 
            this.borrar.Location = new System.Drawing.Point(198, 13);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(75, 23);
            this.borrar.TabIndex = 3;
            this.borrar.Text = "Borrar";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(307, 13);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 23);
            this.modificar.TabIndex = 4;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cancelar);
            this.panel2.Controls.Add(this.guardar);
            this.panel2.Location = new System.Drawing.Point(66, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 50);
            this.panel2.TabIndex = 3;
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(29, 17);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(75, 23);
            this.guardar.TabIndex = 0;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(241, 17);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 1;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // pagActual
            // 
            this.pagActual.AutoSize = true;
            this.pagActual.Location = new System.Drawing.Point(165, 99);
            this.pagActual.Name = "pagActual";
            this.pagActual.Size = new System.Drawing.Size(13, 13);
            this.pagActual.TabIndex = 4;
            this.pagActual.Text = "0";
            // 
            // pagTotal
            // 
            this.pagTotal.AutoSize = true;
            this.pagTotal.Location = new System.Drawing.Point(276, 99);
            this.pagTotal.Name = "pagTotal";
            this.pagTotal.Size = new System.Drawing.Size(13, 13);
            this.pagTotal.TabIndex = 5;
            this.pagTotal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "/";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 309);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pagTotal);
            this.Controls.Add(this.pagActual);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Button nuevo;
        private System.Windows.Forms.Button siguiente;
        private System.Windows.Forms.Button anterior;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Label pagActual;
        private System.Windows.Forms.Label pagTotal;
        private System.Windows.Forms.Label label4;
    }
}

