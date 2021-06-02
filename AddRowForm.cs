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
    public partial class AddRowForm : Form
    {


        public AddRowForm()
        {
            InitializeComponent();

            label1.Text = "Ім'я";
            label2.Text = "Адреса";
            label3.Text = "Возраст";
            label4.Text = "Гендер";
            label5.Text = "Досвід";
            label6.Text = "Зарплата";
            label7.Text = "Робочі";

            addRowBut.Text = "Finish";

        }

        private void AddRowBut_Click(object sender, EventArgs e)
        {
            MainForm main = this.Owner as MainForm;
            Employee employer = new();

            employer.Name = textBox1.Text;
            employer.Adress = textBox2.Text;
            employer.Age = Convert.ToInt32(textBox3.Text);
            employer.Gender = textBox4.Text;
            employer.Expereance = Convert.ToInt32(textBox5.Text);
            employer.Salary = Convert.ToInt32(textBox6.Text);

            main.InitEmployeeData(employer);

            Close();

        }
    }
}
