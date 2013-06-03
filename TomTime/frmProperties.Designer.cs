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
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.nudSeconds = new System.Windows.Forms.NumericUpDown();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.nudSeperators = new System.Windows.Forms.NumericUpDown();
            this.lblSeperators = new System.Windows.Forms.Label();
            this.btnAbort = new System.Windows.Forms.Button();
            this.btnBlinkingColor = new System.Windows.Forms.Button();
            this.lblBlinkingColor = new System.Windows.Forms.Label();
            this.btnCountBackwardsColor = new System.Windows.Forms.Button();
            this.lblCountBackwardsColor = new System.Windows.Forms.Label();
            this.tabTabControl = new System.Windows.Forms.TabControl();
            this.tabTime = new System.Windows.Forms.TabPage();
            this.chkBlink = new System.Windows.Forms.CheckBox();
            this.chkCountBack = new System.Windows.Forms.CheckBox();
            this.nudBlinkMinutes = new System.Windows.Forms.NumericUpDown();
            this.lblBlinkMinutes = new System.Windows.Forms.Label();
            this.tabPosition = new System.Windows.Forms.TabPage();
            this.lblLength = new System.Windows.Forms.Label();
            this.nudLenght = new System.Windows.Forms.NumericUpDown();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblOffsetX = new System.Windows.Forms.Label();
            this.nudOffsetRight = new System.Windows.Forms.NumericUpDown();
            this.nudOffsetTop = new System.Windows.Forms.NumericUpDown();
            this.lblOffsetY = new System.Windows.Forms.Label();
            this.cbHorizontalPosition = new System.Windows.Forms.ComboBox();
            this.lblHorizontalPosition = new System.Windows.Forms.Label();
            this.lblVerticalPosition = new System.Windows.Forms.Label();
            this.cbVerticalPosition = new System.Windows.Forms.ComboBox();
            this.tabHotkeys = new System.Windows.Forms.TabPage();
            this.txtHotkeyHide = new System.Windows.Forms.TextBox();
            this.lblHide = new System.Windows.Forms.Label();
            this.txtHotkeyPause = new System.Windows.Forms.TextBox();
            this.lblPause = new System.Windows.Forms.Label();
            this.lblHotKeyStart = new System.Windows.Forms.Label();
            this.txtHotkeyStart = new System.Windows.Forms.TextBox();
            this.tabAppearance = new System.Windows.Forms.TabPage();
            this.tabBehavior = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeperators)).BeginInit();
            this.tabTabControl.SuspendLayout();
            this.tabTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlinkMinutes)).BeginInit();
            this.tabPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLenght)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetTop)).BeginInit();
            this.tabHotkeys.SuspendLayout();
            this.tabAppearance.SuspendLayout();
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
            this.nudMinutes.Location = new System.Drawing.Point(9, 20);
            this.nudMinutes.Maximum = new decimal(new int[] {
            1560,
            0,
            0,
            0});
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(42, 20);
            this.nudMinutes.TabIndex = 3;
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(6, 4);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(44, 13);
            this.lblMinutes.TabIndex = 9;
            this.lblMinutes.Text = "Minutes";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(54, 4);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(49, 13);
            this.lblSeconds.TabIndex = 10;
            this.lblSeconds.Text = "Seconds";
            // 
            // nudSeconds
            // 
            this.nudSeconds.Location = new System.Drawing.Point(57, 20);
            this.nudSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudSeconds.Name = "nudSeconds";
            this.nudSeconds.Size = new System.Drawing.Size(42, 20);
            this.nudSeconds.TabIndex = 11;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(3, 13);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(49, 13);
            this.lblColor.TabIndex = 21;
            this.lblColor.Text = "Bar color";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Red;
            this.btnColor.Location = new System.Drawing.Point(3, 29);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(46, 23);
            this.btnColor.TabIndex = 22;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // nudSeperators
            // 
            this.nudSeperators.Location = new System.Drawing.Point(3, 187);
            this.nudSeperators.Name = "nudSeperators";
            this.nudSeperators.Size = new System.Drawing.Size(42, 20);
            this.nudSeperators.TabIndex = 23;
            // 
            // lblSeperators
            // 
            this.lblSeperators.AutoSize = true;
            this.lblSeperators.Location = new System.Drawing.Point(0, 170);
            this.lblSeperators.Name = "lblSeperators";
            this.lblSeperators.Size = new System.Drawing.Size(58, 13);
            this.lblSeperators.TabIndex = 24;
            this.lblSeperators.Text = "Seperators";
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
            // btnBlinkingColor
            // 
            this.btnBlinkingColor.BackColor = System.Drawing.Color.IndianRed;
            this.btnBlinkingColor.Location = new System.Drawing.Point(3, 71);
            this.btnBlinkingColor.Name = "btnBlinkingColor";
            this.btnBlinkingColor.Size = new System.Drawing.Size(46, 23);
            this.btnBlinkingColor.TabIndex = 33;
            this.btnBlinkingColor.UseVisualStyleBackColor = false;
            this.btnBlinkingColor.Click += new System.EventHandler(this.btnBlinkingColor_Click);
            // 
            // lblBlinkingColor
            // 
            this.lblBlinkingColor.AutoSize = true;
            this.lblBlinkingColor.Location = new System.Drawing.Point(3, 55);
            this.lblBlinkingColor.Name = "lblBlinkingColor";
            this.lblBlinkingColor.Size = new System.Drawing.Size(70, 13);
            this.lblBlinkingColor.TabIndex = 32;
            this.lblBlinkingColor.Text = "Blinking color";
            // 
            // btnCountBackwardsColor
            // 
            this.btnCountBackwardsColor.BackColor = System.Drawing.Color.Fuchsia;
            this.btnCountBackwardsColor.Location = new System.Drawing.Point(3, 113);
            this.btnCountBackwardsColor.Name = "btnCountBackwardsColor";
            this.btnCountBackwardsColor.Size = new System.Drawing.Size(46, 23);
            this.btnCountBackwardsColor.TabIndex = 37;
            this.btnCountBackwardsColor.UseVisualStyleBackColor = false;
            this.btnCountBackwardsColor.Click += new System.EventHandler(this.btnCountBackwardsColor_Click);
            // 
            // lblCountBackwardsColor
            // 
            this.lblCountBackwardsColor.AutoSize = true;
            this.lblCountBackwardsColor.Location = new System.Drawing.Point(3, 97);
            this.lblCountBackwardsColor.Name = "lblCountBackwardsColor";
            this.lblCountBackwardsColor.Size = new System.Drawing.Size(137, 13);
            this.lblCountBackwardsColor.TabIndex = 36;
            this.lblCountBackwardsColor.Text = "Colour when counting back";
            // 
            // tabTabControl
            // 
            this.tabTabControl.Controls.Add(this.tabTime);
            this.tabTabControl.Controls.Add(this.tabPosition);
            this.tabTabControl.Controls.Add(this.tabHotkeys);
            this.tabTabControl.Controls.Add(this.tabAppearance);
            this.tabTabControl.Controls.Add(this.tabBehavior);
            this.tabTabControl.Location = new System.Drawing.Point(12, 12);
            this.tabTabControl.Name = "tabTabControl";
            this.tabTabControl.SelectedIndex = 0;
            this.tabTabControl.Size = new System.Drawing.Size(375, 236);
            this.tabTabControl.TabIndex = 39;
            // 
            // tabTime
            // 
            this.tabTime.BackColor = System.Drawing.Color.Transparent;
            this.tabTime.Controls.Add(this.chkBlink);
            this.tabTime.Controls.Add(this.chkCountBack);
            this.tabTime.Controls.Add(this.nudBlinkMinutes);
            this.tabTime.Controls.Add(this.lblBlinkMinutes);
            this.tabTime.Controls.Add(this.nudMinutes);
            this.tabTime.Controls.Add(this.lblMinutes);
            this.tabTime.Controls.Add(this.lblSeconds);
            this.tabTime.Controls.Add(this.nudSeconds);
            this.tabTime.Location = new System.Drawing.Point(4, 22);
            this.tabTime.Name = "tabTime";
            this.tabTime.Size = new System.Drawing.Size(367, 210);
            this.tabTime.TabIndex = 0;
            this.tabTime.Text = "Time";
            this.tabTime.UseVisualStyleBackColor = true;
            // 
            // chkBlink
            // 
            this.chkBlink.AutoSize = true;
            this.chkBlink.Checked = true;
            this.chkBlink.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBlink.Location = new System.Drawing.Point(9, 58);
            this.chkBlink.Name = "chkBlink";
            this.chkBlink.Size = new System.Drawing.Size(63, 17);
            this.chkBlink.TabIndex = 39;
            this.chkBlink.Text = "Blinking";
            this.chkBlink.UseVisualStyleBackColor = true;
            this.chkBlink.CheckedChanged += new System.EventHandler(this.chkBlink_CheckedChanged_1);
            // 
            // chkCountBack
            // 
            this.chkCountBack.AutoSize = true;
            this.chkCountBack.Checked = true;
            this.chkCountBack.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCountBack.Location = new System.Drawing.Point(9, 133);
            this.chkCountBack.Name = "chkCountBack";
            this.chkCountBack.Size = new System.Drawing.Size(110, 17);
            this.chkCountBack.TabIndex = 40;
            this.chkCountBack.Text = "Count Backwards";
            this.chkCountBack.UseVisualStyleBackColor = true;
            // 
            // nudBlinkMinutes
            // 
            this.nudBlinkMinutes.Location = new System.Drawing.Point(9, 94);
            this.nudBlinkMinutes.Maximum = new decimal(new int[] {
            1560,
            0,
            0,
            0});
            this.nudBlinkMinutes.Name = "nudBlinkMinutes";
            this.nudBlinkMinutes.Size = new System.Drawing.Size(42, 20);
            this.nudBlinkMinutes.TabIndex = 36;
            this.nudBlinkMinutes.ValueChanged += new System.EventHandler(this.nudBlinkMinutes_ValueChanged);
            // 
            // lblBlinkMinutes
            // 
            this.lblBlinkMinutes.AutoSize = true;
            this.lblBlinkMinutes.Location = new System.Drawing.Point(6, 78);
            this.lblBlinkMinutes.Name = "lblBlinkMinutes";
            this.lblBlinkMinutes.Size = new System.Drawing.Size(115, 13);
            this.lblBlinkMinutes.TabIndex = 37;
            this.lblBlinkMinutes.Text = "Blink the last n minutes";
            // 
            // tabPosition
            // 
            this.tabPosition.Controls.Add(this.lblLength);
            this.tabPosition.Controls.Add(this.nudLenght);
            this.tabPosition.Controls.Add(this.nudHeight);
            this.tabPosition.Controls.Add(this.lblHeight);
            this.tabPosition.Controls.Add(this.lblOffsetX);
            this.tabPosition.Controls.Add(this.nudOffsetRight);
            this.tabPosition.Controls.Add(this.nudOffsetTop);
            this.tabPosition.Controls.Add(this.lblOffsetY);
            this.tabPosition.Controls.Add(this.cbHorizontalPosition);
            this.tabPosition.Controls.Add(this.lblHorizontalPosition);
            this.tabPosition.Controls.Add(this.lblVerticalPosition);
            this.tabPosition.Controls.Add(this.cbVerticalPosition);
            this.tabPosition.Location = new System.Drawing.Point(4, 22);
            this.tabPosition.Name = "tabPosition";
            this.tabPosition.Size = new System.Drawing.Size(367, 210);
            this.tabPosition.TabIndex = 1;
            this.tabPosition.Text = "Positions";
            this.tabPosition.UseVisualStyleBackColor = true;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(3, 50);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(40, 13);
            this.lblLength.TabIndex = 42;
            this.lblLength.Text = "Lenght";
            // 
            // nudLenght
            // 
            this.nudLenght.Location = new System.Drawing.Point(6, 66);
            this.nudLenght.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudLenght.Name = "nudLenght";
            this.nudLenght.Size = new System.Drawing.Size(42, 20);
            this.nudLenght.TabIndex = 41;
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(54, 66);
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(42, 20);
            this.nudHeight.TabIndex = 40;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(51, 50);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 39;
            this.lblHeight.Text = "Height";
            // 
            // lblOffsetX
            // 
            this.lblOffsetX.AutoSize = true;
            this.lblOffsetX.Location = new System.Drawing.Point(102, 50);
            this.lblOffsetX.Name = "lblOffsetX";
            this.lblOffsetX.Size = new System.Drawing.Size(45, 13);
            this.lblOffsetX.TabIndex = 38;
            this.lblOffsetX.Text = "X-Offset";
            // 
            // nudOffsetRight
            // 
            this.nudOffsetRight.Location = new System.Drawing.Point(105, 66);
            this.nudOffsetRight.Name = "nudOffsetRight";
            this.nudOffsetRight.Size = new System.Drawing.Size(42, 20);
            this.nudOffsetRight.TabIndex = 37;
            // 
            // nudOffsetTop
            // 
            this.nudOffsetTop.Location = new System.Drawing.Point(153, 66);
            this.nudOffsetTop.Name = "nudOffsetTop";
            this.nudOffsetTop.Size = new System.Drawing.Size(42, 20);
            this.nudOffsetTop.TabIndex = 36;
            // 
            // lblOffsetY
            // 
            this.lblOffsetY.AutoSize = true;
            this.lblOffsetY.Location = new System.Drawing.Point(150, 50);
            this.lblOffsetY.Name = "lblOffsetY";
            this.lblOffsetY.Size = new System.Drawing.Size(45, 13);
            this.lblOffsetY.TabIndex = 35;
            this.lblOffsetY.Text = "Y-Offset";
            // 
            // cbHorizontalPosition
            // 
            this.cbHorizontalPosition.FormattingEnabled = true;
            this.cbHorizontalPosition.Location = new System.Drawing.Point(94, 26);
            this.cbHorizontalPosition.Name = "cbHorizontalPosition";
            this.cbHorizontalPosition.Size = new System.Drawing.Size(79, 21);
            this.cbHorizontalPosition.TabIndex = 34;
            // 
            // lblHorizontalPosition
            // 
            this.lblHorizontalPosition.AutoSize = true;
            this.lblHorizontalPosition.Location = new System.Drawing.Point(91, 10);
            this.lblHorizontalPosition.Name = "lblHorizontalPosition";
            this.lblHorizontalPosition.Size = new System.Drawing.Size(94, 13);
            this.lblHorizontalPosition.TabIndex = 33;
            this.lblHorizontalPosition.Text = "Horizontal Position";
            // 
            // lblVerticalPosition
            // 
            this.lblVerticalPosition.AutoSize = true;
            this.lblVerticalPosition.Location = new System.Drawing.Point(3, 10);
            this.lblVerticalPosition.Name = "lblVerticalPosition";
            this.lblVerticalPosition.Size = new System.Drawing.Size(82, 13);
            this.lblVerticalPosition.TabIndex = 32;
            this.lblVerticalPosition.Text = "Vertical Position";
            // 
            // cbVerticalPosition
            // 
            this.cbVerticalPosition.FormattingEnabled = true;
            this.cbVerticalPosition.Location = new System.Drawing.Point(6, 26);
            this.cbVerticalPosition.Name = "cbVerticalPosition";
            this.cbVerticalPosition.Size = new System.Drawing.Size(79, 21);
            this.cbVerticalPosition.TabIndex = 31;
            // 
            // tabHotkeys
            // 
            this.tabHotkeys.Controls.Add(this.txtHotkeyHide);
            this.tabHotkeys.Controls.Add(this.lblHide);
            this.tabHotkeys.Controls.Add(this.txtHotkeyPause);
            this.tabHotkeys.Controls.Add(this.lblPause);
            this.tabHotkeys.Controls.Add(this.lblHotKeyStart);
            this.tabHotkeys.Controls.Add(this.txtHotkeyStart);
            this.tabHotkeys.Location = new System.Drawing.Point(4, 22);
            this.tabHotkeys.Name = "tabHotkeys";
            this.tabHotkeys.Size = new System.Drawing.Size(367, 210);
            this.tabHotkeys.TabIndex = 3;
            this.tabHotkeys.Text = "Hotkeys";
            this.tabHotkeys.UseVisualStyleBackColor = true;
            // 
            // txtHotkeyHide
            // 
            this.txtHotkeyHide.BackColor = System.Drawing.Color.White;
            this.txtHotkeyHide.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtHotkeyHide.Location = new System.Drawing.Point(6, 114);
            this.txtHotkeyHide.Name = "txtHotkeyHide";
            this.txtHotkeyHide.ReadOnly = true;
            this.txtHotkeyHide.Size = new System.Drawing.Size(358, 20);
            this.txtHotkeyHide.TabIndex = 32;
            // 
            // lblHide
            // 
            this.lblHide.AutoSize = true;
            this.lblHide.Location = new System.Drawing.Point(3, 98);
            this.lblHide.Name = "lblHide";
            this.lblHide.Size = new System.Drawing.Size(94, 13);
            this.lblHide.TabIndex = 31;
            this.lblHide.Text = "Hotkey to (un)hide";
            // 
            // txtHotkeyPause
            // 
            this.txtHotkeyPause.BackColor = System.Drawing.Color.White;
            this.txtHotkeyPause.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtHotkeyPause.Location = new System.Drawing.Point(6, 75);
            this.txtHotkeyPause.Name = "txtHotkeyPause";
            this.txtHotkeyPause.ReadOnly = true;
            this.txtHotkeyPause.Size = new System.Drawing.Size(358, 20);
            this.txtHotkeyPause.TabIndex = 30;
            // 
            // lblPause
            // 
            this.lblPause.AutoSize = true;
            this.lblPause.Location = new System.Drawing.Point(3, 59);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(85, 13);
            this.lblPause.TabIndex = 29;
            this.lblPause.Text = "Hotkey to pause";
            // 
            // lblHotKeyStart
            // 
            this.lblHotKeyStart.AutoSize = true;
            this.lblHotKeyStart.Location = new System.Drawing.Point(3, 20);
            this.lblHotKeyStart.Name = "lblHotKeyStart";
            this.lblHotKeyStart.Size = new System.Drawing.Size(91, 13);
            this.lblHotKeyStart.TabIndex = 28;
            this.lblHotKeyStart.Text = "Hotkey to (re)start";
            // 
            // txtHotkeyStart
            // 
            this.txtHotkeyStart.BackColor = System.Drawing.Color.White;
            this.txtHotkeyStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtHotkeyStart.Location = new System.Drawing.Point(6, 36);
            this.txtHotkeyStart.Name = "txtHotkeyStart";
            this.txtHotkeyStart.ReadOnly = true;
            this.txtHotkeyStart.Size = new System.Drawing.Size(358, 20);
            this.txtHotkeyStart.TabIndex = 27;
            // 
            // tabAppearance
            // 
            this.tabAppearance.Controls.Add(this.btnColor);
            this.tabAppearance.Controls.Add(this.lblColor);
            this.tabAppearance.Controls.Add(this.btnCountBackwardsColor);
            this.tabAppearance.Controls.Add(this.lblCountBackwardsColor);
            this.tabAppearance.Controls.Add(this.btnBlinkingColor);
            this.tabAppearance.Controls.Add(this.lblSeperators);
            this.tabAppearance.Controls.Add(this.nudSeperators);
            this.tabAppearance.Controls.Add(this.lblBlinkingColor);
            this.tabAppearance.Location = new System.Drawing.Point(4, 22);
            this.tabAppearance.Name = "tabAppearance";
            this.tabAppearance.Size = new System.Drawing.Size(367, 210);
            this.tabAppearance.TabIndex = 2;
            this.tabAppearance.Text = "Appearance";
            this.tabAppearance.UseVisualStyleBackColor = true;
            // 
            // tabBehavior
            // 
            this.tabBehavior.Location = new System.Drawing.Point(4, 22);
            this.tabBehavior.Name = "tabBehavior";
            this.tabBehavior.Size = new System.Drawing.Size(367, 210);
            this.tabBehavior.TabIndex = 4;
            this.tabBehavior.Text = "Behavior";
            this.tabBehavior.UseVisualStyleBackColor = true;
            // 
            // frmProperties
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ClientSize = new System.Drawing.Size(399, 289);
            this.Controls.Add(this.tabTabControl);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmProperties";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Properties";
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeperators)).EndInit();
            this.tabTabControl.ResumeLayout(false);
            this.tabTime.ResumeLayout(false);
            this.tabTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlinkMinutes)).EndInit();
            this.tabPosition.ResumeLayout(false);
            this.tabPosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLenght)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetTop)).EndInit();
            this.tabHotkeys.ResumeLayout(false);
            this.tabHotkeys.PerformLayout();
            this.tabAppearance.ResumeLayout(false);
            this.tabAppearance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nudMinutes;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.NumericUpDown nudSeconds;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.NumericUpDown nudSeperators;
        private System.Windows.Forms.Label lblSeperators;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Button btnBlinkingColor;
        private System.Windows.Forms.Label lblBlinkingColor;
        private System.Windows.Forms.Button btnCountBackwardsColor;
        private System.Windows.Forms.Label lblCountBackwardsColor;
        private System.Windows.Forms.TabControl tabTabControl;
        private System.Windows.Forms.TabPage tabTime;
        private System.Windows.Forms.NumericUpDown nudBlinkMinutes;
        private System.Windows.Forms.Label lblBlinkMinutes;
        private System.Windows.Forms.TabPage tabPosition;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.NumericUpDown nudLenght;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblOffsetX;
        private System.Windows.Forms.NumericUpDown nudOffsetRight;
        private System.Windows.Forms.NumericUpDown nudOffsetTop;
        private System.Windows.Forms.Label lblOffsetY;
        private System.Windows.Forms.ComboBox cbHorizontalPosition;
        private System.Windows.Forms.Label lblHorizontalPosition;
        private System.Windows.Forms.Label lblVerticalPosition;
        private System.Windows.Forms.ComboBox cbVerticalPosition;
        private System.Windows.Forms.TabPage tabHotkeys;
        private System.Windows.Forms.TextBox txtHotkeyHide;
        private System.Windows.Forms.Label lblHide;
        private System.Windows.Forms.TextBox txtHotkeyPause;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Label lblHotKeyStart;
        private System.Windows.Forms.TextBox txtHotkeyStart;
        private System.Windows.Forms.TabPage tabAppearance;
        private System.Windows.Forms.TabPage tabBehavior;
        private System.Windows.Forms.CheckBox chkBlink;
        private System.Windows.Forms.CheckBox chkCountBack;
    }
}