using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TicketReport;

namespace iLotery.Registros
{
    public partial class rTicket : Form
    {
        public rTicket()
        {
            InitializeComponent();
        }
       // DataRow dr;
        DataTable dt = new DataTable();
        DateTime h = DateTime.Now;
        private void rTicket_Load(object sender, EventArgs e)
        {
            LoteriaComboBox.SelectedIndex = 0;
            HoraTextBox.Text = h.ToString();
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
                TicketGridView.Rows.Add();
                TicketGridView.Rows[TicketGridView.Rows.Count - 1].Cells[0].Value = LoteriaComboBox.SelectedItem.ToString();
                TicketGridView.Rows[TicketGridView.Rows.Count - 1].Cells[1].Value = TandaTextBox.Text;
                TicketGridView.Rows[TicketGridView.Rows.Count - 1].Cells[2].Value = HoraTextBox.Text;
                TicketGridView.Rows[TicketGridView.Rows.Count - 1].Cells[3].Value = JugadaTextBox.Text;
                TicketGridView.Rows[TicketGridView.Rows.Count - 1].Cells[4].Value = MontoTextBox.Text;

            Sum();
            TandaTextBox.Clear();
            JugadaTextBox.Clear();
            MontoTextBox.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TicketGridView.Rows.RemoveAt(TicketGridView.Rows.Count - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TicketGridView.Rows.Clear();
            JugadaTextBox.Clear();
            MontoTextBox.Clear();
           TicketReport.Form1 TR = new TicketReport.Form1();
            TR.Show();
        }



        private void TicketGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Boolean paso = false;
            Tickets Ticket = new Tickets();
            int x = 1;
                foreach (DataGridViewRow DataGrid in TicketGridView.Rows)
                {
                    
                    Ticket.Loteria = (string)TicketGridView.Rows[TicketGridView.Rows.Count - x].Cells[0].Value;
                    Ticket.Tanda = (string)TicketGridView.Rows[TicketGridView.Rows.Count - x].Cells[1].Value;
                    Ticket.Jugada = (string)TicketGridView.Rows[TicketGridView.Rows.Count - x].Cells[3].Value;
                    Ticket.Monto = Convert.ToSingle(TicketGridView.Rows[TicketGridView.Rows.Count - x].Cells[4].Value);
                    x++;
                    paso = true;

                    Ticket.Insertar();
                }
            

               if (paso)
               {
                   MessageBox.Show("Ticket Guardado.");
               }
               else
               {
                   MessageBox.Show("Ha Ocurrido un Error Guardando el Ticket.");
               }
           }            
           
        
        private void Sum()
{

        float xs = TicketGridView.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToSingle(x.Cells["Monto"].Value));
            TotalTextBox.Text = xs.ToString("N2");
}

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void LoteriaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MontoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar==8)
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
