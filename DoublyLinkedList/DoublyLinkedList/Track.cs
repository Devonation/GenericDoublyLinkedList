using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    internal class Track
    {
        public Track(string title, string artist, CustomTime duration)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
        }

        public string Title { get; set; }
        public string Artist { get; set; }
        public CustomTime Duration { get; set; }
    }
}
