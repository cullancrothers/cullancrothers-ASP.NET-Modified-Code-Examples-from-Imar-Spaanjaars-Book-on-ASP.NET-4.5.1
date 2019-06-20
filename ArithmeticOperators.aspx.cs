using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Demos_ArithmeticOperators : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int num1 = 100;
        float num2 = 23.5F;
        int num3 = 80;
        int num4 = 50;
        double result1 = 0;
        double result2 = 0;
        double result3 = 0;
        double result4 = 0;
        int result5 = 0;
        result1 = num1 + num2;
        result2 = num1 - num2;
        result3 = num1 * num2;
        result4 = num1 / num2;
        result5 = num3 % num4;
        TextBoxAddition.Text = result1.ToString();
        TextBoxSubtraction.Text = result2.ToString();
        TextBoxMultiplication.Text = result3.ToString();
        TextBoxDivision.Text = result4.ToString();
        TextBoxModulus.Text = result5.ToString();
    }
}