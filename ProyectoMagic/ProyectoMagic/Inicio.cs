using System;
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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginUsuario(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (DataBaseConnection.login(txtUser.Text, txtPassword.Text)){
                    errorLogin.Visible = false;
                    Lista lista = new Lista();
                    this.Hide();
                    lista.Show();
                }
                else{
                    errorLogin.Visible = true;
                }
            }
        }
    }
}
