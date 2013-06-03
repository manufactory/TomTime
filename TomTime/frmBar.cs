using System;
using System.Drawing;
using System.Windows.Forms;

namespace TomTime
{
    public partial class frmBar : Form
    {
        Graphics FormGraphics;
        Pen Pen = new Pen(Color.Black, 1);

        PauseableTimer Timer = new PauseableTimer();
        PauseableTimer BlinkTimer;
        Timer CountBackTimer;

        int CountBackSeconds = 0;

        const int BlinkInvervall = 300;

        enum TimerDirection { DOWNWARDS, UPWARDS };
        TimerDirection BarDirection = TimerDirection.DOWNWARDS;

        public frmBar()
        {
            InitializeComponent();
            this.DoubleClick += new EventHandler(Restart);
        }

        private void Bar_Load(object sender, EventArgs e)
        {
            UserSettings.LoadSettings(this);

            if (UserSettings.Blinking)
            {
                this.BlinkTimer = new PauseableTimer();
                this.BlinkTimer.RestoreTimeAfterPause = false;
            }

            if (UserSettings.CountBack)
            {
                this.CountBackTimer = new Timer();
                this.CountBackTimer.Tick += new EventHandler(CountBackTimer_tick);
                this.CountBackTimer.Interval = 1000;
            }

            FormGraphics = this.CreateGraphics();

            /*
             * Context menu
             */
            ContextMenu cmenu = new ContextMenu();

            MenuItem mi0 = new MenuItem("Start / Restart");
            mi0.Click += new EventHandler(Restart);
            cmenu.MenuItems.Add(mi0);

            MenuItem mi1 = new MenuItem("Pause / Resume");
            mi1.Click += new EventHandler(TogglePause);
            cmenu.MenuItems.Add(mi1);

            MenuItem mi2 = new MenuItem("Hide");
            mi2.Click += new EventHandler(ToggleHide);
            cmenu.MenuItems.Add(mi2);
            cmenu.MenuItems.Add("-");

            MenuItem mi3 = new MenuItem();
            mi3.Text = "Properties";
            mi3.Click += delegate
            {
                this.Reset();
                Form prop = new frmProperties(this);
                prop.ShowDialog();
            };
            cmenu.MenuItems.Add(mi3);

            MenuItem mi4 = new MenuItem();
            mi4.Text = "Close";
            mi4.Click += delegate
            {
                this.Close();
            };
            cmenu.MenuItems.Add(mi4);

            this.ContextMenu = cmenu;

            /*
             * Tray menu
             */
            ContextMenu tmenu = new ContextMenu();

            MenuItem tmi0 = new MenuItem("Start / Restart");
            tmi0.Click += new EventHandler(Restart);
            tmenu.MenuItems.Add(tmi0);

            MenuItem tmi1 = new MenuItem("Pause / Resume");
            tmi1.Click += new EventHandler(TogglePause);
            tmenu.MenuItems.Add(tmi1);

            MenuItem tmi2 = new MenuItem("Hide");
            tmi2.Click += new EventHandler(ToggleHide);
            tmenu.MenuItems.Add(tmi2);
            tmenu.MenuItems.Add("-");

            MenuItem tmi3 = new MenuItem("Properties");
            tmi3.Click += delegate
            {
                Reset();
                Form prop = new frmProperties(this);
                prop.ShowDialog();
            };
            tmenu.MenuItems.Add(tmi3);
            tmenu.MenuItems.Add("-");

            MenuItem tmi4 = new MenuItem("About");
            tmi4.Click += delegate
            {
                Form about = new frmAbout();
                about.ShowDialog();
            };
            tmenu.MenuItems.Add(tmi4);

            MenuItem tmi5 = new MenuItem("Close");
            tmi5.Click += delegate
            {
                this.Close();
            };
            tmenu.MenuItems.Add(tmi5);

            this.niTray.ContextMenu = tmenu;

            Timer.Tick += new EventHandler(Timer_Tick);

            if (UserSettings.Blinking)
            {
                BlinkTimer.Tick += new EventHandler(BlinkTimer_tick);
                BlinkTimer.Interval = UserSettings.TimeToBlink;
            }

            UserSettings.HotkeyStart.Pressed += delegate
            {
                Restart();
            };

            UserSettings.HotkeyPause.Pressed += delegate
            {
                TogglePause();
            };

            UserSettings.HotkeyHide.Pressed += delegate
            {
                ToggleHide();
            };

            ApplySettings();
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            if (this.BarDirection == TimerDirection.DOWNWARDS)
            {
                this.Width--;
            }
            else
            {
                this.Width++;
            }

            /*
             * This is necessary because Winforms just do not make the Form width smaller than 2px.
             * I have no idea, why this is so.
             */
            if (this.Width == 2)
            {
                if (UserSettings.CountBack)
                {
                    this.BackColor = UserSettings.CountBackColor;
                    this.BarDirection = TimerDirection.UPWARDS;

                    if (BlinkTimer != null) //TODO: make nicer
                        this.BlinkTimer.Stop();

                    this.lblCountBack.Visible = true;
                    this.CountBackTimer.Start();
                }
                else
                {
                    Timer.Stop();
                    this.Visible = false;
                }
            }

            if (this.Width == UserSettings.BarWidth)
            {
                //TODO: Talk to customer
                Timer.Stop();
                //CountBackTimer.Stop();
            }
        }

