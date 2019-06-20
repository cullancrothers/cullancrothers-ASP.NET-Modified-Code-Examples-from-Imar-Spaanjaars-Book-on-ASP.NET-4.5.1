using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Demos_Conditionals : BasePage
{
    string username = "Administrator";
    //string username = "Guest";
    protected void Page_Load(object sender, EventArgs e)
    {
        if(username == "Administrator")
        {
            Button1.Visible = true;
        }
        else
        {
            Button1.Visible = false;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Convert.ToInt32(TextBox1.Text) > Convert.ToInt32(TextBox2.Text))
        {
            Label3.Text = TextBox1.Text + " is greater than " + TextBox2.Text;
        }
        else
        {
            Label3.Text = TextBox1.Text + " is not greater than " + TextBox2.Text;
        }
    }
}