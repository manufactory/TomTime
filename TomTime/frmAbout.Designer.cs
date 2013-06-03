namespace TomTime
{
    partial class frmAbout
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
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLicence = new System.Windows.Forms.Label();
            this.llblLicence = new System.Windows.Forms.LinkLabel();
            this.lblCopyright = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picIcon
            // 
            this.picIcon.Image = global::TomTime.Properties.Resources.appointment_soon;
            this.picIcon.Location = new System.Drawing.Point(12, 12);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(32, 32);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picIcon.TabIndex = 0;
            this.picIcon.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(51, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "TomTime 0.2";
            // 
            // lblLicence
            // 
            this.lblLicence.AutoSize = true;
            this.lblLicence.Location = new System.Drawing.Point(9, 73);
            this.lblLicence.Name = "lblLicence";
            this.lblLicence.Size = new System.Drawing.Size(48, 13);
            this.lblLicence.TabIndex = 2;
            this.lblLicence.Text = "Licence:";
            this.lblLicence.Click += new System.EventHandler(this.lblLicence_Click);
            // 
            // llblLicence
            // 
            this.llblLicence.AutoSize = true;
            this.llblLicence.LinkArea = new System.Windows.Forms.LinkArea(28, 52);
            this.llblLicence.Location = new System.Drawing.Point(12, 86);
            this.llblLicence.Name = "llblLicence";
            this.llblLicence.Size = new System.Drawing.Size(191, 17);
            this.llblLicence.TabIndex = 3;
            this.llblLicence.TabStop = true;
            this.llblLicence.Text = "This software is considered beerware";
            this.llblLicence.UseCompatibleTextRendering = true;
            this.llblLicence.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblLicence_LinkClicked);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(9, 47);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(181, 13);
            this.lblCopyright.TabIndex = 4;
            this.lblCopyright.Text = "Copyright (c) 2013 Manuel Wiesinger";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 112);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.llblLicence);
            this.Controls.Add(this.lblLicence);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picIcon);
            this.Name = "frmAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLicence;
        private System.Windows.Forms.LinkLabel llblLicence;
        private System.Windows.Forms.Label lblCopyright;

    }
}