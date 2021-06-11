using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void AuthData(string password, string username, bool Bull)
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

                #region Перевірка данних
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
                #endregion
                // закриваємо конект
                connection.Close();

                // звільнюємо ресурси
                connection.Dispose();

                if (apass == true && auser == true) Bull = true;
            }

        }
    }
}
