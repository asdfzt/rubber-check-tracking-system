<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Print.aspx.cs" Inherits="Admin_Duties_Print" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<head id="Head2" runat="server">
<script>
    function printpage() {
        window.print()
    }
</script>
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
            <br />
            <b id="docs-internal-guid-1692c460-95c0-45d6-b55e-1df97d914124" 
                style="font-weight:normal;">
            <p dir="ltr" 
                style="line-height:1.15;margin-top:0pt;margin-bottom:0pt;margin-left: 288pt;text-indent: 36pt;">
                <span style="font-size:15px;font-family:Arial;color:#000000;background-color:transparent;font-weight:normal;font-style:normal;font-variant:normal;text-decoration:none;vertical-align:baseline;white-space:pre-wrap;">
                RCTS</span></p>
            <p dir="ltr" 
                style="line-height:1.15;margin-top:0pt;margin-bottom:0pt;margin-left: 288pt;text-indent: 36pt;">
                <span style="font-size:15px;font-family:Arial;color:#000000;background-color:transparent;font-weight:normal;font-style:normal;font-variant:normal;text-decoration:none;vertical-align:baseline;white-space:pre-wrap;">
                1700 Wade Hampton Blvd.<span class="Apple-tab-span" style="white-space:pre;">
                </span></span>
            </p>
            <p dir="ltr" 
                style="line-height:1.15;margin-top:0pt;margin-bottom:0pt;margin-left: 288pt;text-indent: 36pt;">
                <span style="font-size:15px;font-family:Arial;color:#000000;background-color:transparent;font-weight:normal;font-style:normal;font-variant:normal;text-decoration:none;vertical-align:baseline;white-space:pre-wrap;">
                Greenville, SC &nbsp;29614</span></p>
            <br />
            <br />
            <br />
            <br />
            <p dir="ltr" style="line-height:1.15;margin-top:0pt;margin-bottom:0pt;">
                <span style="font-size:15px;font-family:Arial;color:#000000;background-color:transparent;font-weight:normal;font-style:normal;font-variant:normal;text-decoration:none;vertical-align:baseline;white-space:pre-wrap;">
                Fred Davis</span></p>
            <p dir="ltr" style="line-height:1.15;margin-top:0pt;margin-bottom:0pt;">
                <span style="font-size:15px;font-family:Arial;color:#000000;background-color:transparent;font-weight:normal;font-style:normal;font-variant:normal;text-decoration:none;vertical-align:baseline;white-space:pre-wrap;">
                16280 Oak Tree Lane</span></p>
            <p dir="ltr" style="line-height:1.15;margin-top:0pt;margin-bottom:0pt;">
                <span style="font-size:15px;font-family:Arial;color:#000000;background-color:transparent;font-weight:normal;font-style:normal;font-variant:normal;text-decoration:none;vertical-align:baseline;white-space:pre-wrap;">
                Robinson, IL &nbsp;34190</span></p>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <p dir="ltr" style="line-height:1.15;margin-top:0pt;margin-bottom:0pt;">
                <span style="font-size:15px;font-family:Arial;color:#000000;background-color:transparent;font-weight:normal;font-style:normal;font-variant:normal;text-decoration:none;vertical-align:baseline;white-space:pre-wrap;">
                This is a reminder that you owe RCTS the total of _________ dollars and ________ 
                cents. To avoid incurring late fees, please pay your remaining balance within 
                two weeks of receiving this letter. If you have any questions or concerns, 
                please contact us.</span></p>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <p dir="ltr" style="line-height:1.15;margin-top:0pt;margin-bottom:0pt;">
                <span style="font-size:15px;font-family:Arial;color:#000000;background-color:transparent;font-weight:normal;font-style:normal;font-variant:normal;text-decoration:none;vertical-align:baseline;white-space:pre-wrap;">
                X</span></p>
            <hr />
            <p dir="ltr" style="line-height:1.15;margin-top:0pt;margin-bottom:0pt;">
                <span style="font-size:15px;font-family:Arial;color:#000000;background-color:transparent;font-weight:normal;font-style:normal;font-variant:normal;text-decoration:none;vertical-align:baseline;white-space:pre-wrap;">
                Bob Simmons, RCTS Manager</span></p>
            </b>
            <br class="Apple-interchange-newline" />
            <asp:Button ID="Button1" OnClientClick="printpage()" runat="server" Text="Print" />
            <br />
        </div>
         
    </div>
    
    </form>
</body>
</html>