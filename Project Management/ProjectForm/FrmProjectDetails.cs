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
    public partial class FrmProjectDetails : Form
    {
        private int _ProjectID = -1;
        private ClsProject _ProjectDetails;
        public FrmProjectDetails(int ProjectID)
        {
            InitializeComponent();
            _ProjectID = ProjectID;
            _ProjectDetails = ClsProject.Find(_ProjectID);

        }
        private void LoadProjectDetails()
        {
            _ProjectDetails = ClsProject.Find(_ProjectID);
            if (_ProjectDetails != null)
            {
                LProjectName.Text = _ProjectDetails.Name;
                LDescription.Text = _ProjectDetails.Description;
                LStartDate.Text = _ProjectDetails.StartDate.ToShortDateString();
                LPlannedEndDAte.Text = _ProjectDetails.PlannedEndDate.ToShortDateString();
                LoadProjectStatus();
                if (_ProjectDetails.ActualEndDate!=DateTime.MinValue)
                {
                    LActualEndDate.Visible = true;
                    LActualEndDate.Text = LActualEndDate.Text + (_ProjectDetails.ActualEndDate.Value.ToShortDateString());
                }
                else
                {
                    LActualEndDate.Visible = false;
                }

            }
            else
            {
                MessageBox.Show("Project not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void LoadProjectStatus()
        {
            LStatus.Text = _ProjectDetails.Status;
            if (_ProjectDetails.Status == "In Progress")
            {
                ShapStatus.FillColor=Color.DeepSkyBlue;
                ShapStatus.BorderColor=Color.DeepSkyBlue;
            }
            else if (_ProjectDetails.Status == "Completed")
            {
                ShapStatus.FillColor = Color.Green;
                ShapStatus.BorderColor = Color.Green;
            }
            else if (_ProjectDetails.Status == "On Hold")
            {
                ShapStatus.FillColor = Color.Yellow;
                ShapStatus.BorderColor = Color.Yellow;
            }
            else
            {
                ShapStatus.FillColor = Color.Gray;
                ShapStatus.BorderColor = Color.Gray;
            }

        }
        private void FrmProjectDetails_Load(object sender, EventArgs e)
        {
            LoadProjectDetails();
        }

        private void guna2Shapes1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            LDescription.MaximumSize = new Size(guna2Panel1.Width, 0);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form FrmEdit= new FrmEditProject(_ProjectID);
            FrmEdit.ShowDialog();
            LoadProjectDetails();
        }
    }
}
