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

public partial class changePassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnChangePassword_Click(object sender, EventArgs e)
    {
        Obs1.dll.Customer c = new Obs1.dll.Customer();
        bool val = c.ChangePassword(TextOldPassword.Text, TextNewPassword.Text);

        if (val == true)
        {
            var Message = new JavaScriptSerializer().Serialize("Password Successfully Changed");
           var script = string.Format("alert({0});", Message);
           ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, true);
            Response.Redirect("Passapproval.aspx");
        }
        else 
        {

            Label1.Text = "password is not correct";
        }
    }
}