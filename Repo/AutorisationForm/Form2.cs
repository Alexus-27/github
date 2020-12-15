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
    public partial class Form2 : Form
    {
        SqlConnection sqlConnection;
        public Form2()
        {
            InitializeComponent();
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            string connection = @"Data Source=GLASS-OK\SQLEXPRESS;Initial Catalog=Logins_Passwords;Integrated Security=True"; // Подключение к БД
            sqlConnection = new SqlConnection(connection);

            await sqlConnection.OpenAsync();
            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM [Logins_Passwords].[dbo].[spectacle_info]", sqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["id_spectacle"]) + "   " + Convert.ToString(sqlReader["name_spectacle"]) + "   " + Convert.ToString(sqlReader["about_spectacle"]) + "   " + Convert.ToString(sqlReader["amount_tickets"]));
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
            SqlCommand command = new SqlCommand("UPDATE [Logins_Passwords].[dbo].[spectacle_info] SET [amount_tickets] = @amount_tickets WHERE [id_spectacle] = @id_spectacle", sqlConnection);

            command.Parameters.AddWithValue("id_spectacle", textBoxIdSpec.Text);
            command.Parameters.AddWithValue("amount_tickets", textBoxTicketsSpec.Text);

            await command.ExecuteNonQueryAsync();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Form2 form2 = new Form2();
            form2.Close();
        }

        private async void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

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

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }
    }
}
