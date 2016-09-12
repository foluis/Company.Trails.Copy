using System;

using Xamarin.Forms;

namespace Common.Pages
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        //async void OnLoginButtonClicked(object sender, EventArgs e)
        //{
        //    var isValid = AreCredentialsCorrect();
        //    if (isValid)
        //    {
        //        App.IsUserLoggedIn = true;
        //        Navigation.InsertPageBefore(new MainMenu(), this);
        //        await Navigation.PopAsync();
        //    }
        //    else
        //    {
        //        //messageLabel.Text = "Login failed";            
        //    }
        //}

        //void OnButtonClicked(object sender, EventArgs e)
        //{
        //    var isValid = AreCredentialsCorrect();
        //    if (isValid)
        //    {
        //        App.IsUserLoggedIn = true;
        //        Navigation.PushModalAsync(new MainMenu());
        //        Navigation.PopAsync();
        //    }
        //    else
        //    {
        //        //messageLabel.Text = "Login failed";            
        //    }
        //}



        void OnButtonClicked(object sender, EventArgs args)
        {
            string sera = "hola";
        }

        bool AreCredentialsCorrect()
        {
            return true;
        }
    }
}
