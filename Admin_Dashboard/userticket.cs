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
    public partial class userticket : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["AdminConnection"].ConnectionString;
        public userticket()
        {
            InitializeComponent();
        }

        private void buttonsubmit_Click(object sender, EventArgs e)
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            Console.WriteLine(DateTime.Today + "," + SqlDbType.DateTime);
            if (textBox1.Text != null)
            {
                try
                {
                    myConnect.Open();
                    
                    string strCommandText = "Insert TicketRequest (UserID, UserName, ticketdesc, status, SubmissionDate) VALUES (@UserID, @UserName, @ticketdesc, @progress, @submissiondate)";
                    SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
                    cmd.Parameters.AddWithValue("@UserID", UserDashboard.userid);
                    cmd.Parameters.AddWithValue("@UserName", UserDashboard.username);
                    cmd.Parameters.AddWithValue("@ticketdesc", textBox1.Text);
                    cmd.Parameters.AddWithValue("@progress", "In progress");
                    cmd.Parameters.AddWithValue("@submissiondate", DateTime.Today);
                    cmd.ExecuteNonQuery();
                    Forms.AdminDashboard admindash = new Forms.AdminDashboard();
                    admindash.UpdateTRData();
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

            else
            {
                MessageBox.Show("Please enter a problem");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserDashboard userdash = new UserDashboard();
            userdash.Show();
            this.Hide();
        }
    }
}
