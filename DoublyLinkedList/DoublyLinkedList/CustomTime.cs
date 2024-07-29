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
    }
}
