using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["currentuser"] != null)
        {
            Response.Write("Welcome"+" "+ Session["currentuser_name"]+ " " + Session["currentuser_surname"]);
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }
}