using System.ComponentModel;
using Test_MSDI.ViewModels;
using Xamarin.Forms;

namespace Test_MSDI.Views
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