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

namespace iLotery.Consultas
{
    public partial class cLoterias : Form
    {
        private int datoEncontrado;

        public int DatoEncontrado
        {
            get { return datoEncontrado; }
        }

        public cLoterias()
        {
            InitializeComponent();
        }

        private void cLoterias_Load(object sender, EventArgs e)
        {
            BuscarPorComboBox.SelectedIndex = 0;
        }

        private void FiltroTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8 || char.IsLetter(e.KeyChar) || e.KeyChar == 45)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void FiltroTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Loterias Loteria = new Loterias();
            DataTable dt = new DataTable();
            string filtro = "1=1";

            if (BuscarPorComboBox.SelectedIndex == 0) //IdLoteria
            {
                if (FiltroTextBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {
                    filtro = "IdLoteria = " + FiltroTextBox.Text;
                }
            }

            else if (BuscarPorComboBox.SelectedIndex == 1) //Loteria
                if (FiltroTextBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {

                    filtro = "Loteria like '%" + FiltroTextBox.Text + "%'";
                }
            else if (BuscarPorComboBox.SelectedIndex == 2) // Tanda
                if (FiltroTextBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {

                    filtro = "Tanda like '%" + FiltroTextBox.Text + "%'";
                }
            else if (BuscarPorComboBox.SelectedIndex == 3) //Tanda2
                if (FiltroTextBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {

                    filtro = "Tanda2 like '%" + FiltroTextBox.Text + "%'";
                }
            
            dt = Loteria.Listar("IdLoteria, Loteria, Tanda, Tanda2", filtro);
            DataGridView.DataSource = dt;
            CantidadTextBox.Text = DataGridView.RowCount.ToString();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            int index;

            index = DataGridView.CurrentRow.Index;

            datoEncontrado = (int)DataGridView.CurrentRow.Cells["IdLoteria"].Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}