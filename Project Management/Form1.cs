using Project_Management.TasksForm;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           Form Frmproject = new FrmProject();
            Frmproject.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void guna2Button2_Click_2(object sender, EventArgs e)
        {
           

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            Form Frmproject = new FrmProject();
            panel1.Controls.Clear();
            Frmproject.TopLevel = false;
            Frmproject.FormBorderStyle = FormBorderStyle.None;

            panel1.Controls.Add(Frmproject);
            Frmproject.Show();

        }

        private void guna2Button2_Click_3(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            FrmUsers frmUser = new FrmUsers();
            frmUser.TopLevel = false;
            frmUser.FormBorderStyle = FormBorderStyle.None;
            this.Size = frmUser.Size;
            panel1.Controls.Add(frmUser);
            frmUser.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           panel1.Controls.Clear();
            Form FrmTasks = new FrmTasks();
            FrmTasks.TopLevel = false;
            FrmTasks.FormBorderStyle = FormBorderStyle.None;
            this.Size = FrmTasks.Size;  
            panel1.Controls.Add(FrmTasks);
            FrmTasks.Show();
        }
    }
}
