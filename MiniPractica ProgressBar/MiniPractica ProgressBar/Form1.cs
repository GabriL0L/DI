using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPractica_ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void arriba_Click(object sender, EventArgs e)
        {
            if(progressBar1.Value < progressBar1.Maximum)
                progressBar1.Value += 5;
        }

        private void abajo_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value > progressBar1.Minimum)
                progressBar1.Value -= 5;
        }

        private void progressBar1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.X >= progressBar1.Maximum / 2)
            {
                if (progressBar1.Value < progressBar1.Maximum)
                    progressBar1.Value += 5;
            }
            else
            {
                if (progressBar1.Value > progressBar1.Minimum)
                    progressBar1.Value -= 5;
            }
        }

        private void progressBar2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.X >= progressBar2.Value)
            {
                if (progressBar2.Value < progressBar2.Maximum)
                    progressBar2.Value += 5;
            }
            else
            {
                if (progressBar2.Value > progressBar2.Minimum)
                    progressBar2.Value -= 5;
            }
        }

        private void progressBar3_MouseClick(object sender, MouseEventArgs e)
        {
            
            //if(e.X >= progressBar3.Minimum && e.X <= progressBar3.Maximum)
                progressBar3.Value = e.X;
            
               
        }

        private void progressBar4_MouseClick(object sender, MouseEventArgs e)
        {
            double redondeo = (double)e.X * ((ProgressBar)sender).Maximum / ((ProgressBar)sender).Width;
            ((ProgressBar)sender).Value = (int) Math.Round(redondeo);

        }
    }
}
