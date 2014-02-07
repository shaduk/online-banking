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


public partial class PerformTransfer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label2.Visible = false;
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
        while(dr.Read())
        {
        DropDownList1 .Items .Add (dr[0].ToString ());

        }

    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
      string Value =DropDownList1.SelectedItem.Value.ToString ()  ;
    
      SqlConnection con = new SqlConnection();
      con.ConnectionString = "Data Source=SHAD-PC;Initial Catalog=BankDB;Integrated Security=true;";

      //Opening Conection
      con.Open();

      //assinging SQLQuery and conn to sqlcommand class
      SqlCommand cmd = new SqlCommand("select acc_balance from Accounts where acc_no = @accno", con);
      //definging datatype of temporary variables

      cmd.Parameters.Add("@accno", SqlDbType.Int);
      cmd.Parameters["@accno"].Value = Value;
      int val = 0;
      SqlDataReader dr = cmd.ExecuteReader();
      if(dr.Read())
      {
           val = Convert .ToInt32 (dr[0]);
          
      }
      Label2.Visible = true;
      Label2.Text = "Balance is:" + val; 
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Obs1.dll.Transaction t = new Obs1.dll.Transaction();

        int Sacno = Convert .ToInt32 (DropDownList1.SelectedItem.Value);
        int Racno = Convert.ToInt32 (TextBox2.Text);
        int amt = Convert .ToInt32 (Amount.Text);
       bool var =  t.MakeTransfer(Racno,amt,Sacno );
       if (var == false)
       {
           var Message = new JavaScriptSerializer().Serialize("Insufficient funds or invalid account");
           var script = string.Format("alert({0});", Message);
           ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, true);
      }


      
       if (var == true)
       {
           t.Transfertran(Racno, amt, Sacno);

           Label1.Text = "Successfully transferred INR." + amt + " to account no " + Racno;
          
       
       }


    }

    protected void btnGoBack_Click(object sender, EventArgs e)
    {
     
    }
}
