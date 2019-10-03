using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SistemaHotelPAV.DataAccessLayer
{
    class Datos
    {
        public enum ResultadoTransaccion {exito, fracaso}

        private ResultadoTransaccion transactionStatus = ResultadoTransaccion.exito;
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        //private string cadenaConexion = @"Provider=SQLNCLI11;Data Source=DESKTOP-2L8MG4Q\SQLEXPRESS;Persist Security Info=True;Integrated Security=SSPI;Initial Catalog=HotelGrandario";
        //private string cadenaConexion = @"Provider=SQLNCLI11;Data Source=DESKTOP-JOO5NDB\SQLEXPRESS;Persist Security Info=True;Integrated Security=SSPI;Initial Catalog=HotelGrandario";
        private string cadenaConexion = @"Provider=SQLNCLI11;Data Source=maquis;Persist Security Info=True;Password=avisuales1;User ID=avisuales1;Initial Catalog=TestLeonardi";

        private void conectar()
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion; // Abrimos la conexion para que los comandos trabajen ahi
            comando.CommandType = CommandType.Text; // Le decimos que es un texto para poder pasar la consulta SQL por ahi
        }

        private void desconectar()
        {
            conexion.Close();
        }

        public ResultadoTransaccion DesconectarTransaccion()
        {
            if (transactionStatus == ResultadoTransaccion.exito) {
                mTransaction.Commit();
                MessageBox.Show("La transacción resultó con éxito.");
            } else {
                mTransaction.Rollback();
                MessageBox.Show("La transacción no pudo realizarse.");
            }

            if ((conexion.State == ConnectionState.Open)) {
                conexion.Close();
            }

            // Dispose() libera los recursos asociados a la conexón
            conexion.Dispose();

            return transactionStatus;
        }

        public DataTable consultar(string consultaSQL) // Data table no esta dentro de OLEDB sino de DATA, es una tabla en memoria con filas y columnas
        {
            DataTable tabla = new DataTable();
            this.conectar();
            comando.CommandText = consultaSQL; // Le mandamos como comando la consulta de parametro
            tabla.Load(comando.ExecuteReader()); // Lo que devuelve el comando lo carga en la tabla
            this.desconectar();
            return tabla; // Importante la tabla porque sino no devuelve nada y tira error
        }

        public DataTable consultarTabla(string nombreTabla) //Metodo aparte para devolver una tabla entera
        {
            DataTable tabla = new DataTable();
            this.conectar();
            comando.CommandText = "SELECT * FROM " + nombreTabla;
            tabla.Load(comando.ExecuteReader());
            this.desconectar();
            return tabla;
        }

        public void actualizar(string consultaSQL)
        {
            this.conectar();
            comando.CommandText = consultaSQL;
            comando.ExecuteNonQuery(); //Query funciona para ejecutar insert, update o delete DML
            this.desconectar();
        }

        public int validarUsuarioLogin(string usuario, string contrasena) // Si el nombre es con la mayuscula es porque hace referencia a una clase
        {
            Datos objDatos = new Datos();
            DataTable tabla = new DataTable();
            string consultaSQL = "SELECT * FROM Usuarios WHERE usuario='" + usuario + "' AND password='" + contrasena + "'";
            tabla = objDatos.consultar(consultaSQL);

            if (tabla.Rows.Count > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private OleDbTransaction mTransaction = null;
        
        public void conectarConTransaccion() {
            transactionStatus = ResultadoTransaccion.exito;
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            mTransaction = conexion.BeginTransaction();
            comando.Transaction = mTransaction;
            comando.Connection = conexion;
        }

        public void EjecutarSQLConTransaccion(string consulta) {
            //try {
                comando.CommandType = CommandType.Text;
                comando.CommandText = consulta;
                comando.ExecuteNonQuery();
            /*} catch {
                transactionStatus = ResultadoTransaccion.fracaso;
            }*/
        }
    }
}
