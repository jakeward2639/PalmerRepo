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
    public partial class LoginPage : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["YIKESConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {            
        }

        protected void SubmitLoginRequest_Click(object sender, EventArgs e)
        {
            bool userexists = false;
            bool passexists = false;

            using (SqlCommand cmd = new SqlCommand("select count(*) from [Users] where Username = @Username", con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("Username", usertxt.Text);
                userexists = (int)cmd.ExecuteScalar() > 0;
                con.Close();
            }
            if (userexists)
            {
                using (SqlCommand cmd = new SqlCommand("select count(*) from [Users] where Password = @Password", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("Password", passtxt.Text);
                    passexists = (int)cmd.ExecuteScalar() > 0;
                    con.Close();
                }
                if (passexists)
                {
                    SqlCommand cmd = new SqlCommand("dbo.ProcedureCheckPermissionAdmin", con);
                    con.Open();
                    cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = usertxt.Text;
                    cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = passtxt.Text;
                    cmd.Parameters.Add("@retper", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                    cmd.CommandType = CommandType.StoredProcedure;
                  
                    cmd.ExecuteReader();
                    int tfpermission = (int)cmd.Parameters["@retper"].Value;
                    usertxt.Text = Convert.ToString(tfpermission);
                    con.Close();
                    if (tfpermission == 1)
                    {                        
                        Response.Redirect("AccessDatabase.aspx?Username=usertxt.Text");
                    }
                    if (tfpermission == 2)
                    {
                        Response.Redirect("PlaceOrder.aspx?Username=usertxt.Text");
                    }
                    
                }


                //SqlCommand cmd = new SqlCommand("dbo.ProcedureCreateUser", con);
                //con.Open();
                //cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = usertxt.Text;
                //cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = passtxt.Text;
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.ExecuteNonQuery();
                //con.Close();
            }
            
        }
    }
}