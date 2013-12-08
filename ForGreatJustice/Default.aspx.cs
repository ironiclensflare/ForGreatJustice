using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace ForGreatJustice
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CrimeInfo crimeList = new CrimeInfo();
            mainContent.Text = "";
            Random rnd = new Random();
            int n = 0;

            while (n < 10)
            {
                Crime c = crimeList.crimes[rnd.Next(crimeList.crimes.Count)];

                if (c.persistent_id != "")
                {
                    mainContent.Text +=
                    @"<div class='crime clearfix'>" +

                        @"<div class='streetView'>" +
                            @"<img src='http://maps.googleapis.com/maps/api/streetview?size=640x480&location=" + c.location.latitude + "," + c.location.longitude + @"&heading=0&sensor=false' alt='Image' />" +
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
        }
    }
}