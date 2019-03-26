using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webApiSession2.Models
{
    public class WeatherReport
    {
        public string country { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string location { get; set; }
        public int temp { get; set; }

    }
}