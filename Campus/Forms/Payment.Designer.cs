namespace Campus
{
    partial class Payment
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
            paymentGoBack = new LinkLabel();
            createHeading = new Label();
            viewDetailsBox = new GroupBox();
            createLayout = new TableLayoutPanel();
            paymentRentLabel = new Label();
            paymentWaterLabel = new Label();
            paymentRentField = new Label();
            paymentWaterField = new Label();
            paymentInternetField = new Label();
            paymentElectricityLabel = new Label();
            paymentInternetLabel = new Label();
            paymentElectricityField = new Label();
            paymentSelectTenant = new ComboBox();
            paymentMake = new Button();
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
            dialogLayout.Controls.Add(paymentGoBack, 1, 4);
            dialogLayout.Controls.Add(createHeading, 1, 0);
            dialogLayout.Controls.Add(viewDetailsBox, 1, 2);
            dialogLayout.Controls.Add(paymentSelectTenant, 1, 1);
            dialogLayout.Controls.Add(paymentMake, 1, 3);
            dialogLayout.Dock = DockStyle.Fill;
            dialogLayout.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            dialogLayout.Location = new Point(0, 0);
            dialogLayout.Name = "dialogLayout";
            dialogLayout.RowCount = 6;
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 13.9534893F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 6.97674465F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 62.7907F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 9.302325F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 4.65116262F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 2.32558179F));
            dialogLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            dialogLayout.Size = new Size(291, 459);
            dialogLayout.TabIndex = 3;
            // 
            // paymentGoBack
            // 
            paymentGoBack.ActiveLinkColor = Color.FromArgb(0, 0, 192);
            paymentGoBack.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            paymentGoBack.AutoSize = true;
            paymentGoBack.Cursor = Cursors.Hand;
            paymentGoBack.LinkBehavior = LinkBehavior.HoverUnderline;
            paymentGoBack.LinkColor = Color.FromArgb(0, 0, 192);
            paymentGoBack.Location = new Point(21, 429);
            paymentGoBack.Margin = new Padding(0);
            paymentGoBack.Name = "paymentGoBack";
            paymentGoBack.Size = new Size(247, 15);
            paymentGoBack.TabIndex = 7;
            paymentGoBack.TabStop = true;
            paymentGoBack.Text = "Върни се назад";
            paymentGoBack.TextAlign = ContentAlignment.MiddleCenter;
            paymentGoBack.VisitedLinkColor = Color.FromArgb(0, 0, 192);
            paymentGoBack.LinkClicked += GoBack;
            // 
            // createHeading
            // 
            createHeading.AutoSize = true;
            createHeading.Dock = DockStyle.Fill;
            createHeading.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            createHeading.Location = new Point(21, 0);
            createHeading.Margin = new Padding(0);
            createHeading.Name = "createHeading";
            createHeading.Size = new Size(247, 64);
            createHeading.TabIndex = 7;
            createHeading.Text = "Плащане";
            createHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // viewDetailsBox
            // 
            viewDetailsBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            viewDetailsBox.Controls.Add(createLayout);
            viewDetailsBox.Dock = DockStyle.Fill;
            viewDetailsBox.Enabled = false;
            viewDetailsBox.Location = new Point(24, 99);
            viewDetailsBox.Name = "viewDetailsBox";
            viewDetailsBox.Size = new Size(241, 282);
            viewDetailsBox.TabIndex = 8;
            viewDetailsBox.TabStop = false;
            viewDetailsBox.Text = "Сметки за плащане";
            // 
            // createLayout
            // 
            createLayout.ColumnCount = 3;
            createLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.5F));
            createLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            createLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.5F));
            createLayout.Controls.Add(paymentRentLabel, 1, 0);
            createLayout.Controls.Add(paymentWaterLabel, 1, 6);
            createLayout.Controls.Add(paymentRentField, 1, 1);
            createLayout.Controls.Add(paymentWaterField, 1, 7);
            createLayout.Controls.Add(paymentInternetField, 1, 3);
            createLayout.Controls.Add(paymentElectricityLabel, 1, 4);
            createLayout.Controls.Add(paymentInternetLabel, 1, 2);
            createLayout.Controls.Add(paymentElectricityField, 1, 5);
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
            createLayout.Size = new Size(235, 260);
            createLayout.TabIndex = 1;
            // 
            // paymentRentLabel
            // 
            paymentRentLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            paymentRentLabel.AutoSize = true;
            paymentRentLabel.Location = new Point(20, 0);
            paymentRentLabel.Name = "paymentRentLabel";
            paymentRentLabel.Size = new Size(40, 32);
            paymentRentLabel.TabIndex = 1;
            paymentRentLabel.Text = "Наем:";
            paymentRentLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // paymentWaterLabel
            // 
            paymentWaterLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            paymentWaterLabel.AutoSize = true;
            paymentWaterLabel.Location = new Point(20, 192);
            paymentWaterLabel.Name = "paymentWaterLabel";
            paymentWaterLabel.Size = new Size(36, 32);
            paymentWaterLabel.TabIndex = 4;
            paymentWaterLabel.Text = "Вода:";
            paymentWaterLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // paymentRentField
            // 
            paymentRentField.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            paymentRentField.AutoSize = true;
            paymentRentField.BackColor = SystemColors.Control;
            paymentRentField.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            paymentRentField.Location = new Point(20, 40);
            paymentRentField.Name = "paymentRentField";
            paymentRentField.Size = new Size(193, 15);
            paymentRentField.TabIndex = 2;
            paymentRentField.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // paymentWaterField
            // 
            paymentWaterField.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            paymentWaterField.AutoSize = true;
            paymentWaterField.BackColor = SystemColors.Control;
            paymentWaterField.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            paymentWaterField.Location = new Point(20, 234);
            paymentWaterField.Name = "paymentWaterField";
            paymentWaterField.Size = new Size(193, 15);
            paymentWaterField.TabIndex = 5;
            paymentWaterField.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // paymentInternetField
            // 
            paymentInternetField.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            paymentInternetField.AutoSize = true;
            paymentInternetField.BackColor = SystemColors.Control;
            paymentInternetField.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            paymentInternetField.Location = new Point(20, 104);
            paymentInternetField.Name = "paymentInternetField";
            paymentInternetField.Size = new Size(193, 15);
            paymentInternetField.TabIndex = 3;
            paymentInternetField.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // paymentElectricityLabel
            // 
            paymentElectricityLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            paymentElectricityLabel.AutoSize = true;
            paymentElectricityLabel.Location = new Point(20, 128);
            paymentElectricityLabel.Name = "paymentElectricityLabel";
            paymentElectricityLabel.Size = new Size(29, 32);
            paymentElectricityLabel.TabIndex = 2;
            paymentElectricityLabel.Text = "Ток:";
            paymentElectricityLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // paymentInternetLabel
            // 
            paymentInternetLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            paymentInternetLabel.AutoSize = true;
            paymentInternetLabel.Location = new Point(20, 64);
            paymentInternetLabel.Name = "paymentInternetLabel";
            paymentInternetLabel.Size = new Size(62, 32);
            paymentInternetLabel.TabIndex = 3;
            paymentInternetLabel.Text = "Интернет:";
            paymentInternetLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // paymentElectricityField
            // 
            paymentElectricityField.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            paymentElectricityField.AutoSize = true;
            paymentElectricityField.BackColor = SystemColors.Control;
            paymentElectricityField.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            paymentElectricityField.Location = new Point(20, 168);
            paymentElectricityField.Name = "paymentElectricityField";
            paymentElectricityField.Size = new Size(193, 15);
            paymentElectricityField.TabIndex = 4;
            paymentElectricityField.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // paymentSelectTenant
            // 
            paymentSelectTenant.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            paymentSelectTenant.DropDownStyle = ComboBoxStyle.DropDownList;
            paymentSelectTenant.FormattingEnabled = true;
            paymentSelectTenant.Location = new Point(24, 68);
            paymentSelectTenant.Name = "paymentSelectTenant";
            paymentSelectTenant.Size = new Size(241, 23);
            paymentSelectTenant.TabIndex = 9;
            paymentSelectTenant.SelectedIndexChanged += TenantSelected;
            // 
            // paymentMake
            // 
            paymentMake.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            paymentMake.AutoSize = true;
            paymentMake.Location = new Point(24, 392);
            paymentMake.Name = "paymentMake";
            paymentMake.Size = new Size(241, 25);
            paymentMake.TabIndex = 10;
            paymentMake.Text = "Плати";
            paymentMake.UseVisualStyleBackColor = true;
            paymentMake.Click += Confirm;
            // 
            // sqlConnection
            // 
            sqlConnection.AccessTokenCallback = null;
            sqlConnection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\aleks\\source\\repos\\Campus\\Campus\\Database\\Database.mdf;Integrated Security=True";
            sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(291, 459);
            Controls.Add(dialogLayout);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Payment";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Плащане на сметки";
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
        private LinkLabel paymentGoBack;
        private Label createHeading;
        private GroupBox viewDetailsBox;
        private TableLayoutPanel createLayout;
        private Label paymentRentLabel;
        private Label paymentWaterLabel;
        private Label paymentRentField;
        private Label paymentWaterField;
        private Label paymentInternetField;
        private Label paymentElectricityLabel;
        private Label paymentInternetLabel;
        private Label paymentElectricityField;
        private ComboBox paymentSelectTenant;
        private Button paymentMake;
        private Microsoft.Data.SqlClient.SqlConnection sqlConnection;
    }
}