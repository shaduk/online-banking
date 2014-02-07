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

public partial class Cheque1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int cid = Convert.ToInt32(Session["Name"]);
        
        SqlConnection con1 = new SqlConnection();
        con1.ConnectionString = "Data Source=SHAD-PC;Initial Catalog=BankDB;Integrated security=true";
        con1.Open();
        SqlCommand cmd = new SqlCommand("select cheque_id from checkbook where cust_id = @cust ", con1);
        cmd.Parameters.Add("@cust", SqlDbType.Int);
        cmd.Parameters["@cust"].Value = cid;

        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            Response.Redirect("Appliedcheckbook.aspx");
        }
    }
    protected void btnApply_Click(object sender, EventArgs e)
    {

        int cid = Convert.ToInt32(Session["Name"]);
        string ctype = null;
        if (Bearer.Checked == true)
        {
            ctype = Bearer.Text;


        }
        if (RadioButton1.Checked == true)
        {
            ctype = RadioButton1.Text;


        }


        int noofpages = 0;

        if (RadioButton2.Checked == true)
        {
            noofpages = Convert .ToInt32 (RadioButton2.Text);


        }
        if (RadioButton3.Checked == true)
        {
            noofpages = Convert .ToInt32 (RadioButton3.Text);


        }
        Obs1.dll.Cheque c = new Obs1.dll.Cheque();
        bool v = c.request_chequebook(cid, ctype, noofpages);

        if (v == true)
        {

            var Message = new JavaScriptSerializer().Serialize("Cheque Book Request Received");
            var script = string.Format("alert({0});", Message);
            ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, true);



            
        }
    }
    protected void btnGoBack_Click(object sender, EventArgs e)
    {

    }
}
