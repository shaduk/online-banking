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

public partial class Default3 : System.Web.UI.Page
{
    int s = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

         s=  Convert .ToInt32 (Request.QueryString["CustId"]);
        
         
    }
    protected void Button1_Click(object sender, EventArgs e)
    { 
        
        

        SqlConnection con1 = new SqlConnection();
        con1.ConnectionString = "Data Source=SHAD-PC;Initial Catalog=BankDB;Integrated security=true";
        con1.Open();
        SqlCommand cmd = new SqlCommand("update client  set password = @pass where cust_id = @cid ", con1);
        cmd.Parameters.Add("@cid", SqlDbType.Int);
        cmd.Parameters["@cid"].Value = s;
        cmd.Parameters.Add("@pass", SqlDbType.VarChar );
        cmd.Parameters["@pass"].Value = TextBox2.Text;


        cmd.ExecuteNonQuery();
       
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
}
