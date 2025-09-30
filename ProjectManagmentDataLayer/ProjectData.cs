using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentDataLayer
{
    public class clsProjectData
    {
        public static bool Find(int id,ref string Name,ref string Description,ref DateTime StartDate,ref DateTime PlannedEndDate,ref DateTime ActualEndDate,ref string Status)
        {
            bool IsFound = false;
            SqlConnection connection =new SqlConnection(ClsDataSettings.ConnectionString);

            string Query = "select *from Projects where ID=@id";

            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    Name = (string)reader["Name"];
                    Description = (string)reader["Description"];
                    StartDate = (DateTime)reader["StartDate"];
                    PlannedEndDate = (DateTime)reader["PlannedEndDate"];
                    if(reader["ActualEndDate"] != DBNull.Value)
                    ActualEndDate=(DateTime)reader["ActualEndDate"];

                    Status = (string)reader["Status"];
                }
                else
                {
                    IsFound = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }
        public static int AddProject(string Name, string Description, DateTime StartDate, DateTime PlannedEndDate)
        {
           int id = -1;
            SqlConnection connection = new SqlConnection(ClsDataSettings.ConnectionString);
            string Query = "insert into Projects (Name,Description,StartDate,PlannedEndDate) values(@Name,@Description,@StartDate,@PlannedEndDate);select SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Description", Description);
            cmd.Parameters.AddWithValue("@StartDate", StartDate);
            cmd.Parameters.AddWithValue("@PlannedEndDate", PlannedEndDate);
            try
            {
                connection.Open();
                object Result = cmd.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int insertedid))
                {
                    id =insertedid;
                }
                else
                {
                    id = -1;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return id;
        }
        public static bool UpdateProject(int id,string Name, string Description, DateTime StartDate, DateTime PlannedEndDate,DateTime ActualEndDate,string Status)
        {
            bool IsUpdated = false;
            SqlConnection connection = new SqlConnection(ClsDataSettings.ConnectionString);
            string Query = "update Projects set Name=@Name,Description=@Description,StartDate=@StartDate,PlannedEndDate=@PlannedEndDate,ActualEndDate=@ActualEndDate,Status =@Status where ID=@id;";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Description", Description);
            cmd.Parameters.AddWithValue("@StartDate", StartDate);
            cmd.Parameters.AddWithValue("@PlannedEndDate", PlannedEndDate);
            if(ActualEndDate==DateTime.MinValue)
                cmd.Parameters.AddWithValue("@ActualEndDate", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@ActualEndDate", ActualEndDate);
            cmd.Parameters.AddWithValue("@Status", Status);

            try
            {
                connection.Open();
                if (cmd.ExecuteNonQuery()>0)
                {
                    IsUpdated = true;
                }
                
            }
            catch (Exception)
            {

                throw;
            }
            finally
            { connection.Close(); }
            return IsUpdated;
        }
        static public DataTable GetAllProjects()
        {
            DataTable Dt = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataSettings.ConnectionString);
            string Query = "select *from Projects";
            SqlCommand cmd = new SqlCommand(@Query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    Dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }
            return Dt;
        }
        static public bool DeleteProject(int id)
        {
            int AffectedRow = 0;
            SqlConnection connection = new SqlConnection(ClsDataSettings.ConnectionString);
            string Query = "delete from Projects where ID =@id";

            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                connection.Open();
                AffectedRow = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }
            return AffectedRow > 0;

        }
    }
}
