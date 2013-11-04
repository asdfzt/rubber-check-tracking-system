<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Report.aspx.cs" Inherits="Admin_Duties_Report" %>

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
            <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" 
                Font-Size="8pt" InteractiveDeviceInfos="(Collection)" 
                WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="800px">
                <localreport reportpath="Report7.rdlc">
                    <datasources>
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet1" />
                    </datasources>
                </localreport>
            </rsweb:ReportViewer>
            <br />
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                SelectMethod="GetData" 
                TypeName="RCTSDataSetTableAdapters.InformationTableAdapter">
            </asp:ObjectDataSource>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </div>
         
    </div>
    
    </form>
</body>
</html>
