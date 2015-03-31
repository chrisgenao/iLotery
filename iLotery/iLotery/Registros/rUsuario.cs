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
using System.Text.RegularExpressions;

namespace iLotery.Registros
{
    public partial class rUsuario : Form
    {
        private Usuarios Usuario = new Usuarios();
        //Todo: Validar Texto Correo.
        public rUsuario()
        {

            InitializeComponent();
            PWTextBox.MaxLength = 10;
            PWTextBox.PasswordChar = '*';
            NivelComboBox.SelectedIndex = 0;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {


            Boolean paso = false;

            if (!Utilitarios.ValidarTextBoxVacio(UsuarioTextBox, errorProvider3, "Debe introducir alguna descripción"))
                return;

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
                errorProvider3.SetError(UsuarioTextBox, "Debe Introducir un Usuario.");
                UsuarioTextBox.Focus();
                return;
            }

            if (PWTextBox.Text.Trim().Length == 0)
            {

                errorProvider4.SetError(PWTextBox, "Debe Introducir una Contraseña y/o No puede exceder los 10 caracteres.");
                PWTextBox.Focus();
                return;
            }

            if (MailTextBox.Text.Trim().Length == 0)
            {
                errorProvider5.SetError(MailTextBox, "Debe Introducir un Correo.");
                MailTextBox.Focus();
                return;
            }


            Usuario.IdUsuario = Utilitarios.ToInt(IDTextBox.Text);
            Usuario.Nombre = NombreTextBox.Text + " " + ApellidoTextBox.Text;
            Usuario.Usuario = UsuarioTextBox.Text;
            Usuario.Contra = PWTextBox.Text;
            Usuario.Mail = MailTextBox.Text;
            Usuario.Nivel = Utilitarios.ToInt(NivelComboBox.SelectedItem.ToString());


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
                MessageBox.Show("Usuario Guardado.");
            else
                MessageBox.Show("Error Guardando el Usuario.");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void rUsuario_Load(object sender, EventArgs e)
        {
            NivelComboBox.ValueMember = "0";
            NivelComboBox.DisplayMember = "0";
        }

        private void NombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8 || char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        private void ApellidoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8 || char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void UsuarioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8 || char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void PWTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8 || char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void MailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8 || char.IsLetter(e.KeyChar) || e.KeyChar == 45 || e.KeyChar == 46 || e.KeyChar == '@')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = DialogResult.Ignore;

            if (Utilitarios.ToInt(IDTextBox.Text) == 0)
            {
                Consultas.cUsuarios cUsuario = new Consultas.cUsuarios();

                result = cUsuario.ShowDialog();

                if (result == DialogResult.OK)
                {
                    IDTextBox.Text = cUsuario.DatoEncontrado.ToString();
                }
                else
                {
                    IDTextBox.Clear();
                }

                if (Usuario.Buscar(Utilitarios.ToInt(IDTextBox.Text)))
                {

                    IDTextBox.Text = Usuario.IdUsuario.ToString();
                    NombreTextBox.Text = Usuario.Nombre.ToString();
                    UsuarioTextBox.Text = Usuario.Usuario.ToString();
                    MailTextBox.Text = Usuario.Mail.ToString();
                    NivelComboBox.SelectedIndex = Convert.ToInt32(Usuario.Nivel.ToString());
                }
            }
        }

        private void BorrarButton_Click(object sender, EventArgs e)
        {
            if (IDTextBox.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(IDTextBox, "Debe ingresar un ID");
                IDTextBox.Focus();
                return;
            }
            if (Usuario.Eliminar(Utilitarios.ToInt(IDTextBox.Text)))
                MessageBox.Show("Usuario Borrado");
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            IDTextBox.Clear();
            NombreTextBox.Clear();
            ApellidoTextBox.Clear();
            UsuarioTextBox.Clear();
            PWTextBox.Clear();
            MailTextBox.Clear();
        }

        private void NombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PWTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
