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
using BLL;

namespace iLotery.Window
{
    public partial class iLotery : Form
    {
        public iLotery()
        {
            InitializeComponent();
        }

        

        private void iLotery_Load(object sender, EventArgs e)
        {
            Usuarios Usuario = new Usuarios();
            int x = 0;
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rUsuario rUsuario = new Registros.rUsuario();
            rUsuario.Show();
        }

        private void cerrarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.AboutBox AboutB = new Window.AboutBox();
            AboutB.Show();
        }

        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rTicket rTicket = new Registros.rTicket();
            rTicket.Show();
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           //Todo: comprobacion de que nivel es
            //Usuarios Usuario = new Usuarios();
            //
            //if (Usuario.Nivel == 1)
            //{
            //    MessageBox.Show("Funciono");
            //}
            //else
            //{
            //    MessageBox.Show("No Funciono");
            //}

        }

        private void ticketToolStripMenuItem1_Click(object sender, EventArgs e)
        {

         Consultas.cTickets cTicket = new Consultas.cTickets();
         cTicket.Show();
        }   
    }       
}           
            