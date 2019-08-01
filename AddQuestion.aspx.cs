using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddQuestion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["currentuser"] != null && Convert.ToInt32(Session["currentuser_rev"]) == 1)
        {
            Response.Write("Welcome" + " " + Session["currentuser_name"] + " " + Session["currentuser_surname"]);
        }
        else
        {
            Response.Redirect("HomePage.aspx");
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        using (var myDB = new alperenEntities())
        {
            int loggeduserid = Convert.ToInt32(Session["currentuser"]);
            int is_reviewer_kontrol = Convert.ToInt32(Session["currentuser_rev"]);
            var loggeduser = (from u in myDB.user
                              where u.id == loggeduserid && is_reviewer_kontrol == 1
                              select u ).FirstOrDefault();
            if (loggeduser != null)
            {
                var newuser = new question();
                newuser.title = TextBoxTitle.Text;
                newuser.question_include = TextBoxQuestionText.Text;
                newuser.answer = TextBoxQuestionAnswer.Text;
                newuser.question_by = Convert.ToInt32((Session["currentuser"]));
                myDB.question.Add(newuser);
                myDB.SaveChanges();
                
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), " ", "alert('Question added.')", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), " ", "alert('Question not added. You are not reviewer!')", true);
                
            }



        }
    }
}