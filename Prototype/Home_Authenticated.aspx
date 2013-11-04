<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home_Authenticated.aspx.cs" Inherits="Home_Authenticated" %>

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
            Rubber Check Tracking System</h1>
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
    <h2>
        Thank you for logging into the RCTS!</h2>
        </div>
         
    </div>
    
    </form>
</body>
</html>