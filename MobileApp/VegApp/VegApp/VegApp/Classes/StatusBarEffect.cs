using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace VegApp.Classes
{
    public class StatusBarEffect : RoutingEffect
    {
        private static Color BackgroundColor;
        public static void SetBackgroundColor(Color color)
        {
            BackgroundColor = color;
        }
        public static Color GetBackgroundColor()
        {
            return BackgroundColor;
        }

        public StatusBarEffect() : base("Xamarin.StatusBarEffect")
        { }
    }
}
