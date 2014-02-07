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

public partial class ApplyForLoan1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {   if(!IsPostBack )
    {
        ddlAccountType.Items.Clear();
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
            ddlAccountType.Items.Add(dr[0].ToString());

        }
        
        }
    }
    protected void btnApplyForLoan_Click(object sender, EventArgs e)
    {
        int val = Convert.ToInt32(Session["Name"]);
        SqlConnection con1 = new SqlConnection();
        con1.ConnectionString = "Data Source=SHAD-PC;Initial Catalog=BankDB;Integrated security=true";
        con1.Open();
        SqlCommand cmd = new SqlCommand("select acc_no ,acc_type from Accounts where cust_id = @cust ", con1);
        cmd.Parameters.Add("@cust", SqlDbType.Int);
        cmd.Parameters["@cust"].Value = val;

        SqlDataReader dr = cmd.ExecuteReader();
        int Acccur = 0 ;
        string Sav = "Savings Account";
        string Sac = "Current Account";
         int Accsav = 0 ;
        while (dr.Read())
        {
            if (Sav== dr[1].ToString () )
            {
                 Accsav = Convert .ToInt32 (dr[0]);
            
            }
            if (Sac == dr[1].ToString ())
            {
                 Acccur = Convert.ToInt32(dr[0]);

            }
           
      
        }


        Obs1.dll.Loan l = new Obs1.dll.Loan();

        bool value = l.CheckStatus(Accsav, Acccur);
        if (value == true)
        {
            int cid = Convert .ToInt32 (Session["Name"]);
            int acno = Convert.ToInt32(ddlAccountType.SelectedItem.Value);
            Session["acno"] = Convert.ToInt32(ddlAccountType.SelectedItem.Value);

            double lamt = Convert.ToDouble(DropDownList2.SelectedItem.Value);
            string ltype = DropDownList1.SelectedItem.Value.ToString();
            int noofyears = Convert.ToInt32(dropdownyears.SelectedItem.Value);
            Session["nyears"] = noofyears;
            int salarypmonth = Convert.ToInt32(TextBoxsalary.Text);
            if (rdbAgree.Checked == true)
            {

               l.ApplyLoan(acno, lamt, ltype, noofyears, salarypmonth,cid );
                
               
                
                var Message = new JavaScriptSerializer().Serialize("Added Successfullly the request" );
                var script = string.Format("alert({0});", Message);
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, true);



            }

            else
            {



                var Message = new JavaScriptSerializer().Serialize("Plz be ready with your documents");
                var script = string.Format("alert({0});", Message);
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, true);
            }
        }
        else
        {

            var Message1 = new JavaScriptSerializer().Serialize("Already a loan exixts on your account");
            var script1 = string.Format("alert({0});", Message1);
            ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script1, true);
        
        }
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
