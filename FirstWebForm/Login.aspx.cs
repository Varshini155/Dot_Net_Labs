using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebForm
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

   

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            btn.Text = "Booking successfull";
            Session["Username"]=btn.Text;
            Session["Hobbies"] = new List<string>() { "Reading", "Playing" };

            //Create a cookie
            HttpCookie cookie = new HttpCookie("RemindMe");
            cookie.Value = "To attend Townhall session";
            cookie.Expires = DateTime.Now.AddDays(1);

            //Cookie for preferences

            HttpCookie prefCookie = new HttpCookie("Prefernces");
            prefCookie.Value = "SeaGreen:White";
            prefCookie.Expires = DateTime.Now.AddDays(1);   


            Response.Cookies.Add(cookie);
            Response.Cookies.Add(prefCookie);
        }
    }
}