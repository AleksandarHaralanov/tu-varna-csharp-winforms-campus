namespace Campus
{
    partial class Create
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
            createDocument = new Button();
            createGoBack = new LinkLabel();
            createHeading = new Label();
            createDetailsBox = new GroupBox();
            createLayout = new TableLayoutPanel();
            createIdentificationLabel = new Label();
            createNameLabel = new Label();
            createTenantTypeLabel = new Label();
            createIdentificationField = new TextBox();
            createNameField = new TextBox();
            createTenantType = new ComboBox();
            createPhoneNumberField = new TextBox();
            createFamilyStatusLabel = new Label();
            createPhoneNumberLabel = new Label();
            createFamilyStatus = new ComboBox();
            errorProvider = new ErrorProvider(components);
            sqlConnection = new Microsoft.Data.SqlClient.SqlConnection();
            dialogLayout.SuspendLayout();
            createDetailsBox.SuspendLayout();
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
            dialogLayout.Controls.Add(createDocument, 1, 2);
            dialogLayout.Controls.Add(createGoBack, 1, 3);
            dialogLayout.Controls.Add(createHeading, 1, 0);
            dialogLayout.Controls.Add(createDetailsBox, 1, 1);
            dialogLayout.Dock = DockStyle.Fill;
            dialogLayout.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            dialogLayout.Location = new Point(0, 0);
            dialogLayout.Name = "dialogLayout";
            dialogLayout.RowCount = 5;
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 2.5F));
            dialogLayout.Size = new Size(291, 439);
            dialogLayout.TabIndex = 1;
            // 
            // createDocument
            // 
            createDocument.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            createDocument.AutoSize = true;
            createDocument.Location = new Point(24, 370);
            createDocument.Name = "createDocument";
            createDocument.Size = new Size(241, 25);
            createDocument.TabIndex = 5;
            createDocument.Text = "Създай";
            createDocument.UseVisualStyleBackColor = true;
            createDocument.Click += Confirm;
            // 
            // createGoBack
            // 
            createGoBack.ActiveLinkColor = Color.FromArgb(0, 0, 192);
            createGoBack.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            createGoBack.AutoSize = true;
            createGoBack.Cursor = Cursors.Hand;
            createGoBack.LinkBehavior = LinkBehavior.HoverUnderline;
            createGoBack.LinkColor = Color.FromArgb(0, 0, 192);
            createGoBack.Location = new Point(21, 407);
            createGoBack.Margin = new Padding(0);
            createGoBack.Name = "createGoBack";
            createGoBack.Size = new Size(247, 15);
            createGoBack.TabIndex = 6;
            createGoBack.TabStop = true;
            createGoBack.Text = "Върни се назад";
            createGoBack.TextAlign = ContentAlignment.MiddleCenter;
            createGoBack.VisitedLinkColor = Color.FromArgb(0, 0, 192);
            createGoBack.LinkClicked += GoBack;
            // 
            // createHeading
            // 
            createHeading.AutoSize = true;
            createHeading.Dock = DockStyle.Fill;
            createHeading.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            createHeading.Location = new Point(21, 0);
            createHeading.Margin = new Padding(0);
            createHeading.Name = "createHeading";
            createHeading.Size = new Size(247, 54);
            createHeading.TabIndex = 7;
            createHeading.Text = "Създаване на картон";
            createHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // createDetailsBox
            // 
            createDetailsBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            createDetailsBox.Controls.Add(createLayout);
            createDetailsBox.Dock = DockStyle.Fill;
            createDetailsBox.Location = new Point(24, 57);
            createDetailsBox.Name = "createDetailsBox";
            createDetailsBox.Size = new Size(241, 301);
            createDetailsBox.TabIndex = 8;
            createDetailsBox.TabStop = false;
            createDetailsBox.Text = "Данни за картон на наемател";
            // 
            // createLayout
            // 
            createLayout.ColumnCount = 3;
            createLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.5F));
            createLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            createLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.5F));
            createLayout.Controls.Add(createIdentificationLabel, 1, 0);
            createLayout.Controls.Add(createNameLabel, 1, 2);
            createLayout.Controls.Add(createTenantTypeLabel, 1, 8);
            createLayout.Controls.Add(createIdentificationField, 1, 1);
            createLayout.Controls.Add(createNameField, 1, 3);
            createLayout.Controls.Add(createTenantType, 1, 9);
            createLayout.Controls.Add(createPhoneNumberField, 1, 5);
            createLayout.Controls.Add(createFamilyStatusLabel, 1, 6);
            createLayout.Controls.Add(createPhoneNumberLabel, 1, 4);
            createLayout.Controls.Add(createFamilyStatus, 1, 7);
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
            createLayout.Size = new Size(235, 279);
            createLayout.TabIndex = 1;
            // 
            // createIdentificationLabel
            // 
            createIdentificationLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            createIdentificationLabel.AutoSize = true;
            createIdentificationLabel.Location = new Point(20, 0);
            createIdentificationLabel.Name = "createIdentificationLabel";
            createIdentificationLabel.Size = new Size(31, 27);
            createIdentificationLabel.TabIndex = 0;
            createIdentificationLabel.Text = "ЕГН:";
            createIdentificationLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // createNameLabel
            // 
            createNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            createNameLabel.AutoSize = true;
            createNameLabel.Location = new Point(20, 54);
            createNameLabel.Name = "createNameLabel";
            createNameLabel.Size = new Size(68, 27);
            createNameLabel.TabIndex = 1;
            createNameLabel.Text = "Три имена:";
            createNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // createTenantTypeLabel
            // 
            createTenantTypeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            createTenantTypeLabel.AutoSize = true;
            createTenantTypeLabel.Location = new Point(20, 216);
            createTenantTypeLabel.Name = "createTenantTypeLabel";
            createTenantTypeLabel.Size = new Size(101, 27);
            createTenantTypeLabel.TabIndex = 4;
            createTenantTypeLabel.Text = "Тип на наемател:";
            createTenantTypeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // createIdentificationField
            // 
            createIdentificationField.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            createIdentificationField.Location = new Point(20, 30);
            createIdentificationField.MaxLength = 10;
            createIdentificationField.Name = "createIdentificationField";
            createIdentificationField.Size = new Size(193, 23);
            createIdentificationField.TabIndex = 0;
            // 
            // createNameField
            // 
            createNameField.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            createNameField.Location = new Point(20, 84);
            createNameField.MaxLength = 35;
            createNameField.Name = "createNameField";
            createNameField.Size = new Size(193, 23);
            createNameField.TabIndex = 1;
            // 
            // createTenantType
            // 
            createTenantType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            createTenantType.Cursor = Cursors.Hand;
            createTenantType.DropDownStyle = ComboBoxStyle.DropDownList;
            createTenantType.FormattingEnabled = true;
            createTenantType.ItemHeight = 15;
            createTenantType.Items.AddRange(new object[] { "Студент", "Докторант", "Преподавател" });
            createTenantType.Location = new Point(20, 249);
            createTenantType.MaxDropDownItems = 5;
            createTenantType.Name = "createTenantType";
            createTenantType.Size = new Size(193, 23);
            createTenantType.TabIndex = 4;
            createTenantType.Tag = "";
            // 
            // createPhoneNumberField
            // 
            createPhoneNumberField.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            createPhoneNumberField.Location = new Point(20, 138);
            createPhoneNumberField.MaxLength = 10;
            createPhoneNumberField.Name = "createPhoneNumberField";
            createPhoneNumberField.Size = new Size(193, 23);
            createPhoneNumberField.TabIndex = 2;
            // 
            // createFamilyStatusLabel
            // 
            createFamilyStatusLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            createFamilyStatusLabel.AutoSize = true;
            createFamilyStatusLabel.Location = new Point(20, 162);
            createFamilyStatusLabel.Name = "createFamilyStatusLabel";
            createFamilyStatusLabel.Size = new Size(89, 27);
            createFamilyStatusLabel.TabIndex = 2;
            createFamilyStatusLabel.Text = "Семеен статус:";
            createFamilyStatusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // createPhoneNumberLabel
            // 
            createPhoneNumberLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            createPhoneNumberLabel.AutoSize = true;
            createPhoneNumberLabel.Location = new Point(20, 108);
            createPhoneNumberLabel.Name = "createPhoneNumberLabel";
            createPhoneNumberLabel.Size = new Size(110, 27);
            createPhoneNumberLabel.TabIndex = 3;
            createPhoneNumberLabel.Text = "Телефонен номер:";
            createPhoneNumberLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // createFamilyStatus
            // 
            createFamilyStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            createFamilyStatus.Cursor = Cursors.Hand;
            createFamilyStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            createFamilyStatus.FormattingEnabled = true;
            createFamilyStatus.ItemHeight = 15;
            createFamilyStatus.Items.AddRange(new object[] { "Неженен/а", "Омъжен/а", "Разведен/а", "Вдовец/ица" });
            createFamilyStatus.Location = new Point(20, 192);
            createFamilyStatus.MaxDropDownItems = 5;
            createFamilyStatus.Name = "createFamilyStatus";
            createFamilyStatus.Size = new Size(193, 23);
            createFamilyStatus.TabIndex = 3;
            createFamilyStatus.Tag = "";
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
            // Create
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(291, 439);
            Controls.Add(dialogLayout);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Create";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Създаване на картон";
            FormClosed += ExitApp;
            dialogLayout.ResumeLayout(false);
            dialogLayout.PerformLayout();
            createDetailsBox.ResumeLayout(false);
            createLayout.ResumeLayout(false);
            createLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel dialogLayout;
        private Button createDocument;
        private Label createHeading;
        private GroupBox createDetailsBox;
        private TableLayoutPanel createLayout;
        private Label createIdentificationLabel;
        private Label createNameLabel;
        private Label createFamilyStatusLabel;
        private Label createPhoneNumberLabel;
        private Label createTenantTypeLabel;
        private ErrorProvider errorProvider;
        private LinkLabel createGoBack;
        private Microsoft.Data.SqlClient.SqlConnection sqlConnection;
        private TextBox createIdentificationField;
        private TextBox createNameField;
        private ComboBox createTenantType;
        private TextBox createPhoneNumberField;
        private ComboBox createFamilyStatus;
    }
}