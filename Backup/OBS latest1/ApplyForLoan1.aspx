<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ApplyForLoan1.aspx.cs" Inherits="ApplyForLoan1" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style9
        {
            height: 66px;
        }
        .style10
        {
            height: 74px;
        }
        .style11
        {
            height: 75px;
        }
        .style12
        {
            height: 80px;
        }
        .style13
        {
            height: 72px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
    <p>
    <img alt="loan" src="Copy%20of%20home-loan-1.jpg" 
        style="width: 412px; height: 758px" /></p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style9">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Account No</td>
                <td class="style9">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:DropDownList ID="ddlAccountType" runat="server">
                    </asp:DropDownList>
                </td>
                <td class="style9">
                    </td>
            </tr>
            <tr>
                <td class="style10">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Loan Amount</td>
                <td class="style10">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList 
                        ID="DropDownList2" runat="server" 
                        onselectedindexchanged="DropDownList2_SelectedIndexChanged">
                        <asp:ListItem>100000</asp:ListItem>
                        <asp:ListItem>200000</asp:ListItem>
                        <asp:ListItem>300000</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;&nbsp; 
                    &nbsp;</td>
                <td class="style10">
                    </td>
            </tr>
            <tr>
                <td class="style11">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Loan Type&nbsp;</td>
                <td class="style11">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Home Loan</asp:ListItem>
                        <asp:ListItem>Vehicle Loan</asp:ListItem>
                        <asp:ListItem>Education Loan</asp:ListItem>
                        <asp:ListItem>Personal Loan</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style11">
                    </td>
            </tr>
            
            <tr>
                <td class="style12">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; No of Years&nbsp;</td>
                <td class="style12">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="dropdownyears" runat="server" Height="19px" Width="64px">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;</td>
                <td class="style12">
                    </td>
            </tr>
            
            <tr>
                <td class="style13">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SalaryPerMonth&nbsp;</td>
                <td class="style13">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="TextBoxsalary" 
                        runat="server"></asp:TextBox>
                </td>
                <td class="style13">
                    </td>
            </tr>
            
            <tr>
                <td class="style2" colspan="2">
                    &nbsp; &nbsp;I have all the documents required for applying for the loan<br />
&nbsp;&nbsp;
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RadioButton ID="rdbAgree" runat="server" Text="Agree" GroupName="m" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RadioButton ID="rdbDisagree" runat="server" Text="Disagree" 
                        GroupName="m" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnApplyForLoan" runat="server" Text="Apply For Loan" 
                        Width="137px" onclick="btnApplyForLoan_Click" />
                </td>
                <td class="style2">
                    &nbsp;</td>
            </tr>
        </table>
&nbsp;</div>


</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

