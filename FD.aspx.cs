using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Web.Script.Serialization;
public partial class FD : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        




    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        
        
        
        var Message = new JavaScriptSerializer().Serialize("FD Request Received");
           var script = string.Format("alert({0});", Message);
           ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, true);
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        int val1 = Convert.ToInt32(Session["Name"]);

        int val = 0;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SHAD-PC;Initial Catalog=BankDB;Integrated Security=true;";

        //Opening Conection
        con.Open();

        //assinging SQLQuery and conn to sqlcommand class
        SqlCommand cmd = new SqlCommand("select * from Accounts where cust_id = @cust", con);
        //definging datatype of temporary variables

        cmd.Parameters.Add("@cust", SqlDbType.Int);
        cmd.Parameters["@cust"].Value = val1;

        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            val = Convert.ToInt32(dr[0]);

        }
        Obs1.dll.FixedDeposit f = new Obs1.dll.FixedDeposit();
        DataTable dt1 = f.ViewFdDetails(val);

        GridView1.DataSource = dt1;
        GridView1.DataBind();



    }
}
