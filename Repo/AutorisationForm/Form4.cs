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

namespace AutorisationForm
{
    public partial class Form4 : Form
    {
        SqlConnection sqlConnection;
        public Form4()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Form4 form4 = new Form4();
            form4.Close();
        }

        private async void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "logins_PasswordsDataSet2.spectacle_info". При необходимости она может быть перемещена или удалена.
            this.spectacle_infoTableAdapter.Fill(this.logins_PasswordsDataSet2.spectacle_info);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "logins_PasswordsDataSet2.login_password". При необходимости она может быть перемещена или удалена.
            this.login_passwordTableAdapter.Fill(this.logins_PasswordsDataSet2.login_password);
            string myConnectionString = @"Data Source=GLASS-OK\SQLEXPRESS;Initial Catalog=Logins_Passwords;Integrated Security=True"; // Подключение к БД
            sqlConnection = new SqlConnection(myConnectionString);

            await sqlConnection.OpenAsync();

            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM [Logins_Passwords].[dbo].[spectacle_info]", sqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["id_spectacle"]) + "  " + Convert.ToString(sqlReader["name_spectacle"]) + "   " + Convert.ToString(sqlReader["about_spectacle"]) + "  " + Convert.ToString(sqlReader["amount_tickets"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        private async void buttonAddInfo_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Logins_Passwords].[dbo].[spectacle_info] (id_spectacle, name_spectacle, about_spectacle, amount_tickets) VALUES(@id_spectacle, @name_spectacle, @about_spectacle, @amount_tickets)", sqlConnection);

            command.Parameters.AddWithValue("id_spectacle", textIdSpecAdd.Text);
            command.Parameters.AddWithValue("name_spectacle", textNameSpecAdd.Text);
            command.Parameters.AddWithValue("about_spectacle", textAboutSpecAdd.Text);
            command.Parameters.AddWithValue("amount_tickets", textTicketsAdd.Text);

            await command.ExecuteNonQueryAsync();
        }

        private async void обновитьСтраницуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM [Logins_Passwords].[dbo].[spectacle_info]", sqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                while(await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["id_spectacle"]) + "  " + Convert.ToString(sqlReader["name_spectacle"]) + "   " + Convert.ToString(sqlReader["about_spectacle"]) + "  " + Convert.ToString(sqlReader["amount_tickets"]));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("UPDATE [Logins_Passwords].[dbo].[spectacle_info] SET [name_spectacle] = @name_spectacle, [about_spectacle] = @about_spectacle, [amount_tickets] = @amount_tickets WHERE [id_spectacle] = @id_spectacle", sqlConnection);

            command.Parameters.AddWithValue("id_spectacle", textBoxIdSpecUp.Text);
            command.Parameters.AddWithValue("name_spectacle", textBoxNameSpecUp.Text);
            command.Parameters.AddWithValue("about_spectacle", textBoxAboutSpecUp.Text);
            command.Parameters.AddWithValue("amount_tickets", textBoxTicketsUp.Text);

            await command.ExecuteNonQueryAsync();
        }

        private async void buttonDel_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [Logins_Passwords].[dbo].[spectacle_info] WHERE [id_spectacle] = @id_spectacle", sqlConnection);

            command.Parameters.AddWithValue("id_spectacle", textBoxIdSpecDel.Text);

            await command.ExecuteNonQueryAsync();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }
    }
}
