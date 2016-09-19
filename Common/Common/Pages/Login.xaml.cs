using System;

using Xamarin.Forms;

namespace Common.Pages
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();

            btnLogin.Clicked += BtnLogin_Clicked;
        }

        async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            var isValid = AreCredentialsCorrect();
            if (isValid)
            {
                //App.IsUserLoggedIn = true;
                //Navigation.InsertPageBefore(new MainMenu(), this);
                //await Navigation.PopAsync();

                var mainMenu = new MainMenu();
                await Navigation.PushModalAsync(mainMenu);
            }
            else
            {
                //messageLabel.Text = "Login failed";            
            }
        }

        bool AreCredentialsCorrect()
        {
            return true;
        }
    }
}
