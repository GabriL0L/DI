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

        //Clase persona que representa a cada botón que encontramos en el formulario.
            
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

        /*Con este método el botón está al tanto de si el ratón se acerca para hacerle click y 
        determina al a velocidad a la que se moverá dependiendo de la distancia al a que se
        encuentre el ratón.*/
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

        /*Este método comprueba en qué dirección debe huir el botón para alejarse del ratón.
        Se moverá a la velocidad de terminada por el método anterior.
        */
        public void huir(Point raton,Size ventana,double distancia)
        {
            int movimiento = mirar(distancia);

            //Cada if comprueba que el botón huye en la dirección correcta y sin salirse del formulario
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

        /*Método encargado de que el botón crezca de tamaño tanto él como su imagen.
        Al crecer el tamaño también crecerá la distancia a la que ve.*/
        public void crecer()
        {
            tamanho += capacidadCrecimiento;
            boton.Width += capacidadCrecimiento;
            boton.Height += capacidadCrecimiento;
            cerca += capacidadCrecimiento;
            distMedia += capacidadCrecimiento;
            lejos += capacidadCrecimiento;
        }

        //Método al que llama el botón para desaparecer del formulario y "morir".
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
