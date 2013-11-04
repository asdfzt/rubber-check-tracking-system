<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminDuties.aspx.cs" Inherits="AdminDuties" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

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
            Rubber Check Tracking System 
                - Admin Duties</h1>
            </div>
            
            <div class="clear hideSkiplink">

                <asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" 
                    EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal" 
                    MenuItemClick="NavigationMenu_MenuItemClick">
                    <Items>
                        <asp:MenuItem NavigateUrl="~/Home_Authenticated.aspx" Text="Home"/>
                        <asp:MenuItem NavigateUrl="~/CheckEntry.aspx" Text="Check Entry"/>
                        <asp:MenuItem NavigateUrl="~/databaseForm.aspx" Text="Manage Checks"/>
                        <asp:MenuItem NavigateUrl="~/Admin_Duties/AdminDuties.aspx" Text="Admin Duties"/>
                        <%--<asp:MenuItem NavigateUrl="~/About.aspx" Text="About"/> --%>
                    </Items>

                </asp:Menu>

         </div>
        </div>

        <div class="body">
            <br />
            <asp:Button ID="Button1" PostBackUrl="~/Admin_Duties/Report.aspx" 
                runat="server" Text="Reports" />
        &nbsp;
            <asp:Button ID="Button2" PostBackUrl="~/Admin_Duties/Print.aspx" runat="server" Text="Print Letter"/>
        </div>
         
    </div>
    
    </form>
</body>
</html>