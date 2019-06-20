using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Demos_link_test_2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("<H1>This is the page!<BR>");
        //Response.Write(Request.QueryString[0].ToString() + " ");
        //Response.Write(Request.QueryString[1].ToString() + "!<BR>");
        Response.Write(Request["greeting"].ToString() + " ");
        Response.Write(Request["name"].ToString() + "!");
    }
}