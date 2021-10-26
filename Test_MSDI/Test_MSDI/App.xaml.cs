using System;
using Test_MSDI.Services;
using Test_MSDI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test_MSDI
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
