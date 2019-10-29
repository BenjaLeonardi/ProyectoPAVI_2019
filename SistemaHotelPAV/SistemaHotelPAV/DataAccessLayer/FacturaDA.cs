using System.Data;

namespace SistemaHotelPAV.DataAccessLayer {
    class FacturaDA {
        Datos Datos = new Datos();

        public int GetLastFacturaID(string tipo) {
            DataTable lastFactura = Datos.consultar("SELECT TOP 1 * FROM Facturas WHERE tipo_factura=" + tipo + " ORDER BY id_factura DESC");
            int id = 0;
            if (lastFactura.Rows.Count > 0) {
                id = (int)lastFactura.Rows[0]["id_factura"];
            }
            return id;
        }

        public void GrabarFactura(string idFactura, string tipoFacturaSeleccionado, string fechaFactura, string nroEstadia, string fechaInicioEstadia, string totalFactura, string idUsuario)
        {
            string consulta = "insert into Facturas values("
                + idFactura + ","
                + tipoFacturaSeleccionado + ",'"
                + fechaFactura + "',"
                + nroEstadia + ",'"
                + fechaInicioEstadia + "',"
                + totalFactura + ", " 
                + idUsuario + ")";

            Datos.EjecutarSQLConTransaccion(consulta);
        }

        public void GrabarDetalle(string idFactura, string tipoFactura, string idArticulo, string cantidad, string precioUnitario)
        {
            string consulta = "insert into DetallesFactura values("
                                                    + idFactura + ","
                                                    + tipoFactura + ","
                                                    + idArticulo + ","
                                                    + cantidad + ","
                                                    + precioUnitario + ")";
            Datos.EjecutarSQLConTransaccion(consulta);
        }

        internal void IniciarTransaccion()
        {
            Datos.conectarConTransaccion();
        }

        internal DataAccessLayer.Datos.ResultadoTransaccion FinalizarTransaccion()
        {
            return Datos.DesconectarTransaccion();
        }
    }
}
