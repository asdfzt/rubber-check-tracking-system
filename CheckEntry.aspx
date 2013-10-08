<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckEntry.aspx.cs" Inherits="CheckEntry" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">



<head id="Head2" runat="server">
    <title></title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="Form2" runat="server">
    <div class="page">
        <div class="header">
            <div class="title">
            <h1>
            Rubber Check Tracking System - Check Entry
            </h1>
            </div>
            <div class="clear hideSkiplink">
                <asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" 
                    EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal" 
                    MenuItemClick="NavigationMenu_MenuItemClick">
                    <Items>
                        <asp:MenuItem NavigateUrl="~/Home_Authenticated.aspx" Text="Home"/>
                        <asp:MenuItem NavigateUrl="~/CheckEntry.aspx" Text="Check Entry"/>
                        <asp:MenuItem NavigateUrl="~/databaseForm.aspx" Text="Manage Checks"/>
                        <asp:MenuItem NavigateUrl="~/AdminDuties.aspx" Text="Admin Duties"/>
                        <%--<asp:MenuItem NavigateUrl="~/About.aspx" Text="About"/> --%>
                    </Items>
                </asp:Menu>
         </div>
        </div>

        <div class="body">
        <div id=" ">
    <asp:ValidationSummary ID="LoginUserValidationSummary" runat="server" CssClass="failureNotification" 
                 ValidationGroup="LoginUserValidationGroup"/>
            <br />
            <br />&nbsp;Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Drivers License:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Check No:&nbsp; </div>
    <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="NameRequired" runat="server" ControlToValidate="TextBoxName" 
                             CssClass="failureNotification" ErrorMessage="Customer Name is required." ToolTip="Customer Name is required." 
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
    <asp:TextBox ID="TextBoxDL" runat="server"></asp:TextBox>
    <asp:TextBox ID="TextBoxCheckNo" runat="server"></asp:TextBox>
    <br />
    &nbsp;Routing No:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Telephone No:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Account No:<br />
    <asp:TextBox ID="TextBoxRouteNo" runat="server"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxRouteNo" 
                             CssClass="failureNotification" ErrorMessage="Routing Number is required." ToolTip="Routing Number is required." 
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
    <asp:TextBox ID="TextBoxTelNo" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBoxAccNo" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxAccNo" 
                             CssClass="failureNotification" ErrorMessage="Account Number is required." ToolTip="Account Number is required." 
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
    <br />
            &nbsp;Address:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Date:<br />
            <asp:TextBox ID="TextBoxAddress" runat="server" Width="256px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxAddress" 
                             CssClass="failureNotification" ErrorMessage="Full Address is required." ToolTip="Full Address is required." 
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
            <asp:TextBox ID="TextBoxDate" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="ButtonAddEntry" runat="server"
            Text="Add Entry" onclick="ButtonAddEntry_Click" ValidationGroup="LoginUserValidationGroup"/>
        <asp:Button ID="ButtonClear" runat="server" Text="Clear" OnClick="ButtonClear_Click" />
        </div>
         
    </div>
    
    </form>
</body>
</html>


