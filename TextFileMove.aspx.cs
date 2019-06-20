using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Demos_TextFileMove : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string sourcefilename = Server.MapPath("~/Demos/TextFileMove.txt");
        string destfilename = Server.MapPath("~/App_Code/TextFileMove.txt");
        File.Move(sourcefilename, destfilename);
    }
}