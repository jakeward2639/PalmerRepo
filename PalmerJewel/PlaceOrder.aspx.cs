using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace PalmerJewel
{
    public partial class PlaceOrder : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["YIKESConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            string Name = Request.QueryString["Username"];
            DateTime now = DateTime.Now;
            Label1.Text = Name;

            SqlCommand cmd = new SqlCommand("dbo.CreateOrder", con);
            con.Open();
            cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = Name;
            cmd.Parameters.Add("@DateOrdered", SqlDbType.Date).Value = now;
            cmd.Parameters.Add("@retord", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery(); //isnt accessing users at all, try one procedure for users one of orders
            con.Close();
            int orderid = (int)cmd.Parameters["@retord"].Value;
        }


        protected void OrderDT_Click(object sender, EventArgs e)
        {

            
        }

        protected void ToCheckout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Checkout.aspx");
        }

        protected void OrderYN_Click(object sender, EventArgs e)
        {

        }

        protected void OrderYR_Click(object sender, EventArgs e)
        {

        }


    }
}