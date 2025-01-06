using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartments
{
    public partial class frmUser : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        Master master = new Master();
        UserClass userClass = new UserClass();
        ConnectionClass connectionClass = new ConnectionClass();

        public frmUser()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            string connectionstring = connectionClass.connection;
            con = new SqlConnection(connectionstring);
            cmd = new SqlCommand();
            cmd.Connection = con;
            txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 12;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            DisplayUsers();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                SqlCommand cmd = new SqlCommand("SELECT u.U_Username As Username From [dbo].[User] u WHERE u.U_Removed = 0 AND u.U_Username = @Username", con);
                cmd.Parameters.AddWithValue("@UserName", txtUsername.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Username is already exsits!");
                }
                else
                {
                    userClass.U_Username = txtUsername.Text;
                    userClass.U_Password = master.EncryptPlainTextToCipherText(txtPassword.Text);
                    userClass.U_Email = txtEmail.Text;
                    userClass.U_Designation = txtDesignation.Text;
                    userClass.U_Role = cmbRole.SelectedItem.ToString();
                    var success = InsertUser(userClass);
                    if (success)
                    {
                        ClearData();
                        DisplayUsers();
                        MessageBox.Show("Data Inserted Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error occured. Please try again...");
                    }
                }
            }
        }

        public bool InsertUser(UserClass userClass)
        {
            int rows;
            con.Open();
            using (SqlCommand com = new SqlCommand(userClass.InsertQuery, con))
            {
                com.Parameters.AddWithValue("@Username", userClass.U_Username);
                com.Parameters.AddWithValue("@Password", userClass.U_Password);
                com.Parameters.AddWithValue("@Email", userClass.U_Email);
                com.Parameters.AddWithValue("@Designation", userClass.U_Designation);
                com.Parameters.AddWithValue("@Role", userClass.U_Role);
                com.Parameters.AddWithValue("@Removed", 0);
                rows = com.ExecuteNonQuery();
            }
            con.Close();
            return (rows > 0) ? true : false;
        }

        private void ClearData()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            txtDesignation.Clear();
            cmbRole.Text = "";
            txtUsername.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                userClass.U_ID = int.Parse(txtID.Text);
                userClass.U_Username = txtUsername.Text;
                userClass.U_Password = master.EncryptPlainTextToCipherText(txtPassword.Text);
                userClass.U_Email = txtEmail.Text;
                userClass.U_Designation = txtDesignation.Text;
                userClass.U_Role = cmbRole.SelectedItem.ToString();
                var success = UpdateUser(userClass);
                if (success)
                {
                    ClearData();
                    DisplayUsers();
                    MessageBox.Show("Data Updated Successfully!");
                    btnSave.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error occured. Please try again...");
                }
            }
        }

        public bool UpdateUser(UserClass userClass)
        {
            int rows;
            con.Open();
            using (SqlCommand com = new SqlCommand(userClass.UpdateQuery, con))
            {
                com.Parameters.AddWithValue("@Password", userClass.U_Password);
                com.Parameters.AddWithValue("@Email", userClass.U_Email); 
                com.Parameters.AddWithValue("@Designation", userClass.U_Designation);
                com.Parameters.AddWithValue("@Role", userClass.U_Role); 
                com.Parameters.AddWithValue("@ID", userClass.U_ID);
                rows = com.ExecuteNonQuery();
            }
            con.Close();
            return (rows > 0) ? true : false;
        }

        private void DisplayUsers()
        {
            dgvUser.DataSource = GetUsers();
            this.dgvUser.Columns["Password"].Visible = false;
        }

        public DataTable GetUsers()
        {
            var datatable = new DataTable();
            con.Open();
            using (SqlCommand com = new SqlCommand(userClass.SelectQuery, con))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                {
                    adapter.Fill(datatable);
                }
            }
            con.Close();
            return datatable;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            userClass.U_ID = int.Parse(txtID.Text);
            var success = DeleteUser(userClass);
            if (success)
            {
                ClearData();
                DisplayUsers();
                MessageBox.Show("Data Deleted Successfully!");
                btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error occured. Please try again...");
            }
        }

        public bool DeleteUser(UserClass userClass)
        {
            int rows;
            con.Open();
            using (SqlCommand com = new SqlCommand(userClass.DeleteQuery, con))
            {
                com.Parameters.AddWithValue("@ID", userClass.U_ID);
                rows = com.ExecuteNonQuery();
            }
            con.Close();
            return (rows > 0) ? true : false;
        }

        public DataTable GetUsersByUsernameOrEmail()
        {
            var datatable = new DataTable();
            con.Open();
            using (SqlCommand com = new SqlCommand(userClass.SearchQuery, con))
            {
                com.Parameters.AddWithValue("@Username", txtSearch.Text);
                com.Parameters.AddWithValue("@Email", txtSearch.Text);
                using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                {
                    adapter.Fill(datatable);
                }
            }
            con.Close();
            return datatable;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvUser.DataSource = GetUsersByUsernameOrEmail();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Visible = true;
            this.Visible = false;
        }

        private void PopulateUsers()
        {
            txtUsername.Enabled = false;
            txtUsername.Text = dgvUser.CurrentRow.Cells["Username"].Value.ToString();
            txtEmail.Text = dgvUser.CurrentRow.Cells["Email"].Value.ToString();
            txtDesignation.Text = dgvUser.CurrentRow.Cells["Designation"].Value.ToString();
            txtPassword.Text =  master.DecryptCipherTextToPlainText(dgvUser.CurrentRow.Cells["Password"].Value.ToString());
            cmbRole.Text = dgvUser.CurrentRow.Cells["Role"].Value.ToString();
        }

        private bool ValidateData()
        {
            bool boo = true;
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Username is required!");
                boo = false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password is required!");
                boo = false;
            }
            else
            {
                if (vaildate_password.IsMatch(txtPassword.Text) != true)
                {
                    MessageBox.Show("Password must be atleast 8 to 15 characters. It contains atleast one Upper case and numbers.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPassword.Focus();
                    boo = false;
                }
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email is required!");
                boo = false;
            }
            if (string.IsNullOrEmpty(cmbRole.Text))
            {
                MessageBox.Show("Role is required!");
                boo = false;
            }
            return boo;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DisplayUsers();
            this.dgvUser.Columns["Password"].Visible = false;
        }

        private static Regex PasswordValidation()
        {
            string pattern = "(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,15})$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        static Regex vaildate_password = PasswordValidation();

        private void dgvUser_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvUser.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            PopulateUsers();
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void dgvUser_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvUser.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            PopulateUsers();
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }
    }
}
