using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Datarynx.Services;
using Datarynx.Views;

namespace Datarynx
{
    public partial class App : Application
    {
        public NavigationPage NavigationPage { get; private set; }
        public App()
        {
            InitializeComponent();

            var menuPage = new MenuPage();
            NavigationPage = new NavigationPage(new ItemsPage());
            var rootPage = new MainPage();
            rootPage.Master = menuPage;
            rootPage.Detail = NavigationPage;
            MainPage = rootPage;

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
