using System.ComponentModel;
using TicketApp.ViewModels;
using Xamarin.Forms;

namespace TicketApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}