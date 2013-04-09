using MovablePython;
using System.Drawing;
using System.Windows.Forms;

namespace TomTime
{
    /*
     *Wrapper class around .NET Properties.Settings
     */
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
        static internal Color BlinkingColor;
        static internal bool Blinking;
        static internal int TimeToBlink;

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
            BlinkingColor = Properties.Settings.Default.BlinkingColor;
            Blinking = Properties.Settings.Default.Blinking;
            TimeToBlink = Properties.Settings.Default.TimeToBlink;

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
            Properties.Settings.Default.XPos = (int)X;
            Properties.Settings.Default.YPos = (int)Y;
            Properties.Settings.Default.XOffset = XOffset;
            Properties.Settings.Default.YOffset = YOffset;
            Properties.Settings.Default.BarTime = BarTime;
            Properties.Settings.Default.BarWidth = BarWidth;
            Properties.Settings.Default.BarHeight = BarHeight;
            Properties.Settings.Default.BarSeperators = BarSeperators;
            Properties.Settings.Default.BarColor = BarColor;
            Properties.Settings.Default.BlinkingColor = BlinkingColor;
            Properties.Settings.Default.Blinking = Blinking;
            Properties.Settings.Default.TimeToBlink = TimeToBlink;

            Properties.Settings.Default.HotkeyStartKeycode = HotkeyStart.KeyCode;
            Properties.Settings.Default.HotkeyStartControl = HotkeyStart.Control;
            Properties.Settings.Default.HotkeyStartShift = HotkeyStart.Shift;
            Properties.Settings.Default.HotkeyStartAlt = HotkeyStart.Alt;
            Properties.Settings.Default.HotkeyStartWin = HotkeyStart.Windows;

            Properties.Settings.Default.HotkeyPauseKeycode = HotkeyPause.KeyCode;
            Properties.Settings.Default.HotkeyPauseControl = HotkeyPause.Control;
            Properties.Settings.Default.HotkeyPauseShift = HotkeyPause.Shift;
            Properties.Settings.Default.HotkeyPauseAlt = HotkeyPause.Alt;
            Properties.Settings.Default.HotkeyPauseWin = HotkeyPause.Windows;

            Properties.Settings.Default.HotkeyHideKeycode = HotkeyHide.KeyCode;
            Properties.Settings.Default.HotkeyHideControl = HotkeyHide.Control;
            Properties.Settings.Default.HotkeyHideShift = HotkeyHide.Shift;
            Properties.Settings.Default.HotkeyHideAlt = HotkeyHide.Alt;
            Properties.Settings.Default.HotkeyHideWin = HotkeyHide.Windows;

            Properties.Settings.Default.Save();
        }
    }
}