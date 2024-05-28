using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Campus
{
    public partial class Archive : Form
    {
        public Archive()
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
                        archiveSelectTenant.Items.Add(reader["document_identification"].ToString());
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
                string insertQuery = "INSERT INTO dbo.archive_documents SELECT document_identification, document_name, document_family_status, document_phone_number, document_tenant_type FROM dbo.documents WHERE document_identification = @identification";
                string deleteQuery = "DELETE FROM dbo.documents WHERE document_identification = @identification";

                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                using (SqlTransaction transaction = sqlConnection.BeginTransaction())
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, sqlConnection, transaction))
                using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, sqlConnection, transaction))
                {
                    insertCmd.Parameters.AddWithValue("@identification", archiveSelectTenant.Text);
                    deleteCmd.Parameters.AddWithValue("@identification", archiveSelectTenant.Text);

                    insertCmd.ExecuteNonQuery();
                    deleteCmd.ExecuteNonQuery();

                    transaction.Commit();
                }

                insertQuery = "INSERT INTO dbo.archive_payments SELECT payment_identification, payment_rent, payment_internet, payment_electricity, payment_water, payment_made FROM dbo.payments WHERE payment_identification = @identification";
                deleteQuery = "DELETE FROM dbo.payments WHERE payment_identification = @identification";

                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                using (SqlTransaction transaction = sqlConnection.BeginTransaction())
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, sqlConnection, transaction))
                using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, sqlConnection, transaction))
                {
                    insertCmd.Parameters.AddWithValue("@identification", archiveSelectTenant.Text);
                    deleteCmd.Parameters.AddWithValue("@identification", archiveSelectTenant.Text);

                    insertCmd.ExecuteNonQuery();
                    deleteCmd.ExecuteNonQuery();

                    transaction.Commit();
                }
                Hide();
                new Manage().Show();
                MessageBox.Show("Картонът беше архивиран.", "Система", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
