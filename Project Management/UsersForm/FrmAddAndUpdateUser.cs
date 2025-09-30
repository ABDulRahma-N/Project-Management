using ProjectManagementBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management.UsersForm
{
    public partial class FrmAddAndUpdateUser : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _UserID;
        private ClsUsers _Users;
        public FrmAddAndUpdateUser(int id=-1)
        {
            _UserID = id;
            if (id > 0)
                _Mode = enMode.Update;
            else
                _Mode = enMode.AddNew;
                InitializeComponent();
        }

        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            if(_Mode == enMode.Update)
            {
                _LoadData();
            }
            else if(_Mode == enMode.AddNew)
            {
                _Users = new ClsUsers();
            }
        }
        private void _LoadData()
        {
            _Users=ClsUsers.Find(_UserID);

            BtSubmit.Text = "Save";
            TbName.Text = _Users.Name;
            TbEmail.Text = _Users.Email;
            TbRole.Text = _Users.Role;
            LuserID.Text="User ID  "+ _Users.ID.ToString();
            LuserID.Visible = true;

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtSubmit_Click(object sender, EventArgs e)
        {
            if(TbName.Text=="")
            {
                MessageBox.Show("User name is required", "Required");
                return;
            }
            if(TbEmail.Text=="")
            {
                MessageBox.Show("Email is required", "Required");
                return;
            }
            if(TbRole.Text =="")
            {
                MessageBox.Show("Role is required", "Required");
                return;
            }
            _Users.Name = TbName.Text;
            _Users.Email = TbEmail.Text;
            _Users.Role = TbRole.Text;

            if (_Mode == enMode.AddNew)
            {  
                if (_Users.AddUser())
                {
                    MessageBox.Show($"User with {_Users.ID} id added successfuly", "successfuly");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Something went wrong", "Error");
                }
            }
            else if(_Mode == enMode.Update)
            {
                if (_Users.UpdataUser())
                {
                    MessageBox.Show($"User with {_Users.ID} id Updated successfuly", "successfuly");
                    _LoadData();
                }
                else
                {
                    MessageBox.Show($"Something went wrong", "Error");
                }


            }
           
           
        }

        
    }
}
