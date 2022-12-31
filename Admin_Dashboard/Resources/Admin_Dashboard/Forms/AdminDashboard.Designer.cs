namespace Admin_Dashboard.Forms
{
    partial class AdminDashboard
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
            this.panelspacing = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelspacing
            // 
            this.panelspacing.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelspacing.Location = new System.Drawing.Point(0, 0);
            this.panelspacing.Name = "panelspacing";
            this.panelspacing.Size = new System.Drawing.Size(1170, 49);
            this.panelspacing.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(654, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 100);
            this.panel1.TabIndex = 1;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 765);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelspacing);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelspacing;
        private System.Windows.Forms.Panel panel1;
    }
}