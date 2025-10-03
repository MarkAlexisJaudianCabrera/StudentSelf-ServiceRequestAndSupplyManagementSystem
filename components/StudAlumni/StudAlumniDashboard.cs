using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StudentSelf_ServiceRequestAndSupplyManagementSystem.components.StudAlumni
{
    public partial class StudAlumniDashboard : Form
    {

        public StudAlumniDashboard()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            DialogResult confirmation = MessageBox.Show("Request Form window will be closed", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.No)
            {
                e.Cancel = true;
            }
            else if (confirmation == DialogResult.Yes)
            {
                new Form1().Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult returnconfirmation = MessageBox.Show("Are you sure you want to return to the home page?", "Return Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );

            if (returnconfirmation == DialogResult.Yes)
            {
                this.Close();
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

        private void StudAlumniDashboard_Load(object sender, EventArgs e)
        {
            StudAlumniReqNewF studAlumniReqNewF = new StudAlumniReqNewF();
            switchPanel(studAlumniReqNewF);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
