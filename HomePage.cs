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
            LandingPButton.Click += LandingPButton_Click;

            // Wire up the event handlers for the existing menu items
            logOutToolStripMenuItem.Click += LogOutToolStripMenuItem_Click;
            toolStripMenuItem2.Click += ExitToolStripMenuItem_Click;
            usersStripButton.Click += UsersStripButton_Click;
            listOfUsersToolStripMenuItem.Click += ListOfUsersToolStripMenuItem_Click;
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
        private void UsersStripButton_Click(object sender, EventArgs e)
        {
            UsersPage usersPage = new UsersPage();
            usersPage.ShowDialog(); // Show the UsersPage without hiding the HomePage
        }
        private void ListOfUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountsPage accountsPage = new AccountsPage();
            accountsPage.ShowDialog(); // Show the AccountsPage as a dialog
        }
        private void LandingPButton_Click(object sender, EventArgs e)
        {
            // Navigate to LandingPage
            LandingPage landingPage = new LandingPage();
            landingPage.Show();

            // Close the current page
            this.Close();

            // Perform logout logic (if any additional logic is required)
            // Example: Clear user session or authentication tokens
            // Logout logic can be added here if needed
        }
    }
}