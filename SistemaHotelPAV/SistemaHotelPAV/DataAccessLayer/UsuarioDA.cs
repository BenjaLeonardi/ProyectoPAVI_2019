using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaHotelPAV.Entities;
using System.Data;

namespace SistemaHotelPAV.DataAccessLayer
{
    class UsuarioDA
    {
        Datos objDatos = new Datos();

        public DataTable recuperarUsuarios()
        {
            return objDatos.consultar("SELECT u.id_usu, u.usuario, u.password, u.apellido, u.nombre, u.nroDni, u.fechaNac, u.calle, u.nroCalle, b.nombre" +
                " FROM Usuarios u JOIN Barrios b on u.id_barrio=b.id_barrio");
        }

        public DataTable recuperarUsuarioID(int id)
        {
            return objDatos.consultar("SELECT * FROM Usuarios WHERE id_usu=" + id);
        }

        public void eliminarUsuario(Usuarios usuario)
        {
            string sqlDelete = "";
            sqlDelete = "DELETE FROM Usuarios WHERE id_usu=" + usuario.Id_usu;
            objDatos.actualizar(sqlDelete);

        }

        public void editarUsuario(Usuarios usuario)
        {
            string SqlUpdate = "";
            SqlUpdate = @"UPDATE Usuarios SET id_usu='" + usuario.Id_usu + "'," +
                                            "usuario='" + usuario.Usuario + "'," +
                                            "password='" + usuario.Password + "'," +
                                            "apellido='" + usuario.Apellido + "'," +
                                            "nombre='" + usuario.Nombre + "'," +
                                            "nroDni='" + usuario.NroDni + "'," +
                                            "fechaNac='" + usuario.FechaNac.ToShortDateString() + "'," +
                                            "calle='" + usuario.Calle + "'," +
                                            "nroCalle='" + usuario.NroCalle + "'," +
                                            "id_barrio=" + usuario.Id_barrio +
                                            " WHERE id_usu=" + usuario.Id_usu;
            objDatos.actualizar(SqlUpdate);
        }

        public void guardarUsuario(Usuarios usuario)
        {
            string SqlInsert = "";

            SqlInsert = @"INSERT INTO Usuarios (id_usu, usuario, password, apellido, nombre, nroDni, fechaNac, calle, nroCalle, id_barrio) VALUES ('" +
                usuario.Id_usu + "','" +
                usuario.Usuario + "','" +
                usuario.Password + "', '" +
                usuario.Apellido + "', '" +
                usuario.Nombre + "', " +
                usuario.NroDni + ", '" +
                usuario.FechaNac.ToShortDateString() + "', '" +
                usuario.Calle + "', " +
                usuario.NroCalle + ", " +
                usuario.Id_barrio + ")";

            objDatos.actualizar(SqlInsert);
        }


        public bool validarDatosUsuarios(Usuarios usuario) //Falta comprobar la date null
        {
            if (usuario.Id_usu == -1)
            {
                return false;
            }
            if (usuario.Usuario == "")
            {
                return false;
            }
            if (usuario.Password == "")
            {
                return false;
            }
            if (usuario.Apellido == "")
            {
                return false;
            }
            if (usuario.Nombre == "")
            {
                return false;
            }
            if (usuario.NroDni == "")
            {
                return false;
            }
            if (usuario.Calle == "")
            {
                return false;
            }
            if (usuario.NroCalle == -1)
            {
                return false;
            }
            if (usuario.Id_barrio == -1)
            {
                return false;
            }

            return true;
        }
    }
}
