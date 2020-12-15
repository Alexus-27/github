using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace AutorisationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textPassword.PasswordChar = '*'; //Пароль в виде звездочек
        }

        

        static bool MaskedLoginCheck(string login)
        {
            string check_login = login;
            Regex logincheck = new Regex(@"[A-Za-z][A-Za-z0-9]*@[a-z]+\.[A-Za-z]{2,6}");
            if (logincheck.IsMatch(check_login))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool MaskedPasswordCheck(string password)
        {
            string check_password = password;
            Regex passwordcheck = new Regex("^[A-Za-z]([0-9]+[A-Za-z][@$!%*#?&]+){5,}$");
            if (passwordcheck.IsMatch(check_password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string login_name = textLogin.Text;
            string password_string = textPassword.Text;

            string adminlogin = "Admin@mail.ru";
            string adminpass = "admin1209";


            string myConnectionString = @"Data Source=GLASS-OK\SQLEXPRESS;Initial Catalog=Logins_Passwords;Integrated Security=True"; // Подключение к БД
            string myQuerystring = "SELECT [login] FROM [Logins_Passwords].[dbo].[login_password] WHERE [login] = '" + login_name + "'and [password]='" + password_string + "'"; // Обращение к экземпляру таблицы

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(myQuerystring, myConnectionString))
            {
                DataTable table = new DataTable(); // представление таблицы в виде переменной table
                dataAdapter.Fill(table);

                if (login_name == adminlogin && password_string == adminpass)
                {
                    Form4 form4 = new Form4(); //форма для админа
                    form4.Show();

                }
                else if (table.Rows.Count != 0) //т.е. если нашел совпадающего по логину и паролю в Table будет больше 0 строк
                {
                    Form2 form2 = new Form2(); //Форма для кассира
                    form2.Show();
                }
                else //т.е. если не нашел совпадающего по логину и паролю в Table будет 0 строк
                {
                    MessageBox.Show("Возможно вы незарегестрированный пользователь. Попробуйте зарегестрироваться?");
                }
            }
        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}
