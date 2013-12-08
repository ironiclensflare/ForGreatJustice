using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Net;
using System.Collections;

namespace ForGreatJustice
{
    public class CrimeInfo
    {
        public List<Crime> crimes { get; private set; }

        public CrimeInfo()
        {
            string url = "http://data.police.uk/api/crimes-street/all-crime?date=2012-12&lat=52.953472&lng=-1.149370";
            string json = RetrieveJson(url);
            crimes = JsonConvert.DeserializeObject<List<Crime>>(json);
        }

        private string RetrieveJson(string url)
        {
            string json = new WebClient().DownloadString(url);
            return json;
        }
    }
}