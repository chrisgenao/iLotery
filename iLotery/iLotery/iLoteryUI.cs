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


            SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=iLoteryDb;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Usuarios where Usuario='" + UsuarioTextBox.Text + "' and Contra ='"+ PasswordTextBox.Text +"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Window.iLotery il = new Window.iLotery();
                MessageBox.Show("Bienvenido a iLotery v1.0");
                il.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta");
                UsuarioTextBox.Focus();
            }
          
                //    Boolean paso = false;            
          //  Usuario.Usuario = UsuarioTextBox.Text;
          //  Usuario.Contra = PasswordTextBox.Text;
          //  
          //  if (UsuarioTextBox.Text == Usuario.Usuario && PasswordTextBox.Text == Usuario.Contra)
          //  {
          //      Window.iLotery il = new Window.iLotery();
          //      MessageBox.Show("Bienvenido a iLotery v1.0");
          //      il.Show();
          //      this.Hide();
          //  }
          //  else
          //  {
          //      MessageBox.Show("Usuario o Contraseña invalidos.");
          //  }
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
