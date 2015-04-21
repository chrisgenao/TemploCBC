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
    public class Ingresos
    {
        private ConexionDb Conexion = new ConexionDb();

        public int IdIngreso { get; set; }
        public int IdPersona { get; set; }
        public string NombrePersona { get; set; }
        public int Monto { get; set; }
        public DateTime Fecha { get; set; }

        public Ingresos()
        {
            this.IdIngreso = 0;
            this.IdPersona = 0;
            this.NombrePersona = string.Empty;
            this.Monto = 0;
            this.Fecha = DateTime.Today;
        }

        public Boolean Insertar(int IdPersona, string NombrePersona, double Monto)
        {
            bool paso = false;

            this.IdIngreso = 0;

            this.IdIngreso = Convert.ToInt32(Conexion.ObtenerValorDb("insert into Ingresos (IdPersona, NombrePersona, Monto, Fecha) values (" + IdPersona + ",'" + NombrePersona + "', " + Monto + ", GETDATE()) Select @@IDENTITY"));

            paso = this.IdIngreso > 0;

            if (paso)
            {

            }

            return paso;

        }

        public Boolean Modificar()
        {
            Boolean paso = false;
            //Terminar de aqui hacia abajo.
            paso = Conexion.EjecutarDB("Update Ingresos set Nombre = '" + this.NombrePersona + "' where IdIngreso =" + this.IdIngreso);


            return paso;//End Modificar
        }

        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Ingresos where IdIngreso = " + IdBuscado);
        }

        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("NombrePersona", "IdIngreso = " + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;

                this.IdIngreso = IdBuscado;
                this.NombrePersona = (string)dt.Rows[0]["NombrePersona"];
            }

            return Encontro;
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Ingresos where " + Filtro);
        }
        
    }
}
