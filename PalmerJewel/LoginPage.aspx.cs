using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace PalmerJewel
{
    public partial class LoginPage : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PalmerConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        protected void SubmitLoginRequest_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into Users values('"+0+ "','" + usertxt.Text + "','" + passtxt.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            usertxt.Text = "";
            passtxt.Text = ""; //this is so close to working but the input was wrong and coulndt turn to int so i tryed to redet but it wasnt weorking because of syntax errors if the errors are fixed thern the prograsm shold run check id it ran correctly by inspectign data make sure all vsrrisbles are spelt thr same
        }
    }
}