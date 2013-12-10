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
            if (Request.QueryString["lat"] != null && Request.QueryString["lng"] != null)
            {
                CrimeInfo crimeList = new CrimeInfo(Request.QueryString["lat"].ToString(), Request.QueryString["lng"].ToString());
                mainContent.Text = crimeList.html;
                place.Text = "your location";
            }
            else
            {
                CrimeInfo crimeList = new CrimeInfo();
                mainContent.Text = crimeList.html;
                place.Text = "Liverpool";
            }
        }
    }
}