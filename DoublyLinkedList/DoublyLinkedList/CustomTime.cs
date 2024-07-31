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

        public CustomTime(){}

        public CustomTime(int minutes, int seconds)
        {
            Minutes = minutes;
            Seconds = seconds;
        }

        public CustomTime ConvertFromStringToTime(string time) 
        {
            string[] times = time.Split(':');
            Minutes = int.Parse(times[0]);
            Seconds = int.Parse(times[1]);
            return new CustomTime(Minutes, Seconds);
        }
        public int TotalSeconds()
        {
            return Minutes*60 + Seconds;
        }
        public string FormattedTime()
        {
            return $"{Minutes}:{Seconds}";
        }
        public string Format(int totalSeconds)
        {
            int minutes = totalSeconds / 60;
            Math.DivRem(minutes, 60, out int seconds);
            return $"{minutes}:{seconds}";
        }
    }
}
