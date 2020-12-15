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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void spectacle_infoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.spectacle_infoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.logins_PasswordsDataSet1);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "logins_PasswordsDataSet1.spectacle_info". При необходимости она может быть перемещена или удалена.
            this.spectacle_infoTableAdapter.Fill(this.logins_PasswordsDataSet1.spectacle_info);

        }

        private void add_spectacle_Click(object sender, EventArgs e)
        {
            string myConnectionString = @"Data Source=GLASS-OK\SQLEXPRESS;Initial Catalog=Logins_Passwords;Integrated Security=True"; // Подключение к БД
            SqlConnection sqlConnection = new SqlConnection();

            SqlCommand command = new SqlCommand("INSERT INTO [spectacle_info] (id_spectacle, name_spectacle, about_spectacle, amount_tickets) VALUES(@id_spectacle, @name_spectacle, @about_spectacle, @amount_tickets)", sqlConnection);
            command.Parameters.AddWithValue("id_spectacle", textIdSpec.Text);

            command.Parameters.AddWithValue("name_spectacle", textNameSpec.Text);

            command.Parameters.AddWithValue("about_spectacle", textAboutSpec.Text);

            command.Parameters.AddWithValue("amount_tickets", textTicketsSpec.Text);



            //await command.ExecuteNonQueryAsync();
        }
    }
}