        void BlinkTimer_tick(object sender, EventArgs e)
        {
            this.BlinkTimer.Interval = BlinkInvervall;

            if (this.BackColor == UserSettings.BlinkingColor)
            {
                this.BackColor = UserSettings.BarColor;
            }
            else
            {
                this.BackColor = UserSettings.BlinkingColor;
            }
        }

        void CountBackTimer_tick(object sender, EventArgs e)
        {
            CountBackSeconds++;

            int min = CountBackSeconds / 60;
            int sec = CountBackSeconds % 60;

            string str = "";
            if (min < 10)
            {
                str += "0" + min;
            }
            else
            {
                str += min.ToString();
            }

            str += " : ";

            if (sec < 10)
            {
                str += "0" + sec;
            }
            else
            {
                str += sec.ToString();
            }

            lblCountBack.Text = str;
        }

        private void frmBar_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserSettings.HotkeyStart.Unregister();
            UserSettings.HotkeyPause.Unregister();
            UserSettings.HotkeyHide.Unregister();
        }

        internal void Restart(object sender, EventArgs e)
        {
            this.Restart();
        }

        internal void Restart()
        {
            this.lblCountBack.Visible = false;
            this.CountBackSeconds = 0;
            this.CountBackTimer.Stop();
            this.BackColor = UserSettings.BarColor;

            if (this.Visible == false)
            {
                this.Visible = true;
            }

            this.Timer.Stop();
            //asking twice for blinking here, for clearness
            //(may safe a functioncall, but depends on the compiler)
            if (UserSettings.Blinking)
            {
                this.BlinkTimer.Stop();
                this.Width = UserSettings.BarWidth;
            }

            this.BarDirection = TimerDirection.DOWNWARDS;
            this.Timer.Start();

            if (UserSettings.Blinking)
            {
                this.BlinkTimer.Interval = UserSettings.TimeToBlink;
                this.BlinkTimer.Start();
            }
        }

        internal void TogglePause(object sender, EventArgs e)
        {
            this.TogglePause();
        }

        internal void TogglePause()
        {
            if (Timer.Enabled)
            {
                Timer.Pause();
                if (UserSettings.Blinking)
                {
                    BlinkTimer.Pause();
                }
            }
            else
            {
                Timer.Resume();
                if (UserSettings.Blinking)
                {
                    BlinkTimer.Resume();
                }
            }
        }

        internal void ToggleHide(object sender, EventArgs e)
        {
            this.ToggleHide();
        }

        internal void ToggleHide()
        {
            this.Visible = this.Visible ? false : true;
        }

        internal void Reset()
        {
            if (this.Visible == false)
            {
                this.Visible = true;
            }

            this.Timer.Stop();
            if (UserSettings.Blinking)
            {
                this.BlinkTimer.Stop();
                this.BlinkTimer.Interval = UserSettings.TimeToBlink;
            }
            this.Width = UserSettings.BarWidth;
        }

        internal void ApplySettings()
        {
            /*
             * set  position on screen
             */
            Rectangle screen = Screen.PrimaryScreen.Bounds;

            int xPos = 0;
            int yPos = 0;

            this.Height = UserSettings.BarHeight;
            this.Width = UserSettings.BarWidth;

            if (UserSettings.X == UserSettings.XPos.Right)
            {
                xPos = screen.Width - this.Size.Width - UserSettings.XOffset;
            }
            else if (UserSettings.X == UserSettings.XPos.Left)
            {
                xPos = UserSettings.XOffset;
            }
            else
            {
                throw new InvalidOperationException();
            }

            if (UserSettings.Y == UserSettings.YPos.Top)
            {
                yPos = UserSettings.YOffset;
            }
            else if (UserSettings.Y == UserSettings.YPos.Bottom)
            {
                yPos = screen.Height - this.Size.Height - UserSettings.YOffset;
            }
            else
            {
                throw new InvalidOperationException();
            }

            this.DesktopLocation = new Point(xPos, yPos);

            int timerInterval = UserSettings.BarTime / this.Width;
            Timer.Interval = timerInterval;

            this.BackColor = UserSettings.BarColor;

            this.Refresh(); //redraw so the paintevent is raised
        }

        [System.Diagnostics.DebuggerHidden()]
        private void frmBar_Paint(object sender, PaintEventArgs e)
        {
            int lineX = 0;

            int lineIntervall = UserSettings.BarWidth / UserSettings.BarSeperators;

            for (int i = 0; i < UserSettings.BarSeperators; i++)
            {
                lineX += lineIntervall;
                FormGraphics.DrawLine(Pen, lineX, 0, lineX, this.Height);
            }
        }

        private void frmBar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Pen.Dispose();
            FormGraphics.Dispose();
        }
    }
}