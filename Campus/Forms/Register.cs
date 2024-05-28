using Microsoft.Data.SqlClient;
using System.Data;

namespace Campus
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private bool ValidateInput(Control inputField, Control errorField, string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(inputField.Text))
            {
                errorProvider.SetError(errorField, errorMessage);
                return true;
            }
            errorProvider.Clear();
            return false;
        }

        private bool ValidatePasswordMatch()
        {
            if (!string.Equals(registerPasswordField.Text, registerRepeatPasswordField.Text))
            {
                errorProvider.SetError(registerPasswordBox, "Паролите не съвпадат!");
                return true;
            }
            errorProvider.Clear();
            return false;
        }

        private bool ValidateSecurityQuestion()
        {
            if (registerSecurityQuestion.SelectedItem == null || string.IsNullOrWhiteSpace(registerSecurityQuestion.SelectedItem.ToString()))
            {
                errorProvider.SetError(registerSecurityBox, "Изберете въпрос за защита!");
                return true;
            }
            errorProvider.Clear();
            return false;
        }

        private bool ValidateAccount()
        {
            string query = "SELECT account_username FROM dbo.accounts WHERE account_username = @Username";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@Username", registerUsernameField.Text);

                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                    }

                    object obj = cmd.ExecuteScalar();
                    if (obj != null)
                    {
                        errorProvider.SetError(registerUsernameBox, "Вече съществува акаунт с това потребителско име!");
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

        private void CreateAccount(string Username, string Password, string Question, string Answer)
        {
            string query = "INSERT INTO dbo.accounts (account_username, account_password, account_sec_question, account_sec_answer) VALUES (@Username, @Password, @Question, @Answer)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@Question", Question);
                    cmd.Parameters.AddWithValue("@Answer", Answer);

                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                    }

                    cmd.ExecuteNonQuery();
                }
                Hide();
                new Access().Show();
                MessageBox.Show($"Акаунт '{Username}' беше създаден!", "Успешна регистрация!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (!ValidateInput(registerUsernameField, registerUsernameBox, "Въведете потребителско име!") &&
                !ValidateInput(registerPasswordField, registerPasswordBox, "Въведете парола на празните полета!") &&
                !ValidateInput(registerRepeatPasswordField, registerPasswordBox, "Въведете парола на празните полета!") &&
                !ValidatePasswordMatch() &&
                !ValidateSecurityQuestion() &&
                !ValidateInput(registerSecurityAnswer, registerSecurityBox, "Въведете отговор на въпроса за защита!") &&
                !ValidateAccount())
            {
                CreateAccount(registerUsernameField.Text, registerPasswordField.Text, registerSecurityQuestion.Text, registerSecurityAnswer.Text);
            }
        }

        private void GoBack(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new Access().Show();
        }

        private void ExitApp(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
