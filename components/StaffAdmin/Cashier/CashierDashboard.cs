using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSelf_ServiceRequestAndSupplyManagementSystem.components.StaffAdmin.Cashier
{
    public partial class CashierDashboard : Form
    {
        public CashierDashboard()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose(true);
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
        private DialogResult PreClosingConfirmation()
        {
            return MessageBox.Show("Are you sure you want to close the system?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void CashierDashboard_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        bool expand = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (expand == false)
            {
                flowLayoutPanel1.Height += 10;
                if (flowLayoutPanel1.Height >= flowLayoutPanel1.MaximumSize.Height)
                {
                    timer1.Stop();
                    expand = true;
                }
            }
            else
            {
                flowLayoutPanel1.Height -= 10;
                if (flowLayoutPanel1.Height <= flowLayoutPanel1.MinimumSize.Height)
                {
                    timer1.Stop();
                    expand = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 StartUpPage = new Form1();
            this.Hide();
            StartUpPage.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
