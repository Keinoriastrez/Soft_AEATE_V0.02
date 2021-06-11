using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soft_AEATE.Codes;

namespace Soft_AEATE
{
    public partial class PayFormView : Form
    {
        static Employee Chad = new("Чад", "GrayBar12Street", 25, "Dancer", 15, 159, "Gay", 1591);
        static Employee Andrei = new("Андрей", "GrayBar12Street", 25, "Dancer", 15, 159, "Танцор", 3500);

        public PayFormView()
        {
            InitializeComponent();



            comboBox1.Items.Add(Chad.Name);
            comboBox1.Items.Add(Andrei.Name);

        }

        private void PayButt_Click(object sender, EventArgs e)
        {
            List<Employee> employee = new List<Employee>() { Chad, Andrei };

            

            for (int i = 0; i < employee.Count; i++)
            {

                if (comboBox1.Text == employee[i].Name)
                {
                    employee[i].WorkTime = Convert.ToInt32(textBox1.Text);

                    labelFPay.Text = "Виплата = " + Math.Round(employee[i].CulcPay(employee[i])).ToString() + " грн. ";

                    label1.Text = "Посада робітника: " + employee[i].Position;

                    label2.Text = "Досвід робітника: " + employee[i].Expereance + " років ";

                    label3.Text = "Зарплата робітника: " + employee[i].Salary;

                }
            }

        }

    }
}
