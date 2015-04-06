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
    public partial class cTickets : Form
    {
        public cTickets()
        {
            InitializeComponent();
        }
        
        private void cTickets_Load(object sender, EventArgs e)
        {
            BuscarPorComboBox.SelectedIndex = 0;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Tickets Ticket = new Tickets();
            DataTable dt = new DataTable();
            string filtro = "1=1";

            if (BuscarPorComboBox.SelectedIndex == 0) //IdTicket
            {
                if (BuscarPorTextBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {
                    filtro = "IdTicket = " + BuscarPorTextBox.Text;
                }
            }

            else if (BuscarPorComboBox.SelectedIndex == 1) //Loteria
                if (BuscarPorTextBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {

                    filtro = "Loteria like '%" + BuscarPorTextBox.Text + "%'";
                }
            else if (BuscarPorComboBox.SelectedIndex == 2) // Tanda
                if (BuscarPorTextBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {

                    filtro = "Tanda like '%" + BuscarPorTextBox.Text + "%'";
                }
            else if (BuscarPorComboBox.SelectedIndex == 3) //Jugada
                if (BuscarPorTextBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {

                    filtro = "Jugada like '%" + BuscarPorTextBox.Text + "%'";
                }
            else if (BuscarPorComboBox.SelectedIndex == 4) //Primer_Lugar
                if (BuscarPorTextBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {

                    filtro = "Primer_Numero = " + BuscarPorTextBox.Text;
                }
            else if (BuscarPorComboBox.SelectedIndex == 5) //Segundo_Lugar
                if (BuscarPorTextBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {

                    filtro = "Segundo_Numero =" + BuscarPorTextBox.Text;
                }
            else if (BuscarPorComboBox.SelectedIndex == 6) //Tercer_Lugar
                if (BuscarPorTextBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {

                    filtro = "Tercer_Numero =" + BuscarPorTextBox.Text;
                }
            dt = Ticket.Listar("IdTicket, Loteria, Tanda, Fecha, Jugada, Primer_Numero, Segundo_Numero, Tercer_Numero, Monto", filtro);
            TicketGridView.DataSource = dt;
            CantidadTextBox.Text = TicketGridView.RowCount.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FiltroTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BuscarPorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        }
    }

