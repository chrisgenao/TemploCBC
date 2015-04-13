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
    public class Grupos
    {
        private ConexionDb Conexion = new ConexionDb();

        public int IdGrupo { get; set; }
        public string Nombre { get; set; }
        public int Monto { get; set; }

        public Grupos()
        {
            this.IdGrupo = 0;
            this.Nombre = string.Empty;

        }

        public Boolean Insertar()
        {
            bool paso = false;

            this.IdGrupo = 0;

            this.IdGrupo = Convert.ToInt32(Conexion.ObtenerValorDb("insert into Grupos (Nombre, Monto) values ('" + this.Nombre + "', "+this.Monto+") Select @@IDENTITY"));

            paso = this.IdGrupo > 0;

            if (paso)
            {

            }

            return paso;

        }

        public Boolean Modificar()
        {
            Boolean paso = false;

            paso = Conexion.EjecutarDB("Update Grupos set Nombre = '" + this.Nombre + "', Monto = "+this.Monto+" where IdGrupo =" + this.IdGrupo);


            return paso;//End Modificar
        }

        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Grupos where IdGrupo = " + IdBuscado);
        }

        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("Nombre, Monto", "IdGrupo = " + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;

                this.IdGrupo = IdBuscado;
                this.Nombre = (string)dt.Rows[0]["Nombre"];
                this.Monto = (int)dt.Rows[0]["Monto"];

            }

            return Encontro;
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Grupos where " + Filtro);
        }
    }
}

