using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Demos_TextFileReadAllText : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string filename = Server.MapPath("~/App_Code/TextFileMove.txt");
        string str = File.ReadAllText(filename);
        Label1.Text = str;
    }
}