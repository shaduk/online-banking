<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="changePassword.aspx.cs" Inherits="changePassword" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style9
    {
        width: 100%;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="style9">
    <tr>
        <td colspan="2">
            Change Password</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Old Password</td>
        <td>
            <asp:TextBox ID="TextOldPassword" runat="server" TextMode="Password"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ErrorMessage="Enter Correct Password" ControlToValidate="TextOldPassword"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            New Password</td>
        <td>
            <asp:TextBox ID="TextNewPassword" runat="server" TextMode="Password"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ErrorMessage="Enter Atleast 8 Characters" 
                ControlToValidate="TextNewPassword"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            Confirm Password</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                ErrorMessage="Password Doesn't Match" ControlToCompare="TextNewPassword" 
                ControlToValidate="TextBox1"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <br />
            <br />
            <br />
            <asp:Button ID="btnChangePassword" runat="server" Text="Change Password" 
                onclick="btnChangePassword_Click" />
        </td>
        <td>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </td>
    </tr>
</table>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

