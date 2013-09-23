using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        dataConn dc;
        protected void Page_Load(object sender, EventArgs e)
        {
            dc = new dataConn();
        }
        protected void NavigationMenu_MenuItemClick(object sender, MenuEventArgs e)
        {
        }
    }