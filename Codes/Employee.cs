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

        public int WorkTime { get; set; }

        public string Position { get; set; }

        public double Salary { get; set; }

        public double Pay {get; set; }


        public Employee(string name, string adress, int age, string gender, int expereance, int workTime, string position, double salary)
        {


            Name = name;
            Adress = adress;
            Age = age;
            Gender = gender;
            Expereance = expereance;
            Salary = salary;
            WorkTime = workTime;
            Position = position;

        }

        public Employee()
        {

        }

        public double CulcPay(Employee employee)
        {
            double WorkedTime;

            double Salary;

            // Визначаємо коефіцієнт відробленого часу відносно стандартного

            WorkedTime = employee.WorkTime / 176;

            //Начисляємо премію, надбавки за понаднормові та зменьшуємо виплати за недоробіток

            switch (WorkedTime)
            {
                case 1:
                    Salary = employee.Salary * 1.3;
                    break;

                case > 1:
                    Salary = employee.Salary * 1.3 + (employee.WorkTime - 176) * (employee.Salary / 176 ) * 1.5;
                    break;

                case < 1:
                    Salary = employee.Salary - (176 - employee.WorkTime) * (employee.Salary / 176);
                    break;

                default:
                    Salary = employee.Salary;
                    break;
            }

            //Визначаємо результуючу виплату з урахунком ВС, ЄСВ                   (Salary * 0.22) НДС

            employee.Pay = Salary - ((Salary * 0.18) + (Salary * 0.015)) ;
            
    
            return employee.Pay;
        }
    }
}