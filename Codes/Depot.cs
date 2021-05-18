using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_AEATE.Codes
{
    public class Depot
    {
        private int Number { get; set; }

        private string Name { get; set; }

        private string Responsible { get; set; }

        public int GetNumber()
        {
            return Number;
        }

        public int SetNumber(int num)
        {
            this.Number = num;
            return Number;
        }
    }
}
