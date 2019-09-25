using System.Data;

namespace SistemaHotelPAV.Entities
{
    public class Articulo
    {
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
    }

}