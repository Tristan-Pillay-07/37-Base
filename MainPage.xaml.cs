namespace _37Base
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }


        private async void OnCardTapped(object sender, TappedEventArgs e)
        {
            // Prefer e.Parameter; fall back to sender if needed
            var key = e.Parameter as string
                      ?? (sender as TapGestureRecognizer)?.CommandParameter as string;

            if (string.IsNullOrWhiteSpace(key)) return;

            switch (key)
            {
                case "Rescue37": await Navigation.PushAsync(new rescue37()); break;
                case "Alpha": await Navigation.PushAsync(new alpha()); break;
                case "Charlie": await Navigation.PushAsync(new charlie()); break;
            }
        }
    }

}
