using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace xamarin.forms.cats
{
    public partial class App : Application
    {
        public App()
        {
            var content = new Views.CatsPage();

            MainPage = new NavigationPage(content);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
