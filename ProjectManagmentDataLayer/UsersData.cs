using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentDataLayer
{
    public class ClsUsersData
    {
        public static DataTable GetAllUsers()
        {
            DataTable Dt = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataSettings.ConnectionString);

            string Query = "select *from Users";
            SqlCommand cmd = new SqlCommand(Query, connection);
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
            finally
            { connection.Close(); }

            return Dt;
        }
        public static bool GetUserById(int id,ref string name,ref string email,ref string role)
        {
            bool IsFound=false;
            SqlConnection connection = new SqlConnection(ClsDataSettings.ConnectionString);
            string Query = "select *from Users where ID =@id";
            SqlCommand cmd =new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    name = (string)reader["Name"];
                    email = (string)reader["Email"];
                    role = (string)reader["Role"];
                }
                else
                    IsFound = false;

                    reader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }
            return IsFound;
        }
        public static int AddUser(string Name,string Email,string Role)
        {
            int Id = -1;
            SqlConnection connection=new SqlConnection(ClsDataSettings.ConnectionString);

            string Query = "insert into Users (Name,Email,Role) Values (@Name,@Email,@Role);select SCOPE_IDENTITY();";
            SqlCommand cmd= new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@Name",Name);
            cmd.Parameters.AddWithValue ("@Email",Email);
            cmd.Parameters.AddWithValue("@Role", Role);
            try
            {
                connection.Open();
                object Result = cmd.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int insertedid))
                {
                    Id = insertedid;
                }
                else 
                {
                    Id = -1;
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
            return Id;


        }
        public static bool UpdateUser(int id,string name,string email,string role)
        {
            int AfectedRow = 0;
            SqlConnection connection = new SqlConnection(ClsDataSettings.ConnectionString);
            string Query = "Update Users set Name=@name,Email=@email,Role=@role where ID =@id";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@role", role);

            try
            {
                connection.Open ();
                AfectedRow = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }
            return AfectedRow > 0;
        }
        public static bool DeleteUser(int id)
        {
            int AfectedRow = 0;
            SqlConnection connection = new SqlConnection(ClsDataSettings.ConnectionString);

            string Query = "delete from Users where ID =@id";
            SqlCommand cmd =new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                connection.Open();
                AfectedRow = cmd.ExecuteNonQuery ();
            }
            catch (Exception)
            {
                throw;
            }
            finally { connection.Close(); }
            return AfectedRow > 0;
        }
    }
}
