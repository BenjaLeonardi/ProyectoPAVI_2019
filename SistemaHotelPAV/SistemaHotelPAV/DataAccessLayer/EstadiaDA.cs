using System;
using System.Data;

namespace SistemaHotelPAV.DataAccessLayer {
    class EstadiaDA {
        Datos datos = new Datos();

        /// <summary>
        /// Devuelve row de estadia con JOIN a cliente
        /// </summary>
        /// <param name="fechaInicio"></param>
        /// <param name="nroEstadia"></param>
        /// <returns></returns>
        public DataTable GetEstadiaCompleto(DateTime fechaInicio, int nroEstadia) {
            string consulta = "SELECT * FROM Estadias E JOIN Clientes C ON E.id_cliente=C.id_cliente " +
                "WHERE E.fecha_inicio='" + fechaInicio.ToShortDateString() + "' AND E.nro_estadia=" + nroEstadia.ToString();
            return datos.consultar(consulta);
        }
    }
}
