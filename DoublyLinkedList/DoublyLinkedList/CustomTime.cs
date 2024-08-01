using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    internal class CustomTime
    {
        public int Minutes { get; set; } = 0;
        public int Seconds { get; set; } = 0;

        public CustomTime(int totalSeconds){
            Minutes = totalSeconds / 60;
            Math.DivRem(totalSeconds, 60, out int sec);
            Seconds = sec;
        }

        public CustomTime(int minutes, int seconds)
        {
            Minutes = minutes;
            Seconds = seconds;
            CalcExtraMinute();
        }

        public CustomTime(string time) 
        {
            string[] times = time.Split(':');
            Minutes = int.Parse(times[0]);
            Seconds = int.Parse(times[1]);
            CalcExtraMinute();
        }
        public int TotalSeconds()
        {
            return Minutes*60 + Seconds;
        }
        private void CalcExtraMinute()
        {
            int extra = int.Parse(Math.Floor(Seconds / 60.0).ToString());
            Minutes += extra;
            Seconds -= extra*60;
        }
        public override string ToString()
        {
            CalcExtraMinute();
            if (Seconds < 10)
            {
                return $"{Minutes}:0{Seconds}";
            }
            else
            {
                return $"{Minutes}:{Seconds}";
            }
        }
    }
}
