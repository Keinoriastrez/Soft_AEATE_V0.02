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
using MySql.Data.MySqlClient;


namespace Soft_AEATE
{
    public partial class MainForm : Form
    {
        public Employee employee = new();
        //List<Products> product = new();
        public MainForm()
        {
            InitializeComponent();
            //AuthorizationForm form = new();
            //form.ShowDialog();

        }

        //Food ananas = new(100, 300, "Ананас", "Selo", 1035, "2000.13.12", "Kavai");

        //Food shrek = new(2000, 1000, "Шрек", "Ниггерия", 1035, "2000.13.12", "Kavai");

        public void InitEmployeeData(Employee Chad)
        {
            // Create an unbound DataGridView by declaring a column count.
            dataGridView1.ColumnCount = 6;
            dataGridView1.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new()
            {
                BackColor = Color.Beige,
                Font = new Font("Verdana", 10, FontStyle.Bold)
            };
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Set the column header names.
            dataGridView1.Columns[0].Name = "Ім'я";
            dataGridView1.Columns[1].Name = "Адреса";
            dataGridView1.Columns[2].Name = "Возраст";
            dataGridView1.Columns[3].Name = "Гендер";
            dataGridView1.Columns[4].Name = "Досвід";
            dataGridView1.Columns[5].Name = "Зарплата";

            // Populate the rows.
            string[] row1 = new string[] { Chad.Name, Chad.Adress, Chad.Age.ToString(), Chad.Gender, Chad.Expereance.ToString(), Chad.Salary.ToString() };

            object[] rows = new object[] { row1 };

            foreach (string[] rowArray in rows)
            {
                dataGridView1.Rows.Add(rowArray);
            }
        }

        private void EmployeeStrip_Click(object sender, EventArgs e)
        {
            Employee Chad = new("Чад", "GrayBar12Street", 25, "Dancer", 15, 159, "Gay", 1591);

            //Employee Andrei = new("Andrii", "GrayBar12Street", 25, "Dancer", 15, 1591);

            InitEmployeeData(Chad);

            dataGridView1.Visible = true;

            employeeStrip.Visible = false;
        }

        private void Purchases_Click(object sender, EventArgs e)
        {
            var orderView = new ViewOrder();

            orderView.ShowDialog();

        }

        private void SalaryStrip_Click(object sender, EventArgs e)
        {

            var payFormView = new PayFormView();

            payFormView.ShowDialog();


        }

        private void Main_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Visible = false;
            employeeStrip.Visible = true;

        }

        private void Sales_Click(object sender, EventArgs e)
        {
            Food banana = new(50, 200, "Банан", "Ниггерия", 1035, "2000.13.12", "Kavai");

            Food ananas = new(100, 300, "Ананас", "Selor", 1035, "2000.13.12", "Pico");

            var products = new List<Products>() { banana };

            products[0].ProductData(products);

            products[0].InitProductData(products, dataGridView1);

        }

        private void Company_Click(object sender, EventArgs e)
        {



        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            AddRowForm f2 = new();
            f2.Owner = this;
            f2.ShowDialog();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

    }
}
