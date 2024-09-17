using Microsoft.Maui.Controls;

namespace Unimates
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Set the MainPage to be the first screen displayed (MainPage.xaml)
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
