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

namespace Project_Management.TasksForm
{
    public partial class FrmAddAndEditTask : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        int TaskID;
        ClsTasks Task;

        public FrmAddAndEditTask(int id=-1)
        {
            TaskID = id;
            InitializeComponent();
            if (TaskID == -1)
            {
                _Mode = enMode.AddNew;
                Task = new ClsTasks();
            }
            else
            {
                _Mode = enMode.Update;
                Task = ClsTasks.Find(TaskID);
            }
        }

       

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _LoadProjectAndUsersIdData()
        {
            DataView ProjectIDs = ClsProject.GetAllProject().DefaultView;
            DataView UserIDs = ClsUsers.GetAllUser().DefaultView;
            for (int i = 0; i < ProjectIDs.Count; i++)
            {
                CbProjectId.Items.Add(ProjectIDs[i]["ID"]);
            }
            for (int i = 0; i < UserIDs.Count; i++)
            {
                CbUserId.Items.Add(UserIDs[i]["ID"]);
            }
        }
        private void FrmAddTask_Load(object sender, EventArgs e)
        {
            _LoadProjectAndUsersIdData();
            if (_Mode == enMode.Update)
            {
             _LoadTaskData();
            }
        }
        private void _LoadTaskData()
        {
            BtSubmit.Text = "Save";
            CbStatus.Visible = true;
            LStatus.Visible = true;
            LIdtitil.Visible = true;
            LTaskID.Text = Task.Id.ToString();
            LTaskID.Visible = true;
            CbProjectId.SelectedItem = Task.ProjectID;
            CbUserId.SelectedItem = Task.AssignedTo;
            TbTitle.Text = Task.Title;
            TbDescription.Text = Task.Description;
            DtpStartDate.Value = Task.StartDate;
            DtpPlannedEndDate.Value = Task.PlannedEndDate;
            CheckStatus();
        }
        private void CheckStatus()
        {
            
            if (Task.Status == "On Hold")
            {
                CbStatus.SelectedIndex = 0;
                Task.Status = "On Hold";
            }
            else if (Task.Status == "In Progress")
            {
                CbStatus.SelectedIndex = 1;
                Task.Status = "In Progress";
            }
            else if (Task.Status == "Completed")
            {
                CbStatus.SelectedIndex = 2;
                Task.Status = "Completed";
            }

        }
        private void CbProjectId_SelectedIndexChanged(object sender, EventArgs e)
        {
            Task.ProjectID = (int)CbProjectId.SelectedItem;
        }

        private void TbTitle_TextChanged(object sender, EventArgs e)
        {
            Task.Title = TbTitle.Text;
        }
        private void BtSubmit_Click(object sender, EventArgs e)
        {
            
            if(TbTitle.Text=="")
                {
                MessageBox.Show("Title is required","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            Task.Description = TbDescription.Text;
            Task.StartDate = DtpStartDate.Value;
            Task.PlannedEndDate = DtpPlannedEndDate.Value;

            if (_Mode==enMode.AddNew)
            {
            if (Task.AddNewTask())
            {
                MessageBox.Show($"Task added with ({Task.Id}) successfully","Add Task",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
            }
            else
            {
                MessageBox.Show("Error, try again","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    this.Close();
            }
            }
            else 
            {
                if (Task.UpdateTask())
                {
                    MessageBox.Show($"Task with {TaskID} id Updated successfuly");
                    this.Close();
                }
            }
        }

        private void CbUserId_SelectedIndexChanged(object sender, EventArgs e)
        {
            Task.AssignedTo = (int)CbUserId.SelectedItem;
        }

        private void CbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Task.Status =CbStatus.SelectedItem.ToString();
            if (Task.Status == "Completed")
            {
                Task.ActualEndDate = DateTime.Now;
            }
            else 
            {
                Task.ActualEndDate= DateTime.MinValue;
            }
        }
    }
}
