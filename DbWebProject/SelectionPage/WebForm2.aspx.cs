using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace DbWebProject
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        DbConnection db = new DbConnection("university");
        string[] secItem = new string[4];
        protected void Page_Load(object sender, EventArgs e)
        {
            Div4.Visible = false;
            Div3.Visible = false;
            Div2.Visible = false;
        }
        private void Show(string query,string param1)
        {
           
            
            DbConnection con = new DbConnection("university");
            MySqlDataReader reader = con.mySqlDataReader(query,param1);
            string inner = "";
            inner = inner + "<table>" +
                            "<thead><tr>";


            int i= 0;
            while (true)
            {
                try
                {
                    inner = inner
                     + "<th Class = \"column"+Convert.ToString(i+1)+"\" >"+reader.GetName(i++)+ " </th>";
                }
                catch
                {
                    break;
                }
            }

            inner = inner + "</tr></thead><tbody>";
            Student.p = 0;
            while (reader.Read())
            {
                if (Div2.Visible)
                {

                    Student.courses[Student.p++] = reader.GetString(0);
                }
                inner = inner + " <tr>";


                i = 0;
                while (true)
                {
                    try
                    {
                        if (i == 0)
                        {
                            if (Student.course_id.Contains(reader.GetString(i)))
                            {
                                inner = inner
                                 + "<th Class = \"column" + Convert.ToString(i + 1) + "\" style=\"color=blue\">" + reader.GetString(i++)+"  " + "<span class=\"badge badge-success\">Selected</span></th>";
                            }
                            else
                            {
                                inner = inner
                                 + "<th Class = \"column" + Convert.ToString(i + 1) + "\" >" + reader.GetString(i++) +  "</th>";
                            }
                        }
                        else
                        {
                            inner = inner
                             + "<th Class = \"column" + Convert.ToString(i + 1) + "\" > " + reader.GetString(i++) + "</th>";
                        }
                    }
                    catch
                    {
                        break;
                    }
                }

                inner = inner + "</tr>";
            }
            con.Closing();
            Div1.InnerHtml = inner+ "</tbody></table>";
            Div1.Disabled = true;
            
        }

        protected void Button6_Click(object sender,EventArgs e)
        {
            Student.course_id = new string[15];
            Div2.Visible = true;
            Div4.Visible = true;

            Show("select * from course where dept_name=(select dept_name from student where ID=@f)",Student.userId);
        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            Div4.Visible = true;

            Show("select * from takes where ID=@f", Student.userId);
        }
        protected void Button8_Click(object sender, EventArgs e)
        {
            Student.courses = new string[15];
            Student.userId = "";
            Student.course_id = new string[15];
            Student.p = Student.Top = 0;
            Response.Redirect("../loginpage/webform1.aspx");
        }

        protected void checkList_Handler(object sender,EventArgs e)
        {
            Div4.Visible = true;

            Div2.Visible = true;
            if (Student.courses.Contains(DropDownList1.SelectedItem.Text))
            {
                Div3.Visible = true;
                Student.course_id[Student.Top++] = DropDownList1.SelectedItem.Text;
                Show("select * from course where dept_name=(select dept_name from student where ID=@f)", Student.userId);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Wrong Course)", true);
                Student.course_id = new string[15];

            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Div4.Visible = true;

            Div3.Visible = true;
            Div2.Visible = true;
            int m = 0;
                while (m < Student.course_id.Length)
                {
                    MySqlDataReader reader = db.mySqlDataReader("select course_id,sec_id,semester,year from section where course_id = @f ", Student.course_id[m]);
                if (!reader.Read()) {
                    Student.course_id = new string[15];
                    Show("select * from course where dept_name=(select dept_name from student where ID=@f)", Student.userId);
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Cant catch')", true); }
                else
                {
                    int i = 0;

                    while (i < 4)
                    {
                        secItem[i] = reader.GetString(i++);
                    }
                    string prereq;



                    string[] score = { "A", "B", "C", "0", "A+", "B+", "C+", "A-", "B-", "C-" };
                    Random rnd = new Random();
                    MySqlDataReader dr = db.mySqlDataReader("select prereq_id from prereq where course_id =@f ", secItem[0]);

                    if (dr.Read())
                    {
                        prereq = dr.GetString(0);
                        MySqlDataReader dr2 = db.mySqlDataReader("select course_id from takes where course_id = @f  and id =@b", prereq, Student.userId);
                        if (dr2.Read())
                        {
                            Student.course_id = new string[15];

                            reader = db.mySqlDataReader("insert into takes values (@a, @b, @c, @d, @f,@g)", Student.userId, secItem[0], secItem[1], secItem[2], secItem[3], score[rnd.Next(0, 10)]);
                            Response.Redirect("./webform2.aspx");
                        }
                        else
                        {
                            Student.course_id = new string[15];
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('prereq was not passed!!!!')", true);
                            Show("select * from course where dept_name=(select dept_name from student where ID=@f)", Student.userId);


                        }

                    }
                    else
                    {
                        Student.course_id = new string[15];
                        reader = db.mySqlDataReader("insert into takes values (@a, @b, @c, @d, @f,@g)", Student.userId, secItem[0], secItem[1], secItem[2], secItem[3], score[rnd.Next(0, 10)]);
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Successfully!!!!')", true);
                        Response.Redirect("./webform2.aspx");

                    }



                }
                m++;
                }
            
        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Student.course_id = new string[15];
            Student.p = Student.Top = 0;
            Response.Redirect("./webform2.aspx");
        }
    }
}
