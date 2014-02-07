<%@ Page Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="style1" style="width: 69%; height: 300px;">
        <tr>
            <td colspan="2" class="style7">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                Add Customer or Account</td>
        </tr>
        <tr>
            <td class="style6">
                <asp:Button ID="Button1" runat="server" Text="Retrieve Registration Page" 
                    PostBackUrl="~/Registration.aspx" Width="170px" />
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
                <asp:Button ID="Button2" runat="server" Text="Add this customer" 
                    PostBackUrl="~/AddAccount.aspx" />
                <br />
                <br />
                <asp:Button ID="Button3" runat="server" Text="Add Account" />
            </td>
            <td class="style6">
                </td>
        </tr>
    </table>




</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

