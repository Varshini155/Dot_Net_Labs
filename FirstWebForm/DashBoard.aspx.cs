using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebForm
{
    public partial class DashBoard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Employee> employees = new List<Employee>();
                employees.Add(new Employee() { EmpId = 1001, EName = "Eena", Designation = "Analyst" });
                employees.Add(new Employee() { EmpId = 1002, EName = "Meena", Designation = "Manager" });
                employees.Add(new Employee() { EmpId = 1003, EName = "Teena", Designation = "Lead" });
                ViewState["EmpData"] = employees;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button1.Text = "You " + Convert.ToString(Session["Username"]) + "has been booked successfully";
        }


        protected void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelected.Text="Your selected Values: " +ListBox2.SelectedValue.ToString();
            lblSelected.Text = lblSelected.Text + " | Your selected Text :" + ListBox2.SelectedItem.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            List<string> dataFromSession = (List<string>)Session["Hobbies"];
            ListBox1.DataSource = dataFromSession;
            ListBox1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
           HttpCookie varReadCookie= Request.Cookies["RemindMe"];
            Button3.Text = varReadCookie.Value;

            HttpCookie varPrefCookie = Request.Cookies["Prefernces"];
            string cookieValue=varPrefCookie.Value; 
            string[] splits = cookieValue.Split(':');

            ApplyColor(splits[0], "BackColor");
            ApplyColor(splits[1], "ForeColor");


        }
        private void ApplyColor(string color,string property)
        {
            System.Drawing.Color resultcolor = System.Drawing.Color.White;
            switch (color)
            {
                case "SeaGreen":resultcolor = System.Drawing.Color.SeaGreen;
                    break;
                case "White": resultcolor = System.Drawing.Color.White;
                    break;
                default:resultcolor = System.Drawing.Color.Tomato;
                    break;
            }

            if(property == "BackColor")
            {
                ListBox2.BackColor = resultcolor;
                ListBox1.BackColor = resultcolor;

            }
           else if (property == "ForeColor")
            {
                ListBox2.ForeColor = resultcolor;
                ListBox1.ForeColor = resultcolor;

            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = ViewState["EmpData"];
            GridView1.DataBind();
        }

        protected void lblSelected_Click(object sender, EventArgs e)
        {

        }
    }

   
}