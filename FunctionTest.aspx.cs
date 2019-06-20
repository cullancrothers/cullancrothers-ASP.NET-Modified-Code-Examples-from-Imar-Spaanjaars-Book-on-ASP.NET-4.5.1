using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Demos_FunctionTest : BasePage
{
    public int AddIt(int a, int b)
    {
        return a + b;
    }
    public string ConcatIt(string fname, string lname)
    {
        return fname + " " + lname;
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int TotalIt;
        TotalIt = AddIt(4, 6);
        Label1.Text = TotalIt.ToString();

        string FullName;
        FullName = ConcatIt("Teresa", "Crothers");
        Label2.Text = FullName;
    }
}