namespace TomTime
{
    partial class frmProperties
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
            this.btnSave = new System.Windows.Forms.Button();
            this.nudMinutes = new System.Windows.Forms.NumericUpDown();
            this.cbVerticalPosition = new System.Windows.Forms.ComboBox();
            this.lblVerticalPosition = new System.Windows.Forms.Label();
            this.lblHorizontalPosition = new System.Windows.Forms.Label();
            this.cbHorizontalPosition = new System.Windows.Forms.ComboBox();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.nudSeconds = new System.Windows.Forms.NumericUpDown();
            this.lblOffsetY = new System.Windows.Forms.Label();
            this.nudOffsetTop = new System.Windows.Forms.NumericUpDown();
            this.nudOffsetRight = new System.Windows.Forms.NumericUpDown();
            this.lblOffsetX = new System.Windows.Forms.Label();
            this.txtHotkeyStart = new System.Windows.Forms.TextBox();
            this.lblHotKeyStart = new System.Windows.Forms.Label();
            this.lblPause = new System.Windows.Forms.Label();
            this.txtHotkeyPause = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.nudSeperators = new System.Windows.Forms.NumericUpDown();
            this.lblSeperators = new System.Windows.Forms.Label();
            this.txtHotkeyHide = new System.Windows.Forms.TextBox();
            this.lblHide = new System.Windows.Forms.Label();
            this.btnAbort = new System.Windows.Forms.Button();
            this.lblLength = new System.Windows.Forms.Label();
            this.nudLenght = new System.Windows.Forms.NumericUpDown();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.lblHeight = new System.Windows.Forms.Label();
            this.chkBlink = new System.Windows.Forms.CheckBox();
            this.btnBlinkingColor = new System.Windows.Forms.Button();
            this.lblBlinkingColor = new System.Windows.Forms.Label();
            this.lblBlinkMinutes = new System.Windows.Forms.Label();
            this.nudBlinkMinutes = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeperators)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLenght)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlinkMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 254);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nudMinutes
            // 
            this.nudMinutes.Location = new System.Drawing.Point(15, 104);
            this.nudMinutes.Maximum = new decimal(new int[] {
            1560,
            0,
            0,
            0});
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(42, 20);
            this.nudMinutes.TabIndex = 3;
            // 
            // cbVerticalPosition
            // 
            this.cbVerticalPosition.FormattingEnabled = true;
            this.cbVerticalPosition.Location = new System.Drawing.Point(15, 25);
            this.cbVerticalPosition.Name = "cbVerticalPosition";
            this.cbVerticalPosition.Size = new System.Drawing.Size(79, 21);
            this.cbVerticalPosition.TabIndex = 5;
            // 
            // lblVerticalPosition
            // 
            this.lblVerticalPosition.AutoSize = true;
            this.lblVerticalPosition.Location = new System.Drawing.Point(12, 9);
            this.lblVerticalPosition.Name = "lblVerticalPosition";
            this.lblVerticalPosition.Size = new System.Drawing.Size(82, 13);
            this.lblVerticalPosition.TabIndex = 6;
            this.lblVerticalPosition.Text = "Vertical Position";
            // 
            // lblHorizontalPosition
            // 
            this.lblHorizontalPosition.AutoSize = true;
            this.lblHorizontalPosition.Location = new System.Drawing.Point(100, 9);
            this.lblHorizontalPosition.Name = "lblHorizontalPosition";
            this.lblHorizontalPosition.Size = new System.Drawing.Size(94, 13);
            this.lblHorizontalPosition.TabIndex = 7;
            this.lblHorizontalPosition.Text = "Horizontal Position";
            // 
            // cbHorizontalPosition
            // 
            this.cbHorizontalPosition.FormattingEnabled = true;
            this.cbHorizontalPosition.Location = new System.Drawing.Point(103, 25);
            this.cbHorizontalPosition.Name = "cbHorizontalPosition";
            this.cbHorizontalPosition.Size = new System.Drawing.Size(79, 21);
            this.cbHorizontalPosition.TabIndex = 8;
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(12, 88);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(44, 13);
            this.lblMinutes.TabIndex = 9;
            this.lblMinutes.Text = "Minutes";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(60, 88);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(49, 13);
            this.lblSeconds.TabIndex = 10;
            this.lblSeconds.Text = "Seconds";
            // 
            // nudSeconds
            // 
            this.nudSeconds.Location = new System.Drawing.Point(63, 104);
            this.nudSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudSeconds.Name = "nudSeconds";
            this.nudSeconds.Size = new System.Drawing.Size(42, 20);
            this.nudSeconds.TabIndex = 11;
            // 
            // lblOffsetY
            // 
            this.lblOffsetY.AutoSize = true;
            this.lblOffsetY.Location = new System.Drawing.Point(159, 49);
            this.lblOffsetY.Name = "lblOffsetY";
            this.lblOffsetY.Size = new System.Drawing.Size(45, 13);
            this.lblOffsetY.TabIndex = 12;
            this.lblOffsetY.Text = "Y-Offset";
            // 
            // nudOffsetTop
            // 
            this.nudOffsetTop.Location = new System.Drawing.Point(162, 65);
            this.nudOffsetTop.Name = "nudOffsetTop";
            this.nudOffsetTop.Size = new System.Drawing.Size(42, 20);
            this.nudOffsetTop.TabIndex = 13;
            // 
            // nudOffsetRight
            // 
            this.nudOffsetRight.Location = new System.Drawing.Point(114, 65);
            this.nudOffsetRight.Name = "nudOffsetRight";
            this.nudOffsetRight.Size = new System.Drawing.Size(42, 20);
            this.nudOffsetRight.TabIndex = 14;
            // 
            // lblOffsetX
            // 
            this.lblOffsetX.AutoSize = true;
            this.lblOffsetX.Location = new System.Drawing.Point(111, 49);
            this.lblOffsetX.Name = "lblOffsetX";
            this.lblOffsetX.Size = new System.Drawing.Size(45, 13);
            this.lblOffsetX.TabIndex = 15;
            this.lblOffsetX.Text = "X-Offset";
            // 
            // txtHotkeyStart
            // 
            this.txtHotkeyStart.BackColor = System.Drawing.Color.White;
            this.txtHotkeyStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtHotkeyStart.Location = new System.Drawing.Point(12, 143);
            this.txtHotkeyStart.Name = "txtHotkeyStart";
            this.txtHotkeyStart.ReadOnly = true;
            this.txtHotkeyStart.Size = new System.Drawing.Size(375, 20);
            this.txtHotkeyStart.TabIndex = 16;
            this.txtHotkeyStart.DoubleClick += new System.EventHandler(this.txtHotkeyStart_DoubleClick);
            this.txtHotkeyStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHotKeyStart_KeyDown);
            // 
            // lblHotKeyStart
            // 
            this.lblHotKeyStart.AutoSize = true;
            this.lblHotKeyStart.Location = new System.Drawing.Point(9, 127);
            this.lblHotKeyStart.Name = "lblHotKeyStart";
            this.lblHotKeyStart.Size = new System.Drawing.Size(91, 13);
            this.lblHotKeyStart.TabIndex = 17;
            this.lblHotKeyStart.Text = "Hotkey to (re)start";
            // 
            // lblPause
            // 
            this.lblPause.AutoSize = true;
            this.lblPause.Location = new System.Drawing.Point(9, 166);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(85, 13);
            this.lblPause.TabIndex = 18;
            this.lblPause.Text = "Hotkey to pause";
            // 
            // txtHotkeyPause
            // 
            this.txtHotkeyPause.BackColor = System.Drawing.Color.White;
            this.txtHotkeyPause.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtHotkeyPause.Location = new System.Drawing.Point(12, 182);
            this.txtHotkeyPause.Name = "txtHotkeyPause";
            this.txtHotkeyPause.ReadOnly = true;
            this.txtHotkeyPause.Size = new System.Drawing.Size(375, 20);
            this.txtHotkeyPause.TabIndex = 19;
            this.txtHotkeyPause.DoubleClick += new System.EventHandler(this.txtHotkeyPause_DoubleClick);
            this.txtHotkeyPause.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHotkeyPause_KeyDown);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(204, 9);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(49, 13);
            this.lblColor.TabIndex = 21;
            this.lblColor.Text = "Bar color";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Red;
            this.btnColor.Location = new System.Drawing.Point(207, 23);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(46, 23);
            this.btnColor.TabIndex = 22;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // nudSeperators
            // 
            this.nudSeperators.Location = new System.Drawing.Point(262, 26);
            this.nudSeperators.Name = "nudSeperators";
            this.nudSeperators.Size = new System.Drawing.Size(42, 20);
            this.nudSeperators.TabIndex = 23;
            // 
            // lblSeperators
            // 
            this.lblSeperators.AutoSize = true;
            this.lblSeperators.Location = new System.Drawing.Point(259, 9);
            this.lblSeperators.Name = "lblSeperators";
            this.lblSeperators.Size = new System.Drawing.Size(58, 13);
            this.lblSeperators.TabIndex = 24;
            this.lblSeperators.Text = "Seperators";
            // 
            // txtHotkeyHide
            // 
            this.txtHotkeyHide.BackColor = System.Drawing.Color.White;
            this.txtHotkeyHide.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtHotkeyHide.Location = new System.Drawing.Point(12, 221);
            this.txtHotkeyHide.Name = "txtHotkeyHide";
            this.txtHotkeyHide.ReadOnly = true;
            this.txtHotkeyHide.Size = new System.Drawing.Size(375, 20);
            this.txtHotkeyHide.TabIndex = 26;
            this.txtHotkeyHide.DoubleClick += new System.EventHandler(this.txtHotkeyHide_DoubleClick);
            this.txtHotkeyHide.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHotkeyHide_KeyDown);
            // 
            // lblHide
            // 
            this.lblHide.AutoSize = true;
            this.lblHide.Location = new System.Drawing.Point(9, 205);
            this.lblHide.Name = "lblHide";
            this.lblHide.Size = new System.Drawing.Size(94, 13);
            this.lblHide.TabIndex = 25;
            this.lblHide.Text = "Hotkey to (un)hide";
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(93, 254);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 23);
            this.btnAbort.TabIndex = 2;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(12, 49);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(40, 13);
            this.lblLength.TabIndex = 30;
            this.lblLength.Text = "Lenght";
            // 
            // nudLenght
            // 
            this.nudLenght.Location = new System.Drawing.Point(15, 65);
            this.nudLenght.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudLenght.Name = "nudLenght";
            this.nudLenght.Size = new System.Drawing.Size(42, 20);
            this.nudLenght.TabIndex = 29;
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(63, 65);
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(42, 20);
            this.nudHeight.TabIndex = 28;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(60, 49);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 27;
            this.lblHeight.Text = "Height";
            // 
            // chkBlink
            // 
            this.chkBlink.AutoSize = true;
            this.chkBlink.Checked = true;
            this.chkBlink.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBlink.Location = new System.Drawing.Point(320, 52);
            this.chkBlink.Name = "chkBlink";
            this.chkBlink.Size = new System.Drawing.Size(63, 17);
            this.chkBlink.TabIndex = 31;
            this.chkBlink.Text = "Blinking";
            this.chkBlink.UseVisualStyleBackColor = true;
            this.chkBlink.CheckedChanged += new System.EventHandler(this.chkBlink_CheckedChanged);
            // 
            // btnBlinkingColor
            // 
            this.btnBlinkingColor.BackColor = System.Drawing.Color.IndianRed;
            this.btnBlinkingColor.Location = new System.Drawing.Point(320, 23);
            this.btnBlinkingColor.Name = "btnBlinkingColor";
            this.btnBlinkingColor.Size = new System.Drawing.Size(46, 23);
            this.btnBlinkingColor.TabIndex = 33;
            this.btnBlinkingColor.UseVisualStyleBackColor = false;
            this.btnBlinkingColor.Click += new System.EventHandler(this.btnBlinkingColor_Click);
            // 
            // lblBlinkingColor
            // 
            this.lblBlinkingColor.AutoSize = true;
            this.lblBlinkingColor.Location = new System.Drawing.Point(317, 7);
            this.lblBlinkingColor.Name = "lblBlinkingColor";
            this.lblBlinkingColor.Size = new System.Drawing.Size(70, 13);
            this.lblBlinkingColor.TabIndex = 32;
            this.lblBlinkingColor.Text = "Blinking color";
            // 
            // lblBlinkMinutes
            // 
            this.lblBlinkMinutes.AutoSize = true;
            this.lblBlinkMinutes.Location = new System.Drawing.Point(251, 88);
            this.lblBlinkMinutes.Name = "lblBlinkMinutes";
            this.lblBlinkMinutes.Size = new System.Drawing.Size(115, 13);
            this.lblBlinkMinutes.TabIndex = 35;
            this.lblBlinkMinutes.Text = "Blink the last n minutes";
            // 
            // nudBlinkMinutes
            // 
            this.nudBlinkMinutes.Location = new System.Drawing.Point(324, 104);
            this.nudBlinkMinutes.Maximum = new decimal(new int[] {
            1560,
            0,
            0,
            0});
            this.nudBlinkMinutes.Name = "nudBlinkMinutes";
            this.nudBlinkMinutes.Size = new System.Drawing.Size(42, 20);
            this.nudBlinkMinutes.TabIndex = 34;
            // 
            // frmProperties
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ClientSize = new System.Drawing.Size(399, 289);
            this.Controls.Add(this.lblBlinkMinutes);
            this.Controls.Add(this.nudBlinkMinutes);
            this.Controls.Add(this.btnBlinkingColor);
            this.Controls.Add(this.lblBlinkingColor);
            this.Controls.Add(this.chkBlink);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.nudLenght);
            this.Controls.Add(this.nudHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtHotkeyHide);
            this.Controls.Add(this.lblHide);
            this.Controls.Add(this.lblSeperators);
            this.Controls.Add(this.nudSeperators);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.txtHotkeyPause);
            this.Controls.Add(this.lblPause);
            this.Controls.Add(this.lblHotKeyStart);
            this.Controls.Add(this.txtHotkeyStart);
            this.Controls.Add(this.lblOffsetX);
            this.Controls.Add(this.nudOffsetRight);
            this.Controls.Add(this.nudOffsetTop);
            this.Controls.Add(this.lblOffsetY);
            this.Controls.Add(this.nudSeconds);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.cbHorizontalPosition);
            this.Controls.Add(this.lblHorizontalPosition);
            this.Controls.Add(this.lblVerticalPosition);
            this.Controls.Add(this.cbVerticalPosition);
            this.Controls.Add(this.nudMinutes);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmProperties";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeperators)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLenght)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlinkMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nudMinutes;
        private System.Windows.Forms.ComboBox cbVerticalPosition;
        private System.Windows.Forms.Label lblVerticalPosition;
        private System.Windows.Forms.Label lblHorizontalPosition;
        private System.Windows.Forms.ComboBox cbHorizontalPosition;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.NumericUpDown nudSeconds;
        private System.Windows.Forms.Label lblOffsetY;
        private System.Windows.Forms.NumericUpDown nudOffsetTop;
        private System.Windows.Forms.NumericUpDown nudOffsetRight;
        private System.Windows.Forms.Label lblOffsetX;
        private System.Windows.Forms.TextBox txtHotkeyStart;
        private System.Windows.Forms.Label lblHotKeyStart;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.TextBox txtHotkeyPause;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.NumericUpDown nudSeperators;
        private System.Windows.Forms.Label lblSeperators;
        private System.Windows.Forms.TextBox txtHotkeyHide;
        private System.Windows.Forms.Label lblHide;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.NumericUpDown nudLenght;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.CheckBox chkBlink;
        private System.Windows.Forms.Button btnBlinkingColor;
        private System.Windows.Forms.Label lblBlinkingColor;
        private System.Windows.Forms.Label lblBlinkMinutes;
        private System.Windows.Forms.NumericUpDown nudBlinkMinutes;
    }
}