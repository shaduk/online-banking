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

public partial class AddAccount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       

    }
    protected void btnAddAccount_Click(object sender, EventArgs e)
    {
        SqlConnection cons = new SqlConnection();

        cons.ConnectionString = "Data Source=SHAD-PC; Initial Catalog= BankDB; Integrated Security=true;";
        cons.Open();
        SqlCommand cmds = new SqlCommand("select * from Accounts where cust_id = @cust and  acc_type = @acctype", cons);

        cmds.Parameters.Add("@cust", SqlDbType.Int );
        cmds.Parameters["@cust"].Value = Convert .ToInt32 (TextBox1.Text);
        cmds.Parameters.Add("@acctype", SqlDbType.VarChar );
        cmds.Parameters["@acctype"].Value = DropDownList1 .SelectedItem .Value .ToString ();

        string value = DropDownList1.SelectedItem.Value.ToString();
        SqlDataReader dr = cmds.ExecuteReader();
        if (dr.Read())
        {
            var Message1 = new JavaScriptSerializer().Serialize(value + " already exists");
            var script1 = string.Format("alert({0});", Message1);
            ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script1, true);



        }
        else 
        
        {

            SqlConnection con2 = new SqlConnection();
            con2.ConnectionString = "Data Source=. ;Initial Catalog=BankDB;Integrated security=true";
            con2.Open();
            SqlCommand cmd1 = new SqlCommand("Insert into Accounts values(@cust,@acc_type,@acc_bal)", con2);
            cmd1.Parameters.Add("@cust", SqlDbType.Int);
            cmd1.Parameters["@cust"].Value = Convert .ToInt32 (TextBox1.Text);
            cmd1.Parameters.Add("@acc_type", SqlDbType.VarChar );
            cmd1.Parameters["@acc_type"].Value = DropDownList1.SelectedItem.Value.ToString();

            cmd1.Parameters.Add("@acc_bal", SqlDbType.Int );
        

            cmd1.Parameters["@acc_bal"].Value = Convert .ToInt32 (TextBox2.Text);
            cmd1.ExecuteNonQuery();
            var Message = new JavaScriptSerializer().Serialize("New Account added successfully");
            var script = string.Format("alert({0});", Message);
            ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, true);
        
        }
        
        
        
      
    }
}
