namespace EDP_Project
{
    partial class AccountsPage
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
            AccountsData = new DataGridView();
            ExportButton = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AccountsData).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AccountsData);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(403, 304);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // AccountsData
            // 
            AccountsData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AccountsData.Location = new Point(6, 13);
            AccountsData.Name = "AccountsData";
            AccountsData.Size = new Size(391, 285);
            AccountsData.TabIndex = 0;
            // 
            // ExportButton
            // 
            ExportButton.Location = new Point(18, 322);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(397, 39);
            ExportButton.TabIndex = 1;
            ExportButton.Text = "Export to MS Excel";
            ExportButton.UseVisualStyleBackColor = true;
            // 
            // AccountsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 373);
            Controls.Add(ExportButton);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AccountsPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "List of Accounts";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AccountsData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView AccountsData;
        private Button ExportButton;
    }
}