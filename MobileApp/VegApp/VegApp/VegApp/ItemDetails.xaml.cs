using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VegApp.Classes;
using VegApp.Model;
using Xamarin.Forms;

namespace VegApp
{
    public partial class ItemDetails : ContentPage
    {
        public ItemDetails(SellingList item)
        {
            InitializeComponent();
            imgBanner.Source = Utility.ConvertToImage(item.ProductImage);
            lblProduct.Text = item.ProductName;
            lblPrice.Text = item.PriceText;
            lblNote.Text= item.Note;
        }
    }
}
