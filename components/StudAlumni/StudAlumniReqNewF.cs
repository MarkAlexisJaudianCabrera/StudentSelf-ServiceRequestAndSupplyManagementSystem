using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSelf_ServiceRequestAndSupplyManagementSystem.components.StudAlumni
{
    public partial class StudAlumniReqNewF : Form
    {

        public StudAlumniReqNewF()
        {
            InitializeComponent();
        }

        private void StudAlumniReqNewF_Load(object sender, EventArgs e)
        {
            AcadDocs acadDocs = new AcadDocs();
            switchPanel(acadDocs);
        }
        public void switchPanel(Form panel)
        {
            panel5.Controls.Clear();
            panel.TopLevel = false;
            panel.FormBorderStyle = FormBorderStyle.None;
            panel.Dock = DockStyle.Fill;
            panel5.Controls.Add(panel);
            panel.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                AcadDocs acadDocs = new AcadDocs();
                switchPanel(acadDocs);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Suppliess suppliess = new Suppliess();
                switchPanel(suppliess);
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
