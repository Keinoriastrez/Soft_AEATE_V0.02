using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_AEATE.Codes
{
    public class Order : IOrder
    {
        public int Amount { get; set; }

        public string Name { get; }

        public int Price { get; set; }

        public string Address { get; }

        public double GetPrice()
        {
            double OrPrice;
            OrPrice = Price * Amount;
            return OrPrice;

        }
        public void Discount()
        {
            if (Amount > 120)
            {
               this.Price = Price / 2;
            }
        }


    }
}
