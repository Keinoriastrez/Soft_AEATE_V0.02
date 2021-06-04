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
            authButt.Text = "Ввести";
        }

       

        private void AuthButt_Click(object sender, EventArgs e)
        {

            string pass, username;
            try
            {
                username = textBox1.Text;
                pass = textBox2.Text;
                AuthData(pass, username);
            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString(), "Перевірте правильність вказанних даних", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (Bull == true)
            {
                Close();
            }

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

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Помилка підключення до БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                string sql = "SELECT * FROM user_auth WHERE Password = '" + password + "' ";
                string sql2 = "SELECT * FROM user_auth WHERE Login = '" + username + "' ";

                var command = new MySqlCommand(sql, connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader["Password"] is not null)
                        {
                            if (password == reader["Password"].ToString()) apass = true;
                            else apass = false;
                        }

                    }


                }


                command = new MySqlCommand(sql2, connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader["Login"] is not null)
                        {
                            if (username == reader["Login"].ToString()) auser = true;
                            else auser = false;
                        }

                    }


                }

                // закриваємо конект
                connection.Close();

                // звільнюємо ресурси
                connection.Dispose();

                if (apass == true && auser == true) Bull = true;
            }

        }

    }
}
