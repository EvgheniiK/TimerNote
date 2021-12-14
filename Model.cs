using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;


namespace TimerNote
{
    public class Model
    {
        public static Stopwatch stopWatch = new Stopwatch();

        public static List<TimeSpan> timeSpanList = new List<TimeSpan>();
        public static List<DateTime> listOfDataNow = new List<DateTime>();



        public void StopWatchReset() { stopWatch.Reset(); }

        public DateTime StartTimer()
        {
            DateTime dt = DateTime.Now;
            listOfDataNow.Add(dt);
            stopWatch.Start();
            return listOfDataNow[0];

        }

        public void RsetlistOfDataNow() { listOfDataNow.Clear(); }


        public string Tick2()
        {
            TimeSpan tempTimeSpan = stopWatch.Elapsed;

            string timeSpanText = Convert.ToString(tempTimeSpan.Hours) + "час " + Convert.ToString(tempTimeSpan.Minutes) + "мин " + Convert.ToString(tempTimeSpan.Seconds) + "сек";

            return timeSpanText;
        }

        public DateTime InToCollection()
        {
            TimeSpan temp = stopWatch.Elapsed;
            timeSpanList.Add(temp);

            DateTime fromStartTame = StartTimer();

            fromStartTame = fromStartTame + temp;
            return fromStartTame;
        }

        public string GetTimeSpan()
        {
            TimeSpan temp2 = new TimeSpan();

            foreach (var item in timeSpanList)
            {
                temp2 += item;
            }
            return temp2.ToString(@"hh\:mm\:ss");
        }


    }
}
