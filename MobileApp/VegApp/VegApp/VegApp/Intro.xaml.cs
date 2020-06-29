using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VegApp.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VegApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Intro : ContentPage
    {
      
        public Intro()
        {
            InitializeComponent();
            var forgetPassword_tap = new TapGestureRecognizer();
            forgetPassword_tap.Tapped += (s, e) =>
            {
                App.NavigationMainPage.Navigation.PushAsync(new MainPage());
                App.MenuIsPresented = false;
            };
            skipLabel.GestureRecognizers.Add(forgetPassword_tap);
        }
        

    }
}
