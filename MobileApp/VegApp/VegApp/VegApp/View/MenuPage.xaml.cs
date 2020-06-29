﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using VegApp.ViewModel;

namespace VegApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        
        public MenuPage()
        {
            BindingContext = new MenuPageViewModel();
            Title = "Menu";
            InitializeComponent();
        }
    }
}
