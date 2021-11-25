using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace TimerNote
{
    public class TimeProcessing
    {
        private ContentControl uiElement;

        public TimeProcessing(ContentControl uiElement)
        {
            this.uiElement = uiElement;
            GetSystemTime();
        }


        public void GetSystemTime()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += tickevent;
            timer.Start();
        }

        private void tickevent(object sender, EventArgs e)
        {
            uiElement.Content = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
