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
    public partial class AccessDatabase : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["YIKESConnectionString"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SelectTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            String str = "";
            if (SelectTable.SelectedItem.Text == "Users")
            {
                SqlCommand cmd = new SqlCommand("dbo.CountUsers", con); //this section is to display how many entires were found
                con.Open();
                cmd.Parameters.Add("@Input", SqlDbType.VarChar).Value = search.Text;
                cmd.Parameters.Add("@retcou", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteReader();
                int retcount = (int)cmd.Parameters["@retcou"].Value;
                con.Close();
                Entries.Text = Convert.ToString(retcount);

                str = "select * from Users where (Username like '%' + @search + '%')"; //wildcard variables like

                //maybe make it so when selected it loads the table in its entirety
            }
            if (SelectTable.SelectedItem.Text == "Products")
            {
                SqlCommand cmd = new SqlCommand("dbo.CountProducts", con); //this section is to display how many entires were found
                con.Open();
                cmd.Parameters.Add("@Input", SqlDbType.VarChar).Value = search.Text;
                cmd.Parameters.Add("@retcou", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteReader();
                int retcount = (int)cmd.Parameters["@retcou"].Value;
                con.Close();
                Entries.Text = Convert.ToString(retcount);

                str = "select * from Products where (ProductName like '%' + @search + '%')"; //wildcard variables like
            }
            if (SelectTable.SelectedItem.Text == "Orders")
            {
                SqlCommand cmd = new SqlCommand("dbo.CountOrders", con); //this section is to display how many entires were found
                con.Open();
                cmd.Parameters.Add("@Input", SqlDbType.VarChar).Value = search.Text;
                cmd.Parameters.Add("@retcou", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteReader();
                int retcount = (int)cmd.Parameters["@retcou"].Value;
                con.Close();
                Entries.Text = Convert.ToString(retcount);

                str = "select * from Orders where (Id like '%' + @search + '%')"; //wildcard variables like
            }
            if (SelectTable.SelectedItem.Text == "OrderDetails")
            {
                SqlCommand cmd = new SqlCommand("dbo.CountOrderDetails", con); //this section is to display how many entires were found
                con.Open();
                cmd.Parameters.Add("@Input", SqlDbType.VarChar).Value = search.Text;
                cmd.Parameters.Add("@retcou", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteReader();
                int retcount = (int)cmd.Parameters["@retcou"].Value;
                con.Close();
                Entries.Text = Convert.ToString(retcount);

                str = "select * from OrderDetails where (OrderId like '%' + @search + '%')"; //wildcard variables like
            }
            if (SelectTable.SelectedItem.Text == "OrderAddress")
            {
                SqlCommand cmd = new SqlCommand("dbo.CountAddresses", con); //this section is to display how many entires were found
                con.Open();
                cmd.Parameters.Add("@Input", SqlDbType.VarChar).Value = search.Text;
                cmd.Parameters.Add("@retcou", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteReader();
                int retcount = (int)cmd.Parameters["@retcou"].Value;
                con.Close();
                Entries.Text = Convert.ToString(retcount);

                str = "select * from OrderAddress where (OrderId like '%' + @search + '%')"; //wildcard variables like
            }
            SqlCommand ad = new SqlCommand(str, con);
            ad.Parameters.Add("@search", SqlDbType.NVarChar).Value = search.Text;
            con.Open();
            ad.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = ad;
            DataSet ds = new DataSet();
            da.Fill(ds, "Username");
            DatabaseAccess.DataSource = ds;
            DatabaseAccess.DataBind();
            con.Close();


        }

    }
}