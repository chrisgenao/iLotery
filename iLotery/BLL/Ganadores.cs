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
    public class Ganadores
    {
        ConexionDb Conexion = new ConexionDb();

        public int IdGanador { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string LoteriaGanadora { get; set; }
        public string JugadaGanadora { get; set; }
        public DateTime Fecha { get; set; }
        public float Monto { get; set; }


        public Ganadores()
        {
            this.IdGanador = 0;
            this.Nombre = String.Empty;
            this.Apellido = String.Empty;
            this.Telefono = String.Empty;
            this.LoteriaGanadora = String.Empty;
            this.JugadaGanadora = String.Empty;
            this.Fecha = DateTime.Now;
            this.Monto = 0;
        }

        public Boolean Insertar()
        {
            bool paso = false;

            this.IdGanador = 0;

            this.IdGanador = Convert.ToInt32(Conexion.ObtenerValorDb("insert into Ganadores (Nombre, Apellido, Telefono, LoteriaG, JugadaG, MontoG, Fecha) values ('" + this.Nombre + "', '" + this.Apellido + "', '" + this.Telefono + "', '" + this.LoteriaGanadora + "', '" + this.JugadaGanadora + "', " + this.Monto + ", GETDATE()) Select @@IDENTITY"));

            paso = this.IdGanador > 0;

            if (paso)
            {

            }

            return paso;
        }
        
        public Boolean Modificar()
        {
            Boolean paso = false;

            paso = Conexion.EjecutarDB("Update Ganadores set Nombre = '" + this.Nombre + "', Apellido ='" + this.Apellido + "', Telefono ='"+this.Telefono+"', LoteriaG='"+this.LoteriaGanadora+"', JugadaG = '"+this.JugadaGanadora+"', Monto = '"+this.Monto+"' where IdGanador =" + this.IdGanador);


            return paso;//End Modificar
        }
        
        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Ganadores where IdGanador=" + IdBuscado);
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Ganadores where " + Filtro);
        }
    }
}
