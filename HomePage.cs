using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDP_Project
{
    public partial class HomePage : Form
    {
        private ToolStripMenuItem exitToolStripMenuItem;

        public HomePage()
        {
            InitializeComponent();
            BooksButton.Click += BooksButton_Click;

            // Wire up the event handlers for the existing menu items
            logOutToolStripMenuItem.Click += LogOutToolStripMenuItem_Click;
            toolStripMenuItem2.Click += ExitToolStripMenuItem_Click;
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LandingPage landingPage = new LandingPage();
            landingPage.Show();
            this.Hide();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit the application?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BooksButton_Click(object sender, EventArgs e)
        {
            BooksPage booksPage = new BooksPage();
            booksPage.Show();
            this.Hide();
        }

    }
}