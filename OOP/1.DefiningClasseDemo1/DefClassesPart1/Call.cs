using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefClassesPart1
{
    public class Call
    {
        public DateTime DateTime { get; set; }

        public string DialedNumber { get; set; }

        public int Duration { get; set; }

        public Call(DateTime dateTime, string number, int duration)
        {
            this.DateTime = dateTime;
            this.DialedNumber = number;
            this.Duration = duration;
        }
    }
}
