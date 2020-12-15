using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutorisationForm
{
    public partial class Form6 : Form
    {
        SqlConnection sqlConnection; 
        public Form6()
        {
            InitializeComponent();
        }

        private async void Form6_Load(object sender, EventArgs e)
        {
            string myconnection = @"Data Source=GLASS-OK\SQLEXPRESS;Initial Catalog=Logins_Passwords;Integrated Security=True";
            sqlConnection = new SqlConnection(myconnection);

            await sqlConnection.OpenAsync();

            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM [Logins_Passwords].[dbo].[View_Report]", sqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                while(await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["name_spectacle"] + "  " + Convert.ToString(sqlReader["about_spectacle"] + "   " + Convert.ToString(sqlReader["amount_tickets"]))));
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
    }
}
