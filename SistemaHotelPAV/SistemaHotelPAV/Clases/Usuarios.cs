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
    public class Usuarios
    {
        Datos objDatos = new Datos();

        private int id_usu;
        private string usuario;
        private string password;
        private string apellido;
        private string nombre;
        private string nroDni;
        private DateTime fechaNac;
        private string calle;
        private int nroCalle;
        private int id_barrio;

        public int Id_usu
        {
            get { return id_usu; }
            set { id_usu = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string NroDni
        {
            get { return nroDni; }
            set { nroDni = value; }
        }

        public DateTime FechaNac
        {
            get { return fechaNac; }
            set { fechaNac = value; }
        }

        public string Calle
        {
            get { return calle; }
            set { calle = value; }
        }

        public int NroCalle
        {
            get { return nroCalle; }
            set { nroCalle = value; }
        }

        public int Id_barrio
        {
            get { return id_barrio; }
            set { id_barrio = value; }
        }

        public bool validarDatosUsuarios() //Falta comprobar la date null
        {
            if (this.id_usu == -1)
            {
                return false;
            }
            if (this.usuario == "")
            {
                return false;
            }
            if (this.password == "")
            {
                return false;
            }
            if (this.apellido == "")
            {
                return false;
            }
            if (this.nombre == "")
            {
                return false;
            }
            if (this.nroDni == "")
            {
                return false;
            }
            if (this.calle == "")
            {
                return false;
            }
            if (this.nroCalle == -1)
            {
                return false;
            }
            if (this.id_barrio == -1)
            {
                return false;
            }

            return true;
        }

        public DataTable recuperarUsuarios()
        {
            return objDatos.consultar("SELECT u.id_usu, u.usuario, u.password, u.apellido, u.nombre, u.nroDni, u.fechaNac, u.calle, u.nroCalle, b.nombre" +
                " FROM Usuarios u JOIN Barrios b on u.id_barrio=b.id_barrio");
        }

        public DataTable recuperarUsuarioID(int id)
        {
            return objDatos.consultar("SELECT * FROM Usuarios WHERE id_usu=" + id);
        }

        public void eliminarUsuario()
        {
            string sqlDelete = "";
            sqlDelete = "DELETE FROM Usuarios WHERE id_usu=" + this.id_usu;
            objDatos.actualizar(sqlDelete);

        }

        public void editarUsuario()
        {
            string SqlUpdate = "";
            SqlUpdate = @"UPDATE Usuarios SET id_usu='" + this.id_usu + "'," +
                                            "usuario='" + this.usuario + "'," +
                                            "password='" + this.password + "'," +
                                            "apellido='" + this.apellido + "'," +
                                            "nombre='" + this.nombre + "'," +
                                            "nroDni='" + this.nroDni + "'," +
                                            "fechaNac='" + this.fechaNac + "'," +
                                            "calle='" + this.calle + "'," +
                                            "nroCalle='" + this.nroCalle + "'," +
                                            "id_barrio=" + this.id_barrio +
                                            " WHERE id_usu=" + this.id_usu;
            objDatos.actualizar(SqlUpdate);
        }

        public void guardarUsuario()
        {
            string SqlInsert = "";

            SqlInsert = @"INSERT INTO Usuarios (id_usu, usuario, password, apellido, nombre, nroDni, fechaNac, calle, nroCalle, id_barrio) VALUES ('" +
                this.id_usu + "','" +
                this.usuario + "','" +
                this.password + "'," +
                this.apellido + "'," +
                this.nombre + "'," +
                this.nroDni + "'," +
                this.fechaNac + "'," +
                this.calle + "'," +
                this.nroCalle + "'," +
                this.id_barrio + ")";

            objDatos.actualizar(SqlInsert);
        }

    }
}
