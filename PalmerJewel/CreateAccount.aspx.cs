﻿using System;
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
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PalmerConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void SubmitAccountRequest_Click(object sender, EventArgs e)
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