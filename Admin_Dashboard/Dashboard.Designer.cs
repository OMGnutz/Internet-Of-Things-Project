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
            this.notificationmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.panelnavbar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonTR = new System.Windows.Forms.Button();
            this.buttonChart = new System.Windows.Forms.Button();
            this.buttonprofile = new System.Windows.Forms.Button();
            this.buttondashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.username = new System.Windows.Forms.Label();
            this.ovalPictureBoxpp = new Admin_Dashboard.OvalPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelnoti = new System.Windows.Forms.Label();
            this.buttonnoti = new System.Windows.Forms.Button();
            this.comboBoxdropdown = new System.Windows.Forms.ComboBox();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonAA = new System.Windows.Forms.Button();
            this.panelnavbar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBoxpp)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // notificationmenu
            // 
            this.notificationmenu.Name = "contextMenuStrip1";
            this.notificationmenu.Size = new System.Drawing.Size(61, 4);
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
            this.panelnavbar.Size = new System.Drawing.Size(232, 929);
            this.panelnavbar.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel3.Controls.Add(this.buttonAA);
            this.panel3.Controls.Add(this.buttonTR);
            this.panel3.Controls.Add(this.buttonChart);
            this.panel3.Controls.Add(this.buttonprofile);
            this.panel3.Controls.Add(this.buttondashboard);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 316);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 613);
            this.panel3.TabIndex = 0;
            // 
            // buttonTR
            // 
            this.buttonTR.FlatAppearance.BorderSize = 0;
            this.buttonTR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTR.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonTR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTR.Location = new System.Drawing.Point(73, 323);
            this.buttonTR.Name = "buttonTR";
            this.buttonTR.Size = new System.Drawing.Size(98, 86);
            this.buttonTR.TabIndex = 7;
            this.buttonTR.Text = "Ticket requests";
            this.buttonTR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTR.UseVisualStyleBackColor = true;
            this.buttonTR.Click += new System.EventHandler(this.buttonTR_Click);
            // 
            // buttonChart
            // 
            this.buttonChart.FlatAppearance.BorderSize = 0;
            this.buttonChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChart.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonChart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChart.Location = new System.Drawing.Point(73, 231);
            this.buttonChart.Name = "buttonChart";
            this.buttonChart.Size = new System.Drawing.Size(98, 86);
            this.buttonChart.TabIndex = 6;
            this.buttonChart.Text = "Charts";
            this.buttonChart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonChart.UseVisualStyleBackColor = true;
            // 
            // buttonprofile
            // 
            this.buttonprofile.FlatAppearance.BorderSize = 0;
            this.buttonprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonprofile.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonprofile.Image = global::Admin_Dashboard.Properties.Resources.profilepic3;
            this.buttonprofile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonprofile.Location = new System.Drawing.Point(73, 139);
            this.buttonprofile.Name = "buttonprofile";
            this.buttonprofile.Size = new System.Drawing.Size(98, 86);
            this.buttonprofile.TabIndex = 5;
            this.buttonprofile.Text = "Edit Profile";
            this.buttonprofile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonprofile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonprofile.UseVisualStyleBackColor = true;
            this.buttonprofile.Click += new System.EventHandler(this.buttonprofile_Click);
            // 
            // buttondashboard
            // 
            this.buttondashboard.FlatAppearance.BorderSize = 0;
            this.buttondashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttondashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttondashboard.Location = new System.Drawing.Point(73, 47);
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
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Controls.Add(this.username);
            this.panel2.Controls.Add(this.ovalPictureBoxpp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 316);
            this.panel2.TabIndex = 0;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.SystemColors.Desktop;
            this.username.ForeColor = System.Drawing.Color.Gainsboro;
            this.username.Location = new System.Drawing.Point(95, 254);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(35, 13);
            this.username.TabIndex = 1;
            this.username.Text = "label1";
            // 
            // ovalPictureBoxpp
            // 
            this.ovalPictureBoxpp.BackColor = System.Drawing.Color.DarkGray;
            this.ovalPictureBoxpp.Location = new System.Drawing.Point(61, 120);
            this.ovalPictureBoxpp.Name = "ovalPictureBoxpp";
            this.ovalPictureBoxpp.Size = new System.Drawing.Size(100, 104);
            this.ovalPictureBoxpp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ovalPictureBoxpp.TabIndex = 2;
            this.ovalPictureBoxpp.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.labelnoti);
            this.panel1.Controls.Add(this.buttonnoti);
            this.panel1.Controls.Add(this.comboBoxdropdown);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(232, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 78);
            this.panel1.TabIndex = 2;
            // 
            // labelnoti
            // 
            this.labelnoti.AutoSize = true;
            this.labelnoti.ForeColor = System.Drawing.Color.Red;
            this.labelnoti.Location = new System.Drawing.Point(783, 14);
            this.labelnoti.Name = "labelnoti";
            this.labelnoti.Size = new System.Drawing.Size(0, 13);
            this.labelnoti.TabIndex = 2;
            // 
            // buttonnoti
            // 
            this.buttonnoti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonnoti.Image = global::Admin_Dashboard.Properties.Resources.ssss1;
            this.buttonnoti.Location = new System.Drawing.Point(753, 14);
            this.buttonnoti.Name = "buttonnoti";
            this.buttonnoti.Size = new System.Drawing.Size(43, 45);
            this.buttonnoti.TabIndex = 1;
            this.buttonnoti.UseVisualStyleBackColor = true;
            this.buttonnoti.Click += new System.EventHandler(this.buttonnoti_Click);
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
            this.comboBoxdropdown.Location = new System.Drawing.Point(882, 27);
            this.comboBoxdropdown.Name = "comboBoxdropdown";
            this.comboBoxdropdown.Size = new System.Drawing.Size(99, 21);
            this.comboBoxdropdown.TabIndex = 0;
            this.comboBoxdropdown.SelectedIndexChanged += new System.EventHandler(this.comboBoxdropdown_SelectedIndexChanged);
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(232, 78);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1050, 851);
            this.panelDesktopPane.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonAA
            // 
            this.buttonAA.FlatAppearance.BorderSize = 0;
            this.buttonAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAA.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAA.Location = new System.Drawing.Point(73, 415);
            this.buttonAA.Name = "buttonAA";
            this.buttonAA.Size = new System.Drawing.Size(135, 86);
            this.buttonAA.TabIndex = 8;
            this.buttonAA.Text = "Account authorisation";
            this.buttonAA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAA.UseVisualStyleBackColor = true;
            this.buttonAA.Click += new System.EventHandler(this.buttonAA_Click);
            // 
            // Dashboard
            // 
            this.ClientSize = new System.Drawing.Size(1282, 929);
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
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBoxpp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip notificationmenu;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Panel panelnavbar;
        private System.Windows.Forms.Button buttondashboard;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonprofile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxdropdown;
        private System.Windows.Forms.BindingSource bindingSource1;
        private OvalPictureBox ovalPictureBoxpp;
        private System.Windows.Forms.Button buttonTR;
        private System.Windows.Forms.Button buttonChart;
        private System.Windows.Forms.Button buttonnoti;
        private System.Windows.Forms.Label labelnoti;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonAA;
    }
}