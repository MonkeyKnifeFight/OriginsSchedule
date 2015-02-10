using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.WindowsAzure.MobileServices;
using OriginsSchedule.Views;
using Xamarin.Forms;

namespace OriginsSchedule
{
    public class App : Application
    {
        public const string applicationURL = @"https://chew.azure-mobile.net/";
        public const string applicationKey = @"DyiWWRlfXvVXLbNVMZTCpEXGrJJQxs29";
        public static MobileServiceClient client = new MobileServiceClient(applicationURL, applicationKey);

        public App()
        {
            // The root page of your application

            //        var tabbedPage = new TabbedFirstPage();
            //        MainPage = new NavigationPage(tabbedPage);
            var mainPage = new EventsView();
            MainPage = new NavigationPage(mainPage);
        }

        public static Page GetMainPage()
        {
            var mainPage = new EventsView();
            return new NavigationPage(mainPage);
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
