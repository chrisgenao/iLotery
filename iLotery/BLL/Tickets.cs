using System;
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
        public string Loteria { get; set; }
        public string Tanda { get; set; }
        public DateTime Fecha { get; set; }
        public string Jugada { get; set; }
        public float Monto { get; set; }


        public Tickets()
        {
            this.IdTicket = 0;
            this.Loteria = string.Empty;
            this.Tanda = string.Empty;
            this.Fecha = DateTime.Now;
            this.Jugada = string.Empty;
            this.Monto = 0;
        }
                public Boolean Insertar()
        {
            //this.IdTicket = 0;

            //this.IdTicket = (int)Conexion.ObtenerValorDb("Insert into Tickets (Loteria, Tanda, Fecha, Jugada, Monto) values ('" + this.Loteria + "', '" + this.Tanda + "', GETDATE(),'" + this.Jugada + "'," + this.Monto + ")");

           // return this.IdTicket > 0;
          return  Conexion.EjecutarDB("Insert into Tickets (Loteria, Tanda, Fecha, Jugada, Monto) values ('" + this.Loteria + "', '" + this.Tanda + "', GETDATE(),'" + this.Jugada + "'," + this.Monto + ")");

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
                this.Loteria = (string)dt.Rows[0]["Loteria"];
                this.Tanda = (string)dt.Rows[0]["Tanda"];
                this.Fecha = (DateTime)dt.Rows[0]["Fecha"];
                this.Jugada = (string)dt.Rows[0]["Jugada"];
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
            return Conexion.BuscarDb("Select " + campos + " from Tickets where " + Filtro);
        }
    }
}

