namespace EDP_Project
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            usersStripButton = new ToolStripButton();
            BooksButton = new Button();
            toolStripButton1 = new ToolStripDropDownButton();
            listOfUsersToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, usersStripButton, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { logOutToolStripMenuItem, toolStripMenuItem2 });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(81, 22);
            toolStripDropDownButton1.Text = "Application";
            toolStripDropDownButton1.ToolTipText = "Application";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(117, 22);
            logOutToolStripMenuItem.Text = "Log Out";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(117, 22);
            toolStripMenuItem2.Text = "Exit";
            // 
            // usersStripButton
            // 
            usersStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            usersStripButton.Image = (Image)resources.GetObject("usersStripButton.Image");
            usersStripButton.ImageTransparentColor = Color.Magenta;
            usersStripButton.Name = "usersStripButton";
            usersStripButton.Size = new Size(80, 22);
            usersStripButton.Text = "System Users";
            // 
            // BooksButton
            // 
            BooksButton.Location = new Point(325, 172);
            BooksButton.Name = "BooksButton";
            BooksButton.Size = new Size(102, 38);
            BooksButton.TabIndex = 1;
            BooksButton.Text = "Proceed to Library Records";
            BooksButton.UseVisualStyleBackColor = true;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.DropDownItems.AddRange(new ToolStripItem[] { listOfUsersToolStripMenuItem });
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(60, 22);
            toolStripButton1.Text = "Reports";
            // 
            // listOfUsersToolStripMenuItem
            // 
            listOfUsersToolStripMenuItem.Name = "listOfUsersToolStripMenuItem";
            listOfUsersToolStripMenuItem.Size = new Size(180, 22);
            listOfUsersToolStripMenuItem.Text = "List of Users";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BooksButton);
            Controls.Add(toolStrip1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home Page";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private Button BooksButton;
        private ToolStripButton usersStripButton;
        private ToolStripDropDownButton toolStripButton1;
        private ToolStripMenuItem listOfUsersToolStripMenuItem;
    }
}