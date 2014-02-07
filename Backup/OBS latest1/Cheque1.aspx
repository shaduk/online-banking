<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Cheque1.aspx.cs" Inherits="Cheque1" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style7
    {
        width: 248px;
        height: 72px;
    }
    .style8
    {
        height: 72px;
    }
    .style9
    {
        width: 248px;
        height: 75px;
    }
    .style10
    {
        height: 75px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
    <p>
    <img alt="chequebook" src="chequebook.jpg" 
        style="width: 371px; height: 245px" /></p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

    <table class="style1">
        <tr>
            <td colspan="2">
                Apply For Cheque Book</td>
        </tr>
        <tr>
            <td class="style7">
                Select Type</td>
            <td class="style8">
                <asp:RadioButton ID="Bearer" runat="server" Text="Bearer" GroupName="type" />
                <br />
                <asp:RadioButton ID="RadioButton1" runat="server" Text="Order" 
                    GroupName="type" />
            </td>
        </tr>
        <tr>
            <td class="style9">
                Number of pages</td>
            <td class="style10">
                <asp:RadioButton ID="RadioButton2" runat="server" Text="30 " 
                    GroupName="npages" />
                <br />
                <asp:RadioButton ID="RadioButton3" runat="server" Text="60 " 
                    GroupName="npages" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
            <asp:Button ID="btnApply" runat="server" style="margin-left: 344px" 
                    Text="Apply" onclick="btnApply_Click" />
            
                &nbsp;</td>
        </tr>
    </table>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

