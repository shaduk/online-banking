<%@ Page Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="CustomerLogin.aspx.cs" Inherits="CustomerLogin" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style7
        {
            width: 110px;
        }
        .style8
        {
            width: 101px;
            height: 32px;
        }
        .style9
        {
            height: 295px;
            width: 451px;
        }
        .style10
        {
            height: 32px;
            width: 81px;
        }
        .style11
        {
            width: 101px;
            height: 56px;
        }
        .style12
        {
            height: 56px;
            width: 81px;
        }
        .style13
        {
            width: 119px;
        }
        .style14
        {
            height: 56px;
            width: 119px;
        }
        .style15
        {
            height: 32px;
            width: 119px;
        }
        .style16
        {
            width: 101px;
        }
        .style17
        {
            width: 81px;
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
            Login Here!!!<br />
                                    </td>
        <td class="style13">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style16">
            User Name</td>
        <td class="style17">
            <asp:TextBox ID="TextUserName" runat="server" Height="22px"></asp:TextBox>
        </td>
        <td class="style13">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ErrorMessage="Enter User Name" ControlToValidate="TextUserName"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style16">
            Password</td>
        <td class="style17">
            <asp:TextBox ID="TextPass" runat="server" AutoCompleteType="Disabled" 
                TextMode="Password"></asp:TextBox>
        </td>
        <td class="style13">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ErrorMessage="Please Enter Correct Password" ControlToValidate="TextPass"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style11">
            </td>
        <td class="style12">
            <asp:Button ID="btnLogin" runat="server" Text="Login" 
                style="margin-left: 45px" onclick="btnChangePassword_Click" />
        </td>
        <td class="style14">
            <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
    </tr>
    <tr>
        <td class="style8">
            </td>
        <td class="style10">
            <br />
            <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Forgotp.aspx">Forgot 
            Password??</asp:HyperLink>
            <br />
            <br />
        </td>
        <td class="style15">
            </td>
    </tr>
</table>




</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

