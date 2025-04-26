namespace EDP_Project
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Add logic for label1 click event here
            MessageBox.Show("Label1 clicked!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add logic for button1 click event here
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }
    }
}
