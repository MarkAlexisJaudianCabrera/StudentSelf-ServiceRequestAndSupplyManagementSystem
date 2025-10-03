using StudentSelf_ServiceRequestAndSupplyManagementSystem.components.StudAlumni;

namespace StudentSelf_ServiceRequestAndSupplyManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StaffAdminLogin().Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new StudAlumniDashboard().Show();
        }
    }
}
