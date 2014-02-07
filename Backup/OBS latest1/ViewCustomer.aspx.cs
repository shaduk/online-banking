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
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con1 = new SqlConnection();
        con1.ConnectionString = "Data Source=SHAD-PC;Initial Catalog=BankDB;Integrated security=true";
        con1.Open();

        SqlCommand cmd = new SqlCommand("select * from client ", con1);
        SqlDataReader dr= cmd.ExecuteReader ();
        DataTable dt= new DataTable ();
        dt.Load (dr);
        GridView1.DataSource = dt;
        GridView1.DataBind();




    }
}
