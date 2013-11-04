using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class databaseForm : System.Web.UI.Page
{
    private dataConn dc;
    protected void Page_Load(object sender, EventArgs e)
    {
        dc = new dataConn();
    }
    protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    protected void DetailsViewEditDB_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
    {
    }
    protected void buttonModifyClick(object sender, EventArgs e)
    { 
    
    }
}