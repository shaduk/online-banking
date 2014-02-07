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

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        
        for (int i = 0; i <= 31; i++)
        {

            Droplistday.Items.Add(i.ToString ());
        
        }

        for (int i = 1978; i <= 1994; i++)
        {
            DropDownLyear.Items.Add(i.ToString ());
        
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int val = 0;
        Obs1.dll.Account a = new Obs1.dll.Account();

        string pass = TextBoxpass.Text;
        string gender = null;
        if (RadioButtonmale.Checked == true)

            gender = RadioButtonmale.Text;
        if (RadioButtonfemale.Checked == true)
            gender = RadioButtonfemale.Text;
        string custn = TextName.Text;
        int age = Convert.ToInt32(TextBoxAge.Text);
        int cday = Convert.ToInt32(Droplistday.SelectedItem.Value);
        string cmonth = DropDownLmonth.SelectedItem.Value.ToString();
        int cyear = Convert.ToInt32(DropDownLyear.SelectedItem.Value);
        string cadd = TextBoxadd.Text;
        string phno = TextBoxphone.Text;
        int panno = Convert.ToInt32(TextBoxpan.Text);
        string cemail = TextBoxemail.Text;
        string vertype = Verfittype.SelectedItem.Value.ToString();
        string verid = Textverid.Text;

        SqlConnection cons = new SqlConnection();

        cons.ConnectionString = "Data Source=SHAD-PC; Initial Catalog= BankDB; Integrated Security=true;";
        cons.Open();
        SqlCommand cmds = new SqlCommand("select Verificationid from client ", cons);


        SqlDataReader dr = cmds.ExecuteReader();
        while (dr.Read())
        {

            if (verid == dr[0].ToString())
            {
                val = 1;
                break;

            }
        }


        if (val != 1)
        {
            bool var = a.open_cust_acc(pass, custn, gender, age, cday, cmonth, cyear, cadd, phno, panno, cemail, vertype, verid);
            if (var == true)
            {
                var Message = new JavaScriptSerializer().Serialize("Customer has been Successfully added");
                var script = string.Format("alert({0});", Message);
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, true);
                reset();
            }

            else
            {
                var Message2 = new JavaScriptSerializer().Serialize("Error Occured ! please try again");
                var script2 = string.Format("alert({0});", Message2);
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script2, true);
                reset();
            }


        


        }

        reset();
        var Message1 = new JavaScriptSerializer().Serialize("ID should be unique");
        var script1 = string.Format("alert({0});", Message1);
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script1, true);
      
            
    }
       
        
    


    public void reset()
    {

        foreach (Control control in this.Controls)
        {
            TextBox box = control as TextBox;
            if (box != null )
            {
                box.Text = "";
            }

            //if (control  is RadioButton)
            //{
            //    ((RadioButton )control ).Checked  = false ;
            
            
            //}


        }
    
    
    }
    
    protected void TextBox8_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBoxpass_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        int cid = 0;
        SqlConnection cons = new SqlConnection();

        cons.ConnectionString = "Data Source=SHAD-PC; Initial Catalog= OOBS; Integrated Security=true;";
        cons.Open();
        SqlCommand cmds = new SqlCommand("select * from Customers1 where =@pass", cons);
        
        cmds.Parameters.Add("@password", SqlDbType.VarChar);
        cmds.Parameters["@password"].Value = TextBoxpass .Text ;

        SqlDataReader dr = cmds.ExecuteReader();
        if (dr.Read())
        {
            cid = Convert .ToInt32 (dr[0]);

            
        }
        //Response.Redirect("AddAccount.aspx?CustId=" + TextBox1.Text);
    }
}
