using StudentSelf_ServiceRequestAndSupplyManagementSystem.components.StudAlumni;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSelf_ServiceRequestAndSupplyManagementSystem.components.StaffAdmin.Admin
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            DialogResult confirmation = MessageBox.Show("Admin window will be closed", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.No)
            {
                e.Cancel = true;
            }
            else if (confirmation == DialogResult.Yes)
            {
                new Form1().Show();
            }
        }

        public void switchPanel(Form panel)
        {
            panel1.Controls.Clear();
            panel.TopLevel = false;
            panel.FormBorderStyle = FormBorderStyle.None;
            panel.Dock = DockStyle.Fill;
            panel1.Controls.Add(panel);
            panel.Show();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            AdminDashboardDefault adminDashboardDefault = new AdminDashboardDefault();
            switchPanel(adminDashboardDefault);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult returnconfirmation = MessageBox.Show("Are you sure you want to log out?", "Log out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );

            if (returnconfirmation == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
