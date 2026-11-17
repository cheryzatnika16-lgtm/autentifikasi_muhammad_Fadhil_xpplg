using MySql.Data.MySqlClient;

namespace SchoolApp
{
    public static class Validation
    {
        public static bool UniqueData(string table, string entity, string inputUser)
        {
            Connection conn = new Connection();

            using (MySqlConnection connection = conn.ConnectionToSQl())
            {
                bool isRegistered = false;

                try
                {
                    connection.Open();
                    string query = $"SELECT {entity} FROM {table} WHERE ({entity}=@inputUser)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@inputUser", inputUser);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        // Jika count lebih besar dari 0, berarti data ada (true), jika 0, data tidak ada (false).
                        isRegistered = count > 0;
                        return isRegistered;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Koneksi Gagal. Error: {ex.Message}");
                }

                return false;
            }
        }
    }
}
