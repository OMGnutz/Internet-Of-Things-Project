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
using System.IO;

namespace Admin_Dashboard.Forms
{
    public partial class Profile : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["AdminConnection"].ConnectionString;
    
        public Profile()
        {
            InitializeComponent();
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            byte[] getImg = new byte[0];
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
                    reader.Close();
                    strCommandText = "UPDATE Admin SET Name = @newname , Profilepic = @pp WHERE ID=@UserID";
                    SqlCommand updatecmd = new SqlCommand(strCommandText, myConnect);
                    updatecmd.Parameters.AddWithValue("@newname", textBoxusername.Text);
                    updatecmd.Parameters.AddWithValue("@UserID", LoginForm.Userid);
                    updatecmd.Parameters.AddWithValue("@pp", ConvertImageToBytes(ovalPictureBoxpp.Image));
                    updatecmd.ExecuteNonQuery();
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Dashboard.instance.displayname.Text = reader["Name"].ToString();
                        Dashboard.instance.namedropdown.Text = reader["Name"].ToString();                       
                        if (!DBNull.Value.Equals(reader["Profilepic"]))
                        {
                            reader.Close();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataSet ds = new DataSet();
                            da.Fill(ds);
                            foreach (DataRow dr in ds.Tables[0].Rows)
                            {
                                getImg = (byte[])dr["Profilepic"];
                            }

                            byte[] imgData = getImg;
                            MemoryStream stream = new MemoryStream(imgData);
                            Dashboard.instance.pp.Image = Image.FromStream(stream);
                            reader.Close();
                        }
                        
                    }                                              
                    myConnect.Close();                   
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

        private void Profile_Load(object sender, EventArgs e)
        {
            byte[] getImg = new byte[0];
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
                    textBoxusername.Text = reader["Name"].ToString();
                    if (!DBNull.Value.Equals(reader["Profilepic"]))
                    {
                        reader.Close();
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
                        reader.Close();
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

        private void buttondiscard_Click(object sender, EventArgs e)
        {
            byte[] getImg = new byte[0];
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
                    if (!DBNull.Value.Equals(reader["Profilepic"]))
                    {
                        textBoxusername.Text = reader["Name"].ToString();
                        reader.Close();
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

        private void buttonImage_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() { Filter= "Image files(*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png" , Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ovalPictureBoxpp.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        byte[] ConvertImageToBytes(Image img)
        {
            using(MemoryStream ms= new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }      
    }
}
