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
    public partial class cTicket : Form
    {
        public cTicket()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Tickets Ticket = new Tickets();
            DataTable dt = new DataTable();
            string filtro = "1=1";
            switch (BuscarComboBox.SelectedIndex)
            {

                case 0:
                    if (BuscarTextBox.Text.Length > 0 && BuscarTextBox.Text.Length < 10){
                            filtro = "IdTicket =" + BuscarTextBox.Text;
                            dt = Ticket.Listar("IdTicket, Loteria, Tanda, Fecha, Jugada, Monto", filtro);
                            DatosGridView.DataSource = dt;

                            CantidadTextBox.Text = DatosGridView.RowCount.ToString();
                        TotalTextBox.Text = dt.Compute("Sum(Monto)", "1=1").ToString();
                       }
                    else 
                        MessageBox.Show("Por Favor Llene la Casilla.");
                        break;


                case 1:
                    if (BuscarTextBox.Text.Length > 0 && BuscarTextBox.Text.Length < 10)
                    {
                        filtro = "Loteria like '%" + BuscarTextBox.Text + "%'";
                        DatosGridView.DataSource = dt;
                        dt = Ticket.Listar("IdTicket, Loteria, Tanda, Fecha, Jugada, Monto", filtro);
                        
                        CantidadTextBox.Text = DatosGridView.RowCount.ToString();
                        TotalTextBox.Text = dt.Compute("Sum(Monto)", "1=1").ToString();
                    }
                        else
                        MessageBox.Show("Por Favor Llene la Casilla2");
                    break;
                case 2:
                   if (BuscarTextBox.Text.Length > 0 && BuscarTextBox.Text.Length < 10)
                    {
                        filtro = "Tanda like '%" + BuscarTextBox.Text + "%'";
                        DatosGridView.DataSource = dt;
                        dt = Ticket.Listar("IdTicket, Loteria, Tanda, Fecha, Jugada, Monto", filtro);

                        CantidadTextBox.Text = DatosGridView.RowCount.ToString();
                        TotalTextBox.Text = dt.Compute("Sum(Monto)", "1=1").ToString();
                    }
                        else
                        MessageBox.Show("Por Favor Llene la Casilla3");
                    break;
                case 3:
                    if (BuscarTextBox.Text.Length > 0 && BuscarTextBox.Text.Length < 80)
                    {
                        filtro = "Jugada like '%" + BuscarTextBox.Text + "%'";
                        DatosGridView.DataSource = dt;
                        dt = Ticket.Listar("IdTicket, Loteria, Tanda, Fecha, Jugada, Monto", filtro);

                        CantidadTextBox.Text = DatosGridView.RowCount.ToString();
                        TotalTextBox.Text = dt.Compute("Sum(Monto)", "1=1").ToString();
                    }
                    else
                        MessageBox.Show("Por Favor Llene la Casilla4");
                    break;
                case 4:
                    if (BuscarTextBox.Text.Length > 0 && BuscarTextBox.Text.Length < 80)
                    {
                        filtro = "Monto >=" + BuscarTextBox.Text;
                        DatosGridView.DataSource = dt;
                        dt = Ticket.Listar("IdTicket, Loteria, Tanda, Fecha, Jugada, Monto", filtro);

                        CantidadTextBox.Text = DatosGridView.RowCount.ToString();
                        TotalTextBox.Text = dt.Compute("Sum(Monto)", "1=1").ToString();
                    }
                   else
                        MessageBox.Show("Por Favor Llene la Casilla5");
                    break;
                default:
                    break;

                 }
            }
        }
    }

