using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.Data;
using System.Data.SqlClient;

public partial class Demos_dbconnect : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
         var conn = new SqlConnection();
         conn.ConnectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\BegASPNET\\Site\\App_Data\\PlanetWrox.mdf;Integrated Security=True";
         conn.Open();
        
        SqlDataReader rdr = null;
        //SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\\BegASPNET\\Site\\App_Data\\PlanetWrox.mdf;Integrated Security=True");
        //conn.ConnectionString = "Provider=System.Data.SqlClient" + " Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\\PlanetWrox.mdf;Integrated  Security=True";
        SqlCommand cmd = new SqlCommand("select * from Genre", conn);
        //conn.Open();
        rdr = cmd.ExecuteReader();
        Response.Write("<Table Border=1>");
        while (rdr.Read())
        {
            // get the results of each column
            int Id = (int)rdr["Id"];
            string Name = (string)rdr["Name"];
            int SortOrder = (int)rdr["SortOrder"];
            Response.Write("<TR><TD align=center><font color=red><b>" + Id + "</b></font></TD><TD align=center>" + Name + "</TD><TD align=center>" + SortOrder + "</TD></TR>");
        }//
        Response.Write("</table>");
    }//
}//