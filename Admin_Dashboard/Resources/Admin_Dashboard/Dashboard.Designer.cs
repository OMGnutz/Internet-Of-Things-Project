namespace Admin_Dashboard
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.panelnavbar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonprofile = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttondashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.username = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxdropdown = new System.Windows.Forms.ComboBox();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panelnavbar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "profilepic.png");
            // 
            // panelnavbar
            // 
            this.panelnavbar.BackColor = System.Drawing.SystemColors.Desktop;
            this.panelnavbar.Controls.Add(this.panel3);
            this.panelnavbar.Controls.Add(this.panel2);
            this.panelnavbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelnavbar.Location = new System.Drawing.Point(0, 0);
            this.panelnavbar.Name = "panelnavbar";
            this.panelnavbar.Size = new System.Drawing.Size(364, 929);
            this.panelnavbar.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonprofile);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.buttondashboard);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 316);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 613);
            this.panel3.TabIndex = 0;
            // 
            // buttonprofile
            // 
            this.buttonprofile.FlatAppearance.BorderSize = 0;
            this.buttonprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonprofile.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonprofile.Image = global::Admin_Dashboard.Properties.Resources.profilepic;
            this.buttonprofile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonprofile.Location = new System.Drawing.Point(151, 114);
            this.buttonprofile.Name = "buttonprofile";
            this.buttonprofile.Size = new System.Drawing.Size(98, 86);
            this.buttonprofile.TabIndex = 5;
            this.buttonprofile.Text = "Edit Profile";
            this.buttonprofile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonprofile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonprofile.UseVisualStyleBackColor = true;
            this.buttonprofile.Click += new System.EventHandler(this.buttonprofile_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.Location = new System.Drawing.Point(151, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Charts";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttondashboard
            // 
            this.buttondashboard.FlatAppearance.BorderSize = 0;
            this.buttondashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttondashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttondashboard.Location = new System.Drawing.Point(151, 35);
            this.buttondashboard.Name = "buttondashboard";
            this.buttondashboard.Size = new System.Drawing.Size(98, 86);
            this.buttondashboard.TabIndex = 2;
            this.buttondashboard.Text = "Dashboard";
            this.buttondashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttondashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttondashboard.UseVisualStyleBackColor = true;
            this.buttondashboard.Click += new System.EventHandler(this.buttondashboard_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.username);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 316);
            this.panel2.TabIndex = 0;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.SystemColors.Desktop;
            this.username.ForeColor = System.Drawing.Color.Gainsboro;
            this.username.Location = new System.Drawing.Point(160, 255);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(35, 13);
            this.username.TabIndex = 1;
            this.username.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.comboBoxdropdown);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(364, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1470, 78);
            this.panel1.TabIndex = 2;
            // 
            // comboBoxdropdown
            // 
            this.comboBoxdropdown.AutoCompleteCustomSource.AddRange(new string[] {
            "logout"});
            this.comboBoxdropdown.BackColor = System.Drawing.SystemColors.Desktop;
            this.comboBoxdropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxdropdown.ForeColor = System.Drawing.Color.Gainsboro;
            this.comboBoxdropdown.FormattingEnabled = true;
            this.comboBoxdropdown.Items.AddRange(new object[] {
            "logout"});
            this.comboBoxdropdown.Location = new System.Drawing.Point(1308, 30);
            this.comboBoxdropdown.Name = "comboBoxdropdown";
            this.comboBoxdropdown.Size = new System.Drawing.Size(99, 21);
            this.comboBoxdropdown.TabIndex = 0;
            this.comboBoxdropdown.SelectedIndexChanged += new System.EventHandler(this.comboBoxdropdown_SelectedIndexChanged);
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Controls.Add(this.dateTimePicker1);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(364, 78);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1470, 851);
            this.panelDesktopPane.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(148, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(210, 129);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(8, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.ClientSize = new System.Drawing.Size(1834, 929);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelnavbar);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelnavbar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelDesktopPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Panel panelnavbar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttondashboard;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonprofile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxdropdown;
        private OvalPictureBox ovalPictureBoxpp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}