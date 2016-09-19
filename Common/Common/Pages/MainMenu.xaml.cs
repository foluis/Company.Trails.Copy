using Common.Pages.ActivityTracking;
using Common.Services;
using Xamarin.Forms;

namespace Common.Pages
{
    public partial class MainMenu : ContentPage
    {
        public MainMenu()
        {
            InitializeComponent();
            Events();
            listView.ItemsSource = MainMenuData.MainMenuOptions;
        }

        private void Events()
        {
            listView.ItemTapped += ListView_ItemTapped;           
        }

        async private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            switch ((e.Item as Common.Model.MainMenu).MenuItemId)
            {
                case 1:
                    await Navigation.PushModalAsync(new ActivityList());
                    break;
                default:
                    break;
            }
                ((ListView)sender).SelectedItem = null;
        }
    }
}
