namespace Campus
{
    partial class Update
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
            components = new System.ComponentModel.Container();
            dialogLayout = new TableLayoutPanel();
            updateDocument = new Button();
            updateGoBack = new LinkLabel();
            createHeading = new Label();
            updateDetailsBox = new GroupBox();
            createLayout = new TableLayoutPanel();
            updateIdentificationLabel = new Label();
            updateNameLabel = new Label();
            updateTenantTypeLabel = new Label();
            updateIdentificationField = new TextBox();
            updateNameField = new TextBox();
            updateTenantType = new ComboBox();
            updatePhoneNumberField = new TextBox();
            updateFamilyStatusLabel = new Label();
            updatePhoneNumberLabel = new Label();
            updateFamilyStatus = new ComboBox();
            updateSelectTenant = new ComboBox();
            errorProvider = new ErrorProvider(components);
            sqlConnection = new Microsoft.Data.SqlClient.SqlConnection();
            dialogLayout.SuspendLayout();
            updateDetailsBox.SuspendLayout();
            createLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // dialogLayout
            // 
            dialogLayout.ColumnCount = 3;
            dialogLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.5F));
            dialogLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            dialogLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.5F));
            dialogLayout.Controls.Add(updateDocument, 1, 3);
            dialogLayout.Controls.Add(updateGoBack, 1, 4);
            dialogLayout.Controls.Add(createHeading, 1, 0);
            dialogLayout.Controls.Add(updateDetailsBox, 1, 2);
            dialogLayout.Controls.Add(updateSelectTenant, 1, 1);
            dialogLayout.Dock = DockStyle.Fill;
            dialogLayout.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            dialogLayout.Location = new Point(0, 0);
            dialogLayout.Name = "dialogLayout";
            dialogLayout.RowCount = 5;
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 7.5F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 67.5F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 7.5F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            dialogLayout.Size = new Size(291, 459);
            dialogLayout.TabIndex = 2;
            // 
            // updateDocument
            // 
            updateDocument.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            updateDocument.AutoSize = true;
            updateDocument.Enabled = false;
            updateDocument.Location = new Point(24, 404);
            updateDocument.Name = "updateDocument";
            updateDocument.Size = new Size(241, 25);
            updateDocument.TabIndex = 6;
            updateDocument.Text = "Промени";
            updateDocument.UseVisualStyleBackColor = true;
            updateDocument.Click += Confirm;
            // 
            // updateGoBack
            // 
            updateGoBack.ActiveLinkColor = Color.FromArgb(0, 0, 192);
            updateGoBack.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            updateGoBack.AutoSize = true;
            updateGoBack.Cursor = Cursors.Hand;
            updateGoBack.LinkBehavior = LinkBehavior.HoverUnderline;
            updateGoBack.LinkColor = Color.FromArgb(0, 0, 192);
            updateGoBack.Location = new Point(21, 439);
            updateGoBack.Margin = new Padding(0);
            updateGoBack.Name = "updateGoBack";
            updateGoBack.Size = new Size(247, 15);
            updateGoBack.TabIndex = 7;
            updateGoBack.TabStop = true;
            updateGoBack.Text = "Върни се назад";
            updateGoBack.TextAlign = ContentAlignment.MiddleCenter;
            updateGoBack.VisitedLinkColor = Color.FromArgb(0, 0, 192);
            updateGoBack.LinkClicked += GoBack;
            // 
            // createHeading
            // 
            createHeading.AutoSize = true;
            createHeading.Dock = DockStyle.Fill;
            createHeading.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            createHeading.Location = new Point(21, 0);
            createHeading.Margin = new Padding(0);
            createHeading.Name = "createHeading";
            createHeading.Size = new Size(247, 57);
            createHeading.TabIndex = 7;
            createHeading.Text = "Актуализиране на картон";
            createHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // updateDetailsBox
            // 
            updateDetailsBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            updateDetailsBox.Controls.Add(createLayout);
            updateDetailsBox.Dock = DockStyle.Fill;
            updateDetailsBox.Enabled = false;
            updateDetailsBox.Location = new Point(24, 94);
            updateDetailsBox.Name = "updateDetailsBox";
            updateDetailsBox.Size = new Size(241, 303);
            updateDetailsBox.TabIndex = 8;
            updateDetailsBox.TabStop = false;
            updateDetailsBox.Text = "Данни за картон на наемател";
            // 
            // createLayout
            // 
            createLayout.ColumnCount = 3;
            createLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.5F));
            createLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            createLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.5F));
            createLayout.Controls.Add(updateIdentificationLabel, 1, 0);
            createLayout.Controls.Add(updateNameLabel, 1, 2);
            createLayout.Controls.Add(updateTenantTypeLabel, 1, 8);
            createLayout.Controls.Add(updateIdentificationField, 1, 1);
            createLayout.Controls.Add(updateNameField, 1, 3);
            createLayout.Controls.Add(updateTenantType, 1, 9);
            createLayout.Controls.Add(updatePhoneNumberField, 1, 5);
            createLayout.Controls.Add(updateFamilyStatusLabel, 1, 6);
            createLayout.Controls.Add(updatePhoneNumberLabel, 1, 4);
            createLayout.Controls.Add(updateFamilyStatus, 1, 7);
            createLayout.Dock = DockStyle.Fill;
            createLayout.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            createLayout.Location = new Point(3, 19);
            createLayout.Name = "createLayout";
            createLayout.RowCount = 10;
            createLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            createLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            createLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            createLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            createLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            createLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            createLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            createLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            createLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            createLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            createLayout.Size = new Size(235, 281);
            createLayout.TabIndex = 1;
            // 
            // updateIdentificationLabel
            // 
            updateIdentificationLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            updateIdentificationLabel.AutoSize = true;
            updateIdentificationLabel.Location = new Point(20, 0);
            updateIdentificationLabel.Name = "updateIdentificationLabel";
            updateIdentificationLabel.Size = new Size(31, 28);
            updateIdentificationLabel.TabIndex = 0;
            updateIdentificationLabel.Text = "ЕГН:";
            updateIdentificationLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // updateNameLabel
            // 
            updateNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            updateNameLabel.AutoSize = true;
            updateNameLabel.Location = new Point(20, 56);
            updateNameLabel.Name = "updateNameLabel";
            updateNameLabel.Size = new Size(68, 28);
            updateNameLabel.TabIndex = 1;
            updateNameLabel.Text = "Три имена:";
            updateNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // updateTenantTypeLabel
            // 
            updateTenantTypeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            updateTenantTypeLabel.AutoSize = true;
            updateTenantTypeLabel.Location = new Point(20, 224);
            updateTenantTypeLabel.Name = "updateTenantTypeLabel";
            updateTenantTypeLabel.Size = new Size(101, 28);
            updateTenantTypeLabel.TabIndex = 4;
            updateTenantTypeLabel.Text = "Тип на наемател:";
            updateTenantTypeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // updateIdentificationField
            // 
            updateIdentificationField.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            updateIdentificationField.Location = new Point(20, 31);
            updateIdentificationField.MaxLength = 10;
            updateIdentificationField.Name = "updateIdentificationField";
            updateIdentificationField.Size = new Size(193, 23);
            updateIdentificationField.TabIndex = 1;
            // 
            // updateNameField
            // 
            updateNameField.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            updateNameField.Location = new Point(20, 87);
            updateNameField.MaxLength = 35;
            updateNameField.Name = "updateNameField";
            updateNameField.Size = new Size(193, 23);
            updateNameField.TabIndex = 2;
            // 
            // updateTenantType
            // 
            updateTenantType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            updateTenantType.Cursor = Cursors.Hand;
            updateTenantType.DropDownStyle = ComboBoxStyle.DropDownList;
            updateTenantType.FormattingEnabled = true;
            updateTenantType.ItemHeight = 15;
            updateTenantType.Items.AddRange(new object[] { "Студент", "Докторант", "Преподавател" });
            updateTenantType.Location = new Point(20, 255);
            updateTenantType.MaxDropDownItems = 5;
            updateTenantType.Name = "updateTenantType";
            updateTenantType.Size = new Size(193, 23);
            updateTenantType.TabIndex = 5;
            updateTenantType.Tag = "";
            // 
            // updatePhoneNumberField
            // 
            updatePhoneNumberField.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            updatePhoneNumberField.Location = new Point(20, 143);
            updatePhoneNumberField.MaxLength = 10;
            updatePhoneNumberField.Name = "updatePhoneNumberField";
            updatePhoneNumberField.Size = new Size(193, 23);
            updatePhoneNumberField.TabIndex = 3;
            // 
            // updateFamilyStatusLabel
            // 
            updateFamilyStatusLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            updateFamilyStatusLabel.AutoSize = true;
            updateFamilyStatusLabel.Location = new Point(20, 168);
            updateFamilyStatusLabel.Name = "updateFamilyStatusLabel";
            updateFamilyStatusLabel.Size = new Size(89, 28);
            updateFamilyStatusLabel.TabIndex = 2;
            updateFamilyStatusLabel.Text = "Семеен статус:";
            updateFamilyStatusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // updatePhoneNumberLabel
            // 
            updatePhoneNumberLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            updatePhoneNumberLabel.AutoSize = true;
            updatePhoneNumberLabel.Location = new Point(20, 112);
            updatePhoneNumberLabel.Name = "updatePhoneNumberLabel";
            updatePhoneNumberLabel.Size = new Size(110, 28);
            updatePhoneNumberLabel.TabIndex = 3;
            updatePhoneNumberLabel.Text = "Телефонен номер:";
            updatePhoneNumberLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // updateFamilyStatus
            // 
            updateFamilyStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            updateFamilyStatus.Cursor = Cursors.Hand;
            updateFamilyStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            updateFamilyStatus.FormattingEnabled = true;
            updateFamilyStatus.ItemHeight = 15;
            updateFamilyStatus.Items.AddRange(new object[] { "Неженен/а", "Омъжен/а", "Разведен/а", "Вдовец/ица" });
            updateFamilyStatus.Location = new Point(20, 199);
            updateFamilyStatus.MaxDropDownItems = 5;
            updateFamilyStatus.Name = "updateFamilyStatus";
            updateFamilyStatus.Size = new Size(193, 23);
            updateFamilyStatus.TabIndex = 4;
            updateFamilyStatus.Tag = "";
            // 
            // updateSelectTenant
            // 
            updateSelectTenant.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            updateSelectTenant.DropDownStyle = ComboBoxStyle.DropDownList;
            updateSelectTenant.FormattingEnabled = true;
            updateSelectTenant.Location = new Point(24, 62);
            updateSelectTenant.Name = "updateSelectTenant";
            updateSelectTenant.Size = new Size(241, 23);
            updateSelectTenant.TabIndex = 9;
            updateSelectTenant.SelectedIndexChanged += TenantSelected;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // sqlConnection
            // 
            sqlConnection.AccessTokenCallback = null;
            sqlConnection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\aleks\\source\\repos\\Campus\\Campus\\Database\\Database.mdf;Integrated Security=True";
            sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // Update
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(291, 459);
            Controls.Add(dialogLayout);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Update";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Актуализиране на картон";
            FormClosed += ExitApp;
            Load += LoadWindow;
            dialogLayout.ResumeLayout(false);
            dialogLayout.PerformLayout();
            updateDetailsBox.ResumeLayout(false);
            createLayout.ResumeLayout(false);
            createLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel dialogLayout;
        private Button updateDocument;
        private LinkLabel updateGoBack;
        private Label createHeading;
        private GroupBox updateDetailsBox;
        private TableLayoutPanel createLayout;
        private Label updateIdentificationLabel;
        private Label updateNameLabel;
        private Label updateTenantTypeLabel;
        private TextBox updateIdentificationField;
        private TextBox updateNameField;
        private ComboBox updateTenantType;
        private TextBox updatePhoneNumberField;
        private Label updateFamilyStatusLabel;
        private Label updatePhoneNumberLabel;
        private ComboBox updateFamilyStatus;
        private ErrorProvider errorProvider;
        private Microsoft.Data.SqlClient.SqlConnection sqlConnection;
        private ComboBox updateSelectTenant;
    }
}