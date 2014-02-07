<%@ Page Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="LogOut.aspx.cs" Inherits="Query" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style6
    {
        width: 180px;
    }
    .style7
    {
        width: 229px;
    }
    .style8
    {
        width: 183px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="style1" style="width: 93%">
    <tr>
        <td class="style6">
            &nbsp;</td>
        <td class="style7">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            Queries</td>
        <td class="style8">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style6">
            &nbsp;</td>
        <td class="style7">
            <asp:GridView ID="QueryGridView" runat="server">
            </asp:GridView>
        </td>
        <td class="style8">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style6">
            &nbsp;</td>
        <td class="style7">
            <asp:DetailsView ID="QueryDetailsView" runat="server" Height="50px" 
                Width="125px">
            </asp:DetailsView>
        </td>
        <td class="style8">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style6">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Feedback&nbsp;</td>
        <td class="style7">
            <asp:TextBox ID="txtSendFeedback" runat="server" Width="236px"></asp:TextBox>
        </td>
        <td class="style8">
            <asp:Button ID="btnSendFeedBack" runat="server" Text="Send FeedBack" 
                Width="126px" />
        </td>
    </tr>
</table>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

