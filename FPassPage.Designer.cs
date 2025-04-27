namespace EDP_Project
{
    partial class FPassPage
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
            EmailInput = new TextBox();
            label3 = new Label();
            ContinueButton = new Button();
            groupBox1 = new GroupBox();
            BackButton = new LinkLabel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(286, 79);
            label1.Name = "label1";
            label1.Size = new Size(200, 30);
            label1.TabIndex = 0;
            label1.Text = "Password Recovery";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 139);
            label2.Name = "label2";
            label2.Size = new Size(301, 15);
            label2.TabIndex = 1;
            label2.Text = "Please enter your email address to recover your account";
            // 
            // EmailInput
            // 
            EmailInput.Location = new Point(23, 50);
            EmailInput.Name = "EmailInput";
            EmailInput.Size = new Size(191, 23);
            EmailInput.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 32);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 3;
            label3.Text = "Email Address";
            // 
            // ContinueButton
            // 
            ContinueButton.Location = new Point(120, 105);
            ContinueButton.Name = "ContinueButton";
            ContinueButton.Size = new Size(75, 23);
            ContinueButton.TabIndex = 4;
            ContinueButton.Text = "Continue";
            ContinueButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BackButton);
            groupBox1.Controls.Add(EmailInput);
            groupBox1.Controls.Add(ContinueButton);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(239, 170);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(301, 166);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input Credentials";
            // 
            // BackButton
            // 
            BackButton.AutoSize = true;
            BackButton.LinkColor = Color.Black;
            BackButton.Location = new Point(116, 131);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(79, 15);
            BackButton.TabIndex = 5;
            BackButton.TabStop = true;
            BackButton.Text = "Back to Login";
            // 
            // FPassPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FPassPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox EmailInput;
        private Label label3;
        private Button ContinueButton;
        private GroupBox groupBox1;
        private LinkLabel BackButton;
    }
}