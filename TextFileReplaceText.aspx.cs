using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Demos_TextFileReplaceText : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string filename = Server.MapPath("~/Demos/TextFileReplaceText.txt");
        string readthefile = File.ReadAllText(filename);
        readthefile = readthefile.Replace("##name1##", "Teresa Crothers");
        readthefile = readthefile.Replace("##name2##", "Cullan Crothers");
        Label1.Text = readthefile;
    }
}