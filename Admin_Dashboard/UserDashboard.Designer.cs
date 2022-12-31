namespace Admin_Dashboard
{
    partial class UserDashboard
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
            this.buttonstr = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonstr
            // 
            this.buttonstr.Location = new System.Drawing.Point(69, 112);
            this.buttonstr.Name = "buttonstr";
            this.buttonstr.Size = new System.Drawing.Size(148, 23);
            this.buttonstr.TabIndex = 0;
            this.buttonstr.Text = "Submit ticket request";
            this.buttonstr.UseVisualStyleBackColor = true;
            this.buttonstr.Click += new System.EventHandler(this.buttonstr_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonstr);
            this.Name = "UserDashboard";
            this.Text = "UserDashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonstr;
        private System.Windows.Forms.Button button1;
    }
}