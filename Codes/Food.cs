using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_AEATE.Codes
{
    class Food : Product
    {

        public string ExpirationDate { get; set; }

        public string Country { get; set; }

        public Food(float price, float weight, string name, string manufactures, int amount, string expdata, string country)
        {

            Price = price;
            Name = name;
            Weight = weight;
            Manufactures = manufactures;
            Amount = amount;
            ExpirationDate = expdata;
            Country = country;

        }

        public Food() { }


    }
}
