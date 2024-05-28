namespace Campus
{
    partial class Recovery
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
            recoveryHeading = new Label();
            errorProvider = new ErrorProvider(components);
            recoveryNewPasswordBox = new GroupBox();
            passwordLayout = new TableLayoutPanel();
            recoveryRepeatNewPasswordField = new TextBox();
            recoveryNewPasswordField = new TextBox();
            recoverySecurityBox = new GroupBox();
            securityLayout = new TableLayoutPanel();
            recoverySecurityQuestion = new Label();
            recoverySecurityAnswer = new TextBox();
            recoveryUsernameBox = new GroupBox();
            recoveryUsernameField = new TextBox();
            recoveryProgressBar = new ProgressBar();
            recoveryGoBackToHome = new LinkLabel();
            recoveryProceed = new Button();
            dialogLayout = new TableLayoutPanel();
            recoveryLayout = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            sqlConnection = new Microsoft.Data.SqlClient.SqlConnection();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            recoveryNewPasswordBox.SuspendLayout();
            passwordLayout.SuspendLayout();
            recoverySecurityBox.SuspendLayout();
            securityLayout.SuspendLayout();
            recoveryUsernameBox.SuspendLayout();
            recoveryLayout.SuspendLayout();
            SuspendLayout();
            // 
            // recoveryHeading
            // 
            recoveryHeading.AutoSize = true;
            recoveryHeading.Dock = DockStyle.Fill;
            recoveryHeading.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            recoveryHeading.Location = new Point(24, 0);
            recoveryHeading.Name = "recoveryHeading";
            recoveryHeading.Size = new Size(233, 72);
            recoveryHeading.TabIndex = 10;
            recoveryHeading.Text = "Възстановяване";
            recoveryHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // recoveryNewPasswordBox
            // 
            recoveryNewPasswordBox.BackColor = Color.Transparent;
            recoveryNewPasswordBox.Controls.Add(passwordLayout);
            recoveryNewPasswordBox.Dock = DockStyle.Fill;
            recoveryNewPasswordBox.Enabled = false;
            recoveryNewPasswordBox.Location = new Point(24, 229);
            recoveryNewPasswordBox.Name = "recoveryNewPasswordBox";
            recoveryNewPasswordBox.Size = new Size(233, 89);
            recoveryNewPasswordBox.TabIndex = 8;
            recoveryNewPasswordBox.TabStop = false;
            recoveryNewPasswordBox.Text = "Нова парола";
            // 
            // passwordLayout
            // 
            passwordLayout.ColumnCount = 1;
            passwordLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            passwordLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            passwordLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            passwordLayout.Controls.Add(recoveryRepeatNewPasswordField, 0, 1);
            passwordLayout.Controls.Add(recoveryNewPasswordField, 0, 0);
            passwordLayout.Dock = DockStyle.Fill;
            passwordLayout.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            passwordLayout.Location = new Point(3, 19);
            passwordLayout.Name = "passwordLayout";
            passwordLayout.RowCount = 2;
            passwordLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            passwordLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            passwordLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            passwordLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            passwordLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            passwordLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            passwordLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            passwordLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            passwordLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            passwordLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            passwordLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            passwordLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            passwordLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            passwordLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            passwordLayout.Size = new Size(227, 67);
            passwordLayout.TabIndex = 11;
            // 
            // recoveryRepeatNewPasswordField
            // 
            recoveryRepeatNewPasswordField.BackColor = SystemColors.Window;
            recoveryRepeatNewPasswordField.Dock = DockStyle.Fill;
            recoveryRepeatNewPasswordField.ImeMode = ImeMode.NoControl;
            recoveryRepeatNewPasswordField.Location = new Point(3, 36);
            recoveryRepeatNewPasswordField.MaxLength = 30;
            recoveryRepeatNewPasswordField.Name = "recoveryRepeatNewPasswordField";
            recoveryRepeatNewPasswordField.PlaceholderText = "Повтори парола";
            recoveryRepeatNewPasswordField.Size = new Size(221, 23);
            recoveryRepeatNewPasswordField.TabIndex = 3;
            recoveryRepeatNewPasswordField.UseSystemPasswordChar = true;
            // 
            // recoveryNewPasswordField
            // 
            recoveryNewPasswordField.BackColor = SystemColors.Window;
            recoveryNewPasswordField.Dock = DockStyle.Fill;
            recoveryNewPasswordField.ImeMode = ImeMode.NoControl;
            recoveryNewPasswordField.Location = new Point(3, 3);
            recoveryNewPasswordField.MaxLength = 30;
            recoveryNewPasswordField.Name = "recoveryNewPasswordField";
            recoveryNewPasswordField.PlaceholderText = "Парола";
            recoveryNewPasswordField.Size = new Size(221, 23);
            recoveryNewPasswordField.TabIndex = 2;
            recoveryNewPasswordField.UseSystemPasswordChar = true;
            // 
            // recoverySecurityBox
            // 
            recoverySecurityBox.BackColor = Color.Transparent;
            recoverySecurityBox.Controls.Add(securityLayout);
            recoverySecurityBox.Dock = DockStyle.Fill;
            recoverySecurityBox.Enabled = false;
            recoverySecurityBox.Location = new Point(24, 134);
            recoverySecurityBox.Name = "recoverySecurityBox";
            recoverySecurityBox.Size = new Size(233, 89);
            recoverySecurityBox.TabIndex = 7;
            recoverySecurityBox.TabStop = false;
            recoverySecurityBox.Text = "Въпрос за защита";
            // 
            // securityLayout
            // 
            securityLayout.ColumnCount = 1;
            securityLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            securityLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            securityLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            securityLayout.Controls.Add(recoverySecurityQuestion, 0, 0);
            securityLayout.Controls.Add(recoverySecurityAnswer, 0, 1);
            securityLayout.Dock = DockStyle.Fill;
            securityLayout.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            securityLayout.Location = new Point(3, 19);
            securityLayout.Name = "securityLayout";
            securityLayout.RowCount = 2;
            securityLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            securityLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            securityLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            securityLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            securityLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            securityLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            securityLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            securityLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            securityLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            securityLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            securityLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            securityLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            securityLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            securityLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            securityLayout.Size = new Size(227, 67);
            securityLayout.TabIndex = 12;
            // 
            // recoverySecurityQuestion
            // 
            recoverySecurityQuestion.AutoSize = true;
            recoverySecurityQuestion.Dock = DockStyle.Left;
            recoverySecurityQuestion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            recoverySecurityQuestion.Location = new Point(3, 0);
            recoverySecurityQuestion.Name = "recoverySecurityQuestion";
            recoverySecurityQuestion.Size = new Size(22, 33);
            recoverySecurityQuestion.TabIndex = 5;
            recoverySecurityQuestion.Text = ". . .";
            recoverySecurityQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // recoverySecurityAnswer
            // 
            recoverySecurityAnswer.BackColor = SystemColors.Window;
            recoverySecurityAnswer.Dock = DockStyle.Fill;
            recoverySecurityAnswer.ImeMode = ImeMode.NoControl;
            recoverySecurityAnswer.Location = new Point(3, 36);
            recoverySecurityAnswer.MaxLength = 25;
            recoverySecurityAnswer.Name = "recoverySecurityAnswer";
            recoverySecurityAnswer.Size = new Size(221, 23);
            recoverySecurityAnswer.TabIndex = 1;
            // 
            // recoveryUsernameBox
            // 
            recoveryUsernameBox.BackColor = Color.Transparent;
            recoveryUsernameBox.Controls.Add(recoveryUsernameField);
            recoveryUsernameBox.Dock = DockStyle.Fill;
            recoveryUsernameBox.Location = new Point(24, 75);
            recoveryUsernameBox.Name = "recoveryUsernameBox";
            recoveryUsernameBox.Size = new Size(233, 53);
            recoveryUsernameBox.TabIndex = 6;
            recoveryUsernameBox.TabStop = false;
            recoveryUsernameBox.Text = "Потребител";
            // 
            // recoveryUsernameField
            // 
            recoveryUsernameField.Dock = DockStyle.Fill;
            recoveryUsernameField.ImeMode = ImeMode.NoControl;
            recoveryUsernameField.Location = new Point(3, 19);
            recoveryUsernameField.MaxLength = 14;
            recoveryUsernameField.Name = "recoveryUsernameField";
            recoveryUsernameField.Size = new Size(227, 23);
            recoveryUsernameField.TabIndex = 0;
            // 
            // recoveryProgressBar
            // 
            recoveryProgressBar.Dock = DockStyle.Fill;
            recoveryProgressBar.Location = new Point(24, 324);
            recoveryProgressBar.Maximum = 3;
            recoveryProgressBar.Name = "recoveryProgressBar";
            recoveryProgressBar.Size = new Size(233, 24);
            recoveryProgressBar.Step = 1;
            recoveryProgressBar.TabIndex = 9;
            // 
            // recoveryGoBackToHome
            // 
            recoveryGoBackToHome.ActiveLinkColor = Color.FromArgb(0, 0, 192);
            recoveryGoBackToHome.AutoSize = true;
            recoveryGoBackToHome.Cursor = Cursors.Hand;
            recoveryGoBackToHome.Dock = DockStyle.Fill;
            recoveryGoBackToHome.LinkBehavior = LinkBehavior.HoverUnderline;
            recoveryGoBackToHome.LinkColor = Color.FromArgb(0, 0, 192);
            recoveryGoBackToHome.Location = new Point(24, 382);
            recoveryGoBackToHome.Name = "recoveryGoBackToHome";
            recoveryGoBackToHome.Size = new Size(233, 18);
            recoveryGoBackToHome.TabIndex = 5;
            recoveryGoBackToHome.TabStop = true;
            recoveryGoBackToHome.Text = "Върни се назад";
            recoveryGoBackToHome.TextAlign = ContentAlignment.MiddleCenter;
            recoveryGoBackToHome.VisitedLinkColor = Color.FromArgb(0, 0, 192);
            recoveryGoBackToHome.LinkClicked += GoBack;
            // 
            // recoveryProceed
            // 
            recoveryProceed.Cursor = Cursors.Hand;
            recoveryProceed.Dock = DockStyle.Fill;
            recoveryProceed.Location = new Point(24, 354);
            recoveryProceed.Name = "recoveryProceed";
            recoveryProceed.Size = new Size(233, 25);
            recoveryProceed.TabIndex = 4;
            recoveryProceed.Text = "Продължи";
            recoveryProceed.UseVisualStyleBackColor = true;
            recoveryProceed.Click += Proceed;
            // 
            // dialogLayout
            // 
            dialogLayout.ColumnCount = 3;
            dialogLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            dialogLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            dialogLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            dialogLayout.Dock = DockStyle.Fill;
            dialogLayout.Location = new Point(0, 0);
            dialogLayout.Name = "dialogLayout";
            dialogLayout.RowCount = 14;
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            dialogLayout.Size = new Size(200, 100);
            dialogLayout.TabIndex = 0;
            // 
            // recoveryLayout
            // 
            recoveryLayout.ColumnCount = 3;
            recoveryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.5F));
            recoveryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            recoveryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.5F));
            recoveryLayout.Controls.Add(recoveryHeading, 1, 0);
            recoveryLayout.Controls.Add(recoveryUsernameBox, 1, 1);
            recoveryLayout.Controls.Add(recoverySecurityBox, 1, 2);
            recoveryLayout.Controls.Add(recoveryNewPasswordBox, 1, 3);
            recoveryLayout.Controls.Add(recoveryProgressBar, 1, 4);
            recoveryLayout.Controls.Add(recoveryProceed, 1, 5);
            recoveryLayout.Controls.Add(recoveryGoBackToHome, 1, 6);
            recoveryLayout.Dock = DockStyle.Fill;
            recoveryLayout.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            recoveryLayout.Location = new Point(0, 0);
            recoveryLayout.Name = "recoveryLayout";
            recoveryLayout.RowCount = 7;
            recoveryLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 22.5F));
            recoveryLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 18.5F));
            recoveryLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 29.5F));
            recoveryLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 29.5F));
            recoveryLayout.RowStyles.Add(new RowStyle());
            recoveryLayout.RowStyles.Add(new RowStyle());
            recoveryLayout.RowStyles.Add(new RowStyle());
            recoveryLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            recoveryLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            recoveryLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            recoveryLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            recoveryLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            recoveryLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            recoveryLayout.Size = new Size(282, 400);
            recoveryLayout.TabIndex = 11;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // sqlConnection
            // 
            sqlConnection.AccessTokenCallback = null;
            sqlConnection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\aleks\\source\\repos\\Campus\\Campus\\Database\\Database.mdf;Integrated Security=True";
            sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // Recovery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(282, 400);
            Controls.Add(recoveryLayout);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Recovery";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Възстановяване на акаунт";
            FormClosed += ExitApp;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            recoveryNewPasswordBox.ResumeLayout(false);
            passwordLayout.ResumeLayout(false);
            passwordLayout.PerformLayout();
            recoverySecurityBox.ResumeLayout(false);
            securityLayout.ResumeLayout(false);
            securityLayout.PerformLayout();
            recoveryUsernameBox.ResumeLayout(false);
            recoveryUsernameBox.PerformLayout();
            recoveryLayout.ResumeLayout(false);
            recoveryLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label recoveryHeading;
        private ErrorProvider errorProvider;
        private ProgressBar recoveryProgressBar;
        private LinkLabel recoveryGoBackToHome;
        private Button recoveryProceed;
        private GroupBox recoveryNewPasswordBox;
        private TextBox recoveryRepeatNewPasswordField;
        private TextBox recoveryNewPasswordField;
        private GroupBox recoverySecurityBox;
        private Label recoverySecurityQuestion;
        private TextBox recoverySecurityAnswer;
        private GroupBox recoveryUsernameBox;
        private TextBox recoveryUsernameField;
        private TableLayoutPanel dialogLayout;
        private TableLayoutPanel recoveryLayout;
        private TableLayoutPanel securityLayout;
        private TableLayoutPanel passwordLayout;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Microsoft.Data.SqlClient.SqlConnection sqlConnection;
    }
}