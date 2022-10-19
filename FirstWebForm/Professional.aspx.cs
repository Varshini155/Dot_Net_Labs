using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace FirstWebForm
{
    public partial class Professional : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Connect to Database 
            SqlDataAdapter adapter=new SqlDataAdapter();

            //Get the command from sqlDataSource
            adapter.InsertCommand = new SqlCommand(SqlDataSource1.InsertCommand);
            adapter.InsertCommand.Connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=kpmgDb;Integrated Security=True");

            //Add Parameters for commands
            adapter.InsertCommand.Parameters.Add(new SqlParameter("Name", txtName.Text));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("Designation", txtDesign.Text));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("Salary", txtSalary.Text));

            //Open connections // execute command
            using (adapter.InsertCommand.Connection)
            {
                adapter.InsertCommand.Connection.Open();
                adapter.InsertCommand.ExecuteNonQuery();
            }

            // Rebind the grid
            GridView1.DataBind();

        }
    }
}