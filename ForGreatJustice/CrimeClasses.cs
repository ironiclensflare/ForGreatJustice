using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForGreatJustice
{
    public class Crime
    {
        public string category { get; set; }
        public Location location { get; set; }
        public DateTime month { get; set; }
        public string persistent_id { get; set; }
    }

    public class Location
    {
        public string latitude { get; set; }
        public string longitude { get; set; }
        public Street street { get; set; }
    }

    public class Street
    {
        public string name { get; set; }
    }

    public class OutcomeStatus
    {
        public string category { get; set; }
        public DateTime date { get; set; }
    }
}