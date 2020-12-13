using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shop_app
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Application.Current.UserAppTheme = OSAppTheme.Light;
            MainPage = new MainPage();
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
