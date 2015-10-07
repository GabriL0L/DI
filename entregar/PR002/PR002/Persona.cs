using System;
using System.Drawing;
using System.Windows.Forms;

namespace PR002
{
    class Persona
    {
        private int velocidad;
        private Point posicion;
        private int tamanho;
        private int lejos;
        private int cerca;
        private int distMedia;
        private int capacidadCrecimiento;
        private Button boton;

        public Persona(int velocidad,Point posicion,Button boton)
        {
            Random rnd = new Random();
            this.velocidad = velocidad;
            this.posicion = posicion;
            this.tamanho = rnd.Next(10,50);
            this.capacidadCrecimiento = rnd.Next(5,10);
            this.lejos = 100;
            this.distMedia = 50;
            this.cerca = 25;
            this.boton = boton;
            this.boton.Width = tamanho;
            this.boton.Height = tamanho;

        }

        public int mirar(double distancia)  //Devuelve la velocidad a la que se mueve el botón o persona
        {
            int movimiento=0;

            if (distancia < lejos)
            {
                movimiento = 10;
            }
            else if (distancia < distMedia)
            {
                movimiento = 50;
            }
            else if (distancia < cerca)
            {
                movimiento = 100;
            }

            return movimiento;
        }

        public void huir(Point raton,Size ventana,double distancia)
        {
            int movimiento = mirar(distancia);

            if (posicion.X > raton.X && posicion.X + boton.Width  < ventana.Width - 10)
            {
                posicion.X += movimiento;
            }
            else if (posicion.X < raton.X && posicion.X > 0 + 10)
            {
                posicion.X -= movimiento;
            }
            if (posicion.Y > raton.Y && posicion.Y + boton.Height < ventana.Height - 10)
            {
                posicion.Y += movimiento;
            }
            else if (posicion.Y < raton.Y && posicion.Y > 0 + 10)
            {
                posicion.Y -= movimiento;
            }

            boton.Location = posicion;
        }

        public void crecer()
        {
            tamanho += capacidadCrecimiento;
            boton.Width += capacidadCrecimiento;
            boton.Height += capacidadCrecimiento;
            cerca += capacidadCrecimiento;
            distMedia += capacidadCrecimiento;
            lejos += capacidadCrecimiento;
        }

        public void morir()
        {
            boton.Dispose();
            
        }

        public Button getButton()
        {
            return boton;
        }

        public Point getPosicion()
        {
            return posicion;
        }
    }
}
