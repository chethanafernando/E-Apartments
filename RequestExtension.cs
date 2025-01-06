using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static E_Apartments.frmLogin;

namespace E_Apartments
{
    public partial class frmRequestExtension : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        Master master = new Master();
        ExtensionClass extensionClass = new ExtensionClass();
        ConnectionClass connectionClass = new ConnectionClass();
        public int userid = int.Parse(LoginInfo.UserID);

        public frmRequestExtension()
        {
            InitializeComponent();
        }

        private void frmRequestExtension_Load(object sender, EventArgs e)
        {
            string connectionstring = connectionClass.connection;
            con = new SqlConnection(connectionstring);
            cmd = new SqlCommand();
            cmd.Connection = con;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            DisplayExtensions();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Visible = true;
            this.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                extensionClass.E_ID = int.Parse(txtID.Text);
                extensionClass.E_Description = txtDescription.Text;
                extensionClass.E_Period = int.Parse(txtPeriod.Text);
                extensionClass.E_Date = DateTime.Now;
                extensionClass.E_ApprovedDate = dtpExtensionDate.Value;
                extensionClass.E_Approved = chkApproved.Checked;
                extensionClass.E_ApprovedBy = userid;
                var success = UpdateExtension(extensionClass);
                if (success)
                {
                    DisplayExtensions();
                    MessageBox.Show("Data Updated Successfully!");
                }
                else
                {
                    MessageBox.Show("Error occured. Please try again...");
                }
            }
        }

        public bool UpdateExtension(ExtensionClass extensionClass)
        {
            int rows;
            con.Open();
            using (SqlCommand com = new SqlCommand(extensionClass.UpdateQuery, con))
            {
                com.Parameters.AddWithValue("@Description", extensionClass.E_Description);
                com.Parameters.AddWithValue("@Period", extensionClass.E_Period);
                com.Parameters.AddWithValue("@Date", extensionClass.E_Date);
                com.Parameters.AddWithValue("@ApprovedDate", extensionClass.E_ApprovedDate);
                com.Parameters.AddWithValue("@Approved", extensionClass.E_Approved);
                com.Parameters.AddWithValue("@ApprovedBy", extensionClass.E_ApprovedBy);
                com.Parameters.AddWithValue("@ID", extensionClass.E_ID);
                rows = com.ExecuteNonQuery();
            }
            con.Close();
            return (rows > 0) ? true : false;
        }

        private void DisplayExtensions()
        {
            dgvExtension.DataSource = GetExtensions();
        }

        public DataTable GetExtensions()
        {
            var datatable = new DataTable();
            con.Open();
            using (SqlCommand com = new SqlCommand(extensionClass.SelectQuery, con))
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
            extensionClass.E_ID = int.Parse(txtID.Text);
            var success = DeleteExtension(extensionClass);
            if (success)
            {
                DisplayExtensions();
                MessageBox.Show("Data Deleted Successfully!");
            }
            else
            {
                MessageBox.Show("Error occured. Please try again...");
            }
        }

        public bool DeleteExtension(ExtensionClass extensionClass)
        {
            int rows;
            con.Open();
            using (SqlCommand com = new SqlCommand(extensionClass.DeleteQuery, con))
            {
                com.Parameters.AddWithValue("@ID", extensionClass.E_ID);
                rows = com.ExecuteNonQuery();
            }
            con.Close();
            return (rows > 0) ? true : false;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvExtension.DataSource = GetExtensionByDate();
        }

        public DataTable GetExtensionByDate()
        {
            var datatable = new DataTable();
            con.Open();
            using (SqlCommand com = new SqlCommand(extensionClass.SearchQuery, con))
            {
                com.Parameters.AddWithValue("@Date", txtSearch.Text);
                using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                {
                    adapter.Fill(datatable);
                }
            }
            con.Close();
            return datatable;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DisplayExtensions();
        }

        private void dgvExtension_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvExtension.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            PopulateExtensions();
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void PopulateExtensions()
        {
            txtDescription.Text = dgvExtension.CurrentRow.Cells["Description"].Value.ToString();
            txtPeriod.Text = dgvExtension.CurrentRow.Cells["Period"].Value.ToString();
            dtpExtensionDate.Value = DateTime.Parse(dgvExtension.CurrentRow.Cells["Date"].Value.ToString());
            chkApproved.Checked = bool.Parse(dgvExtension.CurrentRow.Cells["Approved"].Value.ToString());
        }

        private bool ValidateData()
        {
            bool boo = true;
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Refund Reason is required!");
                boo = false;
            }
            if (string.IsNullOrEmpty(txtPeriod.Text))
            {
                MessageBox.Show("Refund Amount is required!");
                boo = false;
            }
            if (dtpExtensionDate.CustomFormat == "")
            {
                MessageBox.Show("Date is required!");
                boo = false;
            }
            return boo;
        }
    }
}
