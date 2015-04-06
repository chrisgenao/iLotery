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
    public partial class cGanadores : Form
    {
        public cGanadores()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BuscarPorTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cGanadores_Load(object sender, EventArgs e)
        {
            BuscarPorComboBox.SelectedIndex = 0;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Ganadores Ganador = new Ganadores();
            DataTable dt = new DataTable();
            string filtro = "1=1";

            if (BuscarPorComboBox.SelectedIndex == 0) //IdLoteria
            {
                if (BuscarPorTextBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {
                    filtro = "IdGanador = " + BuscarPorTextBox.Text;
                }
            }

            else if (BuscarPorComboBox.SelectedIndex == 1) //Loteria
                if (BuscarPorComboBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {

                    filtro = "Loteria like '%" + BuscarPorComboBox.Text + "%'";
                }
            else if (BuscarPorComboBox.SelectedIndex == 2) // Tanda
                if (BuscarPorComboBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {

                    filtro = "Tanda like '%" + BuscarPorComboBox.Text + "%'";
                }
            else if (BuscarPorComboBox.SelectedIndex == 3) //Primer Lugar
                if (BuscarPorComboBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {

                    filtro = "Primer_Lugar = " + BuscarPorComboBox.Text;
                }
            else if (BuscarPorComboBox.SelectedIndex == 4) //Segundo Lugar
                if (BuscarPorComboBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {

                    filtro = "Segundo_Lugar = " + BuscarPorComboBox.Text;
                }
            else if (BuscarPorComboBox.SelectedIndex == 5) //Tercer Lugar
                if (BuscarPorComboBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {

                    filtro = "Tercer_Lugar = " + BuscarPorComboBox.Text;
                }
            else if (BuscarPorComboBox.SelectedIndex == 6) //Monto
                if (BuscarPorComboBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {

                    filtro = "Monto =" + BuscarPorComboBox.Text;
                }

            dt = Ganador.Listar("IdLoteria, Loteria, Tanda, Tanda2", filtro);
            DataGridView.DataSource = dt;
            CantidadTextBox.Text = DataGridView.RowCount.ToString();
        }

        private void BuscarPorTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
