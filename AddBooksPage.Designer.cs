namespace EDP_Project
{
    partial class AddBooksPage
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
            label1 = new Label();
            TitleInput = new TextBox();
            AuthorCBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            CategoryCBox = new ComboBox();
            YearInput = new TextBox();
            label4 = new Label();
            PriceInput = new TextBox();
            label5 = new Label();
            AvailCopiesInput = new TextBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            PublisherCBox = new ComboBox();
            label7 = new Label();
            LoadButton = new Button();
            AddBookButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 29);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            label1.Click += label1_Click;
            // 
            // TitleInput
            // 
            TitleInput.Location = new Point(27, 47);
            TitleInput.Name = "TitleInput";
            TitleInput.Size = new Size(100, 23);
            TitleInput.TabIndex = 1;
            // 
            // AuthorCBox
            // 
            AuthorCBox.FormattingEnabled = true;
            AuthorCBox.Location = new Point(27, 103);
            AuthorCBox.Name = "AuthorCBox";
            AuthorCBox.Size = new Size(121, 23);
            AuthorCBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 85);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "Author:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 203);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Category:";
            // 
            // CategoryCBox
            // 
            CategoryCBox.FormattingEnabled = true;
            CategoryCBox.Location = new Point(27, 221);
            CategoryCBox.Name = "CategoryCBox";
            CategoryCBox.Size = new Size(121, 23);
            CategoryCBox.TabIndex = 5;
            // 
            // YearInput
            // 
            YearInput.Location = new Point(27, 277);
            YearInput.Name = "YearInput";
            YearInput.Size = new Size(100, 23);
            YearInput.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 259);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 6;
            label4.Text = "Year:";
            // 
            // PriceInput
            // 
            PriceInput.Location = new Point(27, 334);
            PriceInput.Name = "PriceInput";
            PriceInput.Size = new Size(100, 23);
            PriceInput.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 316);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 8;
            label5.Text = "Price:";
            // 
            // AvailCopiesInput
            // 
            AvailCopiesInput.Location = new Point(27, 389);
            AvailCopiesInput.Name = "AvailCopiesInput";
            AvailCopiesInput.Size = new Size(47, 23);
            AvailCopiesInput.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 371);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 10;
            label6.Text = "Available Copies:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PublisherCBox);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(LoadButton);
            groupBox1.Controls.Add(AddBookButton);
            groupBox1.Controls.Add(AuthorCBox);
            groupBox1.Controls.Add(AvailCopiesInput);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(TitleInput);
            groupBox1.Controls.Add(PriceInput);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(YearInput);
            groupBox1.Controls.Add(CategoryCBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(41, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(313, 475);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Book";
            // 
            // PublisherCBox
            // 
            PublisherCBox.FormattingEnabled = true;
            PublisherCBox.Location = new Point(27, 163);
            PublisherCBox.Name = "PublisherCBox";
            PublisherCBox.Size = new Size(121, 23);
            PublisherCBox.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 145);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 15;
            label7.Text = "Publisher:";
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(163, 425);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(78, 26);
            LoadButton.TabIndex = 13;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = true;
            // 
            // AddBookButton
            // 
            AddBookButton.Location = new Point(79, 425);
            AddBookButton.Name = "AddBookButton";
            AddBookButton.Size = new Size(78, 26);
            AddBookButton.TabIndex = 12;
            AddBookButton.Text = "Add";
            AddBookButton.UseVisualStyleBackColor = true;
            // 
            // AddBooksPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 510);
            Controls.Add(groupBox1);
            Name = "AddBooksPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Books";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox TitleInput;
        private ComboBox AuthorCBox;
        private Label label2;
        private Label label3;
        private ComboBox CategoryCBox;
        private TextBox YearInput;
        private Label label4;
        private TextBox PriceInput;
        private Label label5;
        private TextBox AvailCopiesInput;
        private Label label6;
        private GroupBox groupBox1;
        private Button AddBookButton;
        private Button LoadButton;
        private ComboBox PublisherCBox;
        private Label label7;
    }
}