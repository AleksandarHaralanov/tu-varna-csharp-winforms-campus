using Microsoft.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Campus
{
    public partial class Update : Form
    {
        private object originalPhoneNumber;
        public Update()
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
                        updateSelectTenant.Items.Add(reader["document_identification"].ToString());
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

        private bool ValidateInput(Control inputField, string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(inputField.Text))
            {
                errorProvider.SetError(inputField, errorMessage);
                return true;
            }
            errorProvider.Clear();
            return false;
        }

        private bool ValidateLength(Control inputField, string errorMessage)
        {
            if (inputField.Text.Length != 10)
            {
                errorProvider.SetError(inputField, errorMessage);
                return true;
            }
            errorProvider.Clear();
            return false;
        }

        private bool ValidateIdentificationExists(Control inputField, string errorMessage)
        {
            if (updateSelectTenant.Text == updateIdentificationField.Text)
            {
                errorProvider.Clear();
                return false;
            }
            else
            {
                try
                {
                    string query = "SELECT document_identification FROM dbo.documents WHERE document_identification = @Identification";
                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@Identification", updateIdentificationField.Text);

                        if (sqlConnection.State == ConnectionState.Closed)
                        {
                            sqlConnection.Open();
                        }

                        object obj = cmd.ExecuteScalar();

                        if (obj != null)
                        {
                            errorProvider.SetError(inputField, errorMessage);
                            return true;
                        }
                    }
                    errorProvider.Clear();
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
                finally
                {
                    if (sqlConnection.State == ConnectionState.Open)
                    {
                        sqlConnection.Close();
                    }
                }
            }
        }

        private bool ValidatePhoneNumberExists(object originalPhoneNumber, Control inputField, string errorMessage)
        {
            if (inputField.Text == originalPhoneNumber.ToString())
            {
                errorProvider.Clear();
                return false;
            }
            else
            {
                try
                {
                    string query = "SELECT document_phone_number FROM dbo.documents WHERE document_phone_number = @PhoneNumber";
                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@PhoneNumber", updatePhoneNumberField.Text);

                        if (sqlConnection.State == ConnectionState.Closed)
                        {
                            sqlConnection.Open();
                        }

                        object obj = cmd.ExecuteScalar();

                        if (obj != null)
                        {
                            errorProvider.SetError(inputField, errorMessage);
                            return true;
                        }
                    }
                    errorProvider.Clear();
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
                finally
                {
                    if (sqlConnection.State == ConnectionState.Open)
                    {
                        sqlConnection.Close();
                    }
                }
            }
        }

        private void TenantSelected(object sender, EventArgs e)
        {
            updateDetailsBox.Enabled = true;
            updateDocument.Enabled = true;

            try
            {
                string query = "SELECT * FROM dbo.documents WHERE document_identification = @Identification";
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@Identification", updateSelectTenant.SelectedItem.ToString());

                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                    }

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        updateIdentificationField.Text = reader["document_identification"].ToString();
                        updateNameField.Text = reader["document_name"].ToString();
                        updatePhoneNumberField.Text = reader["document_phone_number"].ToString();
                        updateFamilyStatus.SelectedItem = reader["document_family_status"].ToString();
                        updateTenantType.SelectedItem = reader["document_tenant_type"].ToString();

                        originalPhoneNumber = reader["document_phone_number"];
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

        private void UpdatePayment(string identification, string newIdentification)
        {
            try
            {
                string query = "UPDATE dbo.payments SET payment_identification = @newIdentification WHERE payment_identification = @identification";
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@identification", identification);
                    cmd.Parameters.AddWithValue("@newIdentification", newIdentification);

                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                    }

                    cmd.ExecuteNonQuery();
                }
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

        private void UpdateDocument(string identification, string newIdentification, string newName, string newFamilyStatus, string newPhoneNumber, string newTenantType)
        {
            try
            {
                string query = "UPDATE dbo.documents SET document_identification = @newIdentification, document_name = @newName, document_family_status = @newFamilyStatus, document_phone_number = @newPhoneNumber, document_tenant_type = @newTenantType WHERE document_identification = @identification";
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@identification", identification);
                    cmd.Parameters.AddWithValue("@newIdentification", newIdentification);
                    cmd.Parameters.AddWithValue("@newName", newName);
                    cmd.Parameters.AddWithValue("@newFamilyStatus", newFamilyStatus);
                    cmd.Parameters.AddWithValue("@newPhoneNumber", newPhoneNumber);
                    cmd.Parameters.AddWithValue("@newTenantType", newTenantType);

                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                    }

                    cmd.ExecuteNonQuery();

                    if (identification != newIdentification)
                    {
                        UpdatePayment(identification, newIdentification);
                    }
                }
                Hide();
                new Manage().Show();
                MessageBox.Show("Картонът беше актуализиран.", "Система", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void Confirm(object sender, EventArgs e)
        {
            if (!ValidateInput(updateIdentificationField, "Моля, въведете ЕГН.") &&
                !ValidateLength(updateIdentificationField, "ЕГН трябва да съдържа 10 цифри.") &&
                !ValidateInput(updateNameField, "Моля, въведете име.") &&
                !ValidateInput(updatePhoneNumberField, "Моля, въведете телефонен номер.") &&
                !ValidateLength(updatePhoneNumberField, "Телефонният номер трябва да съдържа 10 цифри.") &&
                !ValidateIdentificationExists(updateIdentificationField, "Въведеният ЕГН вече съществува.") &&
                !ValidatePhoneNumberExists(originalPhoneNumber, updatePhoneNumberField, "Въведеният телефонен номер вече съществува."))
            {
                UpdateDocument(updateSelectTenant.Text, updateIdentificationField.Text, updateNameField.Text, updateFamilyStatus.Text, updatePhoneNumberField.Text, updateTenantType.Text);
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
