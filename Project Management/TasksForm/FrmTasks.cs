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
    public partial class FrmTasks : Form
    {
        public FrmTasks()
        {
            InitializeComponent();
        }
        private void _RefrashTasksData()
        {
            DataView Dv = ClsTasks.GetAllTask().DefaultView;
            DgvTasks.DataSource = Dv;
            DgvTasks.Columns["Description"].Visible = false;
        }
        private void FrmTasks_Load(object sender, EventArgs e)
        {
            _RefrashTasksData();
        }

        private void DgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtAddNew_Click(object sender, EventArgs e)
        {
            Form FrmAddTask = new FrmAddAndEditTask();
            FrmAddTask.ShowDialog();
            _RefrashTasksData();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FrmAddTask = new FrmAddAndEditTask((int)DgvTasks.CurrentRow.Cells[0].Value);
            FrmAddTask.ShowDialog();
            _RefrashTasksData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int taslID = (int)DgvTasks.CurrentRow.Cells[0].Value;
            DialogResult result= MessageBox.Show($"Are you sure you want delete task with {taslID} id","To be sure",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if(ClsTasks.DeleteTask(taslID))
                {
                    MessageBox.Show($"Task with {taslID} id deleted successfuly");
                    _RefrashTasksData();
                }
                else
                    MessageBox.Show("Something went wrong");
                
            }
        }
    }
}
