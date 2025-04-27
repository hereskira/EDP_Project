namespace EDP_Project
{
    partial class FPassPage1
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
            SecQuesAnswer = new TextBox();
            groupBox1 = new GroupBox();
            LoadSecButton = new Button();
            SecQuesDisplay = new Label();
            BackButton = new LinkLabel();
            VerifyButton = new Button();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // SecQuesAnswer
            // 
            SecQuesAnswer.Location = new Point(25, 96);
            SecQuesAnswer.Name = "SecQuesAnswer";
            SecQuesAnswer.Size = new Size(191, 23);
            SecQuesAnswer.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LoadSecButton);
            groupBox1.Controls.Add(SecQuesDisplay);
            groupBox1.Controls.Add(BackButton);
            groupBox1.Controls.Add(SecQuesAnswer);
            groupBox1.Controls.Add(VerifyButton);
            groupBox1.Location = new Point(250, 188);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(301, 212);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Security Question";
            // 
            // LoadSecButton
            // 
            LoadSecButton.Location = new Point(25, 63);
            LoadSecButton.Name = "LoadSecButton";
            LoadSecButton.Size = new Size(75, 23);
            LoadSecButton.TabIndex = 9;
            LoadSecButton.Text = "Load";
            LoadSecButton.UseVisualStyleBackColor = true;
            // 
            // SecQuesDisplay
            // 
            SecQuesDisplay.AutoSize = true;
            SecQuesDisplay.Location = new Point(25, 38);
            SecQuesDisplay.Name = "SecQuesDisplay";
            SecQuesDisplay.Size = new Size(205, 15);
            SecQuesDisplay.TabIndex = 6;
            SecQuesDisplay.Text = "Press the Load Security Question first.";
            // 
            // BackButton
            // 
            BackButton.AutoSize = true;
            BackButton.LinkColor = Color.Black;
            BackButton.Location = new Point(133, 181);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(32, 15);
            BackButton.TabIndex = 5;
            BackButton.TabStop = true;
            BackButton.Text = "Back";
            // 
            // VerifyButton
            // 
            VerifyButton.Location = new Point(111, 155);
            VerifyButton.Name = "VerifyButton";
            VerifyButton.Size = new Size(75, 23);
            VerifyButton.TabIndex = 4;
            VerifyButton.Text = "Verify";
            VerifyButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 142);
            label2.Name = "label2";
            label2.Size = new Size(203, 15);
            label2.TabIndex = 7;
            label2.Text = "Please answer your security question.";
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
            // FPassPage1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FPassPage1";
            Text = "FPassPage1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SecQuesAnswer;
        private GroupBox groupBox1;
        private LinkLabel BackButton;
        private Button VerifyButton;
        private Label label2;
        private Label label1;
        private Label SecQuesDisplay;
        private Button LoadSecButton;
    }
}