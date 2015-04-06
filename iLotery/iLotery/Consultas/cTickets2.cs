using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLotery.Consultas
{
    public partial class cTickets2 : Form
    {
        private int datoEncontrado;

        public int DatoEncontrado
        {
            get { return datoEncontrado; }
        }
        
        public cTickets2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cTickets2_Load(object sender, EventArgs e)
        {
            
        }

        private void AcceptarButton_Click(object sender, EventArgs e)
        {
            int index;

            index = DataGridView.CurrentRow.Index;

            datoEncontrado = (int)DataGridView.CurrentRow.Cells["IdLoteria"].Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
