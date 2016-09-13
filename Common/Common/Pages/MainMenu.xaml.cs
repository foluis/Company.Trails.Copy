using Common.Services;

using Xamarin.Forms;

namespace Common.Pages
{
    public partial class MainMenu : ContentPage
    {
        public MainMenu()
        {
            InitializeComponent();

            listView.ItemsSource = MainMenuData.MainMenuOptions;
        }
    }
}
