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

public partial class CurrentAccount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int val = Convert.ToInt32(Session["Name"]);

        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SHAD-PC;Initial Catalog=BankDB;Integrated Security=true;";

        //Opening Conection
        con.Open();

        //assinging SQLQuery and conn to sqlcommand class
        SqlCommand cmd = new SqlCommand("select * from client where cust_id = @cust", con);
        //definging datatype of temporary variables

        cmd.Parameters.Add("@cust", SqlDbType.Int);
        cmd.Parameters["@cust"].Value = val;

        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            CustomerName.Text = dr[2].ToString();
        }
        Obs1.dll.Account a = new Obs1.dll.Account();
        DataTable dt1 = a.account_detailsCur(val);

        GridView1.DataSource = dt1;
        GridView1.DataBind();





    }
}