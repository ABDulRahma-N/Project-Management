using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentDataLayer
{
    public class ClsTaskData
    {
        public static DataTable GetAllTasks()
        {
            DataTable allTasks = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataSettings.ConnectionString);
            string Query = "SELECT * FROM Tasks";
            SqlCommand cmd = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    allTasks.Load(reader);
                }
                reader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }   
            return allTasks;
        }

        public static bool GetTaskById(int id, ref string Title, ref string Description, ref DateTime StartDate, ref DateTime PlannedEndDate, ref DateTime ActualEndDate, ref string Status, ref int ProjectID, ref int AssignedTo)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ClsDataSettings.ConnectionString);
            string Query = "SELECT * FROM Tasks WHERE ID=@id";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    Title = (string)reader["Title"];
                    StartDate = (DateTime)reader["StartDate"];
                    PlannedEndDate = (DateTime)reader["PlannedEndDate"];
                    Status = (string)reader["Status"];

                    if (reader["ActualEndDate"] != DBNull.Value)
                        ActualEndDate = (DateTime)reader["ActualEndDate"];
                    if (reader["Description"] != DBNull.Value)
                        Description = (string)reader["Description"];
                    if (reader["ProjectID"] != DBNull.Value)
                        ProjectID = (int)reader["ProjectID"];
                    if (reader["AssignedTo"] != DBNull.Value)
                        AssignedTo = (int)reader["AssignedTo"];
                }
                else
                {
                    IsFound = false;
                }
                reader.Close();
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
        public static int AddTask(string Title, string Description, DateTime StartDate, DateTime PlannedEndDate, DateTime ActualEndDate, int ProjectID, int AssignedTo)
        {
            int id = -1;
            SqlConnection connection = new SqlConnection(ClsDataSettings.ConnectionString);
            string Query = "INSERT INTO Tasks (Title,Description,StartDate,PlannedEndDate,ActualEndDate,ProjectID,AssignedTo) VALUES(@Title,@Description,@StartDate,@PlannedEndDate,@ActualEndDate,@ProjectID,@AssignedTo);SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@Title", Title);
            cmd.Parameters.AddWithValue("@StartDate", StartDate);
            cmd.Parameters.AddWithValue("@PlannedEndDate", PlannedEndDate);
           

            if (!string.IsNullOrEmpty(Description))
                cmd.Parameters.AddWithValue("@Description", Description);
            else
                cmd.Parameters.AddWithValue("@Description", DBNull.Value);
            if (ActualEndDate != DateTime.MinValue)
                cmd.Parameters.AddWithValue("@ActualEndDate", ActualEndDate);
            else
                cmd.Parameters.AddWithValue("@ActualEndDate", DBNull.Value);
            if (ProjectID != -1)
                cmd.Parameters.AddWithValue("@ProjectID", ProjectID);
            else
                cmd.Parameters.AddWithValue("@ProjectID", DBNull.Value);
            if (AssignedTo != -1)
                cmd.Parameters.AddWithValue("@AssignedTo", AssignedTo);
            else
                cmd.Parameters.AddWithValue("@AssignedTo", DBNull.Value);
            try
            {
                connection.Open();
                id = Convert.ToInt32(cmd.ExecuteScalar());
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
        public static bool UpdateTask(int id, string Title, string Description, DateTime StartDate, DateTime PlannedEndDate, DateTime ActualEndDate, string Status, int ProjectID, int AssignedTo)
        {
            bool IsUpdated = false;
            SqlConnection connection = new SqlConnection(ClsDataSettings.ConnectionString);
            string Query = "UPDATE Tasks SET Title=@Title,Description=@Description,StartDate=@StartDate,PlannedEndDate=@PlannedEndDate,ActualEndDate=@ActualEndDate,Status=@Status,ProjectID=@ProjectID,AssignedTo=@AssignedTo WHERE ID=@id";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@Title", Title);
            cmd.Parameters.AddWithValue("@StartDate", StartDate);
            cmd.Parameters.AddWithValue("@PlannedEndDate", PlannedEndDate);
            cmd.Parameters.AddWithValue("@Status", Status);
            if (!string.IsNullOrEmpty(Description))
                cmd.Parameters.AddWithValue("@Description", Description);
            else
                cmd.Parameters.AddWithValue("@Description", DBNull.Value);
            if (ActualEndDate != DateTime.MinValue)
                cmd.Parameters.AddWithValue("@ActualEndDate", ActualEndDate);
            else
                cmd.Parameters.AddWithValue("@ActualEndDate", DBNull.Value);
            if (ProjectID != -1)
                cmd.Parameters.AddWithValue("@ProjectID", ProjectID);
            else
                cmd.Parameters.AddWithValue("@ProjectID", DBNull.Value);
            if (AssignedTo != -1)
                cmd.Parameters.AddWithValue("@AssignedTo", AssignedTo);
            else
                cmd.Parameters.AddWithValue("@AssignedTo", DBNull.Value);
            try
            {
                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                IsUpdated = rowsAffected > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return IsUpdated;
        }
        static public bool DeleteTask(int id)
        {
            bool IsDeleted = false;
            SqlConnection connection = new SqlConnection(ClsDataSettings.ConnectionString);
            string Query = "DELETE FROM Tasks WHERE ID=@id";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                IsDeleted = rowsAffected > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return IsDeleted;
        }
    }
}
