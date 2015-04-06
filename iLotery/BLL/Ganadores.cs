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
        public DateTime Fecha { get; set; }
        public string Loteria { get; set; }
        public string Tanda { get; set; }
        public int Primer_Lugar { get; set; }
        public int Segundo_Lugar { get; set; }
        public int Tercer_Lugar { get; set; }


        public Ganadores()
        {
            this.IdGanador = 0;
            this.Fecha = DateTime.Now;
            this.Loteria = String.Empty;
            this.Tanda = String.Empty;
            this.Primer_Lugar = 0;
            this.Segundo_Lugar = 0;
            this.Tercer_Lugar = 0;
        }

        public Boolean Insertar()
        {
            bool paso = false;

            this.IdGanador = 0;

            this.IdGanador = Convert.ToInt32(Conexion.ObtenerValorDb("insert into Ganadores (Fecha, Loteria, Tanda, Primer_Lugar, Segundo_Lugar, Tercer_Lugar) values (GETDATE(), '"+this.Loteria+"', '"+this.Tanda+"', "+this.Primer_Lugar+", "+this.Segundo_Lugar+", "+this.Tercer_Lugar+")"));
            paso = this.IdGanador > 0;

            if (paso)
            {

            }

            return paso;
        }
        
        public Boolean Modificar()
        {
            Boolean paso = false;

            paso = Conexion.EjecutarDB("Update Ganadores set Loteria = '" + this.Loteria + "', Tanda ='" + this.Tanda + "', Primer_Lugar = "+this.Primer_Lugar+", Segundo_Lugar = "+this.Tercer_Lugar+" where IdGanador =" + this.IdGanador);


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
