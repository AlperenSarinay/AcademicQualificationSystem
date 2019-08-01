using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["currentuser"] != null)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), " ", "alert('Zaten giriş yaptınız!')", true);
            Session["currentuser"] = null;
        }
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        using (var myDB = new alperenEntities())
        {
            var loggeduser = (from u in myDB.user
                              where u.email == TextBoxEmail.Text && u.password == TextBoxPass.Text
                              select u).FirstOrDefault();
            if (loggeduser != null)
            {
                Session["currentuser"] = loggeduser.id;
                Session["currentuser_email"] = loggeduser.email;
                Session["currentuser_name"] = loggeduser.firstname;
                Session["currentuser_surname"] = loggeduser.surname;
                Session["currentuser_rev"] = loggeduser.is_reviewer;
                Response.Redirect("home.aspx"); 
            }
            else
            {
                FailureText.Text = "Invalid username or password.";
                ErrorMessage.Visible = true;
            }

        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
}