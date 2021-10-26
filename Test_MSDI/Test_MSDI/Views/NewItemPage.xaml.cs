using System;
using System.Collections.Generic;
using System.ComponentModel;
using Test_MSDI.Models;
using Test_MSDI.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test_MSDI.Views
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