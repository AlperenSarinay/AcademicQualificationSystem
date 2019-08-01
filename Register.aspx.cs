using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["currentuser"] != null)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), " ", "alert('Giriş yaptınız,Yeni hesap oluşturamazsınız')", true);
            Session["currentuser"] = null;
        }
        else
        {

        }

    }
    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        using (var myDB = new alperenEntities())
        {
            var loggeduser = (from u in myDB.user
                              where u.email == TextBoxEmail.Text
                              select u).FirstOrDefault();
            if (loggeduser != null)
            {
                
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), " ", "alert('Bu mail adresi kullanılıyor.')", true);
            }
            else
            {
                user newuser = new user();
                newuser.puan = 0;
                newuser.is_reviewer = 0;
                newuser.firstname = TextBoxFname.Text;
                newuser.surname = TextBoxLastName.Text;
                newuser.email = TextBoxEmail.Text;
                newuser.password = TextBoxPass.Text;
                myDB.user.Add(newuser);
                myDB.SaveChanges();           
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), " ", "alert('Sign up Successful!')", true);
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");

    }
}