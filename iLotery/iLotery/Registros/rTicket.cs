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
using CrystalDecisions.CrystalReports.Engine;

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

        private void rTicket_Load(object sender, EventArgs e)
        {
            DateTime h;
            h = DateTime.Now;
            HoraTextBox.Text = h.ToString();
            LoteriaComboBox.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MontoTextBox.Text.Trim().Length == 0)
            {
                Utilitarios.ValidarTextBoxVacio(MontoTextBox, errorProvider1, "Debe Agregar un Monto.");
            }
            if (TandaTextBox.Text.Trim().Length == 0)
            {
                Utilitarios.ValidarTextBoxVacio(TandaTextBox, errorProvider2, "Debe Agregar una Tanda.");
            }
            if (JugadaTextBox.Text.Trim().Length == 0)
            {
                Utilitarios.ValidarTextBoxVacio(JugadaTextBox, errorProvider3, "Debe Agregar una Jugada.");
            }
            else
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
                errorProvider3.Clear();
                errorProvider1.Clear();
                errorProvider2.Clear();
            }
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

            //todo: imprima tickets.

           // DataSet ds = new DataSet();
           // int filas = TicketGridView.Rows.Count;
           // for (int i = 0; i <= filas - 2; i++ )
           // {
           //     ds.Tables[0].Rows.Add
           //         (new object[] {TicketGridView[0, i].Value.ToString(),
           //                        TicketGridView[1, i].Value.ToString(),
           //                        TicketGridView[3, i].Value.ToString(),
           //                        TicketGridView[4, i].Value.ToString()                  
           //         });
           // }
           // ds.Tables.Add(dt);
           // ds.WriteXmlSchema("ImprimirTicket.xml");
           // ReportDocument oRe = new ReportDocument();
           // Imprimir.iTickets iT = new Imprimir.iTickets();
           // oRe.SetDataSource(tds);
           // iT.crystalReportViewer1.ReportSource = oRe;
           // iT.crystalReportViewer1.Refresh();
           // iT.Show();
           // TicketGridView.Rows.Clear();
           // JugadaTextBox.Clear();
           // MontoTextBox.Clear();
        }

        
        private void TicketGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

            //ExportarDataGridViewExcel(TicketGridView);

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

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        //Metodos:
        public void ExportarDataGridViewExcel(DataGridView grd)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //Recorremos el DataGridView rellenando la hoja de trabajo
                int x = grd.Rows.Count;

                for (int i = 0; i < grd.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < grd.Columns.Count; j++)
                    {
                        foreach (DataGridViewRow DataGrid in grd.Rows)
                        {

                            hoja_trabajo.Cells[i + 1, j + 1] = TicketGridView.Rows[TicketGridView.Rows.Count - x].Cells[0].Value;
                            hoja_trabajo.Cells[i + 1, j + 1] = TicketGridView.Rows[TicketGridView.Rows.Count - x].Cells[1].Value;
                            hoja_trabajo.Cells[i + 1, j + 1] = TicketGridView.Rows[TicketGridView.Rows.Count - x].Cells[3].Value;
                            hoja_trabajo.Cells[i + 1, j + 1] = TicketGridView.Rows[TicketGridView.Rows.Count - x].Cells[4].Value;
                            x--;
                        }
                    }
                }


                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }
    }
}
