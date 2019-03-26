using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WepApiWithMvc.Models
{
    public class TempData
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public decimal Temp { get; set; }
    }
}