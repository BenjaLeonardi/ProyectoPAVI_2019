using System.Data;
using SistemaHotelPAV.Entities;

namespace SistemaHotelPAV.DataAccessLayer {
    class ArticuloDA {
        Datos objDatos = new Datos();

        public DataRow recuperarArticuloCompletoPorID(int idArticulo) {
            return objDatos.consultar("SELECT id_art, a.nombre, descripcion, precioUnitario, t.nombre " +
                "FROM Articulos a JOIN Tipos t on a.id_tipo=t.id_tipo " +
                "WHERE id_art=" + idArticulo).Rows[0];
        }

        public DataTable recuperarArticulos() {
            return objDatos.consultar("SELECT id_art, a.nombre, descripcion, precioUnitario, t.nombre" +
                " FROM Articulos a JOIN Tipos t on a.id_tipo=t.id_tipo");
        }

        public enum ValidacionArticulo { exito, id, nombre, descripcion, preciounitario }

        public ValidacionArticulo ValidarDatosArticulo(Articulo articulo)
        {
            if (articulo.ID_ART == -1) {
                return ValidacionArticulo.id;
            }
            if (articulo.NOMBRE == "") {
                return ValidacionArticulo.nombre;
            }
            if (articulo.DESCRIPCION == "") {
                return ValidacionArticulo.descripcion;
            }
            if (articulo.PRECIOUNITARIO <= 0) {
                return ValidacionArticulo.preciounitario;
            }

            return ValidacionArticulo.exito;
        }

        public void eliminarArticulo(Articulo articulo) {
            string sqlDelete = "";
            sqlDelete = "DELETE FROM Articulos WHERE id_art=" + articulo.ID_ART;
            objDatos.actualizar(sqlDelete);

        }

        public void modificarArticulo(Articulo articulo) {
            string SqlUpdate = "";
            SqlUpdate = @"UPDATE Articulos SET id_art='" + articulo.ID_ART + "'," +
                                            "nombre='" + articulo.NOMBRE + "'," +
                                            "descripcion='" + articulo.DESCRIPCION + "'," +
                                            "precioUnitario=" + articulo.PRECIOUNITARIO +
                                            " WHERE id_art=" + articulo.ID_ART;
            objDatos.actualizar(SqlUpdate);
        }

        public void guardarArticulo(Articulo articulo) {
            string SqlInsert = "";

            SqlInsert = @"INSERT INTO Articulos (id_art,nombre,descripcion,precioUnitario) VALUES ('" +
                articulo.ID_ART + "','" +
                articulo.NOMBRE + "','" +
                articulo.DESCRIPCION + "'," +
                articulo.PRECIOUNITARIO + ")";

            objDatos.actualizar(SqlInsert);
        }

        public DataTable recuperarArticuloID(int id) {
            return objDatos.consultar("SELECT * FROM Articulos WHERE id_art=" + id); //Recupero un articulo cuyo id sea igual al parametro
        }
    }
}
