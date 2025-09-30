using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectManagementBusinessLayer;

namespace Project_Management
{
    public partial class FrmProject : Form
    {
        public FrmProject()
        {
            InitializeComponent();
        }

      

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            Form FrmAddProject = new FrmAddProject();
            FrmAddProject.ShowDialog();
            _RefrashProjectData();
        }
        private void _RefrashProjectData()
        {
            DataView Dv = ClsProject.GetAllProject().DefaultView;

            
            
           

            ProjectDataView.DataSource = Dv;
            ProjectDataView.Columns["Description"].Visible = false;

        }

        private void FrmProject_Load(object sender, EventArgs e)
        {
            _RefrashProjectData();
        }

        private void ProjectDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditProject Edit = new FrmEditProject((int)ProjectDataView.CurrentRow.Cells[0].Value);
            Edit.ShowDialog();
            _RefrashProjectData();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete {(string)ProjectDataView.CurrentRow.Cells[1].Value} project","To be sure",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            { 
                if(ClsProject.DeleteById((int)ProjectDataView.CurrentRow.Cells[0].Value))
                {
                    
                    MessageBox.Show("Deleted successfuly","Delete");
                    _RefrashProjectData();
                }
                else
                {
                    MessageBox.Show("Warning, try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
         
        }

        private void deToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProjectDetails Details = new FrmProjectDetails((int)ProjectDataView.CurrentRow.Cells[0].Value);
            Details.ShowDialog();
            _RefrashProjectData();
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
