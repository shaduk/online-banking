<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PerformTransfer.aspx.cs" Inherits="PerformTransfer" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style7
    {
        width: 153px;
    }
        .style9
        {
            width: 164px;
            height: 59px;
        }
        .style10
        {
            height: 59px;
        }
        .style11
        {
            height: 118px;
        }
        .style12
        {
            width: 164px;
            height: 8px;
        }
        .style13
        {
            width: 4px;
        }
        .style14
        {
            height: 59px;
            width: 4px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">

    <p style="background-image: url('images2.jpg'); background-repeat: no-repeat; background-position: center center; height: 306px;">
</p>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

    <table class="style1">
        <tr>
            <td class="style6" colspan="2">
                Transfer</td>
            <td class="style6">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style12">
                Account Holder Acno</td>
            <td class="style13">
                <asp:DropDownList ID="DropDownList1" runat="server" 
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged" Width="87px" 
                    Height="19px" style="margin-left: 0px">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style12">
                Receiver&#39;s Account No</td>
            <td class="style13">
                <asp:TextBox ID="TextBox2" runat="server" Height="22px" Width="91px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style9">
                Amount To be Transfered</td>
            <td class="style14">
                <asp:TextBox ID="Amount" runat="server" Height="25px" Width="88px"></asp:TextBox>
            </td>
            <td class="style10">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2" class="style11">
                <asp:Button ID="Button1" runat="server" style="margin-left: 291px" 
            Text="Proceed" onclick="Button1_Click" />
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
            <td class="style11">
                &nbsp;</td>
        </tr>
    </table>




</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

