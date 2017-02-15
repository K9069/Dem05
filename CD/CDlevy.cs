using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD
{
    class CDlevy
    {
        public string Album { get; set; }
        public string Artist { get; set; }
        public string Song { get; set; }
        public string Time { get; set; }

        public override string ToString()
        {
            return Album + " " + Artist + " " + Song + " " + Time;
        }
    }
}