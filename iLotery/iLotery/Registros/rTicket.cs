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

namespace iLotery.Registros
{
    public partial class rTicket : Form
    {
        public rTicket()
        {
            InitializeComponent();
        }

        DataRow dr;
        DataTable dt = new DataTable();

        private void rTicket_Load(object sender, EventArgs e)
        {
            DateTime h;
            h = DateTime.Now;
            HoraTextBox.Text = h.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= LoteriaCheckList.SelectedItems.Count - 1; i++)
            {
                TicketGridView.Rows.Add();
                TicketGridView.Rows[TicketGridView.Rows.Count - 2].Cells[0].Value = LoteriaCheckList.SelectedItem.ToString();
                TicketGridView.Rows[TicketGridView.Rows.Count - 2].Cells[1].Value = textBox1.Text;
                TicketGridView.Rows[TicketGridView.Rows.Count - 2].Cells[2].Value = HoraTextBox.Text;
                TicketGridView.Rows[TicketGridView.Rows.Count - 2].Cells[3].Value = JugadaTextBox.Text;
                TicketGridView.Rows[TicketGridView.Rows.Count - 2].Cells[4].Value = MontoTextBox.Text;
            }

            Sum();
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
            LoteriaCheckList.ClearSelected();
            JugadaTextBox.Clear();
            MontoTextBox.Clear();

        }


        //Impide que varias loterias se seleccionen a la vez.
        private void LoteriaCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && LoteriaCheckList.CheckedItems.Count > 0)
            {
                LoteriaCheckList.ItemCheck -= LoteriaCheckList_ItemCheck;
                LoteriaCheckList.SetItemChecked(LoteriaCheckList.CheckedIndices[0], false);
                LoteriaCheckList.ItemCheck += LoteriaCheckList_ItemCheck;
            }
        }

        private void TicketGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Boolean paso = false;
            Tickets Ticket = new Tickets();

            Ticket.IdTicket = Utilitarios.ToInt(IDTextBox.Text);
            Ticket.Concepto = ConceptoTextBox.Text;
            Ticket.Monto = Convert.ToSingle(MontoTextBox.Text);
            Ticket.IdCuenta = Utilitarios.ToInt(BuscarPorcomboBox.SelectedValue.ToString());
            Ticket.IdSubClas = Utilitarios.ToInt(BuscarPor2comboBox.SelectedValue.ToString());
        }
        private void Sum()
{

        float xs = TicketGridView.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToSingle(x.Cells["Monto"].Value));
            this.TotalTextBox.Text = xs.ToString("N2");
}
    }
}
