using System;
using System.Windows.Forms;

namespace PruebaCombo
{
    public partial class Form1 : Form
    {
        String[] rangos = {"1-5","6-10","11-15"};

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(rangos);
            comboBox1.SelectedItem = "1-5";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            for (int i = 1; i <= 5; i++)
            {
                comboBox2.Items.Add(comboBox1.SelectedIndex * 5 + i);
            }
            comboBox2.SelectedIndex = 0;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = comboBox2.SelectedItem.ToString();
        }
    }
}
