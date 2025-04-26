namespace EDP_Project
{
    partial class LoginPage
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
            label2 = new Label();
            Username_Input = new TextBox();
            label3 = new Label();
            Password_Input = new TextBox();
            groupBox1 = new GroupBox();
            SubmitButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(198, 77);
            label1.Name = "label1";
            label1.Size = new Size(420, 30);
            label1.TabIndex = 0;
            label1.Text = "Login to the Library Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 17);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // Username_Input
            // 
            Username_Input.Location = new Point(21, 35);
            Username_Input.Name = "Username_Input";
            Username_Input.Size = new Size(100, 23);
            Username_Input.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 81);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // Password_Input
            // 
            Password_Input.Location = new Point(21, 99);
            Password_Input.Name = "Password_Input";
            Password_Input.Size = new Size(100, 23);
            Password_Input.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SubmitButton);
            groupBox1.Controls.Add(Username_Input);
            groupBox1.Controls.Add(Password_Input);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(257, 157);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 194);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input Credentials";
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(86, 151);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(75, 23);
            SubmitButton.TabIndex = 5;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "LoginPage";
            Text = "Login Page";
            Load += LoginPage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Username_Input;
        private Label label3;
        private TextBox Password_Input;
        private GroupBox groupBox1;
        private Button SubmitButton;
    }
}