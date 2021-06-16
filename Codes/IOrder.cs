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

        float Price { get; set; }

        double GetPrice();

        double Discount();


    }
}
