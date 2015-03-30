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
    public partial class rGanadores : Form
    {
        private Ganadores Ganador = new Ganadores();

        public rGanadores()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void rGanadores_Load(object sender, EventArgs e)
        {
            Loterias Loteria = new Loterias();
            LoteriaComboBox.DataSource = Loteria.Listar("IdLoteria, Loteria", "1=1");
            LoteriaComboBox.ValueMember = "Loteria";
            LoteriaComboBox.DisplayMember = "Loteria";
        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelefonoMTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MontoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void JugadaGTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ApellidoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoteriaComboBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void JugadaGTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || char.IsNumber(e.KeyChar) || e.KeyChar == 45)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void MontoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            IDTextBox.Clear();
            NombreTextBox.Clear();
            ApellidoTextBox.Clear();
            TelefonoMTextBox.Clear();
            LoteriaComboBox.SelectedIndex = 0;
            JugadaGTextBox.Clear();
            MontoTextBox.Clear();
        }

        private void BorrarButton_Click(object sender, EventArgs e)
        {
            if (IDTextBox.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(IDTextBox, "Debe ingresar un ID");
                IDTextBox.Focus();
                return;
            }
            if (Ganador.Eliminar(Utilitarios.ToInt(IDTextBox.Text)))
                MessageBox.Show("Ganador Borrado");
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Boolean paso = false;

            if (!Utilitarios.ValidarTextBoxVacio(NombreTextBox, errorProvider3, "Debe introducir alguna descripción"))
                return;

            if (NombreTextBox.Text.Trim().Length == 0)
            {
                errorProvider2.SetError(NombreTextBox, "Debe Introducir un Nombre.");
                NombreTextBox.Focus();
                return;
            }

            if (ApellidoTextBox.Text.Trim().Length == 0)
            {
                errorProvider2.SetError(ApellidoTextBox, "Debe Introducir un Apellido.");
                ApellidoTextBox.Focus();
                return;
            }
            if (TelefonoMTextBox.Text.Trim().Length == 0)
            {
                errorProvider3.SetError(TelefonoMTextBox, "Debe Introducir un Telefono.");
                TelefonoMTextBox.Focus();
                return;
            }

            if (JugadaGTextBox.Text.Trim().Length == 0)
            {

                errorProvider4.SetError(JugadaGTextBox, "Debe Introducir la Jugada");
                JugadaGTextBox.Focus();
                return;
            }

            if (MontoTextBox.Text.Trim().Length == 0)
            {
                errorProvider5.SetError(MontoTextBox, "Debe Introducir un Monto.");
                MontoTextBox.Focus();
                return;
            }


            Ganador.IdGanador = Utilitarios.ToInt(IDTextBox.Text);
            Ganador.Nombre = NombreTextBox.Text;
            Ganador.Apellido = ApellidoTextBox.Text;
            Ganador.Telefono = TelefonoMTextBox.Text;
            Ganador.LoteriaGanadora = LoteriaComboBox.SelectedValue.ToString();
            Ganador.JugadaGanadora = JugadaGTextBox.Text;
            Ganador.Monto = Convert.ToSingle(MontoTextBox.Text);


            if (Ganador.IdGanador > 0)
            {
                //Editando
                paso = Ganador.Modificar();
            }
            else
            {
                //Insertando
                paso = Ganador.Insertar();
            }

            if (paso)
                MessageBox.Show("Ganador Guardado.");
            else
                MessageBox.Show("Error Guardando el Ganador.");
        }
    }
}
