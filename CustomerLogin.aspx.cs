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

public partial class CustomerLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnChangePassword_Click(object sender, EventArgs e)
    {
        int Value = 0;
        SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=SHAD-PC;Initial Catalog=BankDB;Integrated Security=true;";

            //Opening Conection
            con.Open();
            SqlCommand cmd2 = new SqlCommand("select * from client where password = @oldpass ",con);
            cmd2.Parameters.Add("@oldpass", SqlDbType.VarChar);
            cmd2.Parameters["@oldpass"].Value = TextPass.Text ;
            SqlDataReader dr = cmd2.ExecuteReader();

            if (dr.Read())
            {
                Value = Convert .ToInt32 (dr[0]);

            }
        Session["Name"] = Value;
        if (Session["Name"] != null)
        {
            if (FormsAuthentication.Authenticate(TextUserName.Text, TextPass.Text))
            {

                FormsAuthentication.RedirectFromLoginPage(TextUserName.Text, false);


            }
            else
            {
                Label1.Text = "Invalid entry";


            }

            Obs1.dll.Customer c = new Obs1.dll.Customer();
            bool var = c.Login(TextUserName.Text, TextPass.Text);

            if (var == true)
            {
                Response.Redirect("SavingAccount.aspx");



            }
            else
            {


                Label1.Text = "Fields provided are not correct";
            }
        }

        else

        {
            Response.Redirect("Home.aspx");
        }
    }
}
