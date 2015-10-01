using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR002
{
    public partial class Form1 : Form
    {
        int DISTX, DISTY;
        private Point RATON;
        private bool primero = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point boton = new Point(button1.Location.X, button1.Location.Y);
            Point raton = new Point(e.Location.X, e.Location.Y);
            int movimiento = 1;

            if(calcDistancia(boton,raton) < 100)
            {
                movimiento = 10;
            }else if(calcDistancia(boton,raton) < 50)
            {
                movimiento = 50;
            }else if(calcDistancia(boton,raton) < 25)
            {
                movimiento = 100;
            }

            if (primero)
            {
                primero = false;
                RATON.X = e.X;
                RATON.Y = e.Y;
            }

            if (!raton.Equals(RATON) && (Math.Abs(boton.X - e.X) < Math.Abs(boton.X - RATON.X)
                || Math.Abs(boton.Y - e.Y) < Math.Abs(boton.Y - RATON.Y)) )
            {
                if (boton.X > e.Location.X && boton.X + button1.Width < this.Width)
                {
                    boton.X+=movimiento; //Hacer que se resetee en las esquinas
                }
                else if (boton.X < e.Location.X && boton.X > 0)
                {
                    boton.X-=movimiento;
                } 
                if (boton.Y > e.Location.Y && boton.Y + button1.Height < this.Height)
                {
                    boton.Y+=movimiento;
                }
                else if (boton.Y < e.Location.Y && boton.Y > 0)
                {
                    boton.Y-=movimiento;
                } 
            }

                RATON = raton;
                button1.Location = boton;             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Has ganado!");
            this.Close();
        }

        private double calcDistancia(Point a, Point b)
        {
          return Math.Sqrt(Math.Pow((b.X-a.X),2)+Math.Pow((b.Y-a.Y),2));
        }
    }
}
