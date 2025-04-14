namespace EDP_Project;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
	}

    private async void OnRegisterConfirmed(object sender, EventArgs e)
	{
		// Navigate to BooksPage
		await Navigation.PushAsync(new BooksPage());
	}
}