namespace TomTime
{
    partial class frmBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBar));
            this.niTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblCountBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // niTray
            // 
            this.niTray.Icon = ((System.Drawing.Icon)(resources.GetObject("niTray.Icon")));
            this.niTray.Visible = true;
            // 
            // lblCountBack
            // 
            this.lblCountBack.AutoSize = true;
            this.lblCountBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountBack.Location = new System.Drawing.Point(12, 4);
            this.lblCountBack.Name = "lblCountBack";
            this.lblCountBack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCountBack.Size = new System.Drawing.Size(0, 17);
            this.lblCountBack.TabIndex = 0;
            // 
            // frmBar
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(360, 30);
            this.ControlBox = false;
            this.Controls.Add(this.lblCountBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBar_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBar_FormClosed);
            this.Load += new System.EventHandler(this.Bar_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmBar_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon niTray;
        private System.Windows.Forms.Label lblCountBack;

    }
}

