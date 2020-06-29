using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VegApp.View;
using Xamarin.Forms;

namespace VegApp
{
    public partial class App : Application
    {
        public static NavigationPage NavigationMainPage { get; private set; }
        private static RootPage RootPage;

        public static bool MenuIsPresented
        {
            get
            {
                return RootPage.IsPresented;
            }
            set
            {
                RootPage.IsPresented = value;
            }
        }


        public App()
        {
            InitializeComponent();

            CallMain();
            //MainPage = new VegApp.Splash();
           
            
        }

        public void CallMain()
        {
            //Hambarger Menu
            var menuPage = new VegApp.View.MenuPage();
            NavigationMainPage = new NavigationPage(new MainPage());
            NavigationMainPage.BarBackgroundColor = Color.FromHex("#80B845");
            NavigationMainPage.BarTextColor = Color.White;
            NavigationMainPage.Title = "Nutiza";
            
            RootPage = new RootPage();
            RootPage.Master = menuPage;
            RootPage.Detail = NavigationMainPage;
            MainPage = RootPage;
           
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
