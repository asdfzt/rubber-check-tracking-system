<%@ Page Language="C#" AutoEventWireup="true" CodeFile="databaseForm.aspx.cs" Inherits="databaseForm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head id="Head2" runat="server">
    <title></title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="page">
    <div class="header">
            <div class="title">
            <h1>
            Rubber Check Tracking System - Manage Checks</h1>
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
        <asp:ListView ID="ListView1" runat="server" DataKeyNames="Drivers_License, Routing_No, Account_No"
            DataSourceID="SqlDataSource1" 
            onselectedindexchanged="ListView1_SelectedIndexChanged">
            <AlternatingItemTemplate>
                <tr style="background-color: #FFFFFF; color: #284775;">
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" 
                            Text="Delete" />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    </td>
                    <td>
                        <asp:Label ID="Drivers_LicenseLabel" runat="server" 
                            Text='<%# Eval("Drivers_License") %>' />
                    </td>
                    <td>
                        <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Check_NoLabel" runat="server" Text='<%# Eval("Check_No") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Routing_NoLabel" runat="server" 
                            Text='<%# Eval("Routing_No") %>' />
                    </td>
                    <td>
                        <asp:Label ID="AddressLabel" runat="server" Text='<%# Eval("Address") %>' />
                    </td>
                    <td>
                        <asp:Label ID="TelephoneLabel" runat="server" Text='<%# Eval("Telephone") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Account_NoLabel" runat="server" 
                            Text='<%# Eval("Account_No") %>' />
                    </td>
                    <td>
                        <asp:Label ID="DateLabel" runat="server" Text='<%# Eval("Date") %>' />
                    </td>
                </tr>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <tr style="background-color: #999999;">
                    <td>
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" 
                            Text="Update" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                            Text="Cancel" />
                    </td>
                    <td>
                        <asp:Label ID="Drivers_LicenseLabel1" runat="server" 
                            Text='<%# Eval("Drivers_License") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="Check_NoTextBox" runat="server" 
                            Text='<%# Bind("Check_No") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="Routing_NoTextBox" runat="server" 
                            Text='<%# Bind("Routing_No") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="AddressTextBox" runat="server" Text='<%# Bind("Address") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="TelephoneTextBox" runat="server" 
                            Text='<%# Bind("Telephone") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="Account_NoTextBox" runat="server" 
                            Text='<%# Bind("Account_No") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="DateTextBox" runat="server" Text='<%# Bind("Date") %>' />
                    </td>
                </tr>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <table runat="server" 
                    style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                    <tr>
                        <td>
                            No data was returned.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" 
                            Text="Insert" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                            Text="Clear" />
                    </td>
                    <td>
                        <asp:TextBox ID="Drivers_LicenseTextBox" runat="server" 
                            Text='<%# Bind("Drivers_License") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="Check_NoTextBox" runat="server" 
                            Text='<%# Bind("Check_No") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="Routing_NoTextBox" runat="server" 
                            Text='<%# Bind("Routing_No") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="AddressTextBox" runat="server" Text='<%# Bind("Address") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="TelephoneTextBox" runat="server" 
                            Text='<%# Bind("Telephone") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="Account_NoTextBox" runat="server" 
                            Text='<%# Bind("Account_No") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="DateTextBox" runat="server" Text='<%# Bind("Date") %>' />
                    </td>
                </tr>
            </InsertItemTemplate>
            <ItemTemplate>
                <tr style="background-color: #E0FFFF; color: #333333;">
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" 
                            Text="Delete" />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    </td>
                    <td>
                        <asp:Label ID="Drivers_LicenseLabel" runat="server" 
                            Text='<%# Eval("Drivers_License") %>' />
                    </td>
                    <td>
                        <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Check_NoLabel" runat="server" Text='<%# Eval("Check_No") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Routing_NoLabel" runat="server" 
                            Text='<%# Eval("Routing_No") %>' />
                    </td>
                    <td>
                        <asp:Label ID="AddressLabel" runat="server" Text='<%# Eval("Address") %>' />
                    </td>
                    <td>
                        <asp:Label ID="TelephoneLabel" runat="server" Text='<%# Eval("Telephone") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Account_NoLabel" runat="server" 
                            Text='<%# Eval("Account_No") %>' />
                    </td>
                    <td>
                        <asp:Label ID="DateLabel" runat="server" Text='<%# Eval("Date") %>' />
                    </td>
                </tr>
            </ItemTemplate>
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                            <table ID="itemPlaceholderContainer" runat="server" border="1" 
                                style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                <tr runat="server" style="background-color: #E0FFFF; color: #333333;">
                                    <th runat="server">
                                        </th>
                                    <th runat="server">
                                        Drivers_License</th>
                                    <th runat="server">
                                        Name</th>
                                    <th runat="server">
                                        Check_No</th>
                                    <th runat="server">
                                        Routing_No</th>
                                    <th runat="server">
                                        Address</th>
                                    <th runat="server">
                                        Telephone</th>
                                    <th runat="server">
                                        Account_No</th>
                                    <th runat="server">
                                        Date</th>
                                </tr>
                                <tr ID="itemPlaceholder" runat="server">
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" 
                            
                            style="text-align: center;background-color: #5D7B9D; font-family: Verdana, Arial, Helvetica, sans-serif;color: #FFFFFF;">
                            <asp:DataPager ID="DataPager1" runat="server">
                                <Fields>
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" 
                                        ShowLastPageButton="True" />
                                </Fields>
                            </asp:DataPager>
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <tr style="background-color: #E2DED6; font-weight: bold;color: #333333;">
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" 
                            Text="Delete" />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    </td>
                    <td>
                        <asp:Label ID="Drivers_LicenseLabel" runat="server" 
                            Text='<%# Eval("Drivers_License") %>' />
                    </td>
                    <td>
                        <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Check_NoLabel" runat="server" Text='<%# Eval("Check_No") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Routing_NoLabel" runat="server" 
                            Text='<%# Eval("Routing_No") %>' />
                    </td>
                    <td>
                        <asp:Label ID="AddressLabel" runat="server" Text='<%# Eval("Address") %>' />
                    </td>
                    <td>
                        <asp:Label ID="TelephoneLabel" runat="server" Text='<%# Eval("Telephone") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Account_NoLabel" runat="server" 
                            Text='<%# Eval("Account_No") %>' />
                    </td>
                    <td>
                        <asp:Label ID="DateLabel" runat="server" Text='<%# Eval("Date") %>' />
                    </td>
                </tr>
            </SelectedItemTemplate>
        </asp:ListView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:RCTSConnectionString2 %>"
            DeleteCommand="DELETE [Information] WHERE [Routing_No] = @Routing_No AND [Account_No] = @Account_No" 
            SelectCommand="SELECT * FROM [Information]"
            UpdateCommand="UPDATE Information 
            SET Name=@Name, Check_No=@Check_No, Routing_No=@Routing_No, Address=@Address, Telephone=@Telephone,
                Account_No=@Account_No, Date=@Date 
                WHERE Account_No=@Account_No AND Routing_No=@Routing_No"></asp:SqlDataSource>
        <br />
    
   
    </div>
    </div>

    </form>
</body>
</html>
