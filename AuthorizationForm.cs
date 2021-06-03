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



        private void AuthButt_Click(object sender, EventArgs e)
        {

            bool pass, username;
            try
            {
                if (textBox1.Text == "Admin") username = true;
                else username = false;
                if (textBox2.Text == "1111") pass = true;
                else pass = false;
                if (username == true && pass == true) Bull = true;
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
