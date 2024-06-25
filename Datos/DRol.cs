using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DRol
    {

        public void Registrar(string Nombre, bool Activo)
        {
            using (var connection = new SqlConnection(Conexion.cadena))
            {

                connection.Open();
                SqlCommand command = new SqlCommand("USP_InsertRole", connection);
                command.CommandType = CommandType.StoredProcedure;

                //Enviar los parámetros
                SqlParameter parameter = new SqlParameter("@Name", SqlDbType.VarChar, 50);
                parameter.Value = Nombre;
                command.Parameters.Add(parameter);

                SqlParameter parameter2 = new SqlParameter("@Enabled", SqlDbType.Bit);
                parameter2.Value = Activo;
                command.Parameters.Add(parameter2);

                command.ExecuteNonQuery();

            }
        }

        public List<Role> Listar(string Nombre)
        {
            List<Role> roles = new List<Role>();

            using (var connection = new SqlConnection(Conexion.cadena))
            {
                //Usar el procedimiento almacenado
                SqlCommand cmd = new SqlCommand("USP_GetRoles", connection);
                cmd.CommandType = CommandType.StoredProcedure;


                //Enviar los parámetros
                SqlParameter parameter = new SqlParameter("@RoleName", SqlDbType.VarChar, 50);
                parameter.Value = Nombre;
                cmd.Parameters.Add(parameter);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                //Recorrer el data reader
                while (reader.Read())
                {

                    int RoleID = reader["RoleID"] != DBNull.Value ? Convert.ToInt32(reader["RoleID"]) : 0;
                    string RoleName = reader["RoleName"] != DBNull.Value ? Convert.ToString(reader["RoleName"]) : "";

                    roles.Add(new Role { RoleId = RoleID, RoleName = RoleName });
                   

                }
                reader.Close();
            }
            return roles;

        }

    }
}
