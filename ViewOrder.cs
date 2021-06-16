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
    public partial class ViewOrder : Form
    {
        public ViewOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var order = new Order();

            Food banana = new(50, 200, "Банан", "Ниггерия", 1035, "2000.13.12", "Kavai");

            Food ananas = new(100, 300, "Ананас", "Selor", 1035, "2000.13.12", "Pico");

            var products = new List<Products>() { banana, ananas };

            //products[0].ProductData(products);

            try
            {
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].Name == textBox1.Text)
                    {
                        order.ID = products[i].ID;
                        order.Name = textBox1.Text;
                        order.Amount = Convert.ToInt32(textBox2.Text);
                        order.Price = products[i].Price;
                        order.Responsible = textBox3.Text;

                    }
                    else if (i == (products.Count - 1))
                    {
                        label7.Text = "Товар не існує";
                        textBox1.Text = " ";
                        textBox2.Text = " ";
                        textBox3.Text = " ";

                    }

                }
            }
            catch (Exception error)
            {

                MessageBox.Show("Дані введено не корректно " + error, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            order.GetPrice();

            label7.Text = "Ціна = " + order.Discount();

        }

    }
}
