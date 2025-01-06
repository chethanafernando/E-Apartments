using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace E_Apartments
{
    public partial class frmLogin : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        Master master = new Master();

        public static class LoginInfo
        {
            public static string UserID;
            public static string Username;
            public static string Role;
        }

        public frmLogin()
        {
            string connectionstring = @"Data Source = CISI-SL-12048\SQLEXPRESS; Initial Catalog = EApartments; Integrated Security = True";
            con = new SqlConnection(connectionstring);
            cmd = new SqlCommand();
            cmd.Connection = con;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if(username != "" && password != "")
            {
                string encpassword = master.EncryptPlainTextToCipherText(password);

                string pass = master.DecryptCipherTextToPlainText("ikbEGEuFCWkjTj8AA5tbLA==");                

                SqlCommand cmd = new SqlCommand("SELECT u.U_ID As ID, u.U_Username As Username, u.U_Password As Password, u.U_Role As Role From [dbo].[User] u WHERE u.U_Removed = 0 AND u.U_Username = @Username AND u.U_Password = @Password", con);
                cmd.Parameters.AddWithValue("@UserName", username);
                cmd.Parameters.AddWithValue("@Password", encpassword);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    LoginInfo.UserID = dt.Rows[0].ItemArray[0].ToString();
                    LoginInfo.Username = dt.Rows[0].ItemArray[1].ToString();
                    LoginInfo.Role = dt.Rows[0].ItemArray[3].ToString();
                    MessageBox.Show("Successfully loged in");
                    frmHome frmHome = new frmHome();
                    frmHome.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Please enter correct username and password!");
                }
            }
            else
            {
                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Username is required!");
                }
                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Password is required!");
                }
            }
        }
    }
}
