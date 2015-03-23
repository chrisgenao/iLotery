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
    public class Usuarios
    {
        private ConexionDb Conexion = new ConexionDb();
        
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Contra { get; set; }
        public string Mail { get; set; }
        public int Nivel { get; set; }
        public DateTime Fecha { get; set; }

        public Usuarios()
        {
            this.IdUsuario = 0;
            this.Nombre = string.Empty;
            this.Usuario = string.Empty;
            this.Contra = string.Empty;
            this.Mail = string.Empty;
            this.Nivel = 0;
            this.Fecha = DateTime.Now;
            
            
        }

        public Boolean Insertar()
        {
            this.IdUsuario = 0;

            this.IdUsuario = (int)Conexion.ObtenerValorDb("insert into Usuarios (Nombres, Usuario, Contra, Mail, Nivel, Fecha) values ('"+this.Nombre+"', '"+this.Usuario+"', '"+this.Contra+"','"+this.Mail+"',"+this.Nivel+",GETDATE())");

            return this.IdUsuario > 0;

        }

        public Boolean Modificar()
        {
            Boolean paso = false;

            paso = Conexion.EjecutarDB("Update Gastos set Nombres = '" + this.Nombre + "', Usuario ='" + this.Usuario +
                "', Contra = '" + this.Contra + ", Mail = '" + this.Mail + "', Nivel = " + this.Nivel + " where IdUsuario =" + this.IdUsuario);


            return paso;//End Modificar
        }

        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Usuarios where IdUsuario=" + IdBuscado);
        }

         public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("Nombres,Usuario", "IdUsuario=" + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;
               
                this.IdUsuario = IdBuscado;
                this.Nombre = (string)dt.Rows[0]["Nombres"];
                this.Usuario = (string)dt.Rows[0]["Usuario"];
            }

            return Encontro;
        }

         public Boolean BuscarUsuario(string UBuscado, string PwBuscada)
         {
             bool Encontro = false;
             DataTable dt = new DataTable();

             dt = this.Listar("Usuario, Contra, Nivel", "Usuario = '" + UBuscado + "' and Contra = '" + PwBuscada + "'");

             if (dt.Rows.Count == 1)
             {
                 Encontro = true;

                 this.Usuario = (string)dt.Rows[0]["Usuario"];
                 this.Contra = (string)dt.Rows[0]["Contra"];
                 this.Nivel = (Int32)dt.Rows[0]["Nivel"];
             }

             return Encontro;
         }
         
         public Boolean BuscarNivel()
         {
             bool Encontro = false;
             DataTable dt = new DataTable();

             dt = this.Listar("Usuario Nivel", "Usuario = '" + this.Usuario + "'");

             if (dt.Rows.Count == 1)
             {
                 Encontro = true;

                 this.Usuario = (string)dt.Rows[0]["Usuario"];
                 this.Nivel = (int)dt.Rows[0]["Nivel"];
             }

             return Encontro;
         }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Usuarios where " + Filtro);
        }
    }
    }

