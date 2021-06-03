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
            //  AuthorizationForm form = new();
            // form.ShowDialog();

        }

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
            Employee Chad = new("Чад", "GayBar12Street", 25, "Dancer", 15, 1591);

            Employee Andrei = new("Andrii", "GayBar12Street", 25, "Dancer", 15, 1591);

            InitEmployeeData(Chad);

            InitEmployeeData(Andrei);

            dataGridView1.Visible = true;

            employeeStrip.Visible = false;
        }


        private void ClearButt_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Visible = false;
            employeeStrip.Visible = true;
        }

        private void Purchases_Click(object sender, EventArgs e)
        {
            var prod = new Products();

            Food ananas = new(100, 300, "Ананас", "Selo", 1035, "2000.13.12", "Kavai");
            Food banana = new(50, 200, "Банан", "Ниггерия", 1035, "2000.13.12", "Kavai");
            Food shrek = new(2000, 1000, "Шрек", "Ниггерия", 1035, "2000.13.12", "Kavai");

            List<Products> products = new() { banana, ananas, shrek };

            ProductData(products);

            prod.InitProductData(products, dataGridView1);
        }

        private void Main_Click(object sender, EventArgs e)
        {



        }

        private void Sales_Click(object sender, EventArgs e)
        {



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


        string connString = "server=localhost;user=root;database=aethe;password=1111;";

        public void ProductData(List<Products> product)
        {
            

            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                try
                {
                    connection.Open();

                    string sql = "SELECT * FROM product";
                    var command = new MySqlCommand(sql, connection);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            product.Add(new Products(Convert.ToString(reader["ID"]), Convert.ToInt32(reader["Amount"]),
                            Convert.ToSingle(reader["Price"]), Convert.ToSingle(reader["Weight"]), Convert.ToString(reader["Name"]),
                            Convert.ToString(reader["Manufactures"])));

                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Помилка підключення до БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                // закриваємо конект
                connection.Close();
                // звільнюємо ресурси
                connection.Dispose();

            }

        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
