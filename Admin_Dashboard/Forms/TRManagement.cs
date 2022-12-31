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

namespace Admin_Dashboard.Forms
{
    public partial class TRManagement : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["AdminConnection"].ConnectionString;
        public static TRManagement instance;
        public TRManagement()
        {
            instance = this;
            InitializeComponent();
            flowLayoutPanel1.HorizontalScroll.Maximum = 0;
            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.VerticalScroll.Visible = false;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Click += new EventHandler(stealfocus);
            this.Click += new EventHandler(stealfocus);
            textBoxSearch.GotFocus += new EventHandler(placeholderSearch);
            textBoxSearch.LostFocus += new EventHandler(placeholderSearch);
            textBoxSearch.KeyUp += new KeyEventHandler(search);
        }

        private void TRManagement_Load(object sender, EventArgs e)
        {
            updatepanellist();        
        }

        public void updatepanellist()
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            myConnect.Open();
            string strCommandText = "SELECT * FROM TicketRequest";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var pnl = new MyCustomPanel(reader["Id"].ToString(), reader["UserName"].ToString() , reader["Ticketdesc"].ToString() , reader["Status"].ToString(), reader["SubmissionDate"].ToString(), flowLayoutPanel1);
                    flowLayoutPanel1.Controls.Add(pnl);
                }
            }
            myConnect.Close();
        }

        public void resetpanellist()
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(paneltitle);
        }

        private void stealfocus(object sender, EventArgs e)
        {
            label1.Focus();
        }

        public void placeholderSearch(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Search For User...")
            {
                textBoxSearch.Text = "";
            }

            else if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                textBoxSearch.Text = "Search For User...";
            }
        }

        public void search(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                resetpanellist();
                updatepanellist();
            }
            else
            {
                foreach (Control c in flowLayoutPanel1.Controls)
                {
                    foreach (Control x in c.Controls)
                    {
                        if (c.Name != "paneltitle" && x.Name == "LabelName")
                        { 
                            if (x.Text.ToLower().IndexOf(textBoxSearch.Text.ToLower()) > -1)
                            {
                                c.Visible = true;
                            }
                            else
                            {
                                c.Visible = false;
                            }         
                        }
                        
                     }
                 }
             }
        }


    }

    class MyCustomPanel : Panel
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["AdminConnection"].ConnectionString;
        public System.Windows.Forms.Label LabelId;
        public System.Windows.Forms.Label LabelName;
        public System.Windows.Forms.Label Labeldesc;
        public System.Windows.Forms.Label LabelStatus;
        public System.Windows.Forms.Label LabelDate;
        public RJButton CloseTicket;
        public MyCustomPanel(string id , string name , string ticketdesc , string status , string submissiondate , Panel parentpanel)
        {
            DateTime formattedsubmissiondate = DateTime.Parse(submissiondate);
            TimeSpan datediff = DateTime.Today - formattedsubmissiondate;
            Console.WriteLine(datediff.ToString("%d"));

            InitializeComponent();
            if (status == "In progress")
            {
                this.LabelStatus.ForeColor = Color.Orange;
                this.Controls.Add(CloseTicket);
            }
            else
            {
                this.LabelStatus.ForeColor = Color.Red;
                this.BackColor = Color.FromArgb(100, SystemColors.ControlLight);
                foreach(Label l in this.Controls)
                {
                    l.BackColor = Color.FromArgb(0, SystemColors.ControlLight);
                }
            }
            LabelId.Text = id;
            Labeldesc.Text = ticketdesc;
            LabelName.Text = name;
            LabelStatus.Text = status; 
            LabelDate.Text = $"Submitted on {submissiondate}";
            this.Width = parentpanel.Width - 20;
        }
        public void InitializeComponent()
        {
            this.LabelId = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.Labeldesc = new System.Windows.Forms.Label();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.CloseTicket = new RJButton();
            this.CloseTicket.Text = "Close Ticket";
            this.CloseTicket.BorderColor = Color.Green;
            this.CloseTicket.TextColor = Color.Green;
            this.CloseTicket.BackgroundColor = SystemColors.Control;
            this.CloseTicket.BorderSize = 1;
            this.CloseTicket.Click += new EventHandler(CloseTicket_Click);
            this.LabelId.MaximumSize = new Size(200 , 20);
            this.LabelId.Left += 65;
            this.LabelId.Top += 50;
            this.LabelName.Name = "LabelName";
            this.LabelName.MaximumSize = new Size(200, 20);
            this.LabelName.Left = this.LabelId.Location.X + 145;
            this.LabelName.Top = this.LabelId.Top;
            this.Labeldesc.AutoSize = true;
            this.Labeldesc.MaximumSize = new Size(200, 20);
            this.Labeldesc.Left = this.LabelName.Location.X + 175;
            this.Labeldesc.Top = this.LabelId.Top;
            this.LabelStatus.MaximumSize = new Size(200, 20);
            this.LabelStatus.Left = this.LabelId.Location.X + 495;
            this.LabelStatus.Top = this.LabelId.Top;
            this.CloseTicket.Left = this.LabelStatus.Location.X + 200;
            this.CloseTicket.Top += 30;
            this.LabelDate.AutoSize = true;
            this.LabelDate.MaximumSize = new Size(200, 20);
            this.LabelDate.Left = this.CloseTicket.Location.X;
            this.Controls.Add(LabelId);
            this.Controls.Add(LabelName);
            this.Controls.Add(Labeldesc);
            this.Controls.Add(LabelStatus);
            this.Controls.Add(LabelDate);
            this.Dock = DockStyle.Top;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        public string GetLabelName
        {
            get { return LabelName.Name; }
            set
            {
                LabelName.Name = value;
                this.Invalidate();
            }
        }

        public void CloseTicket_Click(object sender, EventArgs e)
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            string strCommandText = "UPDATE TicketRequest SET Status = @status WHERE ID=@UserID";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            cmd.Parameters.AddWithValue("@UserID", this.LabelId.Text);
            cmd.Parameters.AddWithValue("@status", "Closed");
            try
            {
                myConnect.Open();
                cmd.ExecuteNonQuery();
                TRManagement.instance.resetpanellist();
                TRManagement.instance.updatepanellist();
                string selectadminName = "SELECT Name From Admin Where ID=@userid";
                SqlCommand cmdname = new SqlCommand(selectadminName, myConnect);
                cmdname.Parameters.AddWithValue("@userid", LoginForm.Userid);
                SqlDataReader reader = cmdname.ExecuteReader();
                if (reader.Read())
                {
                  Dashboard.instance.Send_notification(LoginForm.Userid, $"{reader["Name"]} has closed the ticket ID number {this.LabelId.Text}");
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
    }


    public class RJButton : Button
    {
        private int borderSize = 0;
        private int borderRadius = 20;
        private Color borderColor = Color.PaleVioletRed;

        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        public RJButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }

        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;
            if (borderRadius > 2) 
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    this.Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);                 
                    if (borderSize >= 1)
                       
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else 
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                this.Region = new Region(rectSurface);
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
