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
            
            if (SelectTable.SelectedItem.Text == "Users")
            {
                String stri = "select * from Users where (Username like '%' + @search + '%')"; //wildcard variables like
            }
            if (SelectTable.SelectedItem.Text == "Products")
            {
                String stri = "select * from Products where (Username like '%' + @search + '%')"; //wildcard variables like
            }
            if (SelectTable.SelectedItem.Text == "Orders")
            {
                String stri = "select * from Users where (Username like '%' + @search + '%')"; //wildcard variables like
            }
            if (SelectTable.SelectedItem.Text == "OrderDetails")
            {
                String stri = "select * from Users where (Username like '%' + @search + '%')"; //wildcard variables like
            }
            if (SelectTable.SelectedItem.Text == "OrderAddress")
            {
                String stri = "select * from Users where (Username like '%' + @search + '%')"; //wildcard variables like
            }
            String str = "select * from Users where (Username like '%' + @search + '%')"; //wildcard variables like; //make global variable
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