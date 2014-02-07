<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LoanPayment.aspx.cs" Inherits="LoanHistory" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="uh" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
    <p>
    <img alt="trans" src="transaction.jpg" style="width: 420px; height: 265px" /></p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div style="margin-left: 160px; height: 34px;">
    
        LOAN PAYMENT<br />
        <br />
        <br />
        LoanID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        LoanType&nbsp;
        <asp:DropDownList ID="DropDownListltype" runat="server">
            <asp:ListItem>Home Loan</asp:ListItem>
            <asp:ListItem>Educational Loan</asp:ListItem>
            <asp:ListItem>Personal Loan</asp:ListItem>
            <asp:ListItem>Vehicle Loan</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" 
            onclick="Button2_Click" Text="Payment" />
        &nbsp;&nbsp;
        <br />
        <br />
        
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <br />
    
    </div>
        


    


</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

