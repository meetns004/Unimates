using Microsoft.Maui.Controls;

namespace Unimates
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnGetStartedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VerificationPage());
            await Navigation.PushAsync(new ProfilePage());    // For Profile Page
            await Navigation.PushAsync(new FavoritesPage());  // For Favorites Page
            await Navigation.PushAsync(new ChatPage());       // For Chat Page
            await Navigation.PushAsync(new SettingsPage());   // For Settings Page
            await Navigation.PushAsync(new NotificationPage());// For Notification Page

        }
    }
}
