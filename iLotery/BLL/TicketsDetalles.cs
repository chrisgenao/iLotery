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
    public class TicketsDetalles
    {
        ConexionDb Conexion = new ConexionDb();

        public int IdTicketDetalle { get; set; }
        public DateTime Fecha { get; set; }
        
        public TicketsDetalles()
        {
            this.IdTicketDetalle = 0;
            this.Fecha = DateTime.Now;
        }

        public Boolean Insertar()
        {
            bool paso = false;

            this.IdTicketDetalle = 0;

            this.IdTicketDetalle = Convert.ToInt32(Conexion.ObtenerValorDb("insert into TicketDetalles (Fecha) values (GETDATE()) Select @@IDENTITY"));
            paso = this.IdTicketDetalle > 0;

            if (paso)
            {
            
            }
                
            return paso;
        }

        public Boolean Buscar(int IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("Fecha", "IdTicketDeatelle = " + IdBuscado);

            if (dt.Rows.Count == 1)
            {
                Encontro = true;

                this.IdTicketDetalle = IdBuscado;
                this.Fecha = (DateTime)dt.Rows[0]["Fecha"];
            }
            
            return Encontro;
        }
        
        
        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Tickets where " + Filtro);
        }
    }
}
