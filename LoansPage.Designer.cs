namespace EDP_Project
{
    partial class LoansPage
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
            PublishersButton = new Button();
            MembersButton = new Button();
            LoansButton = new Button();
            EmployeesButton = new Button();
            CategoriesButton = new Button();
            BooksButton = new Button();
            AuthorsButton = new Button();
            label1 = new Label();
            LoansData = new DataGridView();
            groupBox1 = new GroupBox();
            AddLoanButton = new Button();
            RefreshButton = new Button();
            ((System.ComponentModel.ISupportInitialize)LoansData).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // PublishersButton
            // 
            PublishersButton.Location = new Point(596, 70);
            PublishersButton.Name = "PublishersButton";
            PublishersButton.Size = new Size(75, 23);
            PublishersButton.TabIndex = 17;
            PublishersButton.Text = "Publishers";
            PublishersButton.UseVisualStyleBackColor = true;
            // 
            // MembersButton
            // 
            MembersButton.Location = new Point(515, 70);
            MembersButton.Name = "MembersButton";
            MembersButton.Size = new Size(75, 23);
            MembersButton.TabIndex = 16;
            MembersButton.Text = "Members";
            MembersButton.UseVisualStyleBackColor = true;
            // 
            // LoansButton
            // 
            LoansButton.Location = new Point(434, 70);
            LoansButton.Name = "LoansButton";
            LoansButton.Size = new Size(75, 23);
            LoansButton.TabIndex = 15;
            LoansButton.Text = "Loans";
            LoansButton.UseVisualStyleBackColor = true;
            // 
            // EmployeesButton
            // 
            EmployeesButton.Location = new Point(353, 70);
            EmployeesButton.Name = "EmployeesButton";
            EmployeesButton.Size = new Size(75, 23);
            EmployeesButton.TabIndex = 14;
            EmployeesButton.Text = "Employees";
            EmployeesButton.UseVisualStyleBackColor = true;
            // 
            // CategoriesButton
            // 
            CategoriesButton.Location = new Point(272, 70);
            CategoriesButton.Name = "CategoriesButton";
            CategoriesButton.Size = new Size(75, 23);
            CategoriesButton.TabIndex = 13;
            CategoriesButton.Text = "Categories";
            CategoriesButton.UseVisualStyleBackColor = true;
            // 
            // BooksButton
            // 
            BooksButton.Location = new Point(191, 70);
            BooksButton.Name = "BooksButton";
            BooksButton.Size = new Size(75, 23);
            BooksButton.TabIndex = 12;
            BooksButton.Text = "Books";
            BooksButton.UseVisualStyleBackColor = true;
            // 
            // AuthorsButton
            // 
            AuthorsButton.Location = new Point(110, 70);
            AuthorsButton.Name = "AuthorsButton";
            AuthorsButton.Size = new Size(75, 23);
            AuthorsButton.TabIndex = 11;
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
            label1.TabIndex = 10;
            label1.Text = "Library Management System";
            // 
            // LoansData
            // 
            LoansData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LoansData.Location = new Point(29, 52);
            LoansData.Name = "LoansData";
            LoansData.Size = new Size(686, 304);
            LoansData.TabIndex = 9;
            LoansData.CellContentClick += LoansData_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RefreshButton);
            groupBox1.Controls.Add(AddLoanButton);
            groupBox1.Controls.Add(LoansData);
            groupBox1.Location = new Point(26, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(749, 372);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Loans Table";
            // 
            // AddLoanButton
            // 
            AddLoanButton.Location = new Point(29, 22);
            AddLoanButton.Name = "AddLoanButton";
            AddLoanButton.Size = new Size(75, 23);
            AddLoanButton.TabIndex = 10;
            AddLoanButton.Text = "Add New";
            AddLoanButton.UseVisualStyleBackColor = true;
            // 
            // RefreshButton
            // 
            RefreshButton.Location = new Point(110, 22);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(88, 23);
            RefreshButton.TabIndex = 19;
            RefreshButton.Text = "Refresh Table";
            RefreshButton.UseVisualStyleBackColor = true;
            // 
            // LoansPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 480);
            Controls.Add(groupBox1);
            Controls.Add(PublishersButton);
            Controls.Add(MembersButton);
            Controls.Add(LoansButton);
            Controls.Add(EmployeesButton);
            Controls.Add(CategoriesButton);
            Controls.Add(BooksButton);
            Controls.Add(AuthorsButton);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoansPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loans";
            ((System.ComponentModel.ISupportInitialize)LoansData).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PublishersButton;
        private Button MembersButton;
        private Button LoansButton;
        private Button EmployeesButton;
        private Button CategoriesButton;
        private Button BooksButton;
        private Button AuthorsButton;
        private Label label1;
        private DataGridView LoansData;
        private GroupBox groupBox1;
        private Button AddLoanButton;
        private Button RefreshButton;
    }
}