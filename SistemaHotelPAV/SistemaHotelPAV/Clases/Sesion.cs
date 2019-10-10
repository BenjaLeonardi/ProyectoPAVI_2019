using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotelPAV.Clases
{
    class Sesion
    {
        public static int userID;

        public int UserID //Propiedad utilizada para contener el ID del usuario
        {
            get { return userID; }
            set { userID = value; }
        }
    }
}
