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


public partial class AddNewCust : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        var Message = new JavaScriptSerializer().Serialize("New customer Successfully Added");
           var script = string.Format("alert({0});", Message);
           ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, true);
    }
    protected void Button3_Click1(object sender, EventArgs e)
    {
        
    }
}
