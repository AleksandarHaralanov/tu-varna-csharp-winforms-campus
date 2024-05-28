using Microsoft.Data.SqlClient;
using System.Data;

namespace Campus
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void LoadWindow(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT document_identification FROM dbo.documents";
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                    }

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        viewSelectTenant.Items.Add(reader["document_identification"].ToString());
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
                string query = "SELECT * FROM dbo.documents WHERE document_identification = @Identification";
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@Identification", viewSelectTenant.SelectedItem.ToString());

                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                    }

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        viewNameField.Text = reader["document_name"].ToString();
                        viewPhoneNumberField.Text = reader["document_phone_number"].ToString();
                        viewFamilyStatusField.Text = reader["document_family_status"].ToString();
                        viewTenantTypeField.Text = reader["document_tenant_type"].ToString();
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

        private void GoBack(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new Manage().Show();
        }

        private void ExitApp(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
