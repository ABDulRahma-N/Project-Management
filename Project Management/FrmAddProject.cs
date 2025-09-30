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
    public partial class FrmAddProject : Form
    {
        
        public FrmAddProject()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(TbName.Text=="")
            {
                MessageBox.Show("Project Name is required");
                return ;
            }
            ClsProject project=new ClsProject();
            project.Name = TbName.Text;
            project.Description = TbDescription.Text;
            project.PlannedEndDate = DtpPlannedEndDate.Value;
            project.StartDate = DtpStartDate.Value;
            
            if (project.AddProject()!=-1)
            {
                MessageBox.Show("Project Added Successfully", "Successfully");
                Form FrmProjectDetails = new FrmProjectDetails(project.ID);
                this.Close();
                FrmProjectDetails.ShowDialog();
            }
            else
                MessageBox.Show("Error Adding Project", "Error");
        }

       
    }
}
