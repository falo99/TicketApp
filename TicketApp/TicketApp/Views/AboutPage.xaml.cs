using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TicketApp.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private async void LoginBtn_Clicked(object sender, EventArgs e)
        {
         //   Label loginlbl = this.FindByName<Label>("LoginLabel");
         //   Label passwordlbl = this.FindByName<Label>("PasswordLabel");
            Entry loginEntry = this.FindByName<Entry>("Login");
            Entry passwordEntry = this.FindByName<Entry>("Password");
            string login = loginEntry.Text;   
            string password = passwordEntry.Text;
            if(login=="admin" && password=="admin")
            {
                await Navigation.PushAsync(new CustomPage(login, password));
            }
            else
            {
                await DisplayAlert("Alert", "Wrong Credentials", "OK");
            }
           
        }

        private async void RegisterBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage());
        }
    }
}