using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
namespace PR002
{
    public partial class Form1 : Form
    {

        private Point RATON;
        private bool primero = true;
        ArrayList listaPersonas = new ArrayList();
        
        public Form1()
        {
            InitializeComponent();
            nacer();
              
        }

        public void nacer()
        {
            Persona p;
            Button boton = new Button();
            Random rnd = new Random();

            if(listaPersonas.Count < 15) { 
            boton.Size = new Size(0, 0); // esto se pondrá con los valores de la persona
            boton.Location = new Point(rnd.Next(10,300), rnd.Next(10,300));
            boton.BackgroundImage = Properties.Resources.persona;
            boton.AutoSizeMode = AutoSizeMode.GrowOnly;
            boton.BackColor = Color.Gray;
            boton.BackgroundImageLayout = ImageLayout.Zoom;
            boton.Cursor = Cursors.Cross;
            boton.FlatAppearance.BorderSize = 0;
            boton.FlatStyle = FlatStyle.Flat;
            boton.Click += new EventHandler(this.click);
           
            this.Controls.Add(boton);

            p = new Persona(0,boton.Location,boton);
            listaPersonas.Add(p);

            }else
            {
                timer1.Enabled = false;
                MessageBox.Show("¡Has Perdido! Te gana hasta Krilin.");
                this.Close();
            }

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
            Point raton = new Point(e.Location.X, e.Location.Y);
            
            if (primero)
            {
                primero = false;
                RATON.X = e.X;
                RATON.Y = e.Y;
            }

            foreach (Persona p in listaPersonas) { 
            if (!raton.Equals(RATON) && (Math.Abs(p.getPosicion().X - e.X) < Math.Abs(p.getPosicion().X - RATON.X)
                || Math.Abs(p.getPosicion().Y - e.Y) < Math.Abs(p.getPosicion().Y - RATON.Y)) )
            {
                
               p.huir(e.Location, this.Size, calcDistancia(p.getPosicion(), raton));
                
                
            }
            }
            RATON = raton;
                           
        }

        
        private void click(object sender, EventArgs e) 
        {
            int borrar=0;
            bool haBorrado = false;
            
            foreach(Persona p in listaPersonas)
            {
                
                if (sender.Equals(p.getButton()))
                {
                    haBorrado = true; //para que no borre al de la posicion 0 por la cara
                    p.morir();
                    borrar = listaPersonas.IndexOf(p); 
                }

            }

            if (haBorrado) { 
            listaPersonas.RemoveAt(borrar);
            }

            if(listaPersonas.Count == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("¡Has Ganado! Enhorabuena");
                this.Close();
            }

        }

        private double calcDistancia(Point a, Point b)
        {
          return Math.Sqrt(Math.Pow((b.X-a.X),2)+Math.Pow((b.Y-a.Y),2));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach(Persona p in listaPersonas)
            {
                p.crecer();
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            nacer();
        }
    }
}
