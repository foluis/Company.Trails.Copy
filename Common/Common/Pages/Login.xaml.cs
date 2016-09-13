using System;

using Xamarin.Forms;

namespace Common.Pages
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            OnButtonClicked(null, null);
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            var isValid = AreCredentialsCorrect();
            if (isValid)
            {
                App.IsUserLoggedIn = true;
                //Navigation.InsertPageBefore(new MainMenu(), this);
                //await Navigation.PopAsync();

                var detailPage = new MainMenu();    
                await Navigation.PushModalAsync(detailPage);
            }
            else
            {
                //messageLabel.Text = "Login failed";            
            }
        }

        //void OnButtonClicked(object sender, EventArgs e)
        //{
        //    var isValid = AreCredentialsCorrect();
        //    if (isValid)
        //    {
        //        App.IsUserLoggedIn = true;

        //        var detailPage = new MainMenu();
        //        Navigation.PushModalAsync(detailPage);
        //    }
        //    else
        //    {
        //        //messageLabel.Text = "Login failed";            
        //    }
        //}     

        bool AreCredentialsCorrect()
        {
            return true;
        }
    }
}
