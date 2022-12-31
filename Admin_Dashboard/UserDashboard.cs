using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Admin_Dashboard
{
    public partial class UserDashboard : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["AdminConnection"].ConnectionString;
        public static string username;
        public static int userid;
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void buttonstr_Click(object sender, EventArgs e)
        {
            getuserdetails();
            userticket ticketrequest = new userticket();
            ticketrequest.Show();
            this.Hide();
        }

        public void getuserdetails()
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            string strCommandText = "Select Name, ID From [User] Where ID=@userID";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            cmd.Parameters.AddWithValue("@UserID", LoginForm.Userid);
            try
            {
                myConnect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    username = reader["Name"].ToString();
                    userid = Convert.ToInt32(reader["ID"]);
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message.ToString());
            }

            finally
            {
                myConnect.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginpage = new LoginForm();
            LoginForm.Userid = null;
            loginpage.Show();
            this.Hide();
        }
    }
}
