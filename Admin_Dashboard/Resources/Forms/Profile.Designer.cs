namespace Admin_Dashboard.Forms
{
    partial class Profile
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
            this.label1 = new System.Windows.Forms.Label();
            this.ovalPictureBoxpp = new Admin_Dashboard.OvalPictureBox();
            this.buttonImage = new System.Windows.Forms.Button();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.buttondiscard = new System.Windows.Forms.Button();
            this.buttonsave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBoxpp)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "username";
            // 
            // ovalPictureBoxpp
            // 
            this.ovalPictureBoxpp.BackColor = System.Drawing.Color.DarkGray;
            this.ovalPictureBoxpp.Location = new System.Drawing.Point(70, 28);
            this.ovalPictureBoxpp.Name = "ovalPictureBoxpp";
            this.ovalPictureBoxpp.Size = new System.Drawing.Size(100, 106);
            this.ovalPictureBoxpp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ovalPictureBoxpp.TabIndex = 1;
            this.ovalPictureBoxpp.TabStop = false;
            // 
            // buttonImage
            // 
            this.buttonImage.Location = new System.Drawing.Point(200, 111);
            this.buttonImage.Name = "buttonImage";
            this.buttonImage.Size = new System.Drawing.Size(80, 23);
            this.buttonImage.TabIndex = 2;
            this.buttonImage.Text = "Select Image";
            this.buttonImage.UseVisualStyleBackColor = true;
            this.buttonImage.Click += new System.EventHandler(this.buttonImage_Click);
            // 
            // textBoxusername
            // 
            this.textBoxusername.Location = new System.Drawing.Point(81, 231);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(163, 20);
            this.textBoxusername.TabIndex = 3;
            // 
            // buttondiscard
            // 
            this.buttondiscard.Location = new System.Drawing.Point(81, 329);
            this.buttondiscard.Name = "buttondiscard";
            this.buttondiscard.Size = new System.Drawing.Size(75, 23);
            this.buttondiscard.TabIndex = 6;
            this.buttondiscard.Text = "Discard";
            this.buttondiscard.UseVisualStyleBackColor = true;
            this.buttondiscard.Click += new System.EventHandler(this.buttondiscard_Click);
            // 
            // buttonsave
            // 
            this.buttonsave.Location = new System.Drawing.Point(169, 329);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(75, 23);
            this.buttonsave.TabIndex = 7;
            this.buttonsave.Text = "Save";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ovalPictureBoxpp);
            this.panel1.Controls.Add(this.buttonsave);
            this.panel1.Controls.Add(this.buttonImage);
            this.panel1.Controls.Add(this.buttondiscard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxusername);
            this.panel1.Location = new System.Drawing.Point(240, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 455);
            this.panel1.TabIndex = 8;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 755);
            this.Controls.Add(this.panel1);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBoxpp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private OvalPictureBox ovalPictureBoxpp;
        private System.Windows.Forms.Button buttonImage;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.Button buttondiscard;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Panel panel1;
    }
}