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
        public string html { get; private set; }

        public CrimeInfo(string lat = "53.408536", string lng = "-2.961452", string date = "2012-12")
        {
            string url = "http://data.police.uk/api/crimes-street/all-crime?date=" + date + "&lat=" + lat + "&lng=" + lng;
            string json = RetrieveJson(url);
            crimes = JsonConvert.DeserializeObject<List<Crime>>(json);
            html = BuildOutput();
        }

        private string RetrieveJson(string url)
        {
            string json = new WebClient().DownloadString(url);
            return json;
        }

        public string BuildOutput()
        {
            string output = "";

            Random rnd = new Random();
            int n = 0;

            while (n < 10)
            {
                Crime c = this.crimes[rnd.Next(this.crimes.Count)];

                if (c.persistent_id != null && c.outcome_status != null)
                {
                    output +=
                    @"<div class='crime clearfix'>" +

                        @"<div class='streetView'>" +
                            //Placeholder image to stop hammering the Street View API
                            //@"<img src='/placeholder.png' alt='Image' />" +

                            @"<img src='http://maps.googleapis.com/maps/api/streetview?size=640x480&location=" + c.location.latitude + "," + c.location.longitude + @"&heading=0&sensor=false&key=AIzaSyBPAf4SSt1ndJ7qYLo9CJ3s48NRUbF4sKQ' alt='Image' />" +
                        @"</div>" +

                        @"<div class='crimeInfo'>" +
                            @"<p><strong>Date:</strong> " + c.month.Month.ToString() + "/" + c.month.Year.ToString() + @"</p>" +
                            @"<p><strong>Crime type:</strong> " + c.category.ToString() + @"</p>" +
                            @"<p><strong>Location:</strong> " + c.location.street.name.ToString() + @"</p>" +
                            @"<p><strong>Outcome:</strong> " + c.outcome_status.category.ToString() + @"</p>" +
                        @"</div>" +

                    @"</div>";

                    n++;
                }
            }

            return output;
        }
    }
}