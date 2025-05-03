namespace EDP_Project
{
    partial class AuthorsPage
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
            AuthorsButton = new Button();
            label1 = new Label();
            AuthorsData = new DataGridView();
            BooksButton = new Button();
            PublishersButton = new Button();
            MembersButton = new Button();
            LoansButton = new Button();
            EmployeesButton = new Button();
            CategoriesButton = new Button();
            groupBox1 = new GroupBox();
            AddAuthorButton = new Button();
            RefreshButton = new Button();
            ((System.ComponentModel.ISupportInitialize)AuthorsData).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // AuthorsButton
            // 
            AuthorsButton.Location = new Point(110, 70);
            AuthorsButton.Name = "AuthorsButton";
            AuthorsButton.Size = new Size(75, 23);
            AuthorsButton.TabIndex = 5;
            AuthorsButton.Text = "Authors";
            AuthorsButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(265, 29);
            label1.Name = "label1";
            label1.Size = new Size(229, 21);
            label1.TabIndex = 4;
            label1.Text = "Library Management System";
            // 
            // AuthorsData
            // 
            AuthorsData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AuthorsData.Location = new Point(25, 52);
            AuthorsData.Name = "AuthorsData";
            AuthorsData.Size = new Size(686, 304);
            AuthorsData.TabIndex = 3;
            // 
            // BooksButton
            // 
            BooksButton.Location = new Point(191, 70);
            BooksButton.Name = "BooksButton";
            BooksButton.Size = new Size(75, 23);
            BooksButton.TabIndex = 6;
            BooksButton.Text = "Books";
            BooksButton.UseVisualStyleBackColor = true;
            // 
            // PublishersButton
            // 
            PublishersButton.Location = new Point(596, 70);
            PublishersButton.Name = "PublishersButton";
            PublishersButton.Size = new Size(75, 23);
            PublishersButton.TabIndex = 13;
            PublishersButton.Text = "Publishers";
            PublishersButton.UseVisualStyleBackColor = true;
            // 
            // MembersButton
            // 
            MembersButton.Location = new Point(515, 70);
            MembersButton.Name = "MembersButton";
            MembersButton.Size = new Size(75, 23);
            MembersButton.TabIndex = 12;
            MembersButton.Text = "Members";
            MembersButton.UseVisualStyleBackColor = true;
            // 
            // LoansButton
            // 
            LoansButton.Location = new Point(434, 70);
            LoansButton.Name = "LoansButton";
            LoansButton.Size = new Size(75, 23);
            LoansButton.TabIndex = 11;
            LoansButton.Text = "Loans";
            LoansButton.UseVisualStyleBackColor = true;
            // 
            // EmployeesButton
            // 
            EmployeesButton.Location = new Point(353, 70);
            EmployeesButton.Name = "EmployeesButton";
            EmployeesButton.Size = new Size(75, 23);
            EmployeesButton.TabIndex = 10;
            EmployeesButton.Text = "Employees";
            EmployeesButton.UseVisualStyleBackColor = true;
            // 
            // CategoriesButton
            // 
            CategoriesButton.Location = new Point(272, 70);
            CategoriesButton.Name = "CategoriesButton";
            CategoriesButton.Size = new Size(75, 23);
            CategoriesButton.TabIndex = 9;
            CategoriesButton.Text = "Categories";
            CategoriesButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RefreshButton);
            groupBox1.Controls.Add(AddAuthorButton);
            groupBox1.Controls.Add(AuthorsData);
            groupBox1.Location = new Point(30, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(740, 372);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Authors Table";
            // 
            // AddAuthorButton
            // 
            AddAuthorButton.Location = new Point(25, 22);
            AddAuthorButton.Name = "AddAuthorButton";
            AddAuthorButton.Size = new Size(75, 23);
            AddAuthorButton.TabIndex = 15;
            AddAuthorButton.Text = "Add New";
            AddAuthorButton.UseVisualStyleBackColor = true;
            // 
            // RefreshButton
            // 
            RefreshButton.Location = new Point(106, 23);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(88, 23);
            RefreshButton.TabIndex = 16;
            RefreshButton.Text = "Refresh Table";
            RefreshButton.UseVisualStyleBackColor = true;
            // 
            // AuthorsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 480);
            Controls.Add(PublishersButton);
            Controls.Add(MembersButton);
            Controls.Add(LoansButton);
            Controls.Add(EmployeesButton);
            Controls.Add(CategoriesButton);
            Controls.Add(BooksButton);
            Controls.Add(AuthorsButton);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AuthorsPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Authors";
            Load += AuthorsPage_Load_1;
            ((System.ComponentModel.ISupportInitialize)AuthorsData).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AuthorsButton;
        private Label label1;
        private DataGridView AuthorsData;
        private Button BooksButton;
        private Button PublishersButton;
        private Button MembersButton;
        private Button LoansButton;
        private Button EmployeesButton;
        private Button CategoriesButton;
        private GroupBox groupBox1;
        private Button AddAuthorButton;
        private Button RefreshButton;
    }
}