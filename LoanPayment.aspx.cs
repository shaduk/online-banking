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

public partial class LoanHistory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int cid = Convert.ToInt32(Session["Name"]);
        int Lid = 0;
        SqlConnection con1 = new SqlConnection();
        con1.ConnectionString = "Data Source=SHAD-PC;Initial Catalog=BankDB;Integrated security=true";
        con1.Open();
        SqlCommand cmd = new SqlCommand("select loan_id from LoanCust where cust_id = @cust ", con1);
        cmd.Parameters.Add("@cust", SqlDbType.Int);
        cmd.Parameters["@cust"].Value = cid;

        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            Lid = Convert.ToInt32(dr[0]);
        }
        dr.Close();
        //SqlConnection con11 = new SqlConnection();
        //con11.ConnectionString = "Data Source=SHAD-PC;Initial Catalog=BankDB;Integrated security=true";
        //con11.Open();
        //SqlCommand cmdsa = new SqlCommand("select * from LoanHistory where loan_id = @lid  and loan_status ='Approved'", con11);
        //cmdsa.Parameters.Add("@lid", SqlDbType.Int);
        //cmdsa.Parameters["@lid"].Value = Lid;

        //SqlDataReader drn = cmdsa.ExecuteReader();
        //if (drn.Read()==false )
        //{
        //    Response.Redirect("Noapproved.aspx");

        //}

        //else
        //{
            Obs1.dll.Loan l = new Obs1.dll.Loan();
            //try
            // {
            DataTable dt = l.CurrentLoan(Lid);


            GridView1.DataSource = dt;
            GridView1.DataBind();
            //}
            //catch (Exception e1)
            //{
            //    Response.Redirect("NoapprovedLoans.aspx");

            //}

        //}
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       
       
}
    protected void Button2_Click(object sender, EventArgs e)
    {
        //int noofyears = 0;
        //int Lid = Convert.ToInt32(TextBox1.Text);
        //SqlConnection con1 = new SqlConnection();
        //con1.ConnectionString = "Data Source=SHAD-PC;Initial Catalog=BankDB;Integrated security=true";
        //con1.Open();
        //SqlCommand cmd = new SqlCommand("select nyears from LoanCust where loan_id = @lid ", con1);
        //cmd.Parameters.Add("@lid", SqlDbType.Int);
        //cmd.Parameters["@lid"].Value = Lid;

        //SqlDataReader dr = cmd.ExecuteReader();
        //if (dr.Read())
        //{
        //    noofyears = Convert.ToInt32(dr[0]);
        //}
      
      
        //string Ltype = DropDownListltype.SelectedItem.Value.ToString();
        //Obs1.dll.LoanPay lp = new Obs1.dll.LoanPay();
        //lp.Pay(Lid, noofyears, Ltype); 

        var Message = new JavaScriptSerializer().Serialize("GO TO YOUR BankDB BANK FOR PAYMENT");
        var script = string.Format("alert({0});", Message);
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, true);


    }
}
