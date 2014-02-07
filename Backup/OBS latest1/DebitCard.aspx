<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DebitCard.aspx.cs" Inherits="DebitCard" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style7
        {
            height: 50px;
        }
    .style8
    {
        height: 50px;
        width: 227px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
    <p>
    <img alt="debitcard" src="Copy%20of%20credit_cards.jpg" 
        style="width: 425px; height: 224px" /></p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="style1">
        <tr>
            <td colspan="2">
                Apply for Debit Card</td>
        </tr>
        <tr>
            <td class="style8">
                Select Card Type</td>
            <td class="style7">
                <asp:RadioButton ID="RadioButton1" runat="server" Text="Platinum" 
                    GroupName="cardType" />
                <br />
                <asp:RadioButton ID="RadioButton2" runat="server" Text="Gold" 
                    GroupName="cardType" oncheckedchanged="RadioButton2_CheckedChanged" />
                <br />
                <asp:RadioButton ID="RadioButton3" runat="server" Text="Silver" 
                    GroupName="cardType" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
            <asp:Button ID="Button1" runat="server" style="margin-left: 238px" 
                    Text="Apply" onclick="Button1_Click" />
            
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

