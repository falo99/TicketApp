using System;
using System.Collections.Generic;
using System.ComponentModel;
using TicketApp.Models;
using TicketApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TicketApp.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}