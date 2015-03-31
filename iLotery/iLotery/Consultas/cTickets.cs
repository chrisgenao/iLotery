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
            BuscarPorComboBox2.SelectedIndex = 0;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Tickets Ticket = new Tickets();
            DataTable dt = new DataTable();
            string filtro = "1=1";
            
            switch (BuscarPorComboBox2.SelectedIndex)
            {

                case 0:
                            filtro = "IdTicket >=" + FiltroTextBox2.Text;
                            dt = Ticket.Listar("IdTicket,Loteria,Tanda,Fecha,Jugada,Monto", filtro);
                            DataGridView2.DataSource = dt;

                        CantidadTextBox2.Text = DataGridView2.RowCount.ToString();
                        TotalTextBox2.Text = dt.Compute("Sum(Monto)", "1=1").ToString();
                       break;

                    //Loteria
                    //Tanda
                    //Jugada
                case 1:
                        filtro = "Loteria like '%" + FiltroTextBox2.Text+ "%'";
                        dt = Ticket.Listar("IdTicket, Loteria, Tanda, Fecha, Jugada, Monto", filtro);
                        DataGridView2.DataSource = dt;

                        CantidadTextBox2.Text = DataGridView2.RowCount.ToString();
                        TotalTextBox2.Text = dt.Compute("Sum(Monto)", "1=1").ToString();
                        break;
                case 2:
                    filtro = "Tanda like '%" + FiltroTextBox2.Text + "%'";
                        dt = Ticket.Listar("IdTicket, Loteria, Tanda, Fecha, Jugada, Monto", filtro);
                        DataGridView2.DataSource = dt;

                        CantidadTextBox2.Text = DataGridView2.RowCount.ToString();
                        TotalTextBox2.Text = dt.Compute("Sum(Monto)", "1=1").ToString();
                    break;
                
                case 3:
                            filtro = "Jugada like '%" + FiltroTextBox2.Text + "%'";
                            dt = Ticket.Listar("IdTicket, Loteria, Tanda, Fecha, Jugada, Monto", filtro);
                            DataGridView2.DataSource = dt;

                            CantidadTextBox2.Text = DataGridView2.RowCount.ToString();
                            TotalTextBox2.Text = dt.Compute("Sum(Monto)", "1=1").ToString();
                    break;
                case 4:
                        filtro = "Monto>=" + FiltroTextBox2.Text;
                        dt = Ticket.Listar("IdTicket, Loteria, Tanda, Fecha, Jugada, Monto", filtro);
                        DataGridView2.DataSource = dt;

                        CantidadTextBox2.Text = DataGridView2.RowCount.ToString();
                        TotalTextBox2.Text = dt.Compute("Sum(Monto)", "1=1").ToString();
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

        private void BuscarPorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        }
    }

