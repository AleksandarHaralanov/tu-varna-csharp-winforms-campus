using Microsoft.Data.SqlClient;
using System.Data;

namespace Campus
{
    public partial class Access : Form
    {
        public Access()
        {
            InitializeComponent();
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

        private bool ValidateAccount(Control inputField, string errorMessage)
        {
            string query = "SELECT account_username, account_password FROM dbo.accounts WHERE account_username = @Username AND account_password = @Password";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@Username", accessUsernameField.Text);
                    cmd.Parameters.AddWithValue("@Password", accessPasswordField.Text);

                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                    }

                    object obj = cmd.ExecuteScalar();

                    if (obj == null)
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

        private void Recover(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new Recovery().Show();
        }

        private void Register(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new Register().Show();
        }

        private void Confirm(object sender, EventArgs e)
        {
            if (!ValidateInput(accessUsernameField, "Въведете потребителско име!") &&
                !ValidateInput(accessPasswordField, "Въведете парола!") &&
                !ValidateAccount(accessCredentialsBox, "Невалидно потребителско име и/или парола!"))
            {
                Hide();
                new Manage().Show();
                MessageBox.Show("Успешен вход в системата!", "Вход в системата", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExitApp(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
