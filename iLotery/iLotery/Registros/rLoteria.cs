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

namespace iLotery.Registros
{
    public partial class rLoteria : Form
    {
        private Loterias Loteria = new Loterias();

        public rLoteria()
        {
            InitializeComponent();
        }

        private void rLoteria_Load(object sender, EventArgs e)
        {
            TandaComboBox.SelectedIndex = 0;
        }

        private void BorrarButton_Click(object sender, EventArgs e)
        {
            if (IDTextBox.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(IDTextBox, "Debe ingresar un ID");
                IDTextBox.Focus();
                return;
            }
            if (Loteria.Eliminar(Utilitarios.ToInt(IDTextBox.Text)))
                MessageBox.Show("Loteria Borrado.");

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Boolean paso = false;

            if (NombreTextBox.Text.Trim().Length == 0)
            {
                errorProvider2.SetError(NombreTextBox, "Debe Introducir un Correo.");
                NombreTextBox.Focus();
                return;
            }


            Loteria.IdLoteria = Utilitarios.ToInt(IDTextBox.Text);
            Loteria.Loteria = NombreTextBox.Text;
            Loteria.Tanda = TandaComboBox.SelectedItem.ToString();


            if (Loteria.IdLoteria > 0)
            {
                //Editando
                paso = Loteria.Modificar();
                IDTextBox.Clear();
                NombreTextBox.Clear();
            }
            else
            {
                //Insertando
                paso = Loteria.Insertar();
                IDTextBox.Clear();
                NombreTextBox.Clear();
            }

            if (paso)
            {
                MessageBox.Show("Lotearia Guardada.");
            }
            else
            {
                MessageBox.Show("Error Guardando la Loteria.");
            }
        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void NombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            IDTextBox.Clear();
            NombreTextBox.Clear();
        }
    }
}
