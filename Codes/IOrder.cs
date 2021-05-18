using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_AEATE.Codes
{
    interface IOrder
    {
        int Amount { get; set; }

        string Name { get; }

        int Price { get; set; }

        string Address { get; }

        double GetPrice();

        void Discount();


    }
}
