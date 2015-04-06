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
            Usuarios Usuario = new Usuarios();
            DataTable dt = new DataTable();
            string filtro = "1=1";

            if (BuscarPorComboBox.SelectedIndex == 0) //IdUsuario
            {
                if (BuscarPorTextBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {
                    filtro = "IdUsuario = " + BuscarPorTextBox.Text;
                }
            }


            else if (BuscarPorComboBox.SelectedIndex == 1) //Nombres
                if (BuscarPorComboBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {

                    filtro = "Nombres like '%" + BuscarPorTextBox.Text + "%'";
                }
            else if (BuscarPorComboBox.SelectedIndex == 2) // Usuario
                if (BuscarPorComboBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {

                    filtro = "Usuario like '%" + BuscarPorTextBox.Text + "%'";
                }
            else if (BuscarPorComboBox.SelectedIndex == 3) //Mail
                if (BuscarPorComboBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {

                    filtro = "Mail like '%" + BuscarPorTextBox.Text + "%'";
                }
            else if (BuscarPorComboBox.SelectedIndex == 4) //Nivel
                if (BuscarPorComboBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {

                    filtro = "Nivel = " + BuscarPorTextBox.Text;
                }
            else if (BuscarPorComboBox.SelectedIndex == 5) //Tercer Lugar
                if (BuscarPorComboBox.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {

                    filtro = "Tercer_Lugar = " + BuscarPorTextBox.Text;
                }

                dt = Usuario.Listar("IdUsuario, Nombres, Usuario, Contra, Mail, Nivel, Fecha", filtro);
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
