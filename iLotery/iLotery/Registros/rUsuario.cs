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
using System.Data.SqlClient;

namespace iLotery.Registros
{
    public partial class rUsuario : Form
    {
        private Usuarios Usuario = new Usuarios();

        public rUsuario()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {


            Boolean paso = false;


            if (UsuarioTextBox.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(NombreTextBox, "Debe Introducir un Nombre.");
                NombreTextBox.Focus();
                return;
            }

            if (ApellidoTextBox.Text.Trim().Length == 0)
            {
                errorProvider2.SetError(ApellidoTextBox, "Debe Introducir un Apellido.");
                ApellidoTextBox.Focus();
                return;
            }
            if (UsuarioTextBox.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(UsuarioTextBox, "Debe Introducir un Nombre.");
                UsuarioTextBox.Focus();
                return;
            }

            if (PWTextBox.Text.Trim().Length == 0)
            {
                if (PWTextBox.Text.Trim().Length > 10)
                {
                    errorProvider2.SetError(PWTextBox, "Debe Introducir una Contraseña y/o No puede exceder los 10 caracteres.");
                    PWTextBox.Focus();
                    return;
                }
            }
            Usuario.IdUsuario = Utilitarios.ToInt(IDTextBox.Text);
            Usuario.Nombre = NombreTextBox.Text + ApellidoTextBox.Text;
            Usuario.Usuario = UsuarioTextBox.Text;
            Usuario.Contra = PWTextBox.Text;
            Usuario.Mail = MailTextBox.Text;
            Usuario.Nivel = Utilitarios.ToInt(NivelComboBox.SelectedText);


            if (Usuario.IdUsuario > 0)
            {
                //Editando
                paso = Usuario.Modificar();
            }
            else
            {
                //Insertando
                paso = Usuario.Insertar();
            }

            if (paso)
                MessageBox.Show("Registro Guardado");
            else
                MessageBox.Show("Por Favor Complete los Campo");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}