using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Demos_HelloWorld : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("<H1>Hello World</H1>");
        Response.Write("<A HREF='http://www.cullancrothers.com'>Team Crothers</A>");
    }
}
