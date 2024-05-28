namespace Campus
{
    partial class Access
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            accessHeading = new Label();
            accessLogIntoAccount = new Button();
            accessGoToRegister = new LinkLabel();
            accessUsernameField = new TextBox();
            accessPasswordField = new TextBox();
            errorProvider = new ErrorProvider(components);
            accessCredentialsBox = new GroupBox();
            tableLayoutPanel = new TableLayoutPanel();
            accessGoToRecovery = new LinkLabel();
            tableLayoutPanel2 = new TableLayoutPanel();
            accessLayout = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            sqlConnection = new Microsoft.Data.SqlClient.SqlConnection();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            accessCredentialsBox.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            accessLayout.SuspendLayout();
            SuspendLayout();
            // 
            // accessHeading
            // 
            accessHeading.Dock = DockStyle.Fill;
            accessHeading.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            accessHeading.Location = new Point(16, 0);
            accessHeading.Margin = new Padding(0);
            accessHeading.Name = "accessHeading";
            accessHeading.Size = new Size(182, 44);
            accessHeading.TabIndex = 5;
            accessHeading.Text = "Вход";
            accessHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // accessLogIntoAccount
            // 
            accessLogIntoAccount.Cursor = Cursors.Hand;
            accessLogIntoAccount.Dock = DockStyle.Fill;
            accessLogIntoAccount.Location = new Point(19, 159);
            accessLogIntoAccount.Name = "accessLogIntoAccount";
            accessLogIntoAccount.Size = new Size(176, 27);
            accessLogIntoAccount.TabIndex = 2;
            accessLogIntoAccount.Text = "Влизане";
            accessLogIntoAccount.UseVisualStyleBackColor = true;
            accessLogIntoAccount.Click += Confirm;
            // 
            // accessGoToRegister
            // 
            accessGoToRegister.ActiveLinkColor = Color.FromArgb(0, 0, 192);
            accessGoToRegister.AutoSize = true;
            accessGoToRegister.Cursor = Cursors.Hand;
            accessGoToRegister.Dock = DockStyle.Fill;
            accessGoToRegister.LinkBehavior = LinkBehavior.HoverUnderline;
            accessGoToRegister.LinkColor = Color.FromArgb(0, 0, 192);
            accessGoToRegister.Location = new Point(16, 189);
            accessGoToRegister.Margin = new Padding(0);
            accessGoToRegister.Name = "accessGoToRegister";
            accessGoToRegister.Size = new Size(182, 22);
            accessGoToRegister.TabIndex = 4;
            accessGoToRegister.TabStop = true;
            accessGoToRegister.Text = "Регистриране на акаунт";
            accessGoToRegister.TextAlign = ContentAlignment.MiddleCenter;
            accessGoToRegister.VisitedLinkColor = Color.FromArgb(0, 0, 192);
            accessGoToRegister.LinkClicked += Register;
            // 
            // accessUsernameField
            // 
            accessUsernameField.Dock = DockStyle.Fill;
            accessUsernameField.Location = new Point(15, 0);
            accessUsernameField.Margin = new Padding(0);
            accessUsernameField.MaxLength = 14;
            accessUsernameField.Name = "accessUsernameField";
            accessUsernameField.PlaceholderText = "Потребител";
            accessUsernameField.Size = new Size(139, 23);
            accessUsernameField.TabIndex = 0;
            // 
            // accessPasswordField
            // 
            accessPasswordField.Dock = DockStyle.Fill;
            accessPasswordField.Location = new Point(15, 31);
            accessPasswordField.Margin = new Padding(0);
            accessPasswordField.MaxLength = 30;
            accessPasswordField.Name = "accessPasswordField";
            accessPasswordField.PlaceholderText = "Парола";
            accessPasswordField.Size = new Size(139, 23);
            accessPasswordField.TabIndex = 1;
            accessPasswordField.UseSystemPasswordChar = true;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // accessCredentialsBox
            // 
            accessCredentialsBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            accessCredentialsBox.Controls.Add(tableLayoutPanel);
            accessCredentialsBox.Dock = DockStyle.Fill;
            accessCredentialsBox.Location = new Point(19, 47);
            accessCredentialsBox.Name = "accessCredentialsBox";
            accessCredentialsBox.Size = new Size(176, 106);
            accessCredentialsBox.TabIndex = 6;
            accessCredentialsBox.TabStop = false;
            accessCredentialsBox.Text = "Данни за вход";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9F));
            tableLayoutPanel.Controls.Add(accessGoToRecovery, 1, 2);
            tableLayoutPanel.Controls.Add(accessPasswordField, 1, 1);
            tableLayoutPanel.Controls.Add(accessUsernameField, 1, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel.Location = new Point(3, 19);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.Size = new Size(170, 84);
            tableLayoutPanel.TabIndex = 4;
            // 
            // accessGoToRecovery
            // 
            accessGoToRecovery.ActiveLinkColor = Color.FromArgb(0, 0, 192);
            accessGoToRecovery.AutoSize = true;
            accessGoToRecovery.BackColor = Color.Transparent;
            accessGoToRecovery.Cursor = Cursors.Hand;
            accessGoToRecovery.Dock = DockStyle.Right;
            accessGoToRecovery.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            accessGoToRecovery.LinkBehavior = LinkBehavior.HoverUnderline;
            accessGoToRecovery.LinkColor = Color.FromArgb(0, 0, 192);
            accessGoToRecovery.Location = new Point(65, 62);
            accessGoToRecovery.Margin = new Padding(0);
            accessGoToRecovery.Name = "accessGoToRecovery";
            accessGoToRecovery.Size = new Size(89, 22);
            accessGoToRecovery.TabIndex = 3;
            accessGoToRecovery.TabStop = true;
            accessGoToRecovery.Text = "Забравена парола";
            accessGoToRecovery.TextAlign = ContentAlignment.MiddleCenter;
            accessGoToRecovery.VisitedLinkColor = Color.FromArgb(0, 0, 192);
            accessGoToRecovery.LinkClicked += Recover;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // accessLayout
            // 
            accessLayout.ColumnCount = 3;
            accessLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.5F));
            accessLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            accessLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.5F));
            accessLayout.Controls.Add(accessCredentialsBox, 1, 1);
            accessLayout.Controls.Add(accessHeading, 1, 0);
            accessLayout.Controls.Add(accessGoToRegister, 1, 3);
            accessLayout.Controls.Add(accessLogIntoAccount, 1, 2);
            accessLayout.Dock = DockStyle.Fill;
            accessLayout.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            accessLayout.Location = new Point(0, 0);
            accessLayout.Margin = new Padding(0);
            accessLayout.Name = "accessLayout";
            accessLayout.RowCount = 5;
            accessLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            accessLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            accessLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            accessLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            accessLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            accessLayout.Size = new Size(215, 224);
            accessLayout.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // sqlConnection
            // 
            sqlConnection.AccessTokenCallback = null;
            sqlConnection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\aleks\\source\\repos\\Campus\\Campus\\Database\\Database.mdf;Integrated Security=True";
            sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // Access
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(215, 224);
            Controls.Add(accessLayout);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Access";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход";
            FormClosed += ExitApp;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            accessCredentialsBox.ResumeLayout(false);
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            accessLayout.ResumeLayout(false);
            accessLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label accessHeading;
        private Button accessLogIntoAccount;
        private LinkLabel accessGoToRegister;
        private TextBox accessUsernameField;
        private TextBox accessPasswordField;
        private ErrorProvider errorProvider;
        private GroupBox accessCredentialsBox;
        private LinkLabel accessGoToRecovery;
        private TableLayoutPanel accessLayout;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel;
        private Microsoft.Data.SqlClient.SqlConnection sqlConnection;
    }
}