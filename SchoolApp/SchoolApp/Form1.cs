using MySql.Data.MySqlClient;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Xml.Linq;

namespace SchoolApp
{
    public partial class txtInstitution : Form
    {
        public txtInstitution()
        {
            InitializeComponent();
        }

        private string Connection()
        
        {
            return "server=localhost;database=pi_school;uid=root;password=;";
        }
        
        private void ShowData()
        {
            using (MySqlConnection connection = new MySqlConnection(Connection()))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT id,visitor,institution FROM visitors";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dgvData.DataSource = dataTable;
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
        }         
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "" && textInstitution.Text != "")
            {
                using (MySqlConnection connection = new MySqlConnection(Connection()))
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO visitors (visitor, institution) VALUES (@name, @institution)";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@name", txtName.Text);
                            command.Parameters.AddWithValue("@institution", textInstitution.Text);
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("Data saved successfully!", "Input Notif", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textInstitution.Clear();
                        txtName.Clear();

                        ShowData();

                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }

                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtInstitution_Load(object sender, EventArgs e)
        {

        }
    }
}
