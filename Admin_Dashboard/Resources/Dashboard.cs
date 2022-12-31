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
using System.Drawing.Drawing2D;
using System.IO;

namespace Admin_Dashboard
{

    public partial class Dashboard : Form
    {
        private Button currentButton;
        private Form activeForm;
        private string strConnectionString = ConfigurationManager.ConnectionStrings["AdminConnection"].ConnectionString;
        public static Dashboard instance;
        public Label displayname;
        public ComboBox namedropdown;
        public PictureBox pp;
        public Dashboard()
        {
            InitializeComponent();
            instance = this;
            displayname = username;
            namedropdown = comboBoxdropdown;
            pp = ovalPictureBoxpp;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
          
            buttondashboard.PerformClick();
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            string strCommandText = "SELECT Name, Profilepic FROM Admin WHERE ID=@UserID";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            cmd.Parameters.AddWithValue("@UserID", LoginForm.Userid);
            try
            {
                myConnect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    username.Text = reader["Name"].ToString();
                    comboBoxdropdown.Text = reader["Name"].ToString();
                    if (! DBNull.Value.Equals(reader["Profilepic"]))
                    {
                        reader.Close();
                        byte[] getImg = new byte[0];
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            getImg = (byte[])dr["Profilepic"];
                        }

                        byte[] imgData = getImg;
                        MemoryStream stream = new MemoryStream(imgData);
                        ovalPictureBoxpp.Image = Image.FromStream(stream);
                    }
                   
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

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.ForeColor = Color.White;
                    
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelnavbar.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.ForeColor = Color.Gainsboro;
                    
                }
            }
        }

        private void buttondashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AdminDashboard(), sender);
        }

        private void buttonprofile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Profile(), sender);
        }



        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();       
        }

      

        private void comboBoxdropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxdropdown.SelectedItem.ToString() == "logout")
            {
                LoginForm loginpage = new LoginForm();
                LoginForm.Userid = null;
                loginpage.Show();
                this.Hide();

            }
           
        }

        public void refresh()
        {
            comboBoxdropdown.Refresh();
            username.Refresh();
        }






    }


    class OvalPictureBox : PictureBox
    {
        public OvalPictureBox()
        {
            this.BackColor = Color.DarkGray;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            using (var gp = new GraphicsPath())
            {
                gp.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));
                this.Region = new Region(gp);
            }
        }
    }








}
