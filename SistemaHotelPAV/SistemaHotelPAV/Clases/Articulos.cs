using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SistemaHotelPAV.Clases
{
    public class Articulos
    {
        Datos objDatos = new Datos();

        private int id_art;
        private string nombre;
        private string descripcion;
        private int precioUnitario; //Defino las propiedades

        public int ID_ART
        {
            get { return id_art; }
            set { id_art = value; }
        }

        public string NOMBRE
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string DESCRIPCION
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int PRECIOUNITARIO
        {
            get { return precioUnitario; }
            set { precioUnitario = value; }
        }

        public DataTable recuperarArticulos()
        {
            return objDatos.consultar("SELECT id_art, a.nombre, descripcion, precioUnitario, t.nombre" +
                " FROM Articulos a JOIN Tipos t on a.id_tipo=t.id_tipo");
        }

        public bool validarDatosArticulos()
        {
            if (this.id_art == -1)
            {
                return false;
            }
            if (this.nombre == "")
            {
                return false;
            }
            if (this.descripcion == "")
            {
                return false;
            }
            if (this.precioUnitario == -1)
            {
                return false;
            }

            return true;
        }


        public void eliminarArticulo()
        {
            string sqlDelete = "";
            sqlDelete = "DELETE FROM Articulos WHERE id_art=" + this.id_art;
            objDatos.actualizar(sqlDelete);

        }

        public void modificarArticulo()
        {
            string SqlUpdate = "";
            SqlUpdate = @"UPDATE Articulos SET id_art='" + this.id_art + "'," +
                                            "nombre='" + this.nombre + "'," +
                                            "descripcion='" + this.descripcion + "'," +
                                            "precioUnitario=" + this.precioUnitario +
                                            " WHERE id_art=" + this.id_art;
            objDatos.actualizar(SqlUpdate);
        }

        public void guardarArticulo()
        {
            string SqlInsert = "";

            SqlInsert = @"INSERT INTO Articulos (id_art,nombre,descripcion,precioUnitario) VALUES ('" +
                this.id_art + "','" +
                this.nombre + "','" +
                this.descripcion + "'," +
                this.precioUnitario + ")";

            objDatos.actualizar(SqlInsert);
        }

        public DataTable recuperarArticuloID(int id)
        {
            return objDatos.consultar("SELECT * FROM Articulos WHERE id_art=" + id); //Recupero un articulo cuyo id sea igual al parametro
        }

    }

}