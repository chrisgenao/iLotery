using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;

namespace iLotery
{
    public partial class Login : Form
    {
        private Usuarios Usuario = new Usuarios();
        public Login()
        {
            InitializeComponent();
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.MaxLength = 10;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UsuarioTextBox.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(UsuarioTextBox, "Debe Introducir un Usuario.");
                UsuarioTextBox.Focus();
                return;
            }
            
            if (PasswordTextBox.Text.Trim().Length == 0)
            {
                errorProvider2.SetError(PasswordTextBox, "Debe Introducir una Contraseña.");
                UsuarioTextBox.Focus();
                return;
            }

            if (UsuarioTextBox.Text.Trim().Length > 0 && PasswordTextBox.Text.Trim().Length > 0)
            {
                Usuario.BuscarUsuario(UsuarioTextBox.Text, PasswordTextBox.Text);

                if (UsuarioTextBox.Text == Usuario.Usuario && PasswordTextBox.Text == Usuario.Contra)
                {
                      Window.iLotery il = new Window.iLotery();
                    MessageBox.Show("\tBienvenido a iLotery v1.0");
                   il.Show();
                      this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecta");
                    UsuarioTextBox.Focus();
                }
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
