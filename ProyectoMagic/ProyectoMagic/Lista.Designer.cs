namespace ProyectoMagic
{
    partial class Lista
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
            this.listaColores = new System.Windows.Forms.ListBox();
            this.listaCartas = new System.Windows.Forms.ListBox();
            this.salir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listaColores
            // 
            this.listaColores.FormattingEnabled = true;
            this.listaColores.Items.AddRange(new object[] {
            "Azul",
            "Blanco",
            "Negro",
            "Rojo",
            "Verde"});
            this.listaColores.Location = new System.Drawing.Point(116, 135);
            this.listaColores.Name = "listaColores";
            this.listaColores.Size = new System.Drawing.Size(75, 82);
            this.listaColores.TabIndex = 0;
            this.listaColores.SelectedIndexChanged += new System.EventHandler(this.listaColores_SelectedIndexChanged);
            // 
            // listaCartas
            // 
            this.listaCartas.FormattingEnabled = true;
            this.listaCartas.Location = new System.Drawing.Point(269, 42);
            this.listaCartas.Name = "listaCartas";
            this.listaCartas.Size = new System.Drawing.Size(178, 264);
            this.listaCartas.TabIndex = 1;
            // 
            // salir
            // 
            this.salir.AutoSize = true;
            this.salir.Location = new System.Drawing.Point(245, 337);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(27, 13);
            this.salir.TabIndex = 2;
            this.salir.Text = "Salir";
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 370);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.listaCartas);
            this.Controls.Add(this.listaColores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lista";
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.Lista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaColores;
        private System.Windows.Forms.ListBox listaCartas;
        private System.Windows.Forms.Label salir;
    }
}