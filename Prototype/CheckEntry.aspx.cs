using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CheckEntry : System.Web.UI.Page
{
    dataConn dc;
    protected void Page_Load(object sender, EventArgs e)
    {
        dc = new dataConn();
    }

    protected void ButtonAddEntry_Click(object sender, EventArgs e)
    {
        dc.AddRecord("Information", TextBoxDL.Text, TextBoxName.Text, TextBoxCheckNo.Text,
            TextBoxRouteNo.Text, TextBoxAddress.Text, TextBoxTelNo.Text, TextBoxAccNo.Text, TextBoxDate.Text);
    }


    protected void ButtonClear_Click(object sender, EventArgs e)
    {
        TextBoxName.Text = "";
        TextBoxDL.Text = "";
        TextBoxCheckNo.Text = "";
        TextBoxRouteNo.Text = "";
        TextBoxTelNo.Text = "";
        TextBoxAccNo.Text = "";
        TextBoxAddress.Text = "";
        TextBoxDate.Text = "";

    }
}