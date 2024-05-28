namespace Campus
{
    partial class View
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
            viewGoBack = new LinkLabel();
            createHeading = new Label();
            viewDetailsBox = new GroupBox();
            createLayout = new TableLayoutPanel();
            viewNameLabel = new Label();
            viewTenantTypeLabel = new Label();
            viewNameField = new Label();
            viewTenantTypeField = new Label();
            viewPhoneNumberField = new Label();
            viewFamilyStatusLabel = new Label();
            viewPhoneNumberLabel = new Label();
            viewFamilyStatusField = new Label();
            viewSelectTenant = new ComboBox();
            sqlConnection = new Microsoft.Data.SqlClient.SqlConnection();
            dialogLayout.SuspendLayout();
            viewDetailsBox.SuspendLayout();
            createLayout.SuspendLayout();
            SuspendLayout();
            // 
            // dialogLayout
            // 
            dialogLayout.ColumnCount = 3;
            dialogLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.5F));
            dialogLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            dialogLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.5F));
            dialogLayout.Controls.Add(viewGoBack, 1, 3);
            dialogLayout.Controls.Add(createHeading, 1, 0);
            dialogLayout.Controls.Add(viewDetailsBox, 1, 2);
            dialogLayout.Controls.Add(viewSelectTenant, 1, 1);
            dialogLayout.Dock = DockStyle.Fill;
            dialogLayout.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            dialogLayout.Location = new Point(0, 0);
            dialogLayout.Name = "dialogLayout";
            dialogLayout.RowCount = 4;
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 17.5F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 7.5F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 67.5F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 7.5F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            dialogLayout.Size = new Size(291, 459);
            dialogLayout.TabIndex = 2;
            // 
            // viewGoBack
            // 
            viewGoBack.ActiveLinkColor = Color.FromArgb(0, 0, 192);
            viewGoBack.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            viewGoBack.AutoSize = true;
            viewGoBack.Cursor = Cursors.Hand;
            viewGoBack.LinkBehavior = LinkBehavior.HoverUnderline;
            viewGoBack.LinkColor = Color.FromArgb(0, 0, 192);
            viewGoBack.Location = new Point(21, 433);
            viewGoBack.Margin = new Padding(0);
            viewGoBack.Name = "viewGoBack";
            viewGoBack.Size = new Size(247, 15);
            viewGoBack.TabIndex = 7;
            viewGoBack.TabStop = true;
            viewGoBack.Text = "Върни се назад";
            viewGoBack.TextAlign = ContentAlignment.MiddleCenter;
            viewGoBack.VisitedLinkColor = Color.FromArgb(0, 0, 192);
            viewGoBack.LinkClicked += GoBack;
            // 
            // createHeading
            // 
            createHeading.AutoSize = true;
            createHeading.Dock = DockStyle.Fill;
            createHeading.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            createHeading.Location = new Point(21, 0);
            createHeading.Margin = new Padding(0);
            createHeading.Name = "createHeading";
            createHeading.Size = new Size(247, 80);
            createHeading.TabIndex = 7;
            createHeading.Text = "Преглед на картон";
            createHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // viewDetailsBox
            // 
            viewDetailsBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            viewDetailsBox.Controls.Add(createLayout);
            viewDetailsBox.Dock = DockStyle.Fill;
            viewDetailsBox.Enabled = false;
            viewDetailsBox.Location = new Point(24, 117);
            viewDetailsBox.Name = "viewDetailsBox";
            viewDetailsBox.Size = new Size(241, 303);
            viewDetailsBox.TabIndex = 8;
            viewDetailsBox.TabStop = false;
            viewDetailsBox.Text = "Данни за картон на наемател";
            // 
            // createLayout
            // 
            createLayout.ColumnCount = 3;
            createLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.5F));
            createLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            createLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.5F));
            createLayout.Controls.Add(viewNameLabel, 1, 0);
            createLayout.Controls.Add(viewTenantTypeLabel, 1, 6);
            createLayout.Controls.Add(viewNameField, 1, 1);
            createLayout.Controls.Add(viewTenantTypeField, 1, 7);
            createLayout.Controls.Add(viewPhoneNumberField, 1, 3);
            createLayout.Controls.Add(viewFamilyStatusLabel, 1, 4);
            createLayout.Controls.Add(viewPhoneNumberLabel, 1, 2);
            createLayout.Controls.Add(viewFamilyStatusField, 1, 5);
            createLayout.Dock = DockStyle.Fill;
            createLayout.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            createLayout.Location = new Point(3, 19);
            createLayout.Name = "createLayout";
            createLayout.RowCount = 8;
            createLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            createLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            createLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            createLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            createLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            createLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            createLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            createLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            createLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            createLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            createLayout.Size = new Size(235, 281);
            createLayout.TabIndex = 1;
            // 
            // viewNameLabel
            // 
            viewNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            viewNameLabel.AutoSize = true;
            viewNameLabel.Location = new Point(20, 0);
            viewNameLabel.Name = "viewNameLabel";
            viewNameLabel.Size = new Size(68, 35);
            viewNameLabel.TabIndex = 1;
            viewNameLabel.Text = "Три имена:";
            viewNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // viewTenantTypeLabel
            // 
            viewTenantTypeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            viewTenantTypeLabel.AutoSize = true;
            viewTenantTypeLabel.Location = new Point(20, 210);
            viewTenantTypeLabel.Name = "viewTenantTypeLabel";
            viewTenantTypeLabel.Size = new Size(101, 35);
            viewTenantTypeLabel.TabIndex = 4;
            viewTenantTypeLabel.Text = "Тип на наемател:";
            viewTenantTypeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // viewNameField
            // 
            viewNameField.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            viewNameField.AutoSize = true;
            viewNameField.BackColor = SystemColors.Control;
            viewNameField.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            viewNameField.Location = new Point(20, 45);
            viewNameField.Name = "viewNameField";
            viewNameField.Size = new Size(193, 15);
            viewNameField.TabIndex = 2;
            viewNameField.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // viewTenantTypeField
            // 
            viewTenantTypeField.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            viewTenantTypeField.AutoSize = true;
            viewTenantTypeField.BackColor = SystemColors.Control;
            viewTenantTypeField.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            viewTenantTypeField.Location = new Point(20, 255);
            viewTenantTypeField.Name = "viewTenantTypeField";
            viewTenantTypeField.Size = new Size(193, 15);
            viewTenantTypeField.TabIndex = 5;
            viewTenantTypeField.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // viewPhoneNumberField
            // 
            viewPhoneNumberField.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            viewPhoneNumberField.AutoSize = true;
            viewPhoneNumberField.BackColor = SystemColors.Control;
            viewPhoneNumberField.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            viewPhoneNumberField.Location = new Point(20, 115);
            viewPhoneNumberField.Name = "viewPhoneNumberField";
            viewPhoneNumberField.Size = new Size(193, 15);
            viewPhoneNumberField.TabIndex = 3;
            viewPhoneNumberField.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // viewFamilyStatusLabel
            // 
            viewFamilyStatusLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            viewFamilyStatusLabel.AutoSize = true;
            viewFamilyStatusLabel.Location = new Point(20, 140);
            viewFamilyStatusLabel.Name = "viewFamilyStatusLabel";
            viewFamilyStatusLabel.Size = new Size(89, 35);
            viewFamilyStatusLabel.TabIndex = 2;
            viewFamilyStatusLabel.Text = "Семеен статус:";
            viewFamilyStatusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // viewPhoneNumberLabel
            // 
            viewPhoneNumberLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            viewPhoneNumberLabel.AutoSize = true;
            viewPhoneNumberLabel.Location = new Point(20, 70);
            viewPhoneNumberLabel.Name = "viewPhoneNumberLabel";
            viewPhoneNumberLabel.Size = new Size(110, 35);
            viewPhoneNumberLabel.TabIndex = 3;
            viewPhoneNumberLabel.Text = "Телефонен номер:";
            viewPhoneNumberLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // viewFamilyStatusField
            // 
            viewFamilyStatusField.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            viewFamilyStatusField.AutoSize = true;
            viewFamilyStatusField.BackColor = SystemColors.Control;
            viewFamilyStatusField.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            viewFamilyStatusField.Location = new Point(20, 185);
            viewFamilyStatusField.Name = "viewFamilyStatusField";
            viewFamilyStatusField.Size = new Size(193, 15);
            viewFamilyStatusField.TabIndex = 4;
            viewFamilyStatusField.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // viewSelectTenant
            // 
            viewSelectTenant.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            viewSelectTenant.DropDownStyle = ComboBoxStyle.DropDownList;
            viewSelectTenant.FormattingEnabled = true;
            viewSelectTenant.Location = new Point(24, 85);
            viewSelectTenant.Name = "viewSelectTenant";
            viewSelectTenant.Size = new Size(241, 23);
            viewSelectTenant.TabIndex = 9;
            viewSelectTenant.SelectedIndexChanged += TenantSelected;
            // 
            // sqlConnection
            // 
            sqlConnection.AccessTokenCallback = null;
            sqlConnection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\aleks\\source\\repos\\Campus\\Campus\\Database\\Database.mdf;Integrated Security=True";
            sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(291, 459);
            Controls.Add(dialogLayout);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "View";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Преглед на картон";
            FormClosed += ExitApp;
            Load += LoadWindow;
            dialogLayout.ResumeLayout(false);
            dialogLayout.PerformLayout();
            viewDetailsBox.ResumeLayout(false);
            createLayout.ResumeLayout(false);
            createLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel dialogLayout;
        private LinkLabel viewGoBack;
        private Label createHeading;
        private GroupBox viewDetailsBox;
        private TableLayoutPanel createLayout;
        private Label viewNameLabel;
        private Label viewTenantTypeLabel;
        private Label viewNameField;
        private Label viewTenantTypeField;
        private Label viewPhoneNumberField;
        private Label viewFamilyStatusLabel;
        private Label viewPhoneNumberLabel;
        private Label viewFamilyStatusField;
        private Microsoft.Data.SqlClient.SqlConnection sqlConnection;
        private ComboBox viewSelectTenant;
    }
}
