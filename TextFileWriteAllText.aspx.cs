using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Demos_TextFileWriteAllText : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string filename = Server.MapPath("~/App_Code/TextFileMove.txt");
        string str = "Teresa and Cullan Crothers\r\n604 Parkway RD Brandon, MS 39047";
        File.WriteAllText(filename, str);
    }
}