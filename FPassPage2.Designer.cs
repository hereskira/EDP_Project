namespace EDP_Project
{
    partial class FPassPage2
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
            label2 = new Label();
            label1 = new Label();
            NewPassInput = new TextBox();
            groupBox1 = new GroupBox();
            ConfirmPassInput = new TextBox();
            label4 = new Label();
            BackButton = new LinkLabel();
            ResetPassButton = new Button();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(333, 149);
            label2.Name = "label2";
            label2.Size = new Size(131, 15);
            label2.TabIndex = 7;
            label2.Text = "Create a new password.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(297, 97);
            label1.Name = "label1";
            label1.Size = new Size(200, 30);
            label1.TabIndex = 6;
            label1.Text = "Password Recovery";
            // 
            // NewPassInput
            // 
            NewPassInput.Location = new Point(23, 50);
            NewPassInput.Name = "NewPassInput";
            NewPassInput.PasswordChar = '*';
            NewPassInput.Size = new Size(191, 23);
            NewPassInput.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ConfirmPassInput);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(BackButton);
            groupBox1.Controls.Add(NewPassInput);
            groupBox1.Controls.Add(ResetPassButton);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(250, 188);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(301, 223);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input Credentials";
            // 
            // ConfirmPassInput
            // 
            ConfirmPassInput.Location = new Point(23, 103);
            ConfirmPassInput.Name = "ConfirmPassInput";
            ConfirmPassInput.PasswordChar = '*';
            ConfirmPassInput.Size = new Size(191, 23);
            ConfirmPassInput.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 85);
            label4.Name = "label4";
            label4.Size = new Size(129, 15);
            label4.TabIndex = 7;
            label4.Text = "Confirm new password";
            // 
            // BackButton
            // 
            BackButton.AutoSize = true;
            BackButton.LinkColor = Color.Black;
            BackButton.Location = new Point(134, 191);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(32, 15);
            BackButton.TabIndex = 5;
            BackButton.TabStop = true;
            BackButton.Text = "Back";
            // 
            // ResetPassButton
            // 
            ResetPassButton.Location = new Point(99, 165);
            ResetPassButton.Name = "ResetPassButton";
            ResetPassButton.Size = new Size(100, 23);
            ResetPassButton.TabIndex = 4;
            ResetPassButton.Text = "Reset Password";
            ResetPassButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 32);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 3;
            label3.Text = "Enter new password";
            // 
            // FPassPage2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FPassPage2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FPassPage2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox NewPassInput;
        private GroupBox groupBox1;
        private LinkLabel BackButton;
        private Button ResetPassButton;
        private Label label3;
        private TextBox ConfirmPassInput;
        private Label label4;
    }
}