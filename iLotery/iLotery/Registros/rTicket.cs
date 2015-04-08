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
            Loterias Loteria = new Loterias();
            DateTime h;
            h = DateTime.Now;
            HoraTextBox.Text = h.ToString();
            comboBox1.SelectedIndex = 0;
            TandaComboBox.SelectedIndex = 0;
            LoteriaComboBox.DataSource = Loteria.Listar("Loteria", "1=1");
            LoteriaComboBox.ValueMember = "Loteria";
            LoteriaComboBox.DisplayMember = "Loteria";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MontoTextBox.Text.Trim().Length == 0)
            {
                Utilitarios.ValidarTextBoxVacio(MontoTextBox, errorProvider1, "Debe Agregar un Monto.");
            }
            if (PNTextBox.Text.Trim().Length == 0)
            {
                Utilitarios.ValidarTextBoxVacio(PNTextBox, errorProvider3, "Debe Agregar una Jugada.");
            }
            if (SNTextBox.ReadOnly == false)
            {
                if (SNTextBox.Text.Trim().Length == 0)
                {

                    Utilitarios.ValidarTextBoxVacio(SNTextBox, errorProvider3, "Debe Agregar una Jugada.");
                }
            }
            if (TNTextBox.ReadOnly == false)
            {
                if (TNTextBox.Text.Trim().Length == 0)
                {
                    Utilitarios.ValidarTextBoxVacio(TNTextBox, errorProvider1, "Debe Agregar una Jugada.");
                }
            }
            if (PNTextBox.Text.Trim().Length != 0 && SNTextBox.ReadOnly == true && TNTextBox.ReadOnly == true)
            {
                TicketGridView.Rows.Add();
                TicketGridView.Rows[TicketGridView.Rows.Count - 1].Cells[0].Value = LoteriaComboBox.SelectedValue.ToString();
                TicketGridView.Rows[TicketGridView.Rows.Count - 1].Cells[1].Value = TandaComboBox.SelectedItem.ToString();
                TicketGridView.Rows[TicketGridView.Rows.Count - 1].Cells[2].Value = DateTime.Now.ToString();
                TicketGridView.Rows[TicketGridView.Rows.Count - 1].Cells[3].Value = comboBox1.SelectedItem.ToString();
                TicketGridView.Rows[TicketGridView.Rows.Count - 1].Cells[4].Value = PNTextBox.Text;
                TicketGridView.Rows[TicketGridView.Rows.Count - 1].Cells[7].Value = MontoTextBox.Text;

                Sum();
                TandaComboBox.SelectedIndex = 0;
                PNTextBox.Clear();
                MontoTextBox.Clear();
                errorProvider3.Clear();
                errorProvider1.Clear();
                errorProvider2.Clear();
            }
            else if (PNTextBox.Text.Trim().Length != 0 && SNTextBox.ReadOnly == false && TNTextBox.ReadOnly == true && SNTextBox.Text.Trim().Length != 0)
            {
                TicketGridView.Rows.Add();
                TicketGridView.Rows[TicketGridView.Rows.Count - 1].Cells[0].Value = LoteriaComboBox.SelectedValue.ToString();
                TicketGridView.Rows[TicketGridView.Rows.Count - 1].Cells[1].Value = TandaComboBox.SelectedItem.ToString();
                TicketGridView.Rows[TicketGridView.Rows.Count - 1].Cells[2].Value = DateTime.Now.ToString();
                TicketGridView.Rows[TicketGridView.Rows.Count - 1].Cells[3].Value = comboBox1.SelectedItem.ToString();
                TicketGridView.Rows[TicketGridView.Rows.Count - 1].Cells[4].Value = PNTextBox.Text;
                TicketGridView.Rows[TicketGridView.Rows.Count - 1].Cells[5].Value = SNTextBox.Text;
                TicketGridView.Rows[TicketGridView.Rows.Count - 1].Cells[7].Value = MontoTextBox.Text;
                
                Sum();
                TandaComboBox.SelectedIndex = 0;
                PNTextBox.Clear();
                MontoTextBox.Clear();
                errorProvider3.Clear();
                errorProvider1.Clear();
                errorProvider2.Clear();   
            }
            else if (PNTextBox.Text.Trim().Length != 0 && SNTextBox.ReadOnly == false && TNTextBox.ReadOnly == false && SNTextBox.Text.Trim().Length != 0 && TNTextBox.Text.Trim().Length != 0)
            {
                TicketGridView.Rows.Add();
                TicketGridView.Rows[TicketGridView.Rows.Count - 1].Cells[0].Value = LoteriaComboBox.SelectedValue.ToString();
                TicketGridView.Rows[TicketGridView.Rows.Count - 1].Cells[1].Value = TandaComboBox.SelectedItem.ToString();
                TicketGridView.Rows[TicketGridView.Rows.Count - 1].Cells[2].Value = DateTime.Now.ToString();
                TicketGridView.Rows[TicketGridView.Rows.Count - 1].Cells[3].Value = comboBox1.SelectedItem.ToString();
                TicketGridView.Rows[TicketGridView.Rows.Count - 1].Cells[4].Value = PNTextBox.Text;
                TicketGridView.Rows[TicketGridView.Rows.Count - 1].Cells[5].Value = SNTextBox.Text;
                TicketGridView.Rows[TicketGridView.Rows.Count - 1].Cells[6].Value = TNTextBox.Text;
                TicketGridView.Rows[TicketGridView.Rows.Count - 1].Cells[7].Value = MontoTextBox.Text;

                Sum();
                TandaComboBox.SelectedIndex = 0;
                PNTextBox.Clear();
                MontoTextBox.Clear();
                errorProvider3.Clear();
                errorProvider1.Clear();
                errorProvider2.Clear();
            }
        }//7
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
                Ticket.Primer_Numero = Convert.ToInt32(TicketGridView.Rows[TicketGridView.Rows.Count - x].Cells[4].Value);
                Ticket.Segundo_Numero = Convert.ToInt32(TicketGridView.Rows[TicketGridView.Rows.Count - x].Cells[5].Value);
                Ticket.Tercer_Numero = Convert.ToInt32(TicketGridView.Rows[TicketGridView.Rows.Count - x].Cells[6].Value);
                Ticket.Monto = Convert.ToSingle(TicketGridView.Rows[TicketGridView.Rows.Count - x].Cells[7].Value);
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
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
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

        private void JugadaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = DialogResult.Ignore;

            if (TicketGridView.RowCount == 0)
            {
                Consultas.cLoterias cLoteria = new Consultas.cLoterias();

                result = cLoteria.ShowDialog();

                if (result == DialogResult.OK)
                {
                //    IDTextBox.Text = cLoteria.DatoEncontrado.ToString();
                }
                else
                {
                  //  IDTextBox.Clear();
                }

//                if (Loteria.Buscar(Utilitarios.ToInt(IDTextBox.Text)))
//                {
//
//                    if (Loteria.Tanda != null && Loteria.Tanda2 == null)
//                    {
//                        IDTextBox.Text = Loteria.IdLoteria.ToString();
//                        NombreTextBox.Text = Loteria.Loteria.ToString();
//                        TardeCheckBox.Checked = true;
//                    }
//                    else if (Loteria.Tanda == null && Loteria.Tanda2 != null)
//                    {
//                        IDTextBox.Text = Loteria.IdLoteria.ToString();
//                        NombreTextBox.Text = Loteria.Loteria.ToString();
//                        NocheCheckBox.Checked = true;
//                    }
//                    else if (Loteria.Tanda != null && Loteria.Tanda2 != null)
//                    {
//                        IDTextBox.Text = Loteria.IdLoteria.ToString();
//                        NombreTextBox.Text = Loteria.Loteria.ToString();
//                        TardeCheckBox.Checked = true;
//                        NocheCheckBox.Checked = true;
//                    }
//
//                }
            }
        }

        private void BorrarButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in TicketGridView.SelectedRows)
            {
                TicketGridView.Rows.RemoveAt(item.Index);
            }
            TicketGridView.Refresh();
        }

        private void TandaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                SNTextBox.ReadOnly = true;
                TNTextBox.ReadOnly = true;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                TNTextBox.ReadOnly = true;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                SNTextBox.ReadOnly = false;
                TNTextBox.ReadOnly = false;
            }
        }

        private void SNTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TNTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || char.IsNumber(e.KeyChar))
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
