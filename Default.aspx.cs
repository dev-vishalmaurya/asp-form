using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)

        {
            registration();
            //Response.Write("<script>alert('Success')</script>");

        }
        public void registration()
        {
            try
            {
                string s = @"Data Source=LAPTOP-CQ57ICGG\SQLEXPRESS;Initial Catalog=ShoppingApp;Integrated Security=True";
                SqlConnection con = new SqlConnection(s);
                //con.ConnectionString = s;
                SqlCommand cmd = new SqlCommand("insert into tblshoplogin (Name,EmailId,Address,PinCode,Gender,Password)values(@Name,@EmailId,@Address,@PinCode,@Gender,@Password)", con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@EmailId", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@PinCode", txtPinCode.Text);
                cmd.Parameters.AddWithValue("@Gender", txtGender.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                ClearInput();
                Response.Write("<script>alert('Success')</script>");

                //ClearInput();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('"+ ex.Message+"')</script>");

            }
        }
        public void ClearInput()
        {
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;
                txtPinCode.Text = string.Empty;
            txtGender.Text = string.Empty;
            txtPassword.Text = string.Empty;
            
        }

        
    }
}