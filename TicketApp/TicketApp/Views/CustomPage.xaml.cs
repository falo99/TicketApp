using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TicketApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomPage : ContentPage
    {
        public CustomPage(string login, string password)
        {
            
            InitializeComponent();
            string pass = "";
            string log = "";
            log = login;
            pass = password;

        }

       
    }
}