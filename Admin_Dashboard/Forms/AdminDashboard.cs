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

namespace Admin_Dashboard.Forms
{
    public partial class AdminDashboard : Form
    {
        public static string ticketrequestcount;
        private string strConnectionString = ConfigurationManager.ConnectionStrings["AdminConnection"].ConnectionString;

        public AdminDashboard()
        {
            InitializeComponent();
        }

        public void UpdateTRData()
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            myConnect.Open();
            string strCommandText = "SELECT Count(*) FROM TicketRequest";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            int ticketrequestcount = (int)cmd.ExecuteScalar();
            tr.Text = ticketrequestcount.ToString();
            myConnect.Close();
        }

        public void UpdateTCdata()
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            myConnect.Open();
            string strCommandText = "SELECT Count(*) FROM [User]";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            int Usercount = (int)cmd.ExecuteScalar();
            tc.Text = Usercount.ToString();
            myConnect.Close();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            UpdateTRData();
            UpdateTCdata();
        }
    }
}
