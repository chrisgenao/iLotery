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
using iLotery;

namespace iLotery.Window
{
    public partial class iLotery : Form
    {
        public string x { get; set; }
        public iLotery()
        {
            InitializeComponent();
            timer1.Start();
        }

        

        private void iLotery_Load(object sender, EventArgs e)
        {
            Usuarios Usuario = new Usuarios();
            Usuario.BuscarUsuario_2(x);

            if (Usuario.Nivel == 0)
            {
                usuarioToolStripMenuItem.Visible = false;
                toolStripSeparator1.Visible = false;
                usuarioToolStripMenuItem1.Visible = false;
                toolStripSeparator3.Visible = false;
                imprimirToolStripMenuItem.Visible = false;
                ganadoresToolStripMenuItem.Visible = false;
                toolStripSeparator2.Visible = false;
                loteriaToolStripMenuItem.Visible = false;
                toolStripSeparator8.Visible = false;
                
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rUsuario rUsuario = new Registros.rUsuario();
            rUsuario.ShowDialog();
        }

        private void cerrarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.AboutBox AboutB = new Window.AboutBox();
            AboutB.ShowDialog();
        }

        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rTicket rTicket = new Registros.rTicket();
            rTicket.ShowDialog();
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.cUsuarios cUsuario = new Consultas.cUsuarios();
            cUsuario.ShowDialog();
        }

        private void ticketToolStripMenuItem1_Click(object sender, EventArgs e)
        {

         Consultas.cTickets cTicket = new Consultas.cTickets();
         cTicket.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.label1.Text = dt.ToString();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            //iL
                
        }

        private void ticketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketReport.Form1 Frm = new TicketReport.Form1();
            Frm.ShowDialog();
        }

        private void separator2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loteriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rLoteria rLoteria = new Registros.rLoteria();
            rLoteria.ShowDialog();
        }

        private void ganadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rGanadores Ganador = new Registros.rGanadores();
            Ganador.ShowDialog();
            
        }

        private void ganadoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.cGanadores cGanador = new Consultas.cGanadores();
            cGanador.ShowDialog();
        }   
    }       
}           
            