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
    public partial class Checkout : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["YIKESConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OrderandPay_Click(object sender, EventArgs e)
        {
            string Name = Request.QueryString["Username"];
            SqlCommand cmd = new SqlCommand("dbo.AddAddress", con);
            con.Open();
            cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = Name;
            cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = TextBox2.Text;
            cmd.Parameters.Add("@Street", SqlDbType.VarChar).Value = TextBox3.Text;
            cmd.Parameters.Add("@City", SqlDbType.VarChar).Value = TextBox1.Text;
            cmd.Parameters.Add("@Postcode", SqlDbType.VarChar).Value = TextBox4.Text;
            cmd.Parameters.Add("@MobNum", SqlDbType.VarChar).Value = TextBox5.Text;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
        }
    }
}