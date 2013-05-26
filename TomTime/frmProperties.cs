using MovablePython;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TomTime
{
    public partial class frmProperties : Form
    {
        Hotkey newHotkeyStart;
        Hotkey newHotkeyPause;
        Hotkey newHotkeyHide;

        List<Keys> pressedKeys = new List<Keys>();
        bool singleKeyPressed = false;

        frmBar barForm;

        public frmProperties(frmBar barForm)
        {
            InitializeComponent();

            this.barForm = barForm;

            cbHorizontalPosition.Items.Add("Left");
            cbHorizontalPosition.Items.Add("Right");

            cbVerticalPosition.Items.Add("Top");
            cbVerticalPosition.Items.Add("Bottom");

            /*
             * Load settings ToolBar 
             */

            /*
             * Setting the indexes this way is not best practice, but is sufficent for now.
             */
            if (UserSettings.X == UserSettings.XPos.Left)
            {
                this.cbHorizontalPosition.SelectedIndex = this.cbHorizontalPosition.FindString("Left");
            }
            else if (UserSettings.X == UserSettings.XPos.Right)
            {
                this.cbHorizontalPosition.SelectedIndex = this.cbHorizontalPosition.FindString("Right");
            }

            if (UserSettings.Y == UserSettings.YPos.Top)
            {
                this.cbVerticalPosition.SelectedIndex = this.cbVerticalPosition.FindString("Top");
            }
            else if (UserSettings.Y == UserSettings.YPos.Bottom)
            {
                this.cbVerticalPosition.SelectedIndex = this.cbVerticalPosition.FindString("Bottom");
            }

            this.btnColor.BackColor = UserSettings.BarColor;
            this.nudSeperators.Value = UserSettings.BarSeperators;

            this.btnBlinkingColor.BackColor = UserSettings.BlinkingColor;
            this.chkBlink.Checked = UserSettings.Blinking;

            this.chkCountBack.Checked = UserSettings.CountBack;
            this.btnCountBackwardsColor.BackColor = UserSettings.CountBackColor;

            this.nudMinutes.Value = UserSettings.BarTime / 60000;
            this.nudSeconds.Value = (UserSettings.BarTime / 1000) % 60;
            this.nudBlinkMinutes.Value = UserSettings.TimeToBlink / 60000;

            Rectangle screen = Screen.PrimaryScreen.Bounds;
            this.nudLenght.Maximum = screen.Width;
            this.nudHeight.Value = UserSettings.BarHeight;
            this.nudLenght.Maximum = screen.Width;
            this.nudLenght.Value = UserSettings.BarWidth;

            this.nudOffsetTop.Value = UserSettings.YOffset;
            this.nudOffsetRight.Value = UserSettings.XOffset;

            this.txtHotkeyStart.Text = HotkeyToString(UserSettings.HotkeyStart);
            this.txtHotkeyPause.Text = HotkeyToString(UserSettings.HotkeyPause);
            this.txtHotkeyHide.Text = HotkeyToString(UserSettings.HotkeyHide);
        }

        private void txtHotKeyStart_KeyDown(object sender, KeyEventArgs e)
        {
            if (newHotkeyStart == null)
            {
                newHotkeyStart = new Hotkey();
            }
            txtKeyDown(txtHotkeyStart, e, newHotkeyStart);
        }

        private void txtHotkeyPause_KeyDown(object sender, KeyEventArgs e)
        {
            if (newHotkeyPause == null)
            {
                newHotkeyPause = new Hotkey();
            }
            txtKeyDown(txtHotkeyPause, e, newHotkeyPause);
        }

        private void txtHotkeyHide_KeyDown(object sender, KeyEventArgs e)
        {
            if (newHotkeyHide == null)
            {
                newHotkeyHide = new Hotkey();
            }
            txtKeyDown(txtHotkeyHide, e, newHotkeyHide);
        }

        private void txtKeyDown(TextBox txt, KeyEventArgs e, Hotkey hk)
        {
            if (!pressedKeys.Contains(e.KeyCode))
            {
                pressedKeys.Add(e.KeyCode);

                /*
                 * Fill the textfield
                 */
                string hks = KeyToString(e.KeyCode);

                if (txt.Text == "")
                {
                    txt.Text = hks;
                }
                else if (hks != null)
                {
                    txt.Text += " + " + hks;
                }

                switch (e.KeyCode)
                {
                    case Keys.ControlKey:
                        hk.Control = true;
                        break;
                    case Keys.Menu:
                        hk.Alt = true;
                        break;
                    case Keys.ShiftKey:
                        hk.Shift = true;
                        break;
                    case Keys.LWin:
                    case Keys.RWin:
                        hk.Windows = true;
                        break;
                    default:
                        if (!singleKeyPressed)
                        {
                            singleKeyPressed = true;
                            hk.KeyCode = e.KeyCode;
                        }
                        break;
                }
            }
        }

        private void txtDoubleClick(TextBox txt)
        {
            txt.Text = "";
            pressedKeys = new List<Keys>();
            singleKeyPressed = false;
        }

        string KeyToString(Keys k)
        {
            switch (k)
            {
                case Keys.ControlKey:
                    return "CTRL";
                case Keys.Menu:
                    return "ALT";
                case Keys.ShiftKey:
                    return "SHIFT";
                case Keys.LWin:
                case Keys.RWin:
                    return "WIN";
                default:
                    if (singleKeyPressed)
                    {
                        return null;
                    }
                    else
                    {
                        //singleKeyPressed = true;
                        return k.ToString();
                    }
            }
        }

        string HotkeyToString(Hotkey hk)
        {
            string s = "";

            if (hk.Control)
            {
                if (hk.Shift || hk.Windows || hk.KeyCode != Keys.None)
                {
                    s += "CTRL + ";
                }
                else
                {
                    s += "CTRL";    //only CTRL as keycode shouldn't be used anyway.
                }
            }
            if (hk.Alt)
            {
                if (hk.Shift || hk.Windows || hk.KeyCode != Keys.None)
                {
                    s += "ALT + ";
                }
                else
                {
                    s += "ALT";
                }
            }
            if (hk.Shift)
            {
                if (hk.Windows || hk.KeyCode != Keys.None)
                {
                    s += "SHIFT + ";
                }
                else
                {
                    s += "SHIFT";
                }
            }
            if (hk.Windows)
            {
                if (hk.KeyCode != Keys.None)
                {
                    s += "WIN + ";
                }
                else
                {
                    s += "WIN";
                }
            }
            if (hk.KeyCode != Keys.None)
            {
                s += hk.KeyCode.ToString();
            }
            return s;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult close = MessageBox.Show("Are you sure, you want to save these settings?", "", MessageBoxButtons.OKCancel);

            if (close == DialogResult.OK)
            {
                if (txtHotkeyStart.Text == "")
                {
                    UserSettings.HotkeyStart.Unregister();
                }
                else if (newHotkeyStart != null)
                {
                    UserSettings.HotkeyStart.Unregister();
                    UserSettings.HotkeyStart = newHotkeyStart;
                    UserSettings.HotkeyStart.Pressed += delegate { barForm.Restart(); };
                    UserSettings.HotkeyStart.Register(barForm);
                }

                if (txtHotkeyPause.Text == "")
                {
                    UserSettings.HotkeyPause.Unregister();
                }
                else if (newHotkeyPause != null)
                {
                    UserSettings.HotkeyPause.Unregister();
                    UserSettings.HotkeyPause = newHotkeyPause;
                    UserSettings.HotkeyPause.Pressed += delegate { barForm.TogglePause(); };
                    UserSettings.HotkeyPause.Register(barForm);
                }

                if (txtHotkeyHide.Text == "")
                {
                    UserSettings.HotkeyHide.Unregister();
                }
                else if (newHotkeyHide != null)
                {
                    UserSettings.HotkeyHide.Unregister();
                    UserSettings.HotkeyHide = newHotkeyHide;
                    UserSettings.HotkeyHide.Pressed += delegate { barForm.ToggleHide(); };
                    UserSettings.HotkeyHide.Register(barForm);
                }

                if (this.cbHorizontalPosition.SelectedIndex == this.cbHorizontalPosition.FindString("Left"))
                {
                    UserSettings.X = UserSettings.XPos.Left;
                }
                else if (this.cbHorizontalPosition.SelectedIndex == this.cbHorizontalPosition.FindString("Right"))
                {
                    UserSettings.X = UserSettings.XPos.Right;
                }
                if (this.cbVerticalPosition.SelectedIndex == this.cbVerticalPosition.FindString("Top"))
                {
                    UserSettings.Y = UserSettings.YPos.Top;
                }
                else if (this.cbVerticalPosition.SelectedIndex == this.cbVerticalPosition.FindString("Bottom"))
                {
                    UserSettings.Y = UserSettings.YPos.Bottom;
                }

                UserSettings.BarColor = btnColor.BackColor;
                UserSettings.BarSeperators = Decimal.ToInt32(nudSeperators.Value);

                UserSettings.BarTime = Decimal.ToInt32(nudMinutes.Value * 60000 + nudSeconds.Value * 1000);

                UserSettings.Blinking = chkBlink.Checked;
                UserSettings.TimeToBlink = UserSettings.BarTime - Decimal.ToInt32((nudBlinkMinutes.Value * 60000));
                UserSettings.BlinkingColor = btnBlinkingColor.BackColor;

                UserSettings.CountBack = this.chkCountBack.Checked;
                UserSettings.CountBackColor = this.btnCountBackwardsColor.BackColor;

                UserSettings.BarHeight = Decimal.ToInt32(nudHeight.Value);
                UserSettings.BarWidth = Decimal.ToInt32(nudLenght.Value);

                UserSettings.XOffset = Decimal.ToInt32(nudOffsetRight.Value);
                UserSettings.YOffset = Decimal.ToInt32(nudOffsetTop.Value);

                UserSettings.SaveSettings();

                barForm.ApplySettings();
                this.Close();
            }
        }

        /*
         * Precondition: barForm is in pause-state. This should always the case here.
         */
        private void btnAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            btnColor.BackColor = cd.Color;
        }

        private void txtHotkeyStart_DoubleClick(object sender, EventArgs e)
        {
            txtDoubleClick(this.txtHotkeyStart);
        }

        private void txtHotkeyPause_DoubleClick(object sender, EventArgs e)
        {
            txtDoubleClick(this.txtHotkeyPause);
        }

        private void txtHotkeyHide_DoubleClick(object sender, EventArgs e)
        {
            txtDoubleClick(this.txtHotkeyHide);
        }

        private void chkBlink_CheckedChanged(object sender, EventArgs e)
        {
            btnBlinkingColor.Enabled = btnBlinkingColor.Enabled ? false : true;
        }

        private void btnBlinkingColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            btnBlinkingColor.BackColor = cd.Color;
        }

        private void btnCountBackwardsColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            btnCountBackwardsColor.BackColor = cd.Color;
        }

        private void nudBlinkMinutes_ValueChanged(object sender, EventArgs e)
        {
            if (nudBlinkMinutes.Value > nudMinutes.Value) {
                MessageBox.Show("Value bigger than minutes!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
                if(nudMinutes.Value > 0) {
                    nudBlinkMinutes.Value = nudMinutes.Value - 1;
                } else {
                    nudBlinkMinutes.Value = 0;
                }
            }
        }
    }
}