﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class Tickets
    {
        private ConexionDb Conexion = new ConexionDb();

        public int IdTicket { get; set; }
        public int IdTicketDetalle { get; set; }
        public string Loteria { get; set; }
        public string Tanda { get; set; }
        public DateTime Fecha { get; set; }
        public string Jugada { get; set; }
        public int Primer_Numero { get; set; }
        public int Segundo_Numero { get; set; }
        public int Tercer_Numero { get; set; }
        public float Monto { get; set; }
        

        public Tickets()
        {
            this.IdTicket = 0;
            this.IdTicketDetalle = 0;
            this.Loteria = string.Empty;
            this.Tanda = string.Empty;
            this.Fecha = DateTime.Now;
            this.Jugada = string.Empty;
            this.Primer_Numero = 0;
            this.Segundo_Numero = 0;
            this.Tercer_Numero = 0;
            this.Monto = 0;
        }
                public Boolean Insertar(int x)
        {
            //this.IdTicket = 0;

            //this.IdTicket = (int)Conexion.ObtenerValorDb("Insert into Tickets (Loteria, Tanda, Fecha, Jugada, Monto) values ('" + this.Loteria + "', '" + this.Tanda + "', GETDATE(),'" + this.Jugada + "'," + this.Monto + ")");

           // return this.IdTicket > 0;
          return  Conexion.EjecutarDB("Insert into Tickets (IdTicketDetalle, Loteria, Tanda, Fecha, Jugada, Primer_Numero, Segundo_Numero, Tercer_Numero, Monto) values ("+x+", '" + this.Loteria + "', '" + this.Tanda + "', GETDATE(),'" + this.Jugada + "', "+this.Primer_Numero+", "+this.Segundo_Numero+", "+this.Tercer_Numero+", "+ this.Monto + ")");

        }

        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Tickets where IdTicket =" + IdBuscado);
        }

        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("IdUsuario, Loteria", "IdUsuario=" + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;

                this.IdTicket = IdBuscado;
                this.IdTicketDetalle = (int)dt.Rows[0]["IdTicketDetalle"];
                this.Loteria = (string)dt.Rows[0]["Loteria"];
                this.Tanda = (string)dt.Rows[0]["Tanda"];
                this.Fecha = (DateTime)dt.Rows[0]["Fecha"];
                this.Jugada = (string)dt.Rows[0]["Jugada"];
                this.Primer_Numero = (int)dt.Rows[0]["Primer_Numero"];
                this.Segundo_Numero = (int)dt.Rows[0]["Segundo_Numero"];
                this.Tercer_Numero = (int)dt.Rows[0]["Tercer_Numero"];
                this.Monto = (float)dt.Rows[0]["Monto"];
            }

            return Encontro;
        }

        //public Boolean BuscarUsuario(string UBuscado, string PwBuscada)
        //{
        //    bool Encontro = false;
        //    DataTable dt = new DataTable();
        //
        //    dt = this.Listar("Usuario, Contra", "Usuario = '" + UBuscado + "' and Contra = '" + PwBuscada + "'");
        //
        //    if (dt.Rows.Count == 1)
        //    {
        //        Encontro = true;
        //
        //        this.Usuario = (string)dt.Rows[0]["Usuario"];
        //        this.Contra = (string)dt.Rows[0]["Contra"];
        //    }
        //
        //    return Encontro;
        //}

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Tickets where IdTicket= " + Filtro);
        }

        public DataTable ListarTickets(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Tickets where IdTicketDetalle= " + Filtro);
        }
    }
}

