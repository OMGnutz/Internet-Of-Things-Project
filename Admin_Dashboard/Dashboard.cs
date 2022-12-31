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
            notiexpire();
            buttondashboard.PerformClick();
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            string strCommandText = "SELECT Name, Profilepic , NewNoti FROM Admin WHERE ID=@UserID";
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
                    labelnoti.Text = reader["NewNoti"].ToString();
                    if (labelnoti.Text == "0")
                    {
                        labelnoti.Hide();
                    }
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

        private void buttonTR_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.TRManagement(), sender);
        }

        private void buttonAA_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AccountAuthorisation(), sender);
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

        private void buttonnoti_Click(object sender, EventArgs e)
        {
            notificationmenu.Items.Clear();
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            string selectadminnoti = "SELECT * From Notifications Where UserId=@ID ORDER BY CASE WHEN NotiRead = 'false' THEN 1 ELSE 2 END , CreationDate DESC";
            string newnoti = "UPDATE Admin SET NewNoti=@num Where ID=@userid";
            SqlCommand cmdnewnoti = new SqlCommand(newnoti, myConnect);
            cmdnewnoti.Parameters.AddWithValue("@userid", LoginForm.Userid);
            cmdnewnoti.Parameters.AddWithValue("@num", 0);
            SqlCommand cmd = new SqlCommand(selectadminnoti, myConnect);
            cmd.Parameters.AddWithValue("@ID", LoginForm.Userid);
            try
            {
                myConnect.Open();
                cmdnewnoti.ExecuteNonQuery();
                labelnoti.Hide();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == false)
                {
                    notificationmenu.Items.Add("You have currently no new notifications");
                }

                reader.Close();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    notificationmenu.Items.Add(reader["Description"].ToString());
                    foreach (ToolStripItem contextMenuItem in notificationmenu.Items)
                    {
                        if (contextMenuItem.Text == reader["Description"].ToString() && Convert.ToBoolean(reader["NotiRead"]) == false)
                        {
                            contextMenuItem.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("notidot");
                            contextMenuItem.ImageScaling = ToolStripItemImageScaling.None;
                            
                        }
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


            notificationmenu.Show(buttonnoti, new Point(0, buttonnoti.Height));
            notificationmenu.AutoSize = true;
            notificationmenu.MaximumSize = new Size(260, 100); 
            
            foreach (ToolStripItem item in notificationmenu.Items)
            {
                item.MouseHover += new EventHandler(notihover);
                                                
            }
            Point screenPoint = buttonnoti.PointToScreen(new Point(buttonnoti.Left, buttonnoti.Bottom));
            if (screenPoint.Y + notificationmenu.Size.Height > Screen.PrimaryScreen.WorkingArea.Height)
            {
                notificationmenu.Show(buttonnoti, new Point(0, -notificationmenu.Size.Height));
            }
            else
            {
                notificationmenu.Show(buttonnoti, new Point(0, buttonnoti.Height));
            }

        }

      


        private void notihover(object sender , EventArgs e)
        {
            var itemhovered = sender as ToolStripItem;
            itemhovered.Image = null;
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            try
            {
                myConnect.Open();
                string selectnoti = "UPDATE Notifications SET NotiRead = @Read WHERE Description=@desc AND UserId=@userid";
                SqlCommand cmd = new SqlCommand(selectnoti, myConnect);
                cmd.Parameters.AddWithValue("@Read", true);
                cmd.Parameters.AddWithValue("@desc", itemhovered.Text);
                cmd.Parameters.AddWithValue("userid", LoginForm.Userid);
                cmd.ExecuteNonQuery();
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

        public void Send_notification(int? userid , string notification)
        {
            int[] adminarray;
            SqlConnection myConnect = new SqlConnection(strConnectionString); //Retrieve all the admins that did not commit the change
            
            string selectadmins = "SELECT ID From admin WHERE ID!=@user ";
            string selectadmincount = "SELECT COUNT(ID) From admin WHERE ID!=@user";
            SqlCommand cmd = new SqlCommand(selectadmins, myConnect);
            SqlCommand cmdadmincount = new SqlCommand(selectadmincount, myConnect);
            cmd.Parameters.AddWithValue("@user", userid);
            cmdadmincount.Parameters.AddWithValue("@user", userid);
            int count = 0;
            try
            {
                myConnect.Open();
                Int32 tlcount = (Int32)cmdadmincount.ExecuteScalar();
                adminarray = new int[tlcount];
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    adminarray[count] = Convert.ToInt32(reader["Id"]);
                    count++;
                }
                reader.Close();

                string adminnoti = "SELECT COUNT(*) From Notifications WHERE UserId=@ID";       //Sending notifications to them  
                for (int i = 0; i<adminarray.Count(); i++)
                {
                    SqlCommand cmdnoticount = new SqlCommand(adminnoti, myConnect);
                    cmdnoticount.Parameters.AddWithValue("@ID", adminarray[i]);
                    string insertnoti = "INSERT Notifications (Id , UserId , Description , NotiRead , CreationDate) VALUES (@Id , @UserId , @Description , @NotiRead , @CreationDate)";
                    SqlCommand cmdinsertnoti = new SqlCommand(insertnoti, myConnect);
                    cmdinsertnoti.Parameters.AddWithValue("@Id", Convert.ToInt32(cmdnoticount.ExecuteScalar()) + 1);
                    cmdinsertnoti.Parameters.AddWithValue("@UserId", adminarray[i]);
                    cmdinsertnoti.Parameters.AddWithValue("@Description", notification);
                    cmdinsertnoti.Parameters.AddWithValue("@NotiRead", false);
                    cmdinsertnoti.Parameters.AddWithValue("@CreationDate", DateTime.Today);
                    cmdinsertnoti.ExecuteNonQuery();
                    string newnoti = "UPDATE Admin SET NewNoti += @num WHERE ID=@userid";
                    SqlCommand newnotiupdate = new SqlCommand(newnoti, myConnect);
                    newnotiupdate.Parameters.AddWithValue("@num", 1);
                    newnotiupdate.Parameters.AddWithValue("@userid", adminarray[i]);
                    newnotiupdate.ExecuteNonQuery();                              
                }
                
            }


            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message.ToString());
            }

            catch (InvalidCastException i)
            {
                MessageBox.Show("Error:" + i.Message.ToString());
            }

            finally
            {
                myConnect.Close();
            }

            
        }

        private void notiexpire()
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            string selectdates = "SELECT Id , CreationDate From Notifications WHERE UserId=@userid";
            string notiexpire = "DELETE FROM Notifications WHERE UserId=@userid AND Id=@notiId";
            SqlCommand cmdselect = new SqlCommand(selectdates, myConnect);
            cmdselect.Parameters.AddWithValue("@userid", LoginForm.Userid);
            try
            {
                myConnect.Open();
                SqlDataReader reader = cmdselect.ExecuteReader();
                List<int> expirednotilist = new List<int>();
                while (reader.Read())
                {
                    TimeSpan datediff = DateTime.Today - DateTime.Parse(reader["CreationDate"].ToString());
                    if (Convert.ToInt32(datediff.ToString("%d")) > 30)
                    {   
                        expirednotilist.Add(Convert.ToInt32(reader["Id"]));
                    }
                }

                reader.Close();

                foreach (int value in expirednotilist)
                {
                    SqlCommand cmddelete = new SqlCommand(notiexpire, myConnect);
                    cmddelete.Parameters.AddWithValue("@userid", LoginForm.Userid);
                    cmddelete.Parameters.AddWithValue("notiId", value);
                    cmddelete.ExecuteNonQuery();
                }

            }


            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message.ToString());
            }

            catch (InvalidCastException i)
            {
                MessageBox.Show("Error:" + i.Message.ToString());
            }

            finally
            {
                myConnect.Close();
            }         
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
