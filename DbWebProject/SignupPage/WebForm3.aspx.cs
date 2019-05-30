using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

namespace DbWebProject.SignupPage
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            if (firstName.Text != "" && passwordBox.Text != "" && phoneNumber.Text != "" && depatmanBox.Text != "" && birthday.Text != "")
            {
                try { 
                Random rnd = new Random();
                string ID = Convert.ToString(rnd.Next(10000, 100000));
                string student_Id = Convert.ToString(rnd.Next(10000, 100000));
                DbConnection con = new DbConnection("university");
                con.mySqlDataReader("insert into student values(@a,@b,@c,@d,@f)", ID, firstName.Text, passwordBox.Text, depatmanBox.Text);
                Button3.Text = "Your Id: " + ID + " for Login";
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Register Successfully \n Back To Login')", true);


            }
                catch
                {

                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Somthings wrong')", true);
                } 
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Invalid Field')", true);
            }
        }

        protected void SubmitButton_Click2(object sender, EventArgs e)
        {
            Response.Redirect("~/loginpage/webform1.aspx");
        }
    }
}