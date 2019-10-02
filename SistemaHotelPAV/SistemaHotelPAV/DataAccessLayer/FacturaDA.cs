using System.Data;

namespace SistemaHotelPAV.DataAccessLayer {
    class FacturaDA {
        Datos datos = new Datos();

        public int GetLastFacturaID(string tipo) {
            DataTable lastFactura = datos.consultar("SELECT TOP 1 * FROM Facturas WHERE tipo_factura=" + tipo + " ORDER BY id_factura DESC");
            int id = 0;
            if (lastFactura.Rows.Count > 0) {
                id = (int)lastFactura.Rows[0]["id_factura"];
            }
            return id;
        }
    }
}
