using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class QuestionList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["currentuser"] != null)
        {
            Response.Write("Welcome" + " " + Session["currentuser_name"] + " " + Session["currentuser_surname"]);
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        using (var myDB = new alperenEntities())
        {
            int loggeduserid = Convert.ToInt32(Session["currentuser"]);
            int question_id = Convert.ToInt32(DropDownList1.Text);
            string answergiven = Convert.ToString(TextBoxAnswer.Text);
            var loggeduser = (from u in myDB.solved_by where u.user_id == loggeduserid && u.question_id == question_id select u).FirstOrDefault();
            if (loggeduser != null)
            {
                
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), " ", "alert('If you have given a wrong or correct answer before, you have no other right.')", true);


            }
            else
            {
                string loggedusername = Session["currentuser_email"].ToString();

                var addanswer = (from u in myDB.user where u.email == loggedusername select u).FirstOrDefault();
                if (addanswer != null)
                {
                    var newanswer = new solved_by();
                    newanswer.question_id = Convert.ToInt32(DropDownList1.Text);
                    newanswer.user_id = loggeduserid;

                    var question_check = (from c in myDB.question where c.question_id == question_id && c.answer == answergiven select c).FirstOrDefault();
                    if (question_check != null)
                    {
                        user act = (from f in myDB.user where f.id == loggeduserid select f).FirstOrDefault();
                        act.puan++;
                        
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), " ", "alert('You have answered correctly, your score has increased.')", true);
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), " ", "alert('You gave the wrong answer, your score has not changed.')", true);
                        
                    }
                    myDB.solved_by.Add(newanswer);
                    myDB.SaveChanges();
                }

            }



        }
    }


}