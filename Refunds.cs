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
    public partial class frmRefunds : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        Master master = new Master();
        RefundRequestClass refundClass = new RefundRequestClass();
        ConnectionClass connectionClass = new ConnectionClass();
        public int userid = int.Parse(LoginInfo.UserID);

        public frmRefunds()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Visible = true;
            this.Visible = false;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvRefunds.DataSource = GetRefundsByDate();
        }

        public DataTable GetRefundsByDate()
        {
            var datatable = new DataTable();
            con.Open();
            using (SqlCommand com = new SqlCommand(refundClass.SearchQuery, con))
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
            DisplayRefunds();
        }

        private void frmRefunds_Load(object sender, EventArgs e)
        {
            string connectionstring = connectionClass.connection;
            con = new SqlConnection(connectionstring);
            cmd = new SqlCommand();
            cmd.Connection = con;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            DisplayRefunds();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                refundClass.RR_ID = int.Parse(txtID.Text);
                refundClass.RR_Reason = txtReason.Text;
                refundClass.RR_Amount = int.Parse(txtAmount.Text);
                refundClass.RR_DueAmount = int.Parse(txtDueAmount.Text);
                refundClass.RR_Date = DateTime.Now;
                refundClass.RR_AmountRefundedDate = dtpRefundedDate.Value;
                refundClass.RR_Approved = chkApproved.Checked;
                refundClass.RR_ApprovedBy = userid;
                var success = UpdateRefund(refundClass);
                if (success)
                {
                    DisplayRefunds();
                    MessageBox.Show("Data Updated Successfully!");
                }
                else
                {
                    MessageBox.Show("Error occured. Please try again...");
                }
            }
        }

        public bool UpdateRefund(RefundRequestClass refundClass)
        {
            int rows;
            con.Open();
            using (SqlCommand com = new SqlCommand(refundClass.UpdateQuery, con))
            {
                com.Parameters.AddWithValue("@Reason", refundClass.RR_Reason);
                com.Parameters.AddWithValue("@Amount", refundClass.RR_Amount);
                com.Parameters.AddWithValue("@DueAmount", refundClass.RR_DueAmount);
                com.Parameters.AddWithValue("@Date", refundClass.RR_Date);
                com.Parameters.AddWithValue("@AmoundRefundedDate", refundClass.RR_AmountRefundedDate);
                com.Parameters.AddWithValue("@Approved", refundClass.RR_Approved);
                com.Parameters.AddWithValue("@ApprovedBy", refundClass.RR_ApprovedBy);
                com.Parameters.AddWithValue("@ID", refundClass.RR_ID);
                rows = com.ExecuteNonQuery();
            }
            con.Close();
            return (rows > 0) ? true : false;
        }

        private void DisplayRefunds()
        {
            dgvRefunds.DataSource = GetRefunds();
        }

        public DataTable GetRefunds()
        {
            var datatable = new DataTable();
            con.Open();
            using (SqlCommand com = new SqlCommand(refundClass.SelectQuery, con))
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
            refundClass.RR_ID = int.Parse(txtID.Text);
            var success = DeleteRefunds(refundClass);
            if (success)
            {
                DisplayRefunds();
                MessageBox.Show("Data Deleted Successfully!");
            }
            else
            {
                MessageBox.Show("Error occured. Please try again...");
            }
        }

        public bool DeleteRefunds(RefundRequestClass refundClass)
        {
            int rows;
            con.Open();
            using (SqlCommand com = new SqlCommand(refundClass.DeleteQuery, con))
            {
                com.Parameters.AddWithValue("@ID", refundClass.RR_ID);
                rows = com.ExecuteNonQuery();
            }
            con.Close();
            return (rows > 0) ? true : false;
        }

        private void dgvRefunds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvRefunds.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            PopulateRefunds();
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void PopulateRefunds()
        {
            txtReason.Text = dgvRefunds.CurrentRow.Cells["Reason"].Value.ToString();
            txtAmount.Text = dgvRefunds.CurrentRow.Cells["Amount"].Value.ToString();
            txtDueAmount.Text = dgvRefunds.CurrentRow.Cells["DueAmount"].Value.ToString();
            dtpRefundedDate.Value = DateTime.Parse(dgvRefunds.CurrentRow.Cells["RefundedDate"].Value.ToString());
            chkApproved.Checked = bool.Parse(dgvRefunds.CurrentRow.Cells["Approved"].Value.ToString());
        }

        private bool ValidateData()
        {
            bool boo = true;
            if (string.IsNullOrEmpty(txtReason.Text))
            {
                MessageBox.Show("Refund Reason is required!");
                boo = false;
            }
            if (string.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("Refund Amount is required!");
                boo = false;
            }
            if (dtpRefundedDate.CustomFormat == "")
            {
                MessageBox.Show("Date is required!");
                boo = false;
            }
            return boo;
        }
    }
}
