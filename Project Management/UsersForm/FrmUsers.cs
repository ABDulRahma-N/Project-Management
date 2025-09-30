using Project_Management.UsersForm;
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
    public partial class FrmUsers : Form
    {
        public FrmUsers()
        {
            InitializeComponent();
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            _RefreshUserData();
        }
        private void _RefreshUserData()
        {
            DgvUsers.DataSource = ClsUsers.GetAllUser();
        }

        private void BtAddNew_Click(object sender, EventArgs e)
        {
            Form FrmAddUser = new FrmAddAndUpdateUser();
            FrmAddUser.ShowDialog();
            _RefreshUserData();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FrmEdit = new FrmAddAndUpdateUser((int)DgvUsers.CurrentRow.Cells[0].Value);
            FrmEdit.ShowDialog();
            _RefreshUserData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want delete ({(string)DgvUsers.CurrentRow.Cells[1].Value}) ","To be sure",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (ClsUsers.DeleteUser((int)DgvUsers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User deleted successfuly");
                    _RefreshUserData();

                }
                else
                    MessageBox.Show("Something went wrong", "Wrong");

            }
        }
    }
}
