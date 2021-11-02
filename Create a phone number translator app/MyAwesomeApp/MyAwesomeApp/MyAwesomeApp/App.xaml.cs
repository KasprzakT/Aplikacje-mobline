using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyAwesomeApp
{
    public partial class App : Application
    {
        public App()
        {
            MainPage = new Page1();
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
