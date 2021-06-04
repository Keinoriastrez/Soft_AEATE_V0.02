using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Soft_AEATE
{
    public partial class AuthorizationForm : Form
    {
        bool Bull = false;
        public AuthorizationForm()
        {
            InitializeComponent();
            label1.Text = "Авторизація";
            label2.Text = "Ім'я користувача";
            label3.Text = "Пароль";
        }

        public void AuthData(string password, string username)
        {
            string connString = "server=localhost;user=root;database=aethe;password=root;";

            bool apass = false, auser = false;

            using (var connection = new MySqlConnection(connString))
            {
                try
                {
                    connection.Open();
                   
                    string sql = "SELECT 1 FROM auth WHERE unique_key =" + password;
                    string sql2 = "SELECT 1 FROM auth WHERE unique_key =" + username;

                    var command = new MySqlCommand(sql, connection);
                    
                    using (var reader = command.ExecuteReader())
                    {

                        if (password == reader["password"].ToString()) apass = true;
                        else apass = false;
                        
                    }
                    

                    command = new MySqlCommand(sql2, connection);
                    using (var reader = command.ExecuteReader())
                    {

                        if (username == reader["username"].ToString()) auser = true;
                        else auser = false;


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

                if (apass == true && auser == true) Bull = true; 
            }

        }

        private void AuthButt_Click(object sender, EventArgs e)
        {

            string pass, username;
            try
            {
                username = textBox1.Text;
                pass = textBox2.Text;
                AuthData(pass, username);
                //if (textBox1.Text == "Admin") username = true;
                //else username = false;
                //if (textBox2.Text == "1111") pass = true;
                //else pass = false;
                //if (username == true && pass == true) Bull = true;
            }
            catch (Exception error)
            {

                MessageBox.Show("Перевірте правильність вказанних даних", error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (Bull == true)
            {
                Close();
            }
            
        }
    }
}
