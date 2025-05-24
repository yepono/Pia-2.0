using Pia_2._0.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pia_2._0.DAO
{
    public class MedicoDAO
    {
        public int InsertarMedico(Medico medico)
        {
            int resultado = 0;

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("InsertarMedico", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Cedula", medico.Cedula);
                cmd.Parameters.AddWithValue("@Nombre", medico.Nombre);
                cmd.Parameters.AddWithValue("@Primer_Apellido", medico.PrimerApellido);
                cmd.Parameters.AddWithValue("@Segundo_Apellido", medico.SegundoApellido);
                cmd.Parameters.AddWithValue("@Telefono", medico.Telefono);
                cmd.Parameters.AddWithValue("@Correo", medico.Correo);
                cmd.Parameters.AddWithValue("@RFC", medico.Rfc);
                cmd.Parameters.AddWithValue("@CURP", medico.Curp);
                cmd.Parameters.AddWithValue("@Cuenta_banco", medico.CuentaBanco);
                cmd.Parameters.AddWithValue("@Tarifa", medico.Tarifa);
                cmd.Parameters.AddWithValue("@Id_Especialidad", medico.IdEspecialidad);
                cmd.Parameters.AddWithValue("@Id_Ubicacion", medico.IdUbicacion);

                conexion.Open();
                resultado = cmd.ExecuteNonQuery();
            }

            return resultado;
        }

        public int ActualizarMedico(Medico medico)
        {
            int resultado = 0;

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("ActualizarMedico", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Medico", medico.IdMedico);
                cmd.Parameters.AddWithValue("@Cedula", medico.Cedula);
                cmd.Parameters.AddWithValue("@Nombre", medico.Nombre);
                cmd.Parameters.AddWithValue("@Primer_Apellido", medico.PrimerApellido);
                cmd.Parameters.AddWithValue("@Segundo_Apellido", medico.SegundoApellido);
                cmd.Parameters.AddWithValue("@Telefono", medico.Telefono);
                cmd.Parameters.AddWithValue("@Correo", medico.Correo);
                cmd.Parameters.AddWithValue("@RFC", medico.Rfc);
                cmd.Parameters.AddWithValue("@CURP", medico.Curp);
                cmd.Parameters.AddWithValue("@Cuenta_banco", medico.CuentaBanco);
                cmd.Parameters.AddWithValue("@Tarifa", medico.Tarifa);
                cmd.Parameters.AddWithValue("@Id_Especialidad", medico.IdEspecialidad);
                cmd.Parameters.AddWithValue("@Id_Ubicacion", medico.IdUbicacion);

                conexion.Open();
                resultado = cmd.ExecuteNonQuery();
            }

            return resultado;
        }


    }
}
