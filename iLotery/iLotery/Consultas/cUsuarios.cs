﻿using System;
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
    public partial class cUsuarios : Form
    {
        //todo: Terminar cUsuarios

        private int datoEncontrado;

        public int DatoEncontrado
        {
            get { return datoEncontrado; }
        }

        public cUsuarios()
        {
            InitializeComponent();
        }

        private void cUsuarios_Load(object sender, EventArgs e)
        {
            BuscarPorComboBox.SelectedIndex = 0;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Usuarios Ticket = new Usuarios();
            DataTable dt = new DataTable();
            string filtro = "1=1";

            switch (BuscarPorComboBox.SelectedIndex)
            {

                case 0:
                    if (BuscarPorTextbox.Text.Length > 0 && BuscarPorTextbox.Text.Length < 10)
                    {
                        BuscarUsuario(BuscarPorTextbox.Text);
                    }
                    else
                        MessageBox.Show("Por Favor Llene la Casilla.");
                    break;

                //Loteria
                //Tanda
                //Jugada
                case 1:
                    if (BuscarPorTextbox.Text.Length > 0 && BuscarPorTextbox.Text.Length < 10)
                    {
                        BuscarUsuario(BuscarPorTextbox.Text);
                    }
                    else
                        MessageBox.Show("Por Favor Llene la Casilla2");
                    break;
                case 2:
                    if (BuscarPorTextbox.Text.Length > 0 && BuscarPorTextbox.Text.Length < 10)
                    {
                        BuscarUsuario(BuscarPorTextbox.Text);
                    }
                    else
                        MessageBox.Show("Por Favor Llene la Casilla3");
                    break;
                case 3:
                    if (BuscarPorTextbox.Text.Length > 0 && BuscarPorTextbox.Text.Length < 80)
                    {
                        BuscarUsuario(BuscarPorTextbox.Text);

                        }
                        else
                            MessageBox.Show("Por Favor Llene la Casilla4");
                    break;
                
                default:
                    break;

            }
        }
        public void BuscarUsuario(object o)
        {

            Usuarios Ticket = new Usuarios();
            DataTable dt = new DataTable();
            string filtro = "1=1"; 
            
            filtro = BuscarPorComboBox.SelectedItem.ToString() +" like '%" + o +"%'";
            dt = Ticket.Listar("IdUsuario,Nombres,Usuario,Mail,Nivel,Fecha", filtro);
            UsuarioGridView.DataSource = dt;

            CantidadTextBox.Text = UsuarioGridView.RowCount.ToString();

        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            int index;

            index = UsuarioGridView.CurrentRow.Index;

            datoEncontrado = (int)UsuarioGridView.CurrentRow.Cells["IdUsuario"].Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BuscarPorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
