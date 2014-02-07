<%@ Page Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="ForgotPass.aspx.cs" Inherits="ForgotPass" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<p style="height: 120px">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<table 
        class="style9">
        <tr>
            <td align="center">
                Forgot Password?<br />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Enter your User Name to Receive your Password:<asp:TextBox ID="TextBox1" 
                    runat="server" style="margin-left: 45px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <br />
                <br />
                <asp:Button ID="btnForgotPassword" runat="server" style="margin-left: 308px" 
                    Text="Submit" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</p>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

