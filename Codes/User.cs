using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_AEATE.Codes
{
    public class User
    {

        public string Adress { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public User(string name, string adress, int age, string gender)
        {


            Name = name;
            Adress = adress;
            Age = age;
            Gender = gender;


        }

        public User()
        {



        }
    }
}
