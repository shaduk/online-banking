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
            dr.Close();


        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "Data Source=SHAD-PC;Initial Catalog=BankDB;Integrated Security=true;";

            //Opening Conection
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("select * from transac where acc_no = @acno ", con1);
            cmd1.Parameters.Add("@acno", SqlDbType.Int);
            cmd1.Parameters["@acno"].Value = Convert.ToInt32(DropDownList1.SelectedItem.Value);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr1);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
