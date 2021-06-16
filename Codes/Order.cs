using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_AEATE.Codes
{
    public class Order : IOrder
    {
        public string Client { get; set; }

        public string ID { get; set; }

        public string Responsible { get; set; }

        public string Date { get; set; }

        public string Depot { get; set; }

        public int Amount { get; set; }

        public string Name { get; set; }

        public float Price { get; set; }

        public Order(string id, int amount, float price, string client, string responsible, string name, string depot, string date)
        {

            ID = id;
            Amount = amount;
            Price = price;
            Client = client;
            Responsible = responsible;
            Name = name;
            Depot = depot;
            Date = date;

        }


        public double GetPrice()
        {
            double OrPrice;
            OrPrice = Price * Amount;
            return OrPrice;

        }

        public double Discount()
        {
            if (Amount > 120)
            {
                this.Price = Price / 2;
            }

            return Price;

        }

        public Order()
        {

        }

    }
}
