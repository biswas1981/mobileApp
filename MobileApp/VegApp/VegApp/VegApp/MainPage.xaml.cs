using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using static VegApp.Classes.Utility;

namespace VegApp
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            IsBusy = false;
            var banners = new List<string>
            {
                "banner1.jpg",
                "banner2.jpg",
                "banner3.jpg",
                "banner4.jpg"
            };
            MainCarouselView.ItemsSource = banners;


            
            vegImage.GestureRecognizers.Add(new TapGestureRecognizer
            {
                TappedCallback = (v, o) =>
                {
                    ItemList.SearchContent = "";
                    App.NavigationMainPage.PushAsync(new ItemList(NutizaShopItem.Vegetable));
                    
                },
                NumberOfTapsRequired = 1
            });
            fruitsImage.GestureRecognizers.Add(new TapGestureRecognizer
            {
                TappedCallback = (v, o) =>
                {
                    ItemList.SearchContent = "";
                    App.NavigationMainPage.PushAsync(new ItemList(NutizaShopItem.Fruit));
                },
                NumberOfTapsRequired = 1
            });
            flowersImage.GestureRecognizers.Add(new TapGestureRecognizer
            {
                TappedCallback = (v, o) =>
                {
                    ItemList.SearchContent = "";
                    App.NavigationMainPage.PushAsync(new ItemList(NutizaShopItem.Flower));
                },
                NumberOfTapsRequired = 1
            });

        }
       
       
        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.Animate("main", s => Layout(new Rectangle(((-1 + s) * Width), Y, Width, Height)), 16, 250, Easing.SpringOut, null, null);
        }
    }
    
}
