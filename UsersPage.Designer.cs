namespace EDP_Project
{
    partial class UsersPage
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            NameInput = new TextBox();
            label6 = new Label();
            LoadButton = new Button();
            SecAnsInput = new TextBox();
            label5 = new Label();
            SecQuesInput = new ComboBox();
            label4 = new Label();
            UserInput = new TextBox();
            label3 = new Label();
            SaveButton = new Button();
            PassInput = new TextBox();
            EmailInput = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            UpdateButton = new Button();
            UpdatePass = new TextBox();
            label10 = new Label();
            UpdateEmail = new TextBox();
            label9 = new Label();
            UpdateName = new TextBox();
            label8 = new Label();
            SearchUsername = new TextBox();
            label7 = new Label();
            tabPage3 = new TabPage();
            DeleteUser = new TextBox();
            label11 = new Label();
            groupBox2 = new GroupBox();
            DeleteButton = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(409, 349);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(NameInput);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(LoadButton);
            tabPage1.Controls.Add(SecAnsInput);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(SecQuesInput);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(UserInput);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(SaveButton);
            tabPage1.Controls.Add(PassInput);
            tabPage1.Controls.Add(EmailInput);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(401, 321);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add User";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // NameInput
            // 
            NameInput.Location = new Point(164, 52);
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(121, 23);
            NameInput.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 55);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 12;
            label6.Text = "Full Name:";
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(164, 170);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(75, 23);
            LoadButton.TabIndex = 11;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = true;
            // 
            // SecAnsInput
            // 
            SecAnsInput.Location = new Point(164, 228);
            SecAnsInput.Name = "SecAnsInput";
            SecAnsInput.Size = new Size(121, 23);
            SecAnsInput.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 231);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 9;
            label5.Text = "Security Answer:";
            // 
            // SecQuesInput
            // 
            SecQuesInput.FormattingEnabled = true;
            SecQuesInput.Location = new Point(164, 199);
            SecQuesInput.Name = "SecQuesInput";
            SecQuesInput.Size = new Size(208, 23);
            SecQuesInput.TabIndex = 8;
            SecQuesInput.Text = "Select a question";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 176);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 7;
            label4.Text = "Security Question:";
            // 
            // UserInput
            // 
            UserInput.Location = new Point(164, 10);
            UserInput.Name = "UserInput";
            UserInput.Size = new Size(121, 23);
            UserInput.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 13);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 5;
            label3.Text = "Username:";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(155, 272);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "Save Account";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // PassInput
            // 
            PassInput.Location = new Point(164, 131);
            PassInput.Name = "PassInput";
            PassInput.PasswordChar = '*';
            PassInput.Size = new Size(121, 23);
            PassInput.TabIndex = 3;
            // 
            // EmailInput
            // 
            EmailInput.Location = new Point(164, 94);
            EmailInput.Name = "EmailInput";
            EmailInput.Size = new Size(121, 23);
            EmailInput.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 134);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 97);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Email Address:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(SearchUsername);
            tabPage2.Controls.Add(label7);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(401, 321);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Update User Profile";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(UpdateButton);
            groupBox1.Controls.Add(UpdatePass);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(UpdateEmail);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(UpdateName);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(27, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(354, 223);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Update Existing Account";
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(113, 184);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(123, 23);
            UpdateButton.TabIndex = 8;
            UpdateButton.Text = "Update Account";
            UpdateButton.UseVisualStyleBackColor = true;
            // 
            // UpdatePass
            // 
            UpdatePass.Location = new Point(113, 131);
            UpdatePass.Name = "UpdatePass";
            UpdatePass.PasswordChar = '*';
            UpdatePass.Size = new Size(123, 23);
            UpdatePass.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 131);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 6;
            label10.Text = "Password:";
            // 
            // UpdateEmail
            // 
            UpdateEmail.Location = new Point(113, 80);
            UpdateEmail.Name = "UpdateEmail";
            UpdateEmail.Size = new Size(124, 23);
            UpdateEmail.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 83);
            label9.Name = "label9";
            label9.Size = new Size(84, 15);
            label9.TabIndex = 4;
            label9.Text = "Email Address:";
            // 
            // UpdateName
            // 
            UpdateName.Location = new Point(113, 33);
            UpdateName.Name = "UpdateName";
            UpdateName.Size = new Size(124, 23);
            UpdateName.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 36);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 0;
            label8.Text = "Full Name:";
            // 
            // SearchUsername
            // 
            SearchUsername.Location = new Point(164, 23);
            SearchUsername.Name = "SearchUsername";
            SearchUsername.Size = new Size(100, 23);
            SearchUsername.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 26);
            label7.Name = "label7";
            label7.Size = new Size(116, 15);
            label7.TabIndex = 0;
            label7.Text = "Search by username:";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Gray;
            tabPage3.Controls.Add(DeleteUser);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(groupBox2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(401, 321);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Delete User";
            // 
            // DeleteUser
            // 
            DeleteUser.Location = new Point(182, 81);
            DeleteUser.Name = "DeleteUser";
            DeleteUser.Size = new Size(100, 23);
            DeleteUser.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(45, 84);
            label11.Name = "label11";
            label11.Size = new Size(116, 15);
            label11.TabIndex = 2;
            label11.Text = "Search by username:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(DeleteButton);
            groupBox2.Location = new Point(21, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(345, 256);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Delete Existing Account";
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(115, 160);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(102, 23);
            DeleteButton.TabIndex = 0;
            DeleteButton.Text = "Delete Account";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // UsersPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 373);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UsersPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UsersPage";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private Label label1;
        private TabPage tabPage3;
        private Button SaveButton;
        private TextBox PassInput;
        private TextBox EmailInput;
        private TextBox UserInput;
        private Label label3;
        private TextBox SecAnsInput;
        private Label label5;
        private ComboBox SecQuesInput;
        private Label label4;
        private Button LoadButton;
        private TextBox NameInput;
        private Label label6;
        private GroupBox groupBox1;
        private TextBox UpdatePass;
        private Label label10;
        private TextBox UpdateEmail;
        private Label label9;
        private TextBox UpdateName;
        private Label label8;
        private TextBox SearchUsername;
        private Label label7;
        private Button UpdateButton;
        private TextBox DeleteUser;
        private Label label11;
        private GroupBox groupBox2;
        private Button DeleteButton;
    }
}