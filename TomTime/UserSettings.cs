using MovablePython;
using System.Drawing;
using System.Windows.Forms;

namespace TomTime
{
    internal static class UserSettings
    {
        internal enum XPos { Left, Right }
        internal enum YPos { Top, Bottom };

        static internal int XOffset, YOffset;
        static internal int BarTime;
        static internal int BarWidth;
        static internal int BarHeight;
        static internal int BarSeperators;
        static internal Color BarColor;

        static internal Hotkey HotkeyStart;
        static internal Hotkey HotkeyPause;
        static internal Hotkey HotkeyHide;

        static internal XPos X;
        static internal YPos Y;

        internal static void LoadSettings(Control hotkeyControl)
        {
            X = (XPos)Properties.Settings.Default.XPos;
            Y = (YPos)Properties.Settings.Default.YPos;
            XOffset = Properties.Settings.Default.XOffset;
            YOffset = Properties.Settings.Default.YOffset;
            BarTime = Properties.Settings.Default.BarTime;
            BarHeight = Properties.Settings.Default.BarHeight;
            BarWidth = Properties.Settings.Default.BarWidth;
            BarSeperators = Properties.Settings.Default.BarSeperators;
            BarColor = Properties.Settings.Default.BarColor;

            HotkeyStart = new Hotkey();
            HotkeyStart.KeyCode = Properties.Settings.Default.HotkeyStartKeycode;
            HotkeyStart.Control = Properties.Settings.Default.HotkeyStartControl;
            HotkeyStart.Shift = Properties.Settings.Default.HotkeyStartShift;
            HotkeyStart.Alt = Properties.Settings.Default.HotkeyStartAlt;
            HotkeyStart.Windows = Properties.Settings.Default.HotkeyStartWin;
            HotkeyStart.Register(hotkeyControl);

            HotkeyPause = new Hotkey();
            HotkeyPause.KeyCode = Properties.Settings.Default.HotkeyPauseKeycode;
            HotkeyPause.Control = Properties.Settings.Default.HotkeyPauseControl;
            HotkeyPause.Shift = Properties.Settings.Default.HotkeyPauseShift;
            HotkeyPause.Alt = Properties.Settings.Default.HotkeyPauseAlt;
            HotkeyPause.Windows = Properties.Settings.Default.HotkeyPauseWin;
            HotkeyPause.Register(hotkeyControl);

            HotkeyHide = new Hotkey();
            HotkeyHide.KeyCode = Properties.Settings.Default.HotkeyHideKeycode;
            HotkeyHide.Control = Properties.Settings.Default.HotkeyHideControl;
            HotkeyHide.Shift = Properties.Settings.Default.HotkeyHideShift;
            HotkeyHide.Alt = Properties.Settings.Default.HotkeyHideAlt;
            HotkeyHide.Windows = Properties.Settings.Default.HotkeyHideWin;
            HotkeyHide.Register(hotkeyControl);
        }

        internal static void SaveSettings()
        {
            Properties.Settings.Default.Save();
        }
    }
}