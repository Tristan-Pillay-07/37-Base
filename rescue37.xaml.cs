namespace _37Base;

public partial class rescue37 : ContentPage
{
    public rescue37()
    {
        InitializeComponent();
    }

    private async void Pre_Clicked(object sender, EventArgs e)
    {
        Uri uri = new Uri("https://forms.office.com/r/tUYpq25TGS");
        await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);

    }
    private async void Housing_Clicked(object sender, EventArgs e)
    {
        Uri uri = new Uri("https://forms.office.com/r/c3pFWCi65j");
        await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
    }
}