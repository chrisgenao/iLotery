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
            
            switch (BuscarPorComboBox.SelectedIndex)
            {

                case 0:
                    if (FiltroTextBox.Text.Length > 0 && FiltroTextBox.Text.Length < 10){
                            filtro = "IdTicket >=" + FiltroTextBox.Text;
                            dt = Ticket.Listar("IdTicket,Loteria,Tanda,Fecha,Jugada,Monto", filtro);
                            DataGridView.DataSource = dt;

                        CantidadTextBox.Text = DataGridView.RowCount.ToString();
                        TotalTextBox.Text = dt.Compute("Sum(Monto)", "1=1").ToString();
                       }
                    else 
                        MessageBox.Show("Por Favor Llene la Casilla.");
                        break;

                    //Loteria
                    //Tanda
                    //Jugada
                case 1:
                    if (FiltroTextBox.Text.Length > 0 && FiltroTextBox.Text.Length < 10)
                    {
                        filtro = "Loteria like '%" + FiltroTextBox.Text+ "%'";
                        dt = Ticket.Listar("IdTicket, Loteria, Tanda, Fecha, Jugada, Monto", filtro);
                        DataGridView.DataSource = dt;

                        CantidadTextBox.Text = DataGridView.RowCount.ToString();
                        TotalTextBox.Text = dt.Compute("Sum(Monto)", "1=1").ToString();
                    }
                        else
                        MessageBox.Show("Por Favor Llene la Casilla2");
                    break;
                case 2:
                    if (FiltroTextBox.Text.Length > 0 && FiltroTextBox.Text.Length < 10)
                    {
                        filtro = "Tanda like '%" + FiltroTextBox.Text + "%'";
                        dt = Ticket.Listar("IdTicket, Loteria, Tanda, Fecha, Jugada, Monto", filtro);
                        DataGridView.DataSource = dt;

                        CantidadTextBox.Text = DataGridView.RowCount.ToString();
                        TotalTextBox.Text = dt.Compute("Sum(Monto)", "1=1").ToString();
                    }
                        else
                        MessageBox.Show("Por Favor Llene la Casilla3");
                    break;
                case 3:
                    if (FiltroTextBox.Text.Length > 0 && FiltroTextBox.Text.Length < 80)
                        if (FiltroTextBox.Text.Length > 0 && FiltroTextBox.Text.Length < 10)
                        {
                            filtro = "Jugada like '%" + FiltroTextBox.Text + "%'";
                            dt = Ticket.Listar("IdTicket, Loteria, Tanda, Fecha, Jugada, Monto", filtro);
                            DataGridView.DataSource = dt;

                            CantidadTextBox.Text = DataGridView.RowCount.ToString();
                            TotalTextBox.Text = dt.Compute("Sum(Monto)", "1=1").ToString();
                        }
                    else
                        MessageBox.Show("Por Favor Llene la Casilla4");
                    break;
                case 4:
                    if (FiltroTextBox.Text.Length > 0 && FiltroTextBox.Text.Length < 80)
                    {
                        filtro = "Monto>=" + FiltroTextBox.Text;
                        dt = Ticket.Listar("IdTicket, Loteria, Tanda, Fecha, Jugada, Monto", filtro);
                        DataGridView.DataSource = dt;

                        CantidadTextBox.Text = DataGridView.RowCount.ToString();
                        TotalTextBox.Text = dt.Compute("Sum(Monto)", "1=1").ToString();
                    }
                   else
                        MessageBox.Show("Por Favor Llene la Casilla5");
                    break;

                default:
                    break;

                 }
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

        
        }
    }

