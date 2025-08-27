namespace _37Base;

public partial class charlie : ContentPage
{
	public charlie()
	{
		InitializeComponent();
	}
    private async void Pre_Clicked(object sender, EventArgs e)
    {
        Uri uri = new Uri("https://forms.office.com/Pages/ResponsePage.aspx?id=yFTJrUhOwk2L_GQhkVkO0VYdg0r2vilNioodwSyET9xUMU9XTE1NUkRYOFZDN0dSSEpRNVZURVQxMi4u");
        await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);

    }
    private async void Housing_Clicked(object sender, EventArgs e)
    {
        Uri uri = new Uri("https://forms.office.com/Pages/ResponsePage.aspx?id=yFTJrUhOwk2L_GQhkVkO0VYdg0r2vilNioodwSyET9xUMzE2NkoxVlJETzBWSEIyV1hCWUU5U01KUC4u");
        await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
    }
}