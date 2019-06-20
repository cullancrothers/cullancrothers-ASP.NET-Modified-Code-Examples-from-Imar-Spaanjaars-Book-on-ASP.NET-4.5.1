using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Demos_Default : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string dayofweek = TextBox1.Text;
        int discount;
        switch(dayofweek)
        {
            case "Monday":
                discount = 40;
                break;
            case "Tuesday":
                discount = 30;
                break;
            case "Wednesday":
                discount = 20;
                break;
            case "Thursday":
                discount = 10;
                break;

            default:
                discount = 0;
                break;
        }
        Label2.Text = discount.ToString();
    }
}