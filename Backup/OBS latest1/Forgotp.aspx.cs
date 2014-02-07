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
using System.Web.Script.Serialization;
using System.Data.SqlClient;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        SqlConnection con1 = new SqlConnection();
        con1.ConnectionString = "Data Source=SHAD-PC;Initial Catalog=BankDB;Integrated security=true";
        con1.Open();
        SqlCommand cmd = new SqlCommand("select * from client where cust_id = @cid  and pan_no = @panno  ", con1);
        cmd.Parameters.Add("@cid", SqlDbType.Int);
        cmd.Parameters["@cid"].Value = Convert.ToInt32(TextBox1 .Text );
        cmd.Parameters.Add("@panno", SqlDbType.Int);
        cmd.Parameters["@panno"].Value = Convert.ToInt32(TextBox2 .Text );
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            Response.Redirect("forgotpassChange.aspx?CustId="+TextBox1.Text );
            //Button1.PostBackUrl = "forgotpassChange.aspx";





        }

        else 
        
        {
            var Message = new JavaScriptSerializer().Serialize("Record doesnot exist");
            var script = string.Format("alert({0});", Message);
            ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, true);

        
        }

        
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
}
