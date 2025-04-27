namespace EDP_Project
{
    partial class BooksPage
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
            BooksData = new DataGridView();
            label1 = new Label();
            AuthorsButton = new Button();
            BooksButton = new Button();
            CategoriesButton = new Button();
            EmployeesButton = new Button();
            LoansButton = new Button();
            MembersButton = new Button();
            PublishersButton = new Button();
            ((System.ComponentModel.ISupportInitialize)BooksData).BeginInit();
            SuspendLayout();
            // 
            // BooksData
            // 
            BooksData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BooksData.Location = new Point(76, 115);
            BooksData.Name = "BooksData";
            BooksData.Size = new Size(686, 304);
            BooksData.TabIndex = 0;
            BooksData.CellContentClick += BooksData_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(284, 26);
            label1.Name = "label1";
            label1.Size = new Size(229, 21);
            label1.TabIndex = 1;
            label1.Text = "Library Management System";
            // 
            // AuthorsButton
            // 
            AuthorsButton.Location = new Point(129, 67);
            AuthorsButton.Name = "AuthorsButton";
            AuthorsButton.Size = new Size(75, 23);
            AuthorsButton.TabIndex = 2;
            AuthorsButton.Text = "Authors";
            AuthorsButton.UseVisualStyleBackColor = true;
            // 
            // BooksButton
            // 
            BooksButton.Location = new Point(210, 67);
            BooksButton.Name = "BooksButton";
            BooksButton.Size = new Size(75, 23);
            BooksButton.TabIndex = 3;
            BooksButton.Text = "Books";
            BooksButton.UseVisualStyleBackColor = true;
            // 
            // CategoriesButton
            // 
            CategoriesButton.Location = new Point(291, 67);
            CategoriesButton.Name = "CategoriesButton";
            CategoriesButton.Size = new Size(75, 23);
            CategoriesButton.TabIndex = 4;
            CategoriesButton.Text = "Categories";
            CategoriesButton.UseVisualStyleBackColor = true;
            // 
            // EmployeesButton
            // 
            EmployeesButton.Location = new Point(372, 67);
            EmployeesButton.Name = "EmployeesButton";
            EmployeesButton.Size = new Size(75, 23);
            EmployeesButton.TabIndex = 5;
            EmployeesButton.Text = "Employees";
            EmployeesButton.UseVisualStyleBackColor = true;
            // 
            // LoansButton
            // 
            LoansButton.Location = new Point(453, 67);
            LoansButton.Name = "LoansButton";
            LoansButton.Size = new Size(75, 23);
            LoansButton.TabIndex = 6;
            LoansButton.Text = "Loans";
            LoansButton.UseVisualStyleBackColor = true;
            // 
            // MembersButton
            // 
            MembersButton.Location = new Point(534, 67);
            MembersButton.Name = "MembersButton";
            MembersButton.Size = new Size(75, 23);
            MembersButton.TabIndex = 7;
            MembersButton.Text = "Members";
            MembersButton.UseVisualStyleBackColor = true;
            // 
            // PublishersButton
            // 
            PublishersButton.Location = new Point(615, 67);
            PublishersButton.Name = "PublishersButton";
            PublishersButton.Size = new Size(75, 23);
            PublishersButton.TabIndex = 8;
            PublishersButton.Text = "Publishers";
            PublishersButton.UseVisualStyleBackColor = true;
            // 
            // BooksPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PublishersButton);
            Controls.Add(MembersButton);
            Controls.Add(LoansButton);
            Controls.Add(EmployeesButton);
            Controls.Add(CategoriesButton);
            Controls.Add(BooksButton);
            Controls.Add(AuthorsButton);
            Controls.Add(label1);
            Controls.Add(BooksData);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BooksPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Books";
            ((System.ComponentModel.ISupportInitialize)BooksData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView BooksData;
        private Label label1;
        private Button AuthorsButton;
        private Button BooksButton;
        private Button CategoriesButton;
        private Button EmployeesButton;
        private Button LoansButton;
        private Button MembersButton;
        private Button PublishersButton;
    }
}