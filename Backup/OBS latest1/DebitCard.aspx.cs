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

public partial class DebitCard : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int cid = Convert.ToInt32(Session["Name"]);

        SqlConnection con1 = new SqlConnection();
        con1.ConnectionString = "Data Source=SHAD-PC;Initial Catalog=BankDB;Integrated security=true";
        con1.Open();
        SqlCommand cmd = new SqlCommand("select card_id from Debitcard where cust_id = @cust ", con1);
        cmd.Parameters.Add("@cust", SqlDbType.Int);
        cmd.Parameters["@cust"].Value = cid;

        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            Response.Redirect("Applieddebitcard.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int cid = Convert.ToInt32(Session["Name"]);
        string card_type = null;
        if (RadioButton1.Checked == true)
        {

            card_type = RadioButton1.Text;

        }
        if (RadioButton2.Checked == true)
        {

            card_type = RadioButton2.Text;

        }
        if (RadioButton3.Checked == true)
        {

            card_type = RadioButton3.Text;

        }
        Obs1.dll.DebitCard d = new Obs1.dll.DebitCard();
        bool var = d.request_debitcard(cid, card_type);
        if (var == true)
        {

            var Message = new JavaScriptSerializer().Serialize("Request Received");
            var script = string.Format("alert({0});", Message);
            ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, true);
        }
    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {

    }
}
