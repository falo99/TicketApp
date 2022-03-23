using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TicketApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private async void RegisterBtn_Clicked(object sender, EventArgs e)
        {
            var databasePath = "C:\\Users\\Olaf Komputer\\source\\repos\\Database";
            var dPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "database.db");
            var path = Path.Combine(dPath, "MyDatabase.db3");
            FileStream fs = File.Create(path);
            //System.IO.Directory.CreateDirectory(path);
            var dataBase = new SQLiteConnection(path);
            dataBase.CreateTable<User>();
            
            var User = new User()
            {
                Email = Email.Text,
                Login = Login.Text,
                Password = Password.Text,
                Name = Name.Text,
                Surname = Surname.Text
            };
            dataBase.Insert(User);

            

            Device.BeginInvokeOnMainThread(async () =>
            {
                var info = await this.DisplayAlert("Congrats", "You have successfully registered!", "OK","Cancel" );
                if(info)
                await Navigation.PushAsync(new CustomPage("login", "password"));
            });
        }
    }
}