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

public partial class Requests : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        foreach (var item in Page.Controls)
        {
            if (item is TextBox)
            {
                ((TextBox)item).Text = "";

            }

        }



        //if (!IsPostBack)
        //{
        if (Radiobtnloans.Checked == true)
        {
            Label3.Text = "Loan Id";
            Label4.Text = "Loan Type";

            SqlConnection con = new SqlConnection("Data source = SHAD-PC; initial catalog=BankDB;integrated security = true");
            con.Open();
            SqlCommand cmd = new SqlCommand("select  loan_id,loan_type ,loan_amt ,accno ,emi_amt ,salaryPmonth ,loan_status ,emi_rem from LoanHistory ", con);

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            GridViewRequests.DataSource = dt;
            GridViewRequests.DataBind();

        }

        if (RadiobtnDebitCard.Checked == true)
        {
            Label3.Text = "Card Id";
            Label4.Text = "Card Type";
            SqlConnection con = new SqlConnection("Data source = SHAD-PC; initial catalog=BankDB;integrated security = true");
            con.Open();
            SqlCommand cmd = new SqlCommand("select  * from Debitcard ", con);

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            GridViewRequests.DataSource = dt;
            GridViewRequests.DataBind();

        }

        if (RadiobtnChequeBook.Checked == true)
        {
            Label3.Text = "Cheque Id";
            Label4.Text = "Cheque Type";

            SqlConnection con = new SqlConnection("Data source = SHAD-PC; initial catalog=BankDB;integrated security = true");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from checkbook ", con);

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            GridViewRequests.DataSource = dt;
            GridViewRequests.DataBind();

        }




        // }

    }
    protected void RequestDetailsView_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        if (Radiobtnloans.Checked == true)
        {
            

            int accno = 0;
            int nyears = 0;
            int Lid = Convert.ToInt32(TextLoan.Text);
            string Ltype = TextBoxltype.Text;
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "Data Source=SHAD-PC;Initial Catalog=BankDB;Integrated security=true";
            con1.Open();
            SqlCommand cmd = new SqlCommand("select acc_no ,nyears from LoanCust where loan_id = @lid ", con1);
            cmd.Parameters.Add("@lid", SqlDbType.Int);
            cmd.Parameters["@lid"].Value = Lid;

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                accno = Convert.ToInt32(dr[0]);
                nyears = Convert.ToInt32(dr[1]);
            }
            




            Obs1.dll.Transaction t = new Obs1.dll.Transaction();
            bool var2 = t.Approve(Lid, Ltype, accno, nyears);
            if (var2 == false)
            {
                var Message1 = new JavaScriptSerializer().Serialize("Loan has been already approved or disapproved");
                var script1 = string.Format("alert({0});", Message1);
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script1, true);


            }
            else
            {
                var Message = new JavaScriptSerializer().Serialize("Loan has Been  Approved");
                var script = string.Format("alert({0});", Message);
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, true);

                GridViewRequests.Visible = false;

            }

        }

        if (RadiobtnDebitCard.Checked == true)
        {
            
            int card_id = Convert.ToInt32(TextLoan.Text);
            Obs1.dll.DebitCard d = new Obs1.dll.DebitCard();
            bool var = d.ApproveDebitc(card_id);
            if (var == true)
            {

                var Message = new JavaScriptSerializer().Serialize("DebitCard has Been  Approved");
                var script = string.Format("alert({0});", Message);
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, true);

                GridViewRequests.Visible = false;


            }






        }

        if (RadiobtnChequeBook.Checked == true)
        {
            
            int card_id = Convert.ToInt32(TextLoan.Text);
            Obs1.dll.Cheque c = new Obs1.dll.Cheque();

            bool var = c.ApproveCheckbook(card_id);
            if (var == true)
            {

                var Message = new JavaScriptSerializer().Serialize("CHeckbook has Been  Approved");
                var script = string.Format("alert({0});", Message);
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, true);

                GridViewRequests.Visible = false;





            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (RadiobtnChequeBook.Checked == true)
        {
            int card_id = Convert.ToInt32(TextLoan.Text);
            Obs1.dll.Cheque c = new Obs1.dll.Cheque();
            bool var = c.DisApproveCheckbook(card_id);

           
            if (var == true)
            {

                var Message = new JavaScriptSerializer().Serialize("CHeckbook has Been  DisApproved");
                var script = string.Format("alert({0});", Message);
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, true);

                GridViewRequests.Visible = false;





            }
        }


        if (Radiobtnloans.Checked == true)
        {
            int card_id = Convert.ToInt32(TextLoan.Text);
            Obs1.dll.Loan c = new Obs1.dll.Loan();
             string Ltype = TextBoxltype.Text;
            bool var = c.disApprove (card_id ,Ltype );
            if (var == true)
            {

                var Message = new JavaScriptSerializer().Serialize("Loan has Been  disapproved");
                var script = string.Format("alert({0});", Message);
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, true);

                GridViewRequests.Visible = false;





            }
        }

        if (RadiobtnDebitCard .Checked ==true )
        {
            int card_id = Convert.ToInt32(TextLoan.Text);
            Obs1.dll.DebitCard d = new Obs1.dll.DebitCard();

            bool  var = d.DisApproveDebitc(card_id);
            if (var == true)
            {

                var Message = new JavaScriptSerializer().Serialize("Debitcard has Been  Approved");
                var script = string.Format("alert({0});", Message);
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, true);

                GridViewRequests.Visible = false;





            }

        }

    }
}