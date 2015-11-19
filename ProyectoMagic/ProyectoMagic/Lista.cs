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

namespace ProyectoMagic
{
    public partial class Lista : Form
    {
        public Lista()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Lista_Load(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listaColores_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaCartas.Items.Clear();
            ArrayList lista = DataBaseConnection.mostrarListaCartas(listaColores.GetItemText(listaColores.SelectedItem).ToString());

            listaCartas.Items.AddRange(lista.ToArray());
        }
    }
}
