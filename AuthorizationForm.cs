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
using Soft_AEATE.Codes;

namespace Soft_AEATE
{
    public partial class AuthorizationForm : Form
    {
        
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
            bool Bull = false;
            string pass, username;

            try
            {
                var user = new User();
                username = textBox1.Text;
                pass = textBox2.Text;
                user.AuthData(pass, username, Bull);
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

        

    }
}
