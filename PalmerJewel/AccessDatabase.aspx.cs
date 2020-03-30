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
                str = "select * from Users where (Username like '%' + @search + '%')"; //wildcard variables like
                //matbe make it so when selected it loads the table in its entirety
            }
            if (SelectTable.SelectedItem.Text == "Products")
            {
                str = "select * from Products where (ProductName like '%' + @search + '%')"; //wildcard variables like
            }
            if (SelectTable.SelectedItem.Text == "Orders")
            {
                str = "select * from Orders where (Username like '%' + @search + '%')"; //wildcard variables like
            }
            if (SelectTable.SelectedItem.Text == "OrderDetails")
            {
                str = "select * from OrderDetails where (OrderId like '%' + @search + '%')"; //wildcard variables like
            }
            if (SelectTable.SelectedItem.Text == "OrderAddress")
            {
                str = "select * from OrderAddress where (OrderId like '%' + @search + '%')"; //wildcard variables like
            }
            //String str = "select * from Users where (Username like '%' + @search + '%')"; //wildcard variables like; //make global variable
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