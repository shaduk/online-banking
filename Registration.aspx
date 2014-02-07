<%@ Page Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style6
    {
        height: 33px;
    }
    .style7
    {
        height: 31px;
    }
    .style8
    {
        height: 24px;
    }
    .style9
    {
        height: 30px;
    }
    .style10
    {
        height: 8px;
    }
    .style11
    {
        height: 10px;
    }
        .style12
        {
            height: 33px;
            width: 291px;
        }
        .style13
        {
            height: 31px;
            width: 291px;
        }
        .style14
        {
            height: 24px;
            width: 291px;
        }
        .style15
        {
            height: 30px;
            width: 291px;
        }
        .style16
        {
            height: 8px;
            width: 291px;
        }
        .style17
        {
            width: 291px;
        }
        .style18
        {
            height: 10px;
            width: 291px;
        }
        .style19
        {
            height: 33px;
            width: 134px;
        }
        .style20
        {
            height: 31px;
            width: 134px;
        }
        .style21
        {
            height: 24px;
            width: 134px;
        }
        .style22
        {
            height: 30px;
            width: 134px;
        }
        .style23
        {
            height: 8px;
            width: 134px;
        }
        .style24
        {
            width: 134px;
        }
        .style25
        {
            height: 10px;
            width: 134px;
        }
        .style26
        {
            height: 37px;
            width: 134px;
        }
        .style27
        {
            height: 37px;
            width: 291px;
        }
        .style28
        {
            height: 33px;
            width: 99px;
        }
        .style29
        {
            height: 31px;
            width: 99px;
        }
        .style30
        {
            height: 24px;
            width: 99px;
        }
        .style31
        {
            height: 30px;
            width: 99px;
        }
        .style32
        {
            height: 8px;
            width: 99px;
        }
        .style33
        {
            width: 99px;
        }
        .style34
        {
            height: 10px;
            width: 99px;
        }
        .style35
        {
            height: 37px;
            width: 99px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div style="font-size: x-large; background-color: #FFCC66; height: 35px; width: 529px;">
    Registration Form<br />
    <br />
    <br />
</div>
<table class="style1">
    <tr>
        <td class="style19">
            Verification Document Type</td>
        <td class="style12">
            <asp:DropDownList ID="Verfittype" runat="server">
                <asp:ListItem>Passport</asp:ListItem>
                <asp:ListItem>Driving Licence</asp:ListItem>
                <asp:ListItem>Voter Id</asp:ListItem>
                <asp:ListItem>Ration Card</asp:ListItem>
                <asp:ListItem>Aadhar Card</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td class="style28">
            &nbsp;</td>
        <td class="style6">
        </td>
    </tr>
    <tr>
        <td class="style20">
            Verification Document ID</td>
        <td class="style13">
            <asp:TextBox ID="Textverid" runat="server" ontextchanged="TextBox8_TextChanged" 
                AutoCompleteType="Disabled"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
        <td class="style29">
            &nbsp;</td>
        <td class="style7">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                ErrorMessage="ID is mandatory" ControlToValidate="Textverid"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style19">
            <asp:Label ID="LblName" runat="server" Text="Name"></asp:Label>
        </td>
        <td class="style12">
            <asp:TextBox ID="TextName" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
        </td>
        <td class="style28">
            &nbsp;</td>
        <td class="style6">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="TextName" ErrorMessage="Name cannot be left blank!!"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style21">
            <asp:Label ID="LblGender" runat="server" Text="Gender"></asp:Label>
        </td>
        <td class="style14">
            <asp:RadioButton ID="RadioButtonmale" runat="server" Text="Male" 
                GroupName="gen" />
            <asp:RadioButton ID="RadioButtonfemale" runat="server" Text="Female" 
                GroupName="gen" />
        </td>
        <td class="style30">
            &nbsp;</td>
        <td class="style8">
        </td>
    </tr>
    <tr>
        <td class="style22">
            <asp:Label ID="LblAge" runat="server" Text="Age"></asp:Label>
        </td>
        <td class="style15">
            <asp:TextBox ID="TextBoxAge" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
        </td>
        <td class="style31">
            &nbsp;</td>
        <td class="style9">
            <asp:RangeValidator ID="RangeValidator1" runat="server" 
                ControlToValidate="TextBoxAge" ErrorMessage="Age should be greater than 18" 
                MaximumValue="80" MinimumValue="10"></asp:RangeValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="TextBoxAge" ErrorMessage="Please specify your age "></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style23">
            <asp:Label ID="LblDoB" runat="server" Text="Date of  Birth"></asp:Label>
        </td>
        <td class="style16">
            <asp:DropDownList ID="Droplistday" runat="server" Height="18px" Width="48px">
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownLmonth" runat="server" Height="16px" Width="71px">
                <asp:ListItem>January</asp:ListItem>
                <asp:ListItem>February</asp:ListItem>
                <asp:ListItem>March</asp:ListItem>
                <asp:ListItem>April</asp:ListItem>
                <asp:ListItem>May</asp:ListItem>
                <asp:ListItem>June</asp:ListItem>
                <asp:ListItem>July</asp:ListItem>
                <asp:ListItem>August</asp:ListItem>
                <asp:ListItem>September</asp:ListItem>
                <asp:ListItem>October</asp:ListItem>
                <asp:ListItem>November</asp:ListItem>
                <asp:ListItem>December</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownLyear" runat="server" style="margin-left: 0px" 
                Width="54px">
            </asp:DropDownList>
        </td>
        <td class="style32">
            &nbsp;</td>
        <td class="style10">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                ControlToValidate="DropDownLyear">Please specify year</asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="DropDownLmonth" ErrorMessage="Please mention the month"></asp:RequiredFieldValidator>
        &nbsp;&nbsp;
        </td>
    </tr>
    <tr>
        <td class="style24">
            <asp:Label ID="LblAddress" runat="server" Text="Address"></asp:Label>
        </td>
        <td class="style17">
            <asp:TextBox ID="TextBoxadd" runat="server" Height="71px" 
                AutoCompleteType="Disabled"></asp:TextBox>
        </td>
        <td class="style33">
            &nbsp;</td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                ControlToValidate="TextBoxadd" ErrorMessage="Address cannot be left blank"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style25">
            <asp:Label ID="LblPhoneNo" runat="server" Text="Phone No"></asp:Label>
        </td>
        <td class="style18">
            <asp:TextBox ID="TextBoxphone" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
        </td>
        <td class="style34">
            &nbsp;</td>
        <td class="style11">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                ControlToValidate="TextBoxphone" 
                ErrorMessage="Phone No cannot be left blank"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style25">
            <asp:Label ID="LblPanNo" runat="server" Text="Pan No."></asp:Label>
        </td>
        <td class="style18">
            <asp:TextBox ID="TextBoxpan" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
        </td>
        <td class="style34">
            &nbsp;</td>
        <td class="style11">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                ControlToValidate="TextBoxpan" 
                ErrorMessage="Pan No cannot be left blank!!"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style24">
            <asp:Label ID="LblEmail" runat="server" Text="Email Address"></asp:Label>
        </td>
        <td class="style17">
            <asp:TextBox ID="TextBoxemail" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
        </td>
        <td class="style33">
            &nbsp;</td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                ControlToValidate="TextBoxemail" ErrorMessage="Specify your Email Address"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ControlToValidate="TextBoxemail" ErrorMessage="Enter a valid email address" 
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
    <td class="style24">Password</td>
    <td class="style17">
        <asp:TextBox ID="TextBoxpass" runat="server" TextMode="Password" 
            ontextchanged="TextBoxpass_TextChanged"></asp:TextBox>
        &nbsp;&nbsp;
        </td>
    <td class="style33">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
            ControlToValidate="TextBoxpass" ErrorMessage="Password is mandatory"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
    <td class="style26">Confirm Password</td>
    <td class="style27">
        <asp:TextBox ID="TextBoxcpass" runat="server" AutoCompleteType="Disabled" 
            TextMode="Password"></asp:TextBox>
&nbsp;&nbsp;
        </td>
    <td class="style35">
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToCompare="TextBoxpass" ControlToValidate="TextBoxcpass" 
            ErrorMessage="Password don&quot;t match"></asp:CompareValidator>
        </td>
    </tr>
</table>
<p>
    &nbsp;</p>
<p>
    <asp:Button ID="Button1" runat="server" Text="Submit" Width="90px" 
        onclick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AdminHome.aspx">Go 
    back</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

