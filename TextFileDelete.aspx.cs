using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Demos_TextFileDelete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        if(File.Exists(Server.MapPath("~/Demos/TextFileCreateNew2.txt")))
        {
            string filename = Server.MapPath("~/Demos/TextFileCreateNew2.txt");
            File.Delete(filename);
        }
        else
        {
            //Not needed right now
        }
    }
}


