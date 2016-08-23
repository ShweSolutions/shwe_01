using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ShweStock
{
    public static class GenericDataAccess
    {
        static GenericDataAccess()
        {

        }
        public static string DataConn = Properties.Settings.Default.Setting;

        // executes a command and returns the results as a DataTable object
        public static DataTable ExecuteSelectCommand(SqlCommand command)
        {
            // The DataTable to be returned 
            DataTable table;
            try
            {
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                table = new DataTable();
                table.Load(reader);

                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                // Close the connection
                command.Connection.Close();
            }
            return table;
        }


        // executes a command and returns the results as a DataTable object
        public static DataSet ExecuteSelectDataSetCommand(SqlCommand command)
        {
            // The DataSet to be returned 
            DataSet dataSet = new DataSet();

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                // Close the connection
                command.Connection.Close();
            }
            return dataSet;
        }

        // creates and prepares a new DbCommand object on a new connection
        public static SqlCommand CreateCommand()
        {
            string connectionString = Properties.Settings.Default.Setting;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            SqlCommand comm = conn.CreateCommand();
            comm.CommandType = CommandType.StoredProcedure;
            return comm;
        }

        // execute an update, delete, or insert command 
        // and return the number of affected rows
        public static int ExecuteNonQuery(SqlCommand command)
        {
            // The number of affected rows 
            int affectedRows = 0;

            try
            {
                command.Connection.Open();
                affectedRows = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                command.Connection.Close();
            }

            return affectedRows;
        }

        // execute a select command and return a single result as a string
        public static string ExecuteScalar(SqlCommand command)
        {
            string value = "";

            try
            {
                command.Connection.Open();

                value = command.ExecuteScalar().ToString();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                command.Connection.Close();
            }

            return value;
        }

        public static Boolean GetScalar(SqlCommand command)
        {
            //string value = "";

            try
            {
                command.Connection.Open();

                command.ExecuteScalar();
                return Convert.ToBoolean(command.ExecuteScalar());

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                command.Connection.Close();
            }

        }
        public static int GetSQLTransVoid(SqlCommand sqlCmd)
        {
            int int_Result = 0;
            try
            {
                int_Result = sqlCmd.ExecuteNonQuery();
            }
            catch (SqlException sqx)
            {
                throw sqx;
                //DevExpress.XtraEditors.XtraMessageBox.Show(sqx.Message + sqx.Source);
            }
            finally
            {
                // sqlCon.Close();
            }

            return int_Result;
        }
    }
}
