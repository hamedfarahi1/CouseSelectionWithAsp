using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace DbWebProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void Button1_Click(object sender,EventArgs e)
        {
            Student.userId = "";
            Button1.Text = "Sign In";
            DbConnection cnn = new DbConnection("university");
            MySqlDataReader reader=
                        cnn.mySqlDataReader("select * from student where ID=@f",IDBox.Text);
            if (reader.Read())
            {
                if (reader.GetString(2) == pswBox.Text)
                {
                    Student.userId = reader.GetString(0);
                    Response.Redirect("~/selectionPage/webform2.aspx");
                }
                else
                {
                    pswBox.Text = "";
                    Button1.Text = "Invalid Password";
                }
            }
            else
            {
                IDBox.Text = pswBox.Text = "";
                Button1.Text = "Invalid Id";
            }
            cnn.Closing();

            //Response.Redirect("~/SelectionPage/WebForm2.aspx");
        } 
        protected void Text_Change1(object sender,EventArgs e)
        {
            Button1.Text = "Sign In";
        }
        protected void Text_Change2(object sender, EventArgs e)
        {
            Button1.Text = "Sign In";
        }

        protected void ButtonSignUp_Click(object sender,EventArgs e)
        {
            Response.Redirect("~/SignupPage/WebForm3.aspx");
        }
    }
}