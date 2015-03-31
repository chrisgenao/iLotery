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

                switch (BuscarPorComboBox.SelectedIndex)
                {

                    case 0:
                        if (FiltroTextBox.Text.Length > 0 && FiltroTextBox.Text.Length < 10)
                        {
                            filtro = "IdLoteria >=" + FiltroTextBox.Text;
                            dt = Loteria.Listar("IdLoteria, Loteria, Tanda", filtro);
                            DataGridView.DataSource = dt;

                            CantidadTextBox.Text = DataGridView.RowCount.ToString();
                        }
                        else
                            MessageBox.Show("Por Favor Llene la Casilla.");
                        break;

                    case 1:
                        if (FiltroTextBox.Text.Length > 0 && FiltroTextBox.Text.Length < 10)
                        {
                            filtro = "Loteria like '%" + FiltroTextBox.Text + "%'";
                            dt = Loteria.Listar("IdLoteria, Loteria, Tanda", filtro);
                            DataGridView.DataSource = dt;

                            CantidadTextBox.Text = DataGridView.RowCount.ToString();
                        }
                        else
                            MessageBox.Show("Por Favor Llene la Casilla2");
                        break;
                    case 2:
                        if (FiltroTextBox.Text.Length > 0 && FiltroTextBox.Text.Length < 10)
                        {
                            filtro = "Tanda like '%" + FiltroTextBox.Text + "%'";
                            dt = Loteria.Listar("IdLoteria, Loteria, Tanda", filtro);
                            DataGridView.DataSource = dt;

                            CantidadTextBox.Text = DataGridView.RowCount.ToString();
                        }
                        else
                            MessageBox.Show("Por Favor Llene la Casilla3");
                        break;
                    default:
                        break;

                }
            }
        }
    }
