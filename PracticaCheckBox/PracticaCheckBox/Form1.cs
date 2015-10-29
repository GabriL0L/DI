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

namespace PracticaCheckBox
{
    public partial class Form1 : Form
    {

        ArrayList lista = new ArrayList();
       

        public Form1()
        {
            InitializeComponent();
            checkBox1.Checked = true;
            checkBox2.Checked = true;

            lista.Add(checkBox4);
            lista.Add(checkBox5);
            lista.Add(checkBox6);
            lista.Add(checkBox7);
            lista.Add(checkBox8);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (checkBox2.Checked)
                {
                    checkBox3.Checked = false;
                }
                else
                {
                    checkBox2.Checked = false;
                }
            }

            if (!checkBox1.Checked)
            {
                if (checkBox2.Checked && !checkBox3.Checked)
                {
                    checkBox1.Checked = true;
                }
                else if (checkBox3.Checked && !checkBox2.Checked)
                {
                    checkBox1.Checked = true;
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked)
             {
                 if (checkBox1.Checked)
                 {
                     checkBox3.Checked = false;
                 }
                 else
                 {
                     checkBox1.Checked = false;
                 }
             }

            if (!checkBox2.Checked)
            {
                if (checkBox1.Checked && !checkBox3.Checked)
                {
                    checkBox2.Checked = true;
                }
                else if (checkBox3.Checked && !checkBox1.Checked)
                {
                    checkBox2.Checked = true;
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
          
            if (checkBox3.Checked)
            {
                if (checkBox1.Checked)
                {
                    checkBox2.Checked = false;
                }
                else
                {
                    checkBox1.Checked = false;
                }
            }

            if (!checkBox3.Checked)
            {
                if (checkBox2.Checked && !checkBox1.Checked)
                {
                    checkBox3.Checked = true;
                }
                else if (checkBox1.Checked && !checkBox2.Checked)
                {
                    checkBox3.Checked = true;
                }
            }

        }

        private void click(object sender, EventArgs e)
        {
            foreach(CheckBox b in lista)
            {
                if(!sender.Equals(b))
                    b.Checked = false;
                else
                    b.Checked = true;
            }

            checkedChange(sender, e);

                        
        }

        private void checkedChange(object sender, EventArgs e)
        {
            int indice = 0;
            if (((CheckBox)sender).Checked){ 
                foreach(CheckBox b in lista)
                {
                    if(sender.Equals(b))
                    {
                        indice = lista.IndexOf(b);
                    }
                }

                foreach (CheckBox b in lista)
                {
                        if(lista.IndexOf(b) < indice)
                        {
                            b.Checked = true;
                        }
               
                }
            }
        }

        private void Crear_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            CheckBox cb = new CheckBox();
            cb.Text = "";
            //cb.Location = new Point(rnd.Next(panel3.Size.Width - cb.Size.Width)+ panel3.Location.X, rnd.Next(panel3.Size.Height - cb.Size.Height) + panel3.Location.Y);
            cb.Location = new Point(rnd.Next(panel3.Location.X, panel3.Size.Width - cb.Size.Width), rnd.Next(panel3.Location.Y, panel3.Size.Height - cb.Size.Height));
            panel3.Controls.Add(cb);
            
        }

        private void Borrar_Tick(object sender, EventArgs e)
        {
            foreach(Object c in panel3.Controls)
            {
                if(c is CheckBox)
                   ((CheckBox)c).Checked = false;
            }
        }
    }
}
