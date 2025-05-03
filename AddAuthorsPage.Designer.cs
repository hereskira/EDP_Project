namespace EDP_Project
{
    partial class AddAuthorsPage
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
            BioInput = new RichTextBox();
            AddAuthorButton = new Button();
            label1 = new Label();
            NameInput = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BioInput);
            groupBox1.Controls.Add(AddAuthorButton);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(NameInput);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(37, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(313, 246);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Author";
            // 
            // BioInput
            // 
            BioInput.Location = new Point(27, 103);
            BioInput.Name = "BioInput";
            BioInput.Size = new Size(257, 85);
            BioInput.TabIndex = 14;
            BioInput.Text = "";
            // 
            // AddAuthorButton
            // 
            AddAuthorButton.Location = new Point(109, 210);
            AddAuthorButton.Name = "AddAuthorButton";
            AddAuthorButton.Size = new Size(78, 26);
            AddAuthorButton.TabIndex = 12;
            AddAuthorButton.Text = "Add";
            AddAuthorButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 29);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // NameInput
            // 
            NameInput.Location = new Point(27, 47);
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(100, 23);
            NameInput.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 85);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "Biography:";
            // 
            // AddAuthorsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 279);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddAuthorsPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Authors";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button AddAuthorButton;
        private Label label1;
        private TextBox NameInput;
        private Label label2;
        private RichTextBox BioInput;
    }
}