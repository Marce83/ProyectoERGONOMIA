using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TF.ENTITIES;
using TF.COMMON.Cache;

namespace TF.DAC
{
    public class UsuariosDAC
    {
        string conectionString = ConnectionStringManager.ConectionString;
        public DataTable Login(Usuarios oBe)
        {
            try
            {
                string sqlSentencia = "SP_Login";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@Usuario", SqlDbType.NVarChar).Value = oBe.Usuario;
                sqlCom.Parameters.Add("@Clave", SqlDbType.NVarChar).Value = oBe.Clave;
                sqlCnn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter DA = new SqlDataAdapter();
                DA.SelectCommand = sqlCom;
                DA.Fill(ds);
                sqlCnn.Close();
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en el logueo del Usuario: " + ex.Message);
                return null;
            }
        }

        public bool UserLogin(string Usuario, string Clave)
        {
            try
            {
                string sqlSentencia = "SP_Login";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@Usuario", SqlDbType.NVarChar).Value = Usuario;
                sqlCom.Parameters.Add("@Clave", SqlDbType.NVarChar).Value = Clave;
                sqlCnn.Open();
                SqlDataReader reader = sqlCom.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UserLoginCache.IdUsuario = reader.GetInt32(0);
                        UserLoginCache.Usuario = reader.GetString(1);
                        UserLoginCache.Nombre = reader.GetString(3);
                        UserLoginCache.Apellido = reader.GetString(4);
                        UserLoginCache.Cargo = reader.GetString(5);
                        UserLoginCache.Correo = reader.GetString(6);
                    }
                }
                sqlCnn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al validar el Usuario: " + ex.Message);
                return false;
            }
        }

        public void PermisosRoles()
        {
            if(UserLoginCache.Cargo == Cargos.Administrador) 
            {}
            if (UserLoginCache.Cargo == Cargos.Recepcionista)
            {}
            if (UserLoginCache.Cargo == Cargos.Profesional)
            {}
            if(UserLoginCache.Cargo == Cargos.Contador)
            {}
        }

        public int Insertusuario(Usuarios oBe)
        {
            try
            {
                string sqlSentencia = "SP_makeLogin";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@Usuario", SqlDbType.NVarChar).Value = oBe.Usuario;
                sqlCom.Parameters.Add("@Clave", SqlDbType.NVarChar).Value = oBe.Clave;
                sqlCom.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = oBe.Nombre;
                sqlCom.Parameters.Add("@Apellido", SqlDbType.NVarChar).Value = oBe.Apellido;
                sqlCnn.Open();
                var res = sqlCom.ExecuteNonQuery();
                sqlCnn.Close();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar los datos del Usuario: " + ex.Message);
                return 0;
            }
        }
        
        public bool ExisteUsr(String NombreUsr)
        {
            string sqlSentencia = "SP_ExisteUsr";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
            sqlCom.CommandType = CommandType.StoredProcedure;
            sqlCnn.Open();
            sqlCom.Parameters.AddWithValue("@Usuario", NombreUsr);
            // Ejecutar el comando y obtener el resultado
            int count = Convert.ToInt32(sqlCom.ExecuteScalar());
            // Si count es mayor que 0, el usuario ya existe
            return count > 0;
        }
    }
}
