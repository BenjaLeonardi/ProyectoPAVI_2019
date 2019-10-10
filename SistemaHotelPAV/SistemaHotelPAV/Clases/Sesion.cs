using SistemaHotelPAV.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotelPAV.Clases
{
    class Sesion
    {
        static int userID;
        static string userNombre;
        static string userApellido;

        public static string UserApellido
        {
            get { return userApellido; }
            set { userApellido = value; }
        }

        public static string UserNombre
        {
            get { return userNombre; }
            set { userNombre = value; }
        }

        public static string UserNombreCompleto
        {
            get { return userNombre + " " + UserApellido; }
        }

        public static int UserID //Propiedad utilizada para contener el ID del usuario
        {
            get { return userID; }
            set { userID = value; }
        }

        public static void RecuperarDatos(int idUsuario){
            UsuarioDA objUser = new UsuarioDA();
            DataTable tablaDatosUsuario = new DataTable();
            tablaDatosUsuario = objUser.recuperarUsuarioID(idUsuario);

            UserID = idUsuario;
            UserNombre = tablaDatosUsuario.Rows[0]["nombre"].ToString();
            UserApellido = tablaDatosUsuario.Rows[0]["apellido"].ToString();
        }
    }
}
