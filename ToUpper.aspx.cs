using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Demos_ToUpper : BasePage
{
    public string ConcatIt(string fname, string lname)
    {
        int fnamelength = fname.Length - 1;
        int lnamelength = lname.Length - 1;
        fname = fname.Substring(0, 1).ToUpper() + fname.Substring(1,fnamelength);
        lname = lname.Substring(0, 1).ToUpper() + lname.Substring(1,lnamelength);
        return fname + " " + lname;
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string fname = TextBox1.Text;
        string lname = TextBox2.Text;
        string FullName = ConcatIt(fname, lname);
        Label3.Text = FullName;
        Label4.Text = FullName.Length.ToString();
    }
}