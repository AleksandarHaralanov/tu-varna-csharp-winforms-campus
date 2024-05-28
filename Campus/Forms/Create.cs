using Microsoft.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace Campus
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        private bool ValidateName(Control inputField, string errorMessage)
        {
            string name = inputField.Text.Trim();
            if (string.IsNullOrEmpty(name) || !Regex.IsMatch(name, @"^[a-zA-Z\u0400-\u04FF\s]+$"))
            {
                errorProvider.SetError(inputField, errorMessage);
                return true;
            }
            errorProvider.Clear();
            return false;
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
            string input = inputField.Text.Trim();
            if (!Regex.IsMatch(input, @"^\d{10}$"))
            {
                errorProvider.SetError(inputField, errorMessage);
                return true;
            }
            errorProvider.Clear();
            return false;
        }

        private bool ValidateNotEmpty(ComboBox inputField, string errorMessage)
        {
            if (inputField.SelectedItem == null || string.IsNullOrWhiteSpace(inputField.SelectedItem.ToString()))
            {
                errorProvider.SetError(inputField, errorMessage);
                return true;
            }
            errorProvider.Clear();
            return false;
        }

        private bool ValidateIdentificationExists(Control inputField, string errorMessage)
        {
            string query = "SELECT document_identification FROM dbo.documents WHERE document_identification = @Identification";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@Identification", createIdentificationField.Text);

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

        private bool ValidatePhoneNumberExists(Control inputField, string errorMessage)
        {
            string query = "SELECT document_phone_number FROM dbo.documents WHERE document_phone_number = @PhoneNumber";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@PhoneNumber", createPhoneNumberField.Text);

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

        private void CreateDocument(string Identification, string Name, string FamilyStatus, string PhoneNumber, string TenantType)
        {
            string query = "INSERT INTO dbo.documents (document_identification, document_name, document_family_status, document_phone_number, document_tenant_type) VALUES (@Identification, @Name, @FamilyStatus, @PhoneNumber, @TenantType)";
            string queryPayment = "INSERT INTO dbo.payments (payment_identification, payment_rent, payment_internet, payment_electricity, payment_water) VALUES (@Identification, @Rent, @Internet, @Electricity, @Water)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@Identification", Identification);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@FamilyStatus", FamilyStatus);
                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    cmd.Parameters.AddWithValue("@TenantType", TenantType);
                    
                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                    }
                    
                    cmd.ExecuteNonQuery();
                }
                using (SqlCommand cmd = new SqlCommand(queryPayment, sqlConnection))
                {
                    Random random = new Random();
                    int internet = random.Next(15, 26);
                    int electricity = random.Next(25, 51);
                    int water = random.Next(10, 21);

                    cmd.Parameters.AddWithValue("@Identification", Identification);
                    cmd.Parameters.AddWithValue("@Rent", 80);
                    cmd.Parameters.AddWithValue("@Internet", internet);
                    cmd.Parameters.AddWithValue("Electricity", electricity);
                    cmd.Parameters.AddWithValue("Water", water);

                    cmd.ExecuteNonQuery();
                }
                Hide();
                new Manage().Show();
                MessageBox.Show($"Картон за '{Name}' беше създаден!", "Успешно създаване!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (!ValidateLength(createIdentificationField, "Въведете правилно ЕГН!") &&
                !ValidateInput(createNameField, "Въведете име!") &&
                !ValidateName(createNameField, "Въведете правилно име!") &&
                !ValidateNotEmpty(createFamilyStatus, "Въведете семеен статус!") &&
                !ValidateLength(createPhoneNumberField, "Въведете правилен телефонен номер!") &&
                !ValidateNotEmpty(createTenantType, "Изберете тип на наемател!") &&
                !ValidateIdentificationExists(createIdentificationField, "Вече съществува картон с това ЕГН!") &&
                !ValidatePhoneNumberExists(createPhoneNumberField, "Вече съществува картон с този телефонен номер!"))
            {
                CreateDocument(createIdentificationField.Text, createNameField.Text, createFamilyStatus.Text, createPhoneNumberField.Text, createTenantType.Text);
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
