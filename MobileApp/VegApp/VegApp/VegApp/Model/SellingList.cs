using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegApp.Model
{
    public class SellingList
    {
        public int ProductId { get; set; }

        public int CategoryId { get; set; }
        public string ProductImage { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string UnitName { get; set; }
        public string Note { get; set; }

        public string PriceText => string.Format("Rs. {0} / {1}", Price.ToString("0.00"), UnitName);
    }
}
