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
    public partial class frmExtensions : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        Master master = new Master();
        ExtensionClass extensionClass = new ExtensionClass();
        ConnectionClass connectionClass = new ConnectionClass();

        public frmExtensions()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                extensionClass.E_Description = txtDescription.Text;
                extensionClass.E_Period = int.Parse(txtPeriod.Text);
                extensionClass.E_Date = dtpDate.Value;
                var success = InsertExtension(extensionClass);
                if (success)
                {
                    ClearData();
                    MessageBox.Show("Extension Requested Successfully!");
                }
                else
                {
                    MessageBox.Show("Error occured. Please try again...");
                }
            }
        }

        public bool InsertExtension(ExtensionClass extensionClass)
        {
            int rows;
            con.Open();
            using (SqlCommand com = new SqlCommand(extensionClass.InsertQuery, con))
            {
                com.Parameters.AddWithValue("@Description", extensionClass.E_Description);
                com.Parameters.AddWithValue("@Period", extensionClass.E_Period);
                com.Parameters.AddWithValue("@Date", extensionClass.E_Date);
                com.Parameters.AddWithValue("@Approved", 1);
                com.Parameters.AddWithValue("@Removed", 0);
                rows = com.ExecuteNonQuery();
            }
            con.Close();
            return (rows > 0) ? true : false;
        }

        private void frmExtensions_Load(object sender, EventArgs e)
        {
            string connectionstring = connectionClass.connection;
            con = new SqlConnection(connectionstring);
            cmd = new SqlCommand();
            cmd.Connection = con;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
            dtpDate.CustomFormat = "";
            txtDescription.Text = "";
            txtPeriod.Text = "";
        }

        private bool ValidateData()
        {
            bool boo = true;
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Description is required!");
                boo = false;
            }
            if (string.IsNullOrEmpty(txtPeriod.Text))
            {
                MessageBox.Show("Period is required!");
                boo = false;
            }
            if (dtpDate.CustomFormat == "")
            {
                MessageBox.Show("Date is required!");
                boo = false;
            }
            return boo;
        }
    }
}
