using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace E_Apartments
{
    public partial class frmRefundRequest : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        Master master = new Master();
        RefundRequestClass refundRequestClass = new RefundRequestClass();
        ConnectionClass connectionClass = new ConnectionClass();

        public frmRefundRequest()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
            dtpDate.CustomFormat = "";
            dtpRefDate.CustomFormat = "";
            txtReason.Text = "";
            txtAccount.Text = "";
            txtDueAccount.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                refundRequestClass.RR_Reason = txtReason.Text;
                refundRequestClass.RR_Amount = int.Parse(txtAccount.Text);
                refundRequestClass.RR_DueAmount = int.Parse(txtDueAccount.Text);
                refundRequestClass.RR_Date = dtpDate.Value;
                refundRequestClass.RR_AmountRefundedDate = dtpRefDate.Value;
                var success = InsertRefundRequest(refundRequestClass);
                if (success)
                {
                    ClearData();
                    MessageBox.Show("Refund Requested Successfully!");
                }
                else
                {
                    MessageBox.Show("Error occured. Please try again...");
                }
            }
        }

        public bool InsertRefundRequest(RefundRequestClass refundRequestClass)
        {
            int rows;
            con.Open();
            using (SqlCommand com = new SqlCommand(refundRequestClass.InsertQuery, con))
            {
                com.Parameters.AddWithValue("@Reason", refundRequestClass.RR_Reason);
                com.Parameters.AddWithValue("@Amount", refundRequestClass.RR_Amount);
                com.Parameters.AddWithValue("@DueAmount", refundRequestClass.RR_DueAmount);
                com.Parameters.AddWithValue("@Date", refundRequestClass.RR_Date);
                com.Parameters.AddWithValue("@RefDate", refundRequestClass.RR_AmountRefundedDate);
                com.Parameters.AddWithValue("@Removed", 0);
                rows = com.ExecuteNonQuery();
            }
            con.Close();
            return (rows > 0) ? true : false;
        }

        private void frmRefundRequest_Load(object sender, EventArgs e)
        {
            string connectionstring = connectionClass.connection;
            con = new SqlConnection(connectionstring);
            cmd = new SqlCommand();
            cmd.Connection = con;
        }

        private bool ValidateData()
        {
            bool boo = true;
            if (string.IsNullOrEmpty(txtReason.Text))
            {
                MessageBox.Show("Refund Reason is required!");
                boo = false;
            }
            if (string.IsNullOrEmpty(txtAccount.Text))
            {
                MessageBox.Show("Refund Amount is required!");
                boo = false;
            }
            if (dtpDate.CustomFormat == "")
            {
                MessageBox.Show("Date is required!");
                boo = false;
            }
            return boo;
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
