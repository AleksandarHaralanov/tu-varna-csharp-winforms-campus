using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Campus
{
    public partial class Recovery : Form
    {
        public Recovery()
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

        private bool ValidateAccount()
        {
            string query = "SELECT account_username FROM dbo.accounts WHERE account_username = @Username";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@Username", recoveryUsernameField.Text);

                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                    }

                    object obj = cmd.ExecuteScalar();
                    if (obj == null)
                    {
                        errorProvider.SetError(recoveryUsernameBox, "Не съществува акаунт с това потребителско име!");
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

        private bool ValidateSecurity()
        {
            string query = "SELECT account_username FROM dbo.accounts WHERE account_username = @Username AND account_sec_answer = @Answer";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@Username", recoveryUsernameField.Text);
                    cmd.Parameters.AddWithValue("@Answer", recoverySecurityAnswer.Text);

                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                    }

                    object obj = cmd.ExecuteScalar();
                    if (obj == null)
                    {
                        errorProvider.SetError(recoverySecurityBox, "Вашият отговор е грешен!");
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

        private bool ValidatePasswordEmpty()
        {
            return ValidateInput(recoveryNewPasswordField, recoveryNewPasswordBox, "Въведете парола на празните полета!") ||
                   ValidateInput(recoveryRepeatNewPasswordField, recoveryNewPasswordBox, "Въведете парола на празните полета!");
        }

        private bool ValidatePasswordSame()
        {
            if (!string.Equals(recoveryNewPasswordField.Text, recoveryRepeatNewPasswordField.Text))
            {
                errorProvider.SetError(recoveryNewPasswordBox, "Паролите не съвпадат!");
                return true;
            }
            errorProvider.Clear();
            return false;
        }

        private bool ValidatePasswordIsNotCurrent()
        {
            string query = "SELECT account_password FROM dbo.accounts WHERE account_username = @Username AND account_password = @Password";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@Username", recoveryUsernameField.Text);
                    cmd.Parameters.AddWithValue("@Password", recoveryNewPasswordField.Text);

                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                    }

                    object obj = cmd.ExecuteScalar();
                    if (obj != null)
                    {
                        errorProvider.SetError(recoveryNewPasswordBox, "Не можете да смените паролата на такава, която вече се използва!");
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

        private void Confirm(string newPassword, string username)
        {
            try
            {
                string query = "UPDATE dbo.accounts SET account_password = @newPassword WHERE account_username = @Username";
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@newPassword", newPassword);
                    cmd.Parameters.AddWithValue("@Username", username);

                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                    }

                    cmd.ExecuteNonQuery();
                }
                Hide();
                new Access().Show();
                MessageBox.Show($"Паролата за акаунт '{username}' беше сменена!", "Поздравления!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void Proceed(object sender, EventArgs e)
        {
            switch (recoveryProgressBar.Value)
            {
                case 0:
                    if (!ValidateAccount())
                    {
                        recoveryProgressBar.PerformStep();
                        SetControlsState(false, recoveryUsernameBox);
                        SetControlsState(true, recoverySecurityBox);
                        LoadSecurityQuestion();
                    }
                    break;
                case 1:
                    if (!ValidateSecurity())
                    {
                        recoveryProgressBar.PerformStep();
                        recoveryProceed.Text = "Промени";
                        SetControlsState(false, recoverySecurityBox);
                        SetControlsState(true, recoveryNewPasswordBox);
                    }
                    break;
                case 2:
                    if (!ValidatePasswordEmpty() && !ValidatePasswordSame() && !ValidatePasswordIsNotCurrent())
                    {
                        recoveryProgressBar.PerformStep();
                        SetControlsState(false, recoveryNewPasswordBox);
                        ConfirmChanges();
                    }
                    break;
                default:
                    break;
            }
        }

        private void LoadSecurityQuestion()
        {
            string query = "SELECT account_sec_question FROM dbo.accounts WHERE account_username = @Username";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@Username", recoveryUsernameField.Text);

                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                    }

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        recoverySecurityQuestion.Text = result.ToString();
                    }
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

        private static void SetControlsState(bool enabled, Control container)
        {
            container.Enabled = enabled;
            foreach (Control control in container.Controls)
            {
                control.Enabled = enabled;
            }
        }

        private void ConfirmChanges()
        {
            DialogResult dialogResult = MessageBox.Show("Искате ли да потвърдите промяната?", "Потвърждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Confirm(recoveryNewPasswordField.Text, recoveryUsernameField.Text);
            }
            else
            {
                Hide();
                new Access().Show();
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
