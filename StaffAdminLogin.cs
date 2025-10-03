using MySql.Data.MySqlClient;
using StudentSelf_ServiceRequestAndSupplyManagementSystem.components.Others;
using StudentSelf_ServiceRequestAndSupplyManagementSystem.components.StaffAdmin.Admin;
using StudentSelf_ServiceRequestAndSupplyManagementSystem.components.StaffAdmin.BusiCenter;
using StudentSelf_ServiceRequestAndSupplyManagementSystem.components.StaffAdmin.Cashier;
using StudentSelf_ServiceRequestAndSupplyManagementSystem.components.StaffAdmin.Registrar;
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

namespace StudentSelf_ServiceRequestAndSupplyManagementSystem
{
    public partial class StaffAdminLogin : Form
    {
        public StaffAdminLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=1234;database=capstone_one"))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM staff_userlogin WHERE staff_userid = @staff_userid AND password = @password";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@staff_userid", textBox4.Text);
                        command.Parameters.AddWithValue("@password", textBox1.Text);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count == 1)
                        {
                            string queryRole = "SELECT staff_userrole FROM staff_userlogin WHERE staff_userid = @staff_userid";
                            using (MySqlCommand commandRole = new MySqlCommand(queryRole, conn))
                            {
                                commandRole.Parameters.AddWithValue("@staff_userid", textBox4.Text);

                                string? userRole = commandRole.ExecuteScalar()?.ToString();

                                if (!string.IsNullOrEmpty(userRole))
                                {
                                    this.Hide();
                                    switch (userRole.ToLower())
                                    {
                                        case "admin":
                                            new AdminDashboard().Show();
                                            break;
                                        case "busicenter":
                                            new BusiCenterDashboard().Show();
                                            break;
                                        case "cashier":
                                            new CashierDashboard().Show();
                                            break;
                                        case "registrar":
                                            new RegistrarDashboard().Show();
                                            break;
                                        default:
                                            new NotFound404().Show();
                                            break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username and/or Password is incorrect!", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to the database: " + ex.Message, "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StaffAdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
