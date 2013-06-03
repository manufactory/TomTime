using System;
using System.Windows.Forms;

namespace TomTime
{
    class PauseableTimer : Timer
    {
        DateTime PausedTime;
        int NormalInterval;

        /*
         * this is because a Blinking timer should _not_
         * be restored to it original state, it is set 
         * to the blinking intervall, when the rest time
         * has passed, instead */
        internal bool RestoreTimeAfterPause = true;
        
        public PauseableTimer()
        {

        }

        public void Pause()
        {
            PausedTime = DateTime.Now;
            this.Stop();
            NormalInterval = this.Interval;
        }

        public void Resume()
        {
            TimeSpan offset = DateTime.Now - PausedTime;
            TimeSpan tick = TimeSpan.FromMilliseconds(NormalInterval - (offset.TotalMilliseconds % NormalInterval));

            if (RestoreTimeAfterPause)
            {
                this.Tick += new EventHandler(this.Offset_Tick);
            }


            this.Interval = Convert.ToInt32(tick.TotalMilliseconds);
            //this.Interval = Convert.ToInt32(offset.TotalMilliseconds);
            //this.Interval = offset.Milliseconds;

            this.Start();
        }

        void Offset_Tick(object sender, EventArgs e)
        {
            this.Tick -= new EventHandler(Offset_Tick);
            this.Interval = NormalInterval;
        }
    }
}