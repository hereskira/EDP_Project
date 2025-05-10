namespace EDP_Project
{
    partial class EditLoansPage
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
            groupBox1 = new GroupBox();
            OverdueGBox = new GroupBox();
            NoOverdue = new RadioButton();
            YesOverdue = new RadioButton();
            PaidGBox = new GroupBox();
            NoPaid = new RadioButton();
            YesPaid = new RadioButton();
            DueDate = new DateTimePicker();
            LoanDate = new DateTimePicker();
            MemberCBox = new ComboBox();
            EmployeeCBox = new ComboBox();
            label7 = new Label();
            AddLoanButton = new Button();
            BookCBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            OverdueGBox.SuspendLayout();
            PaidGBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(OverdueGBox);
            groupBox1.Controls.Add(PaidGBox);
            groupBox1.Controls.Add(DueDate);
            groupBox1.Controls.Add(LoanDate);
            groupBox1.Controls.Add(MemberCBox);
            groupBox1.Controls.Add(EmployeeCBox);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(AddLoanButton);
            groupBox1.Controls.Add(BookCBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(37, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(313, 475);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Edit Existing Loan";
            // 
            // OverdueGBox
            // 
            OverdueGBox.Controls.Add(NoOverdue);
            OverdueGBox.Controls.Add(YesOverdue);
            OverdueGBox.Location = new Point(27, 366);
            OverdueGBox.Name = "OverdueGBox";
            OverdueGBox.Size = new Size(182, 47);
            OverdueGBox.TabIndex = 24;
            OverdueGBox.TabStop = false;
            OverdueGBox.Text = "Is it Overdue?";
            // 
            // NoOverdue
            // 
            NoOverdue.AutoSize = true;
            NoOverdue.Location = new Point(62, 22);
            NoOverdue.Name = "NoOverdue";
            NoOverdue.Size = new Size(41, 19);
            NoOverdue.TabIndex = 22;
            NoOverdue.Text = "No";
            NoOverdue.UseVisualStyleBackColor = true;
            // 
            // YesOverdue
            // 
            YesOverdue.AutoSize = true;
            YesOverdue.Location = new Point(10, 22);
            YesOverdue.Name = "YesOverdue";
            YesOverdue.Size = new Size(42, 19);
            YesOverdue.TabIndex = 21;
            YesOverdue.Text = "Yes";
            YesOverdue.UseVisualStyleBackColor = true;
            // 
            // PaidGBox
            // 
            PaidGBox.Controls.Add(NoPaid);
            PaidGBox.Controls.Add(YesPaid);
            PaidGBox.Location = new Point(27, 313);
            PaidGBox.Name = "PaidGBox";
            PaidGBox.Size = new Size(182, 47);
            PaidGBox.TabIndex = 23;
            PaidGBox.TabStop = false;
            PaidGBox.Text = "Is it Paid?";
            // 
            // NoPaid
            // 
            NoPaid.AutoSize = true;
            NoPaid.Location = new Point(62, 22);
            NoPaid.Name = "NoPaid";
            NoPaid.Size = new Size(41, 19);
            NoPaid.TabIndex = 20;
            NoPaid.Text = "No";
            NoPaid.UseVisualStyleBackColor = true;
            // 
            // YesPaid
            // 
            YesPaid.AutoSize = true;
            YesPaid.Location = new Point(10, 22);
            YesPaid.Name = "YesPaid";
            YesPaid.Size = new Size(42, 19);
            YesPaid.TabIndex = 19;
            YesPaid.Text = "Yes";
            YesPaid.UseVisualStyleBackColor = true;
            // 
            // DueDate
            // 
            DueDate.Location = new Point(27, 277);
            DueDate.Name = "DueDate";
            DueDate.Size = new Size(200, 23);
            DueDate.TabIndex = 18;
            // 
            // LoanDate
            // 
            LoanDate.Location = new Point(27, 221);
            LoanDate.Name = "LoanDate";
            LoanDate.Size = new Size(200, 23);
            LoanDate.TabIndex = 17;
            // 
            // MemberCBox
            // 
            MemberCBox.FormattingEnabled = true;
            MemberCBox.Location = new Point(27, 47);
            MemberCBox.Name = "MemberCBox";
            MemberCBox.Size = new Size(121, 23);
            MemberCBox.TabIndex = 16;
            // 
            // EmployeeCBox
            // 
            EmployeeCBox.FormattingEnabled = true;
            EmployeeCBox.Location = new Point(27, 163);
            EmployeeCBox.Name = "EmployeeCBox";
            EmployeeCBox.Size = new Size(121, 23);
            EmployeeCBox.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 145);
            label7.Name = "label7";
            label7.Size = new Size(116, 15);
            label7.TabIndex = 15;
            label7.Text = "Employee in Charge:";
            // 
            // AddLoanButton
            // 
            AddLoanButton.Location = new Point(120, 432);
            AddLoanButton.Name = "AddLoanButton";
            AddLoanButton.Size = new Size(78, 26);
            AddLoanButton.TabIndex = 12;
            AddLoanButton.Text = "Edit";
            AddLoanButton.UseVisualStyleBackColor = true;
            // 
            // BookCBox
            // 
            BookCBox.FormattingEnabled = true;
            BookCBox.Location = new Point(27, 103);
            BookCBox.Name = "BookCBox";
            BookCBox.Size = new Size(121, 23);
            BookCBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 29);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Member Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 85);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 3;
            label2.Text = "Book:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 203);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 4;
            label3.Text = "Loan Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 259);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 6;
            label4.Text = "Due Date:";
            // 
            // EditLoansPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 510);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditLoansPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Loans";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            OverdueGBox.ResumeLayout(false);
            OverdueGBox.PerformLayout();
            PaidGBox.ResumeLayout(false);
            PaidGBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox OverdueGBox;
        private RadioButton NoOverdue;
        private RadioButton YesOverdue;
        private GroupBox PaidGBox;
        private RadioButton NoPaid;
        private RadioButton YesPaid;
        private DateTimePicker DueDate;
        private DateTimePicker LoanDate;
        private ComboBox MemberCBox;
        private ComboBox EmployeeCBox;
        private Label label7;
        private Button AddLoanButton;
        private ComboBox BookCBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}