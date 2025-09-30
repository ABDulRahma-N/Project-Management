using ProjectManagmentDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementBusinessLayer
{
    public class ClsUsers
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        public ClsUsers()
        {
            this.ID = -1;
            this.Name = "";
            this.Email = "";
            this.Role = "";
        }
        private ClsUsers(int id,string name,string email,string role)
        {
            this.ID=id;
            this.Name = name;
            this.Email = email;
            this.Role = role;
        }
        public static ClsUsers Find(int id)
        {
            string name = "",email="",role="";
            
           if(ClsUsersData.GetUserById(id,ref name, ref email, ref role))
            {
                return new ClsUsers(id,name,email,role);
            }
           else 
                return null;
        }
        static public DataTable GetAllUser()
        {
           return ClsUsersData.GetAllUsers();
        }
        public bool AddUser()
        {
            if(this.ID<0)
            {
                this.ID = ClsUsersData.AddUser(this.Name, this.Email, this.Role);
            }
            return ID >0;
        }
        public bool UpdataUser()
        {
            if (this.ID != -1)
                return ClsUsersData.UpdateUser(this.ID, this.Name, this.Email, this.Role);
            return false;
        }
        public static bool DeleteUser(int id)
        {
            return ClsUsersData.DeleteUser(id);
        }
    }
}
