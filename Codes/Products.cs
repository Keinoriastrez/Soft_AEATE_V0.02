using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_AEATE.Codes
{
     public class Products
     {
        public string ID { get; set; }

        public int Amount { get; set; }

        public float Price { get; set; }

        public float Weight { get; set; }

        public string Name { get; set; }

        public string Manufactures { get; set; }

        public Products(string id, int amount, float price, float weight, string name, string manufactures)
        {
            
            ID = id;
            Price = price;
            Name = name;
            Weight = weight;
            Manufactures = manufactures;
            Amount = amount;

        }

        public Products() { }

        public void InitProductData(List<Products> product, DataGridView dataGridView1)
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
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Назва";
            dataGridView1.Columns[2].Name = "Ціна";
            dataGridView1.Columns[3].Name = "Вага";
            dataGridView1.Columns[4].Name = "Кількість";
            dataGridView1.Columns[5].Name = "Виробник";

            product.ForEach(x => dataGridView1.Rows.Add(x.ID, x.Name, x.Price.ToString(), x.Weight.ToString(), x.Amount.ToString(), x.Manufactures));

            dataGridView1.Visible = true;
        }

    }
}   
