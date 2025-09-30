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

namespace Project_Management
{
    public partial class FrmEditProject : Form
    {
       private ClsProject Update;
        public FrmEditProject(int id)
        {
            InitializeComponent();
            Update = ClsProject.Find(id);
        }
        private void LoadProjectData()
        {
           if (Update == null)
            {
                MessageBox.Show("Project not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            TbName.Text = Update.Name;
            TbDescription.Text = Update.Description;
            DtpStartDate.Value = Update.StartDate;
            DtpPlannedEndDate.Value = Update.PlannedEndDate;

            CheckStatus();
            
           
        }
        private void CheckStatus()
        {
            if (Update.Status == "On Hold")
            {
                CbStatus.SelectedIndex = 0;
                Update.Status="On Hold";
            }
            else if (Update.Status == "In Progress")
            {
                CbStatus.SelectedIndex = 1;
                Update.Status = "In Progress";
            }
            else if (Update.Status == "Completed")
            {
                CbStatus.SelectedIndex=2;
                Update.Status = "Completed";
            }
          
        }
        private void FrmEditProject_Load(object sender, EventArgs e)
        {
          LoadProjectData();
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Update.Status=CbStatus.SelectedItem.ToString();
            if (Update.Status == "Completed")
            {
                Update.ActualEndDate = DateTime.Now;
            }
            else
            {
                Update.ActualEndDate = DateTime.MinValue;
            }
        }

        private void DtpActualEndDate_ValueChanged(object sender, EventArgs e)
        {
           
        }

      

        private void TbName_TextChanged(object sender, EventArgs e)
        {
            Update.Name = TbName.Text;
        }

        private void TbDescription_TextChanged(object sender, EventArgs e)
        {
            Update.Description = TbDescription.Text;
        }

        private void DtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            Update.StartDate = DtpStartDate.Value;
        }

        private void DtpPlannedEndDate_ValueChanged(object sender, EventArgs e)
        {
            Update.PlannedEndDate = DtpPlannedEndDate.Value;
        }

        private void BSave_Click_1(object sender, EventArgs e)
        {
            if (TbName.Text == "")
            {
                MessageBox.Show("Project Name is required");
                return;
            }
            DialogResult result = MessageBox.Show($"Are you sure you want to update this project", "to be sure", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (Update.UpdateProject())
                {
                    MessageBox.Show("Project Updated Successfully", "Successfully");

                    this.Close();
                }
                else
                    MessageBox.Show("Error Updating Project", "Error");
            }
        }
    }
}
