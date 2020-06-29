using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace VegApp.Classes
{
    public class Utility
    {

        public static Image ImageFromBase64(string base64picture)
        {
            byte[] imageBytes = Convert.FromBase64String(base64picture);
            return new Image { Source = ImageSource.FromStream(() => new MemoryStream(imageBytes)) };
        }

        public static ImageSource ConvertToImage(object value)
        {
            string base64Image = (string)value;

            if (base64Image == null)
                return null;

            // Convert base64Image from string to byte-array
            var imageBytes = System.Convert.FromBase64String(base64Image);

            // Return a new ImageSource
            return ImageSource.FromStream(() => { return new MemoryStream(imageBytes); });
        }

        public enum NutizaShopItem
        {
            Vegetable = 0,
            Fruit=1,
            Flower=2
        }

    }






    public class ConverterBase64ImageSource : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string base64Image = (string)value;

            if (base64Image == null)
                return null;

            // Convert base64Image from string to byte-array
            var imageBytes = System.Convert.FromBase64String(base64Image);

            // Return a new ImageSource
            return ImageSource.FromStream(() => { return new MemoryStream(imageBytes); });
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Not implemented as we do not convert back
            throw new NotSupportedException();
        }
    }
}
