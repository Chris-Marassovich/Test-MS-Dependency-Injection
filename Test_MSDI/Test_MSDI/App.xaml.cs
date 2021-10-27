using System;
using Xamarin.Forms;

namespace Test_MSDI
{
    public partial class App : Application
    {
        /// <summary>
        /// My DI container.
        /// </summary>
        public static IServiceProvider ServiceProvider { get; set; }

        public App()
        {
            InitializeComponent();

            //Init the DI or do it from the Platform Init.
            //Startup.Init(null);

            //DependencyService.Register<MockDataStore>();
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
