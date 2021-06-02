using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_AEATE.Codes
{
    public class Employee : User
    {
        public int Expereance { get; set; }

        public float Salary { get; set; }

        public Employee(string name, string adress, int age, string gender, int expereance, float salary)
        {


            Name = name;
            Adress = adress;
            Age = age;
            Gender = gender;
            Expereance = expereance;
            Salary = salary;


        }

        public Employee()
        {

        }

    }
}
