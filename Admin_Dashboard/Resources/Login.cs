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
using System.Configuration;

namespace Admin_Dashboard
{
    public partial class LoginForm : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["AdminConnection"].ConnectionString;
        private static int? userid;
        public static int? Userid
        {
            get { return userid; }
            set { userid = value; }
        }
        
        public LoginForm()
        {
            InitializeComponent();
        }



        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            string strCommandText = "SELECT Name, ID, Password FROM Admin WHERE Name=@uname AND Password = @pwd";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            cmd.Parameters.AddWithValue("@uname", tbusername.Text);
            cmd.Parameters.AddWithValue("@pwd", tbpassword.Text);

            try
            {
                myConnect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    userid = Convert.ToInt32(reader["ID"]);
                    Dashboard admin = new Dashboard();
                    admin.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Wrong password or username");
                }

                reader.Close();
                    
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
