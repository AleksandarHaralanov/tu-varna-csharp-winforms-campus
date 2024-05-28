namespace Campus
{
    partial class Manage
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
            manageHeading = new Label();
            manageCreate = new Button();
            manageView = new Button();
            manageChange = new Button();
            manageEnd = new Button();
            manageGoBack = new LinkLabel();
            managePay = new Button();
            manageLayout = new TableLayoutPanel();
            manageLayout.SuspendLayout();
            SuspendLayout();
            // 
            // manageHeading
            // 
            manageHeading.AutoSize = true;
            manageHeading.Dock = DockStyle.Fill;
            manageHeading.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            manageHeading.Location = new Point(16, 0);
            manageHeading.Margin = new Padding(0);
            manageHeading.Name = "manageHeading";
            manageHeading.Size = new Size(188, 65);
            manageHeading.TabIndex = 6;
            manageHeading.Text = "Управление";
            manageHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // manageCreate
            // 
            manageCreate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            manageCreate.AutoSize = true;
            manageCreate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            manageCreate.Location = new Point(16, 70);
            manageCreate.Margin = new Padding(0);
            manageCreate.Name = "manageCreate";
            manageCreate.Size = new Size(188, 25);
            manageCreate.TabIndex = 0;
            manageCreate.Tag = "create";
            manageCreate.Text = "Създаване";
            manageCreate.UseVisualStyleBackColor = true;
            manageCreate.Click += Options;
            // 
            // manageView
            // 
            manageView.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            manageView.AutoSize = true;
            manageView.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            manageView.Location = new Point(16, 106);
            manageView.Margin = new Padding(0);
            manageView.Name = "manageView";
            manageView.Size = new Size(188, 25);
            manageView.TabIndex = 1;
            manageView.Tag = "view";
            manageView.Text = "Разглеждане";
            manageView.UseVisualStyleBackColor = true;
            manageView.Click += Options;
            // 
            // manageChange
            // 
            manageChange.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            manageChange.AutoSize = true;
            manageChange.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            manageChange.Location = new Point(16, 142);
            manageChange.Margin = new Padding(0);
            manageChange.Name = "manageChange";
            manageChange.Size = new Size(188, 25);
            manageChange.TabIndex = 2;
            manageChange.Tag = "change";
            manageChange.Text = "Актуализиране";
            manageChange.UseVisualStyleBackColor = true;
            manageChange.Click += Options;
            // 
            // manageEnd
            // 
            manageEnd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            manageEnd.AutoSize = true;
            manageEnd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            manageEnd.Location = new Point(16, 178);
            manageEnd.Margin = new Padding(0);
            manageEnd.Name = "manageEnd";
            manageEnd.Size = new Size(188, 25);
            manageEnd.TabIndex = 3;
            manageEnd.Tag = "end";
            manageEnd.Text = "Приключване";
            manageEnd.UseVisualStyleBackColor = true;
            manageEnd.Click += Options;
            // 
            // manageGoBack
            // 
            manageGoBack.ActiveLinkColor = Color.FromArgb(0, 0, 192);
            manageGoBack.AutoSize = true;
            manageGoBack.Cursor = Cursors.Hand;
            manageGoBack.Dock = DockStyle.Fill;
            manageGoBack.LinkBehavior = LinkBehavior.HoverUnderline;
            manageGoBack.LinkColor = Color.FromArgb(0, 0, 192);
            manageGoBack.Location = new Point(16, 245);
            manageGoBack.Margin = new Padding(0);
            manageGoBack.Name = "manageGoBack";
            manageGoBack.Size = new Size(188, 28);
            manageGoBack.TabIndex = 5;
            manageGoBack.TabStop = true;
            manageGoBack.Text = "Излизане от системата";
            manageGoBack.TextAlign = ContentAlignment.MiddleCenter;
            manageGoBack.VisitedLinkColor = Color.FromArgb(0, 0, 192);
            manageGoBack.LinkClicked += GoBack;
            // 
            // managePay
            // 
            managePay.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            managePay.AutoSize = true;
            managePay.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            managePay.Location = new Point(16, 214);
            managePay.Margin = new Padding(0);
            managePay.Name = "managePay";
            managePay.Size = new Size(188, 25);
            managePay.TabIndex = 4;
            managePay.Tag = "pay";
            managePay.Text = "Плащане";
            managePay.UseVisualStyleBackColor = true;
            managePay.Click += Options;
            // 
            // manageLayout
            // 
            manageLayout.ColumnCount = 3;
            manageLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.5F));
            manageLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            manageLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.5F));
            manageLayout.Controls.Add(manageHeading, 1, 0);
            manageLayout.Controls.Add(managePay, 1, 5);
            manageLayout.Controls.Add(manageCreate, 1, 1);
            manageLayout.Controls.Add(manageView, 1, 2);
            manageLayout.Controls.Add(manageChange, 1, 3);
            manageLayout.Controls.Add(manageEnd, 1, 4);
            manageLayout.Controls.Add(manageGoBack, 1, 6);
            manageLayout.Dock = DockStyle.Fill;
            manageLayout.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            manageLayout.Location = new Point(0, 0);
            manageLayout.Name = "manageLayout";
            manageLayout.RowCount = 8;
            manageLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 22.5F));
            manageLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            manageLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            manageLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            manageLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            manageLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            manageLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            manageLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            manageLayout.Size = new Size(222, 289);
            manageLayout.TabIndex = 7;
            // 
            // Manage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(222, 289);
            Controls.Add(manageLayout);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Manage";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Управление";
            FormClosed += ExitApp;
            manageLayout.ResumeLayout(false);
            manageLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label manageHeading;
        private Button manageCreate;
        private Button manageView;
        private Button manageChange;
        private Button manageEnd;
        private LinkLabel manageGoBack;
        private Button managePay;
        private TableLayoutPanel manageLayout;
    }
}