using System;
using System.Collections;
using System.Windows.Forms;

namespace MiniPracticaRadioButton
{
    public partial class Form1 : Form
    {
        ArrayList listaFuerza = new ArrayList();
        ArrayList listaDestreza = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            listaFuerza.Add(radioButton4);
            listaFuerza.Add(radioButton5);
            listaFuerza.Add(radioButton6);
            listaFuerza.Add(radioButton7);
            listaFuerza.Add(radioButton8);

            listaDestreza.Add(radioButton9);
            listaDestreza.Add(radioButton10);
            listaDestreza.Add(radioButton11);
            listaDestreza.Add(radioButton12);
            listaDestreza.Add(radioButton13);

            
        }

        private void panelFuerza_Click(object sender, EventArgs e)
        {
            Boolean marcar = true;

            foreach(RadioButton r in listaFuerza)
            {
                r.Checked = marcar;
                if (r.Equals(sender))
                {
                    marcar = false;
                }
            }
        }

        private void panelDestreza_Click(object sender, EventArgs e)
        {
            Boolean marcar = true;

            foreach (RadioButton r in listaDestreza)
            {
                r.Checked = marcar;
                if (r.Equals(sender))
                {
                    marcar = false;
                }
            }
        }
    }
}
