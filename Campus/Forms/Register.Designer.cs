namespace Campus
{
    partial class Register
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
            registerHeading = new Label();
            registerAccountCreation = new Button();
            registerGoBack = new LinkLabel();
            errorProvider = new ErrorProvider(components);
            registerSecurityBox = new GroupBox();
            securityLayout = new TableLayoutPanel();
            registerSecurityQuestion = new ComboBox();
            registerPasswordBox = new GroupBox();
            passwordLayout = new TableLayoutPanel();
            registerPasswordField = new TextBox();
            registerRepeatPasswordField = new TextBox();
            registerUsernameBox = new GroupBox();
            usernameLayout = new TableLayoutPanel();
            registerUsernameField = new TextBox();
            registerLayout = new TableLayoutPanel();
            sqlConnection = new Microsoft.Data.SqlClient.SqlConnection();
            registerSecurityAnswer = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            registerSecurityBox.SuspendLayout();
            securityLayout.SuspendLayout();
            registerPasswordBox.SuspendLayout();
            passwordLayout.SuspendLayout();
            registerUsernameBox.SuspendLayout();
            usernameLayout.SuspendLayout();
            registerLayout.SuspendLayout();
            SuspendLayout();
            // 
            // registerHeading
            // 
            registerHeading.Dock = DockStyle.Fill;
            registerHeading.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            registerHeading.Location = new Point(22, 0);
            registerHeading.Name = "registerHeading";
            registerHeading.Size = new Size(219, 73);
            registerHeading.TabIndex = 7;
            registerHeading.Text = "Регистрация";
            registerHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // registerAccountCreation
            // 
            registerAccountCreation.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            registerAccountCreation.AutoSize = true;
            registerAccountCreation.Cursor = Cursors.Hand;
            registerAccountCreation.Location = new Point(22, 326);
            registerAccountCreation.Name = "registerAccountCreation";
            registerAccountCreation.Size = new Size(219, 25);
            registerAccountCreation.TabIndex = 5;
            registerAccountCreation.Text = "Регистриране";
            registerAccountCreation.UseVisualStyleBackColor = true;
            registerAccountCreation.Click += Confirm;
            // 
            // registerGoBack
            // 
            registerGoBack.ActiveLinkColor = Color.FromArgb(0, 0, 192);
            registerGoBack.Anchor = AnchorStyles.None;
            registerGoBack.AutoSize = true;
            registerGoBack.Cursor = Cursors.Hand;
            registerGoBack.LinkBehavior = LinkBehavior.HoverUnderline;
            registerGoBack.LinkColor = Color.FromArgb(0, 0, 192);
            registerGoBack.Location = new Point(86, 355);
            registerGoBack.Name = "registerGoBack";
            registerGoBack.Size = new Size(90, 15);
            registerGoBack.TabIndex = 6;
            registerGoBack.TabStop = true;
            registerGoBack.Text = "Върни се назад";
            registerGoBack.TextAlign = ContentAlignment.MiddleCenter;
            registerGoBack.VisitedLinkColor = Color.FromArgb(0, 0, 192);
            registerGoBack.LinkClicked += GoBack;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // registerSecurityBox
            // 
            registerSecurityBox.Controls.Add(securityLayout);
            registerSecurityBox.Dock = DockStyle.Fill;
            registerSecurityBox.Location = new Point(22, 234);
            registerSecurityBox.Name = "registerSecurityBox";
            registerSecurityBox.Size = new Size(219, 86);
            registerSecurityBox.TabIndex = 10;
            registerSecurityBox.TabStop = false;
            registerSecurityBox.Text = "Въпрос за защита";
            // 
            // securityLayout
            // 
            securityLayout.ColumnCount = 1;
            securityLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            securityLayout.Controls.Add(registerSecurityAnswer, 0, 1);
            securityLayout.Controls.Add(registerSecurityQuestion, 0, 0);
            securityLayout.Dock = DockStyle.Fill;
            securityLayout.Location = new Point(3, 19);
            securityLayout.Name = "securityLayout";
            securityLayout.RowCount = 2;
            securityLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            securityLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            securityLayout.Size = new Size(213, 64);
            securityLayout.TabIndex = 12;
            // 
            // registerSecurityQuestion
            // 
            registerSecurityQuestion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            registerSecurityQuestion.Cursor = Cursors.Hand;
            registerSecurityQuestion.DropDownStyle = ComboBoxStyle.DropDownList;
            registerSecurityQuestion.FormattingEnabled = true;
            registerSecurityQuestion.ItemHeight = 15;
            registerSecurityQuestion.Items.AddRange(new object[] { "Детският ви прякор?", "Любим филм/сериал?", "Любим спорт?", "Любимо хоби?" });
            registerSecurityQuestion.Location = new Point(3, 4);
            registerSecurityQuestion.MaxDropDownItems = 5;
            registerSecurityQuestion.Name = "registerSecurityQuestion";
            registerSecurityQuestion.Size = new Size(207, 23);
            registerSecurityQuestion.TabIndex = 3;
            registerSecurityQuestion.Tag = "";
            // 
            // registerPasswordBox
            // 
            registerPasswordBox.Controls.Add(passwordLayout);
            registerPasswordBox.Dock = DockStyle.Fill;
            registerPasswordBox.FlatStyle = FlatStyle.Flat;
            registerPasswordBox.Location = new Point(22, 142);
            registerPasswordBox.Name = "registerPasswordBox";
            registerPasswordBox.Size = new Size(219, 86);
            registerPasswordBox.TabIndex = 9;
            registerPasswordBox.TabStop = false;
            registerPasswordBox.Text = "Парола";
            // 
            // passwordLayout
            // 
            passwordLayout.AutoSize = true;
            passwordLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            passwordLayout.ColumnCount = 1;
            passwordLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            passwordLayout.Controls.Add(registerPasswordField, 0, 0);
            passwordLayout.Controls.Add(registerRepeatPasswordField, 0, 1);
            passwordLayout.Dock = DockStyle.Fill;
            passwordLayout.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            passwordLayout.Location = new Point(3, 19);
            passwordLayout.Margin = new Padding(0);
            passwordLayout.Name = "passwordLayout";
            passwordLayout.RowCount = 2;
            passwordLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            passwordLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            passwordLayout.Size = new Size(213, 64);
            passwordLayout.TabIndex = 11;
            // 
            // registerPasswordField
            // 
            registerPasswordField.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            registerPasswordField.Location = new Point(0, 4);
            registerPasswordField.Margin = new Padding(0);
            registerPasswordField.MaxLength = 30;
            registerPasswordField.Name = "registerPasswordField";
            registerPasswordField.Size = new Size(213, 23);
            registerPasswordField.TabIndex = 1;
            registerPasswordField.UseSystemPasswordChar = true;
            // 
            // registerRepeatPasswordField
            // 
            registerRepeatPasswordField.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            registerRepeatPasswordField.Location = new Point(0, 36);
            registerRepeatPasswordField.Margin = new Padding(0);
            registerRepeatPasswordField.MaxLength = 30;
            registerRepeatPasswordField.Name = "registerRepeatPasswordField";
            registerRepeatPasswordField.Size = new Size(213, 23);
            registerRepeatPasswordField.TabIndex = 2;
            registerRepeatPasswordField.UseSystemPasswordChar = true;
            // 
            // registerUsernameBox
            // 
            registerUsernameBox.Controls.Add(usernameLayout);
            registerUsernameBox.Dock = DockStyle.Fill;
            registerUsernameBox.Location = new Point(22, 76);
            registerUsernameBox.Name = "registerUsernameBox";
            registerUsernameBox.Size = new Size(219, 60);
            registerUsernameBox.TabIndex = 8;
            registerUsernameBox.TabStop = false;
            registerUsernameBox.Text = "Потребител";
            // 
            // usernameLayout
            // 
            usernameLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            usernameLayout.ColumnCount = 1;
            usernameLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            usernameLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            usernameLayout.Controls.Add(registerUsernameField, 0, 0);
            usernameLayout.Dock = DockStyle.Fill;
            usernameLayout.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            usernameLayout.Location = new Point(3, 19);
            usernameLayout.Name = "usernameLayout";
            usernameLayout.RowCount = 1;
            usernameLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            usernameLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            usernameLayout.Size = new Size(213, 38);
            usernameLayout.TabIndex = 12;
            // 
            // registerUsernameField
            // 
            registerUsernameField.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            registerUsernameField.ImeMode = ImeMode.NoControl;
            registerUsernameField.Location = new Point(0, 7);
            registerUsernameField.Margin = new Padding(0);
            registerUsernameField.MaxLength = 14;
            registerUsernameField.Name = "registerUsernameField";
            registerUsernameField.Size = new Size(213, 23);
            registerUsernameField.TabIndex = 0;
            // 
            // registerLayout
            // 
            registerLayout.ColumnCount = 3;
            registerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.5F));
            registerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            registerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.5F));
            registerLayout.Controls.Add(registerHeading, 1, 0);
            registerLayout.Controls.Add(registerGoBack, 1, 5);
            registerLayout.Controls.Add(registerSecurityBox, 1, 3);
            registerLayout.Controls.Add(registerAccountCreation, 1, 4);
            registerLayout.Controls.Add(registerPasswordBox, 1, 2);
            registerLayout.Controls.Add(registerUsernameBox, 1, 1);
            registerLayout.Dock = DockStyle.Fill;
            registerLayout.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            registerLayout.Location = new Point(0, 0);
            registerLayout.Name = "registerLayout";
            registerLayout.RowCount = 6;
            registerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 22.5F));
            registerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20.5F));
            registerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 28.5F));
            registerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 28.5F));
            registerLayout.RowStyles.Add(new RowStyle());
            registerLayout.RowStyles.Add(new RowStyle());
            registerLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            registerLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            registerLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            registerLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            registerLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            registerLayout.Size = new Size(265, 371);
            registerLayout.TabIndex = 11;
            // 
            // sqlConnection
            // 
            sqlConnection.AccessTokenCallback = null;
            sqlConnection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\aleks\\source\\repos\\Campus\\Campus\\Database\\Database.mdf;Integrated Security=True";
            sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // registerSecurityAnswer
            // 
            registerSecurityAnswer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            registerSecurityAnswer.ImeMode = ImeMode.NoControl;
            registerSecurityAnswer.Location = new Point(0, 36);
            registerSecurityAnswer.Margin = new Padding(0);
            registerSecurityAnswer.MaxLength = 14;
            registerSecurityAnswer.Name = "registerSecurityAnswer";
            registerSecurityAnswer.Size = new Size(213, 23);
            registerSecurityAnswer.TabIndex = 4;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(265, 371);
            Controls.Add(registerLayout);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Register";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистриране на акаунт";
            FormClosed += ExitApp;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            registerSecurityBox.ResumeLayout(false);
            securityLayout.ResumeLayout(false);
            securityLayout.PerformLayout();
            registerPasswordBox.ResumeLayout(false);
            registerPasswordBox.PerformLayout();
            passwordLayout.ResumeLayout(false);
            passwordLayout.PerformLayout();
            registerUsernameBox.ResumeLayout(false);
            usernameLayout.ResumeLayout(false);
            usernameLayout.PerformLayout();
            registerLayout.ResumeLayout(false);
            registerLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label registerHeading;
        private Button registerAccountCreation;
        private LinkLabel registerGoBack;
        private ErrorProvider errorProvider;
        private GroupBox registerSecurityBox;
        private ComboBox registerSecurityQuestion;
        private GroupBox registerUsernameBox;
        private TextBox registerUsernameField;
        private GroupBox registerPasswordBox;
        private TextBox registerPasswordField;
        private TextBox registerRepeatPasswordField;
        private TableLayoutPanel registerLayout;
        private TableLayoutPanel passwordLayout;
        private TableLayoutPanel usernameLayout;
        private TableLayoutPanel securityLayout;
        private Microsoft.Data.SqlClient.SqlConnection sqlConnection;
        private TextBox registerSecurityAnswer;
    }
}