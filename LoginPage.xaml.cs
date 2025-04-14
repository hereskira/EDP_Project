namespace EDP_Project;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	private async void OnLoginConfirmed(object sender, EventArgs e)
	{
		// Navigate to BooksPage
		await Navigation.PushAsync(new BooksPage());
	}
}