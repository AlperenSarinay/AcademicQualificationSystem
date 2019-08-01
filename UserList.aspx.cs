using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class UserList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["currentuser"] != null)
        {
            //Response.Write("Welcome" + " " + Session["currentuser_name"] + " " + Session["currentuser_surname"]);
        
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
            int True = 1;
            int is_reviewer_k = Convert.ToInt32(Session["currentuser_rev"]);
            var loggeduser = (from u in myDB.user
                              where is_reviewer_k == 1
                              select u).FirstOrDefault();
            if (loggeduser != null)
            {
                foreach (GridViewRow row in GridView1.Rows)
                {
                    CheckBox status = (row.Cells[3].FindControl("CheckBox1") as CheckBox);
                    int rollno = Convert.ToInt32(row.Cells[0].Text);
                    if (status.Checked)
                    {
                        updaterow(rollno, True);
                    }
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), " ", "alert('you changed this user to reviewer.')", true);
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), " ", "alert('You are not reviewer!')", true);
            }

        }
    }
    private void updaterow(int rollno, int markstatus)
    {
        String mycon = "Data Source=LAPTOP-TA79PATF\\SQLEXPRESS; Initial Catalog=c1511048; Integrated Security=True";
        String updatedata = "Update [user] set is_reviewer ='" + markstatus + "' where id=" + rollno;

        SqlConnection con = new SqlConnection(mycon);
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = updatedata;
        cmd.Connection = con;
        cmd.ExecuteNonQuery();

    }



}