using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pia_2._0.DAO
{
    public class EspecialidadDAO
    {
        public static int InsertarEspecialidad(string especialidad)
        {
            int retorno = 0;
            
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC InsertarEspecialidad @Especialidad = '" + especialidad + "';";
                SqlCommand comando = new SqlCommand(query, conexion);
                retorno = comando.ExecuteNonQuery();

            }

            return retorno;
        }
    }
}
