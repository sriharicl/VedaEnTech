using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoScProject
{
    class CoscDAL
    {
        private static string coscConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["VedConnections"].ConnectionString;
        SqlConnection connection = new SqlConnection(coscConnectionString);
        public DataTable getJobs()
        {
            SqlCommand commandgetJobs = connection.CreateCommand();

            DataSet ds = new DataSet();
            try
            {
                commandgetJobs.CommandType = CommandType.StoredProcedure;
                commandgetJobs.CommandText = "getJobs";
                SqlDataAdapter daJobs = new SqlDataAdapter(commandgetJobs);                
                connection.Open();                
                daJobs.Fill(ds);
            }
            catch (Exception ex)
            {
                ds = null;
            }
            finally
            {
                connection.Close();
            }

            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    return ds.Tables[0];
                }
            }

            return null;
        }

        public int getMaxReportNumber()
        {
            int maxNo = 0;
            try
            {
                SqlCommand commandgetMaxreportNumber = connection.CreateCommand();
                commandgetMaxreportNumber.CommandText = "getMaxReportNumber";
                commandgetMaxreportNumber.CommandType = CommandType.StoredProcedure;

                var returnParameter = commandgetMaxreportNumber.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                commandgetMaxreportNumber.Parameters.Add("@maxReportNumber", SqlDbType.Int);
                commandgetMaxreportNumber.Parameters["@maxReportNumber"].Direction = ParameterDirection.Output;
                connection.Open();
                commandgetMaxreportNumber.ExecuteNonQuery();
                var result = returnParameter.Value;
                maxNo=(int)result;
                
            }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
                connection.Close();

            }
            if (maxNo != null)
            {
                return maxNo;
            }
            else
                return 0;

        }

        internal Boolean Update_Dispacthed_Value_For_Scanned_Records(string barodeId)
        {
            string strQuery = "UPDATE ProductDetails SET isdispatched = 1 WHERE barcodeid IN (" + barodeId  + ")";
            //SqlConnection connection = new SqlConnection(coscConnectionString);
            try
            {
                SqlCommand command = new SqlCommand(strQuery, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }
    }
}
