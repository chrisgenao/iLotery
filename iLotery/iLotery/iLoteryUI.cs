using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace iLotery
{
    public partial class Login : Form
    {
        private Usuarios Usuario = new Usuarios();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean paso = false;

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

            Usuario.Usuario = UsuarioTextBox.Text;
            Usuario.Contra = PasswordTextBox.Text;

            if (Usuario.)
            {
                Window.iLotery il = new Window.iLotery();
                il.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña invalidos.");
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
