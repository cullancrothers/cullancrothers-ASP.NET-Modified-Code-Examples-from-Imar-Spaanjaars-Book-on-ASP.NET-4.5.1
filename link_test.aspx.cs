using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Demos_link_test : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string greeting = "Greetings";
        string name = "Teresa Crothers";
        Response.Write("<a href='http://www.cullancrothers.com'>Team Crothers</a><BR>");
        Response.Write("<a href='link_test_2.aspx?greeting=" + greeting + "&name=" + name + "'>Link Test</a>");
    }
}