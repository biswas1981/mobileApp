using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace VegApp.ViewModel
{
    class MenuPageViewModel
    {
        public ICommand GoHomeCommand { get; set; }
        public ICommand GoSecondCommand { get; set; }
        public ICommand GoThirdCommand { get; set; }
        public MenuPageViewModel()
        {
            GoHomeCommand = new Command(GoHome);
            GoSecondCommand = new Command(GoSecond);
            //GoThirdCommand = new Command(GoThird);
        }

        void GoHome(object obj)
        {
            App.NavigationMainPage.Navigation.PopToRootAsync();
            App.MenuIsPresented = false;
        }

        void GoSecond(object obj)
        {
            App.NavigationMainPage.Navigation.PushAsync(new MainPage());
            App.MenuIsPresented = false;
        }

        //void GoThird(object obj)
        //{
        //    App.NavigationPage.Navigation.PushAsync(new ClinicInformation());
        //    App.MenuIsPresented = false;
        //}
    }
}
