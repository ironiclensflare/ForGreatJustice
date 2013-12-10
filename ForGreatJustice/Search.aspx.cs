using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;

namespace ForGreatJustice
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["search"] != null)
            {
                string json = new WebClient().DownloadString("http://maps.googleapis.com/maps/api/geocode/json?sensor=false&address=" + Request.QueryString["search"].ToString());
                Response.Write(json);
            }
            else
            {
                Response.Redirect("/");
            }
        }
    }
}