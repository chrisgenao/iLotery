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
    public partial class cGanadores : Form
    {
        public cGanadores()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BuscarPorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8 || char.IsLetter(e.KeyChar) || e.KeyChar == 45)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cGanadores_Load(object sender, EventArgs e)
        {
            BuscarPorComboBox.SelectedIndex = 0;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Ganadores Ganador = new Ganadores();
            DataTable dt = new DataTable();
            string filtro = "1=1";

            switch (BuscarPorComboBox.SelectedIndex)
            {

                case 0:
                        filtro = "IdGanador >=" + BuscarPorTextBox.Text;
                        dt = Ganador.Listar("IdGanador,Nombre,Apellido,Telefono,LoteriaG,JugadaG,MontoG,Fecha", filtro);
                        DataGridView.DataSource = dt;

                        CantidadTextBox.Text = DataGridView.RowCount.ToString();
                        TotalTextBox.Text = dt.Compute("Sum(MontoG)", "1=1").ToString();
                    break;

                case 1:
                        filtro = "Nombre like '%" + BuscarPorTextBox.Text + "%'";
                        dt = Ganador.Listar("IdGanador,Nombre,Apellido,Telefono,LoteriaG,JugadaG,MontoG,Fecha", filtro);
                        DataGridView.DataSource = dt;

                        CantidadTextBox.Text = DataGridView.RowCount.ToString();
                        TotalTextBox.Text = dt.Compute("Sum(MontoG)", "1=1").ToString();
                    
                    break;
                case 2:
                    
                        filtro = "Apellido like '%" + BuscarPorTextBox.Text + "%'";
                        dt = Ganador.Listar("IdGanador,Nombre,Apellido,Telefono,LoteriaG,JugadaG,MontoG,Fecha", filtro);
                        DataGridView.DataSource = dt;

                        CantidadTextBox.Text = DataGridView.RowCount.ToString();
                        TotalTextBox.Text = dt.Compute("Sum(MontoG)", "1=1").ToString();
                    break;
                case 3:
                            filtro = "LoteriaG like '%" + BuscarPorTextBox.Text + "%'";
                            dt = Ganador.Listar("IdGanador,Nombre,Apellido,Telefono,LoteriaG,JugadaG,MontoG,Fecha", filtro);
                            DataGridView.DataSource = dt;

                            CantidadTextBox.Text = DataGridView.RowCount.ToString();
                            TotalTextBox.Text = dt.Compute("Sum(MontoG)", "1=1").ToString();
                    break;
                case 4:
                        filtro = "JugadaG like '%" + BuscarPorTextBox.Text + "%'";
                        dt = Ganador.Listar("IdGanador,Nombre,Apellido,Telefono,LoteriaG,JugadaG,MontoG,Fecha", filtro);
                        DataGridView.DataSource = dt;

                        CantidadTextBox.Text = DataGridView.RowCount.ToString();
                        TotalTextBox.Text = dt.Compute("Sum(MontoG)", "1=1").ToString();
                    
                        break;
                case 5:
                        filtro = "Monto>=" + BuscarPorTextBox.Text;
                        dt = Ganador.Listar("IdGanador,Nombre,Apellido,Telefono,LoteriaG,JugadaG,MontoG,Fecha", filtro);
                        DataGridView.DataSource = dt;

                        CantidadTextBox.Text = DataGridView.RowCount.ToString();
                        TotalTextBox.Text = dt.Compute("Sum(MontoG)", "1=1").ToString();
                    break;

                default:
                    break;

            }
        }

        private void BuscarPorTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}