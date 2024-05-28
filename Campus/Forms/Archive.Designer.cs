namespace Campus
{
    partial class Archive
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dialogLayout = new TableLayoutPanel();
            archiveGoBack = new LinkLabel();
            createHeading = new Label();
            archiveSelectTenant = new ComboBox();
            archiveCommit = new Button();
            sqlConnection = new Microsoft.Data.SqlClient.SqlConnection();
            dialogLayout.SuspendLayout();
            SuspendLayout();
            // 
            // dialogLayout
            // 
            dialogLayout.ColumnCount = 3;
            dialogLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.5F));
            dialogLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            dialogLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.5F));
            dialogLayout.Controls.Add(archiveGoBack, 1, 3);
            dialogLayout.Controls.Add(createHeading, 1, 0);
            dialogLayout.Controls.Add(archiveSelectTenant, 1, 1);
            dialogLayout.Controls.Add(archiveCommit, 1, 2);
            dialogLayout.Dock = DockStyle.Fill;
            dialogLayout.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            dialogLayout.Location = new Point(0, 0);
            dialogLayout.Name = "dialogLayout";
            dialogLayout.RowCount = 5;
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            dialogLayout.Size = new Size(247, 192);
            dialogLayout.TabIndex = 4;
            // 
            // archiveGoBack
            // 
            archiveGoBack.ActiveLinkColor = Color.FromArgb(0, 0, 192);
            archiveGoBack.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            archiveGoBack.AutoSize = true;
            archiveGoBack.Cursor = Cursors.Hand;
            archiveGoBack.LinkBehavior = LinkBehavior.HoverUnderline;
            archiveGoBack.LinkColor = Color.FromArgb(0, 0, 192);
            archiveGoBack.Location = new Point(18, 159);
            archiveGoBack.Margin = new Padding(0);
            archiveGoBack.Name = "archiveGoBack";
            archiveGoBack.Size = new Size(209, 15);
            archiveGoBack.TabIndex = 2;
            archiveGoBack.TabStop = true;
            archiveGoBack.Text = "Върни се назад";
            archiveGoBack.TextAlign = ContentAlignment.MiddleCenter;
            archiveGoBack.VisitedLinkColor = Color.FromArgb(0, 0, 192);
            archiveGoBack.LinkClicked += GoBack;
            // 
            // createHeading
            // 
            createHeading.AutoSize = true;
            createHeading.Dock = DockStyle.Fill;
            createHeading.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            createHeading.Location = new Point(18, 0);
            createHeading.Margin = new Padding(0);
            createHeading.Name = "createHeading";
            createHeading.Size = new Size(209, 57);
            createHeading.TabIndex = 7;
            createHeading.Text = "Приключване на картон";
            createHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // archiveSelectTenant
            // 
            archiveSelectTenant.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            archiveSelectTenant.DropDownStyle = ComboBoxStyle.DropDownList;
            archiveSelectTenant.FormattingEnabled = true;
            archiveSelectTenant.Location = new Point(21, 69);
            archiveSelectTenant.Name = "archiveSelectTenant";
            archiveSelectTenant.Size = new Size(203, 23);
            archiveSelectTenant.TabIndex = 0;
            // 
            // archiveCommit
            // 
            archiveCommit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            archiveCommit.AutoSize = true;
            archiveCommit.Location = new Point(21, 116);
            archiveCommit.Name = "archiveCommit";
            archiveCommit.Size = new Size(203, 25);
            archiveCommit.TabIndex = 1;
            archiveCommit.Text = "Прикючи";
            archiveCommit.UseVisualStyleBackColor = true;
            archiveCommit.Click += Confirm;
            // 
            // sqlConnection
            // 
            sqlConnection.AccessTokenCallback = null;
            sqlConnection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\aleks\\source\\repos\\Campus\\Campus\\Database\\Database.mdf;Integrated Security=True";
            sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // Archive
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(247, 192);
            Controls.Add(dialogLayout);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Archive";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Приключване на картон";
            FormClosed += ExitApp;
            Load += LoadWindow;
            dialogLayout.ResumeLayout(false);
            dialogLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel dialogLayout;
        private LinkLabel archiveGoBack;
        private Label createHeading;
        private ComboBox archiveSelectTenant;
        private Button archiveCommit;
        private Microsoft.Data.SqlClient.SqlConnection sqlConnection;
    }
}