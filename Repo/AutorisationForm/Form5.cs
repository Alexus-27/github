using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace AutorisationForm
{
    public partial class Form5 : Form
    {
        SqlConnection sqlConnection;
        public Form5()
        {
            InitializeComponent();
        }

        private async void Form5_Load(object sender, EventArgs e)
        {
            string myConnectionString = @"Data Source=GLASS-OK\SQLEXPRESS;Initial Catalog=Logins_Passwords;Integrated Security=True"; // Подключение к БД
            sqlConnection = new SqlConnection(myConnectionString);

            await sqlConnection.OpenAsync();

            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM [Logins_Passwords].[dbo].[login_password]", sqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                while(await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["login"]) + " " + Convert.ToString(sqlReader["password"]));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(sqlReader != null)
                {
                    sqlReader.Close();
                }
            }
        }
        private async void buttonAddUser_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            Regex logincheck = new Regex(@"[A-Za-z][A-Za-z0-9]*@[a-z]+\.[A-Za-z]{2,6}");
            Regex passwordcheck = new Regex (@"^.{5,10}\d+[a-zA-Z]*[!@#$%^]+");

            if (logincheck.Match(login).Success && passwordcheck.Match(password).Success)
            {
                
                SqlCommand command = new SqlCommand("INSERT INTO [Logins_Passwords].[dbo].[login_password] (login, password)VALUES(@login, @password)", sqlConnection);

                command.Parameters.AddWithValue("login", textBoxLogin.Text);
                command.Parameters.AddWithValue("password", textBoxPassword.Text);

                await command.ExecuteNonQueryAsync();
            }
            else
            {
                MessageBox.Show("Введено неверное имя пользователя и пароль!");
            } 
        }

        private async void обноввитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM [Logins_Passwords].[dbo].[login_password]", sqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                while(await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["login"]) + " " + Convert.ToString(sqlReader["password"]));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(sqlReader != null)
                {
                    sqlReader.Close();
                }
            }

        }

        private void вГлавноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
