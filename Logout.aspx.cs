using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Logout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["currentuser"] != null)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), " ", "alert('çıkış yaptınız')", true);
            Session["currentuser"] = null;
            Response.Redirect("Login.aspx");
            
        }
        else
        {
        }
    }
}