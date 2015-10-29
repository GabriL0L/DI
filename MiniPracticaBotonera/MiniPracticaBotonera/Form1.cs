using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPracticaBotonera
{
    public partial class Form1 : Form
    {

        ArrayList nombres = new ArrayList();
        int total = 0;
        int actual = 0;

        public Form1()
        {
            InitializeComponent();
            panel2.Enabled = false;
            textBox1.Enabled = false;
            anterior.Enabled = false;
            siguiente.Enabled = false;
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            if (nombres.Count > 0) { 
                anterior.Enabled = true;
            }
            total++;
            actual++;
            pagTotal.Text = total.ToString();
            pagActual.Text = actual.ToString();
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            //Activa modo editar
            panel2.Enabled = true;
            panel1.Enabled = false;
            textBox1.Enabled = true;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            panel2.Enabled = false;
            panel1.Enabled = true;
            textBox1.Enabled = false;
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            //if(textBox1.Text != null && textBox1.Text != "")
                nombres.Add(textBox1.Text);
                panel2.Enabled = false;
                panel1.Enabled = true;
                textBox1.Enabled = false;
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            if(nombres.IndexOf(textBox1.Text) != -1) { 
                if (nombres.IndexOf(textBox1.Text) != 0) { 
                    textBox1.Text = (String)nombres[nombres.IndexOf(textBox1.Text) - 1];
                    actual--;
                    total--;
                    pagTotal.Text = total.ToString();
                    pagActual.Text = actual.ToString();
                    nombres.RemoveAt(nombres.IndexOf(textBox1.Text));
                    nombres.Sort();
                }else { 
                    total = 0;
                    actual = 0;
                    pagTotal.Text = total.ToString();
                    pagActual.Text = actual.ToString();
                    nombres.RemoveAt(nombres.IndexOf(textBox1.Text));
                    textBox1.ResetText();
                    anterior.Enabled = false;
                    siguiente.Enabled = false;
                    nombres.Sort();
                }
            }
        }

        private void anterior_Click(object sender, EventArgs e)
        {
            if (nombres.IndexOf(textBox1.Text) < nombres.Count)
                siguiente.Enabled = true;
            //if (nombres.IndexOf(textBox1.Text) > 0)
                
            if (nombres.IndexOf(textBox1.Text) == 1)
                anterior.Enabled = false;
           
             textBox1.Text = (String)nombres[nombres.IndexOf(textBox1.Text) - 1];
             actual--;
             pagActual.Text = actual.ToString();
            
        }

        private void siguiente_Click(object sender, EventArgs e)
        {
            if (nombres.IndexOf(textBox1.Text)+1 > 0)
                anterior.Enabled = true;
            //if (nombres.IndexOf(textBox1.Text) < nombres.Count - 1)
            
            if (nombres.Count == 0 || nombres.IndexOf(textBox1.Text) == nombres.Count - 2)
                siguiente.Enabled = false;

            textBox1.Text = (String)nombres[nombres.IndexOf(textBox1.Text) + 1];
            actual++;
            pagActual.Text = actual.ToString();
        }
    }
}
