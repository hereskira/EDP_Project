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
            AuthorsPage = new Button();
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
            // AuthorsPage
            // 
            AuthorsPage.Location = new Point(129, 67);
            AuthorsPage.Name = "AuthorsPage";
            AuthorsPage.Size = new Size(75, 23);
            AuthorsPage.TabIndex = 2;
            AuthorsPage.Text = "Authors";
            AuthorsPage.UseVisualStyleBackColor = true;
            // 
            // BooksPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AuthorsPage);
            Controls.Add(label1);
            Controls.Add(BooksData);
            Name = "BooksPage";
            Text = "Books";
            ((System.ComponentModel.ISupportInitialize)BooksData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView BooksData;
        private Label label1;
        private Button AuthorsPage;
    }
}