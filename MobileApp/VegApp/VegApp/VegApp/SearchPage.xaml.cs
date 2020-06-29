using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using static VegApp.Classes.Utility;

namespace VegApp
{
    public partial class SearchPage : ContentPage
    {
        public NutizaShopItem ItemName { get; set; }
        public SearchPage()
        {
            InitializeComponent();
        }
        void Search_OnSearchButtonPressed(object sender, EventArgs e)
        {
            ItemList.SearchContent = searchBar.Text;
            App.NavigationMainPage.PushAsync(new ItemList(ItemName));
        }
    }
}
