using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Demos_LogicalOperators : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string firstname = TextBox1.Text;
        string lastname = TextBox2.Text;
        if(firstname == "Teresa" & lastname == "Crothers")
        {
            Label3.Text = "The name entered is " + firstname + " " + lastname;
        }
        else if(firstname == "Teresa" | lastname == "Crothers")
        {
            Label3.Text = "The first name entered is " + firstname + " and the last name entered is " + lastname;
        }
        /*else if (!(firstname == "Teresa") | !(firstname == "Cullan"))
        {
            Label3.Text = "The first name entered is not Cullan or Teresa";
        }*/
        else if (firstname != "Teresa" | firstname != "Cullan")
        {
            Label3.Text = "The first name entered is not Cullan or Teresa";
        }
    }
}