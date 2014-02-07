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

public partial class LoanHistory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownList1.Items.Clear();

            int val = Convert.ToInt32(Session["Name"]);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=SHAD-PC;Initial Catalog=BankDB;Integrated Security=true;";

            //Opening Conection
            con.Open();

            //assinging SQLQuery and conn to sqlcommand class
            SqlCommand cmd = new SqlCommand("select * from Accounts where cust_id = @cust", con);
            //definging datatype of temporary variables

            cmd.Parameters.Add("@cust", SqlDbType.Int);
            cmd.Parameters["@cust"].Value = val;

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DropDownList1.Items.Add(dr[0].ToString());

            }

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Obs1.dll.Loan l = new Obs1.dll.Loan();
        int value = Convert.ToInt32(DropDownList1.SelectedItem.Value);
        DataTable dt = l.LoanHistory(value);

        GridView1.DataSource = dt;
        GridView1.DataBind();
        
    }
}
