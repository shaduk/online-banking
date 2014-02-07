<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SavingAccount.aspx.cs" Inherits="SavingAccount" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <p>
    <br />
        Savings
    Account Summary</p>
<p>
    Welcome
    <asp:Label ID="CustomerName" runat="server" Text="Label"></asp:Label>
</p>
<p>
    &nbsp;</p>
<p>
    <asp:GridView ID="GridView1" runat="server" Width="439px">
    </asp:GridView>
</p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

