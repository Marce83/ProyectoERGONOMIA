using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TF.ENTITIES;

namespace TF.DAC
{

    public class EmpleadosDAC
    {

        string conectionString = ConnectionStringManager.ConectionString;

        public DataTable Empleados_GetAll()
        {
            string sqlSentencia = "SP_Empleados_GetAll";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlCnn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = sqlComm;
            DA.Fill(ds);
            sqlCnn.Close();

            return ds.Tables[0];
        }

        public int InsertEmpleados(Empleados oempl)
        {
            try
            {
                string sqlSentencia = "SP_Empleados_Insert";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = oempl.Nombre;
                sqlCom.Parameters.Add("@Apellido", SqlDbType.NVarChar).Value = oempl.Apellido;
                sqlCom.Parameters.Add("@DNI", SqlDbType.NVarChar).Value = oempl.DNI;
                sqlCom.Parameters.Add("@Genero", SqlDbType.NVarChar).Value = oempl.Genero;
                sqlCom.Parameters.Add("@PuestoDeTrabajo", SqlDbType.NVarChar).Value = oempl.PuestoDeTrabajo;
                sqlCom.Parameters.Add("@Peso", SqlDbType.Float).Value = oempl.Peso;
                sqlCom.Parameters.Add("@Altura", SqlDbType.Float).Value = oempl.Altura;
                sqlCom.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = oempl.FechaNacimiento;
                sqlCom.Parameters.Add("@FechaIngreso", SqlDbType.Date).Value = DateTime.Today;
                sqlCom.Parameters.Add("@FechaEgreso", SqlDbType.Date).Value = DBNull.Value;
                sqlCom.Parameters.Add("@IdEmpresa", SqlDbType.Int).Value = oempl.IdEmpresa;
                sqlCnn.Open();
                var res = sqlCom.ExecuteNonQuery();
                sqlCnn.Close();
                return 1;
            }
            catch (Exception ex)
            {
                throw ex;
                //Console.WriteLine("Error al cargar los datos del Empleado: " + ex.Message);
                //return 0;
            }
        }

        public DataTable Empleados_Idempresa(Empresas oemp)
        {
            string sqlSentencia = "SP_Empresas_GetIdempresa";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
            sqlCom.CommandType = CommandType.StoredProcedure;
            sqlCom.Parameters.Add("@CUIT", SqlDbType.NVarChar).Value = oemp.CUIT;
            sqlCnn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = sqlCom;
            DA.Fill(ds);
            sqlCnn.Close();
            return ds.Tables[0];
        }

        public DataTable Consultarempleadospordni(Empleados oempl)
        {
            try
            {
                string sqlSentencia = "SP_Empleados_DNI";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@DNI", SqlDbType.NVarChar).Value = oempl.DNI;
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
                throw ex;
                //Console.WriteLine("Error al validar el DNI del Empleado: " + ex.Message);
                //return null;
            }
        }

        public int ObtenerSoloIdEmpresa(long CUIT)
        {
            Empresas oEmpresas = new Empresas();
            string sqlSentencia = "SP_Empresas_Solo_GetId";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.Add("@CUIT", SqlDbType.NVarChar).Value = CUIT;
            sqlCnn.Open();
            SqlDataReader dr = sqlComm.ExecuteReader();
            while (dr.Read())
            {
                oEmpresas.IdEmpresa = dr.GetInt32(0);
            }
            sqlCnn.Close();
            int IdEmpresa = oEmpresas.IdEmpresa;
            return IdEmpresa;
        }

        public int ModificarEmpleados(Empleados oempl)
        {
            try
            {
                string sqlSentencia = "SP_Empleados_Update";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = oempl.Nombre;
                sqlCom.Parameters.Add("@Apellido", SqlDbType.NVarChar).Value = oempl.Apellido;
                sqlCom.Parameters.Add("@DNI", SqlDbType.NVarChar).Value = oempl.DNI;
                sqlCom.Parameters.Add("@Genero", SqlDbType.NVarChar).Value = oempl.Genero;
                sqlCom.Parameters.Add("@PuestoDeTrabajo", SqlDbType.NVarChar).Value = oempl.PuestoDeTrabajo;
                sqlCom.Parameters.Add("@Peso", SqlDbType.Float).Value = oempl.Peso;
                sqlCom.Parameters.Add("@Altura", SqlDbType.Float).Value = oempl.Altura;
                sqlCom.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = oempl.FechaNacimiento;

                sqlCnn.Open();
                var res = sqlCom.ExecuteNonQuery();
                sqlCnn.Close();
                return 1;

            }


            catch (Exception ex)
            {
                throw ex;
                //Console.WriteLine("Error al validar el DNI del Empleado: " + ex.Message);
                //return null;
            }

    }

    }
}
