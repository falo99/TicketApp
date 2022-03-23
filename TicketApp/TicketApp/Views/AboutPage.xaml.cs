using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TicketApp.Services;
using System.IO;
using SQLite;
using TicketApp.Models;

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
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MyDb.db");
            var dataBase = new SQLiteConnection(databasePath);
            var query = dataBase.Table<User>().Where(x => x.Login.Equals(Login.Text) && x.Password.Equals(Password.Text)).FirstOrDefault();
            Entry loginEntry = this.FindByName<Entry>("Login");
            Entry passwordEntry = this.FindByName<Entry>("Password");
            string login = loginEntry.Text;   
            string password = passwordEntry.Text;
           
            if(query!=null)
            {
                App.Current.MainPage = new NavigationPage(new CustomPage(login,password));
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