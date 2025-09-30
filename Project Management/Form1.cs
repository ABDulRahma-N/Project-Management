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
            Form FrmUser = new FrmUsers();
            FrmUser.ShowDialog();

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Form Frmproject = new FrmProject();
            Frmproject.ShowDialog();
        }
    }
}
