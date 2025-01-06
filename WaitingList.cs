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
    public partial class frmWaitingList : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        Master master = new Master();
        WaitingListClass waitingListClass = new WaitingListClass();
        ConnectionClass connectionClass = new ConnectionClass();
        public int userid = int.Parse(LoginInfo.UserID);

        public frmWaitingList()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                waitingListClass.W_QueueNumber = int.Parse(txtQueue.Text);
                waitingListClass.W_OccupantID = int.Parse(cmbOccu.SelectedValue.ToString());
                waitingListClass.W_ReservationDate = dtpResDate.Value;
                waitingListClass.W_RequiredDate = dtpReqDate.Value;
                var success = InsertWaitingList(waitingListClass);
                if (success)
                {
                    ClearData();
                    DisplayWaitingList();
                    MessageBox.Show("Data Inserted Successfully!");
                }
                else
                {
                    MessageBox.Show("Error occured. Please try again...");
                }
            }
        }

        public bool InsertWaitingList(WaitingListClass waitingListClass)
        {
            int rows;
            con.Open();
            using (SqlCommand com = new SqlCommand(waitingListClass.InsertQuery, con))
            {
                com.Parameters.AddWithValue("@Queue", waitingListClass.W_QueueNumber);
                com.Parameters.AddWithValue("@OccID", waitingListClass.W_OccupantID);
                com.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                com.Parameters.AddWithValue("@CreatedBy", userid);
                com.Parameters.AddWithValue("@ResDate", waitingListClass.W_ReservationDate);
                com.Parameters.AddWithValue("@ReqDate", waitingListClass.W_RequiredDate);
                com.Parameters.AddWithValue("@Removed", 0);
                rows = com.ExecuteNonQuery();
            }
            con.Close();
            return (rows > 0) ? true : false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
            dtpReqDate.CustomFormat = "";
            dtpResDate.CustomFormat = "";
            txtQueue.Clear();
            cmbOccu.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                waitingListClass.W_ID = int.Parse(txtID.Text);
                waitingListClass.W_QueueNumber = int.Parse(txtQueue.Text);
                waitingListClass.W_OccupantID = int.Parse(cmbOccu.SelectedValue.ToString());
                waitingListClass.W_ReservationDate = dtpResDate.Value;
                waitingListClass.W_RequiredDate = dtpReqDate.Value;
                var success = UpdateWaitingList(waitingListClass);
                if (success)
                {
                    ClearData();
                    DisplayWaitingList();
                    MessageBox.Show("Data Updated Successfully!");
                    btnSave.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error occured. Please try again...");
                }
            }
        }

        public bool UpdateWaitingList(WaitingListClass waitingListClass)
        {
            int rows;
            con.Open();
            using (SqlCommand com = new SqlCommand(waitingListClass.UpdateQuery, con))
            {
                com.Parameters.AddWithValue("@Queue", waitingListClass.W_QueueNumber);
                com.Parameters.AddWithValue("@OccID", waitingListClass.W_OccupantID);
                com.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                com.Parameters.AddWithValue("@CreatedBy", userid);
                com.Parameters.AddWithValue("@ResDate", waitingListClass.W_ReservationDate);
                com.Parameters.AddWithValue("@ReqDate", waitingListClass.W_RequiredDate);
                com.Parameters.AddWithValue("@Removed", 0);
                com.Parameters.AddWithValue("@ID", waitingListClass.W_ID);
                rows = com.ExecuteNonQuery();
            }
            con.Close();
            return (rows > 0) ? true : false;
        }

        private void DisplayWaitingList()
        {
            dgvWaitingList.DataSource = GetWaitingList();
        }

        public DataTable GetWaitingList()
        {
            var datatable = new DataTable();
            con.Open();
            using (SqlCommand com = new SqlCommand(waitingListClass.SelectQuery, con))
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
            waitingListClass.W_ID = int.Parse(txtID.Text);
            var success = DeleteWaitingList(waitingListClass);
            if (success)
            {
                ClearData();
                DisplayWaitingList();
                MessageBox.Show("Data Deleted Successfully!");
                btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error occured. Please try again...");
            }
        }

        public bool DeleteWaitingList(WaitingListClass waitingListClass)
        {
            int rows;
            con.Open();
            using (SqlCommand com = new SqlCommand(waitingListClass.DeleteQuery, con))
            {
                com.Parameters.AddWithValue("@ID", waitingListClass.W_ID);
                rows = com.ExecuteNonQuery();
            }
            con.Close();
            return (rows > 0) ? true : false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Visible = true;
            this.Visible = false;
        }

        private void frmWaitingList_Load(object sender, EventArgs e)
        {
            string connectionstring = connectionClass.connection;
            con = new SqlConnection(connectionstring);
            cmd = new SqlCommand();
            cmd.Connection = con;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            DisplayWaitingList();
            LoadOccupantData();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvWaitingList.DataSource = GetWaitingListByName();
        }

        public DataTable GetWaitingListByName()
        {
            var datatable = new DataTable();
            con.Open();
            using (SqlCommand com = new SqlCommand(waitingListClass.SearchQuery, con))
            {
                com.Parameters.AddWithValue("@Number", txtSearch.Text);
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
            DisplayWaitingList();
        }

        private void dgvWaitingList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvWaitingList.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            PopulateWaitingList();
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void PopulateWaitingList()
        {
            txtQueue.Text = dgvWaitingList.CurrentRow.Cells["Queue"].Value.ToString();
            cmbOccu.Text = dgvWaitingList.CurrentRow.Cells["Occupant"].Value.ToString();
            dtpReqDate.Value = DateTime.Parse(dgvWaitingList.CurrentRow.Cells["RequiredDate"].Value.ToString());
            dtpResDate.Value = DateTime.Parse(dgvWaitingList.CurrentRow.Cells["ReservationDate"].Value.ToString());
        }

        private bool ValidateData()
        {
            bool boo = true;
            if (string.IsNullOrEmpty(txtQueue.Text))
            {
                MessageBox.Show("Queue Number is required!");
                boo = false;
            }
            if (string.IsNullOrEmpty(cmbOccu.Text))
            {
                MessageBox.Show("Occupant is required!");
                boo = false;
            }
            if (dtpResDate.CustomFormat == "")
            {
                MessageBox.Show("Reservation Date is required!");
                boo = false;
            }
            if (dtpReqDate.CustomFormat == "")
            {
                MessageBox.Show("Required Date is required!");
                boo = false;
            }
            return boo;
        }

        private void LoadOccupantData()
        {
            string query = "SELECT O_ID, O_Name FROM Occupant WHERE O_Removed = 0";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "Occupant");
            cmbOccu.DisplayMember = "O_Name";
            cmbOccu.ValueMember = "O_ID";
            cmbOccu.DataSource = ds.Tables["Occupant"];
            con.Close();
        }
    }
}
