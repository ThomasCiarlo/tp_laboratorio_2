using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class PaqueteDAO
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;

        /// <summary>
        /// Es un contructo static, que genera la conexion con la base de datos
        /// </summary>
          static PaqueteDAO() {

            StringBuilder conec = new StringBuilder();
            conec.Append($"Data Source= .//SQLEXPRESS; Initial Catalog = correo-sp-2017 ; Integrated Security = True");

            try
            {
                conexion = new SqlConnection(conec.ToString());
            }
            catch (Exception)
            {
                conexion = null;
            }

        }

        /// <summary>
        /// metodo statico el cual cargara un paquete en la base de datos
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
         public static bool Insertar(Paquete p) {

            bool todoOk = true;


            try
            {
                comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = ($"INSERT INTO dbo.Paquetes(direccionEntrega,trackingID,alumno) VALUES('{p.DireccionEntrega}','{p.TrackingID}','Ciarlo Thomas')");
                comando.Connection = conexion;

                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {

                todoOk = false;

            }

            return todoOk;


        }
    }
}
