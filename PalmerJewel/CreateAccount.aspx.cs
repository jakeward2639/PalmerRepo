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
    public partial class CreateAccount : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["YIKESConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            //ErrorLabel1.Text = "Enter Username";
            //ErrorLabel.Text = "Enter Password";
        }

        protected void SubmitAccountRequest_Click(object sender, EventArgs e)
        {
            bool exists = false;
            string passwordvalid = Convert.ToString(PasswordCreate.Text);
            int capscheck = 0;

            using (SqlCommand cmd = new SqlCommand("select count(*) from [Users] where Username = @Username", con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("Username", UsernameCreate.Text);
                exists = (int)cmd.ExecuteScalar() > 0;
                con.Close();
            }
            if (exists)
            {
                ErrorLabel1.Text = "This username already exists";
                
            }
            for (int i = 0; i < PasswordCreate.Text.Length; i++)
            {
                char passwordvalidchar = passwordvalid[i];
                bool result = Char.IsUpper(passwordvalidchar);
                if (result == true)
                {
                    capscheck = capscheck + 1;
                }
            }
            if (capscheck == 0)  //get this working could be if else but probs lower case
            {
                ErrorLabel.Text = "Password must contain at least one capital letter";
            }
            else
            {
                SqlCommand cmd = new SqlCommand("dbo.ProcedureCreateUser", con);
                con.Open();
                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = UsernameCreate.Text;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = PasswordCreate.Text;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}