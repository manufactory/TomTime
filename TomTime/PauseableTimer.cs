using System;
using System.Windows.Forms;

namespace TomTime
{
    class PauseableTimer : Timer
    {
        DateTime PausedTime;
        int NormalInterval;

        public void Pause()
        {
            PausedTime = DateTime.Now;
            this.Stop();
            NormalInterval = this.Interval;
        }

        public void Resume()
        {
            TimeSpan offset = DateTime.Now - PausedTime;
            TimeSpan tick = TimeSpan.FromMilliseconds(NormalInterval - (offset.Milliseconds % NormalInterval));

            this.Tick += new EventHandler(this.Offset_Tick);
            this.Interval = offset.Milliseconds;

            this.Start();
        }

        void Offset_Tick(object sender, EventArgs e)
        {
            this.Tick -= new EventHandler(Offset_Tick);
            this.Interval = NormalInterval;
        }
    }
}