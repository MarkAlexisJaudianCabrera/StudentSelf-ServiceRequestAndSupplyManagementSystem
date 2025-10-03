using MySql.Data.MySqlClient;
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
    public partial class AcadDocs : Form
    {
        public AcadDocs()
        {
            InitializeComponent();
            LoadComboBoxData();
        }
        private string connectionString = "server=127.0.0.1;port=3306;username=root;password=1234;database=capstone_one";
        private void LoadComboBoxData()
        {
            string query = "SELECT itemname FROM acaditemtb";

            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        MySqlDataReader reader = command.ExecuteReader();

                        // Loop through the results and add to the ComboBox
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader["itemname"].ToString());
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT itemprice FROM acaditemtb WHERE itemname = @ItemName";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    string selectedItemName = comboBox1.SelectedItem.ToString();
                    command.Parameters.AddWithValue("@ItemName", selectedItemName);

                    try
                    {
                        connection.Open();
                        object price = command.ExecuteScalar();

                        if (price != null)
                        {
                            decimal priceVal = Convert.ToDecimal(price);
                            label2.Text = string.Format("Price: ₱{0:F2}", priceVal);
                        }
                        else
                        {
                            label2.Text = "Price: Not Found";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching price: " + ex.Message);
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
