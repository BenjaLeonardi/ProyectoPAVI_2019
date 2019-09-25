using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SistemaHotelPAV.Entities
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
    }
}
