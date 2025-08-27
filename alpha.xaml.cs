namespace _37Base;

public partial class alpha : ContentPage
{
	public alpha()
	{
		InitializeComponent();
	}

    private async void Pre_Clicked(object sender, EventArgs e)
    {
        Uri uri = new Uri("https://forms.office.com/Pages/ResponsePage.aspx?id=yFTJrUhOwk2L_GQhkVkO0VYdg0r2vilNioodwSyET9xUNkhDTTA4Q0FONkswQk9ZNUIwMkFJQU5KRS4u");
        await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);

    }
    private async void Housing_Clicked(object sender, EventArgs e)
    {
        Uri uri = new Uri("https://forms.office.com/Pages/ResponsePage.aspx?id=yFTJrUhOwk2L_GQhkVkO0VYdg0r2vilNioodwSyET9xUM0JTVVFNRzk5TVlXMTlVR0tUUVhJWllDTC4u");
        await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
    }
}