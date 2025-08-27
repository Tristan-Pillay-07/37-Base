namespace _37Base;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void Login_Clicked(object sender, EventArgs e)
	{
		if (txtUsername.Text == "Toby" && txtPassword.Text == "LostAtSea")
		{
			Navigation.PushAsync(new MainPage());
		}
		else
		{
			Error_Message.Text = "Please enter correct login details!";
		}
	}
}