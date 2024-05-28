using Microsoft.Data.SqlClient;
using System.Data;

namespace Campus
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void LoadWindow(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT payment_identification FROM dbo.payments WHERE payment_made = 0";
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                    }

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        paymentSelectTenant.Items.Add(reader["payment_identification"].ToString());
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void TenantSelected(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM dbo.payments WHERE payment_made = 0";
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                    }

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        paymentRentField.Text = reader["payment_rent"].ToString();
                        paymentInternetField.Text = reader["payment_internet"].ToString();
                        paymentElectricityField.Text = reader["payment_electricity"].ToString();
                        paymentWaterField.Text = reader["payment_water"].ToString();
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void Confirm(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE dbo.payments SET payment_made = 1 WHERE payment_identification = @identification";
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@identification", paymentSelectTenant.Text);

                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                    }

                    cmd.ExecuteNonQuery();
                }
                Hide();
                new Manage().Show();
                MessageBox.Show($"Сметки за '{paymentSelectTenant.Text}' бяха платени.", "Успешно плащане!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

        private void ExitApp(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void GoBack(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new Manage().Show();
        }
    }
}
