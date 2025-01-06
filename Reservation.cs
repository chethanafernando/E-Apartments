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
    public partial class frmReservation : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        Master master = new Master();
        ReservationClass reservationClass = new ReservationClass();
        ConnectionClass connectionClass = new ConnectionClass();
        public int userid = int.Parse(LoginInfo.UserID);

        public frmReservation()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                reservationClass.R_ApartmentID = int.Parse(cmbApart.SelectedValue.ToString());
                reservationClass.R_OccupantID = int.Parse(cmbOccu.SelectedValue.ToString());
                reservationClass.R_Date = dtpDate.Value;
                reservationClass.R_PaymentID = int.Parse(txtPayID.Text);
                reservationClass.R_IsAdditonalPark = chkAddPark.Checked;
                reservationClass.R_IsReserved = chkReserved.Checked;
                var success = InsertReservation(reservationClass);
                if (success)
                {
                    ClearData();
                    DisplayReservation();
                    MessageBox.Show("Data Inserted Successfully!");
                }
                else
                {
                    MessageBox.Show("Error occured. Please try again...");
                }
            }
        }

        public bool InsertReservation(ReservationClass reservationClass)
        {
            int rows;
            con.Open();
            using (SqlCommand com = new SqlCommand(reservationClass.InsertQuery, con))
            {
                com.Parameters.AddWithValue("@AptID", reservationClass.R_ApartmentID);
                com.Parameters.AddWithValue("@OccID", reservationClass.R_OccupantID);
                com.Parameters.AddWithValue("@Date", reservationClass.R_Date);
                com.Parameters.AddWithValue("@PayID", reservationClass.R_PaymentID);
                com.Parameters.AddWithValue("@AddPark", reservationClass.R_IsAdditonalPark);
                com.Parameters.AddWithValue("@ForDate", DateTime.Now);
                com.Parameters.AddWithValue("@IsReserved", reservationClass.R_IsReserved);
                com.Parameters.AddWithValue("@ReservedBy", userid);
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
            dtpDate.CustomFormat = "";
            txtPayID.Clear();
            cmbApart.Text = "";
            cmbOccu.Text = "";
            chkAddPark.Checked = false;
            chkReserved.Checked = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                reservationClass.R_ID = int.Parse(txtID.Text);
                reservationClass.R_ApartmentID = int.Parse(cmbApart.SelectedValue.ToString());
                reservationClass.R_OccupantID = int.Parse(cmbOccu.SelectedValue.ToString());
                reservationClass.R_Date = dtpDate.Value;
                reservationClass.R_PaymentID = int.Parse(txtPayID.Text);
                reservationClass.R_IsAdditonalPark = chkAddPark.Checked;
                reservationClass.R_IsReserved = chkReserved.Checked;
                var success = UpdateReservation(reservationClass);
                if (success)
                {
                    ClearData();
                    DisplayReservation();
                    MessageBox.Show("Data Updated Successfully!");
                    btnSave.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error occured. Please try again...");
                }
            }
        }

        public bool UpdateReservation(ReservationClass reservationClass)
        {
            int rows;
            con.Open();
            using (SqlCommand com = new SqlCommand(reservationClass.UpdateQuery, con))
            {
                com.Parameters.AddWithValue("@AptID", reservationClass.R_ApartmentID);
                com.Parameters.AddWithValue("@OccID", reservationClass.R_OccupantID);
                com.Parameters.AddWithValue("@Date", reservationClass.R_Date);
                com.Parameters.AddWithValue("@PayID", reservationClass.R_PaymentID);
                com.Parameters.AddWithValue("@AddPark", reservationClass.R_IsAdditonalPark);
                com.Parameters.AddWithValue("@ForDate", DateTime.Now);
                com.Parameters.AddWithValue("@IsReserved", reservationClass.R_IsReserved);
                com.Parameters.AddWithValue("@ReservedBy", userid);
                com.Parameters.AddWithValue("@ID", reservationClass.R_ID);
                rows = com.ExecuteNonQuery();
            }
            con.Close();
            return (rows > 0) ? true : false;
        }

        private void DisplayReservation()
        {
            dgvReservation.DataSource = GetReservations();
        }

        public DataTable GetReservations()
        {
            var datatable = new DataTable();
            con.Open();
            using (SqlCommand com = new SqlCommand(reservationClass.SelectQuery, con))
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
            reservationClass.R_ID = int.Parse(txtID.Text);
            var success = DeleteReservation(reservationClass);
            if (success)
            {
                ClearData();
                DisplayReservation();
                MessageBox.Show("Data Deleted Successfully!");
                btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error occured. Please try again...");
            }
        }

        public bool DeleteReservation(ReservationClass reservationClass)
        {
            int rows;
            con.Open();
            using (SqlCommand com = new SqlCommand(reservationClass.DeleteQuery, con))
            {
                com.Parameters.AddWithValue("@ID", reservationClass.R_ID);
                rows = com.ExecuteNonQuery();
            }
            con.Close();
            return (rows > 0) ? true : false;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvReservation.DataSource = GetReservationByDate();
        }

        public DataTable GetReservationByDate()
        {
            var datatable = new DataTable();
            con.Open();
            using (SqlCommand com = new SqlCommand(reservationClass.SearchQuery, con))
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
            DisplayReservation();
        }

        private void dgvReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvReservation.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            PopulateReservations();
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void PopulateReservations()
        {
            cmbApart.Text = dgvReservation.CurrentRow.Cells["Apartment"].Value.ToString();
            cmbOccu.Text = dgvReservation.CurrentRow.Cells["Occupant"].Value.ToString();
            dtpDate.Value = DateTime.Parse(dgvReservation.CurrentRow.Cells["Date"].Value.ToString());
            txtPayID.Text = dgvReservation.CurrentRow.Cells["PayID"].Value.ToString();
            chkAddPark.Checked = bool.Parse(dgvReservation.CurrentRow.Cells["AddPark"].Value.ToString());
            chkReserved.Checked = bool.Parse(dgvReservation.CurrentRow.Cells["IsReserved"].Value.ToString());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Visible = true;
            this.Visible = false;
        }

        private bool ValidateData()
        {
            bool boo = true;
            if (string.IsNullOrEmpty(cmbApart.Text))
            {
                MessageBox.Show("Apartment is required!");
                boo = false;
            }
            if (string.IsNullOrEmpty(cmbOccu.Text))
            {
                MessageBox.Show("Occupant is required!");
                boo = false;
            }
            if (dtpDate.CustomFormat == "")
            {
                MessageBox.Show("Date is required!");
                boo = false;
            }
            return boo;
        }

        private void frmReservation_Load(object sender, EventArgs e)
        {
            string connectionstring = connectionClass.connection;
            con = new SqlConnection(connectionstring);
            cmd = new SqlCommand();
            cmd.Connection = con;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            DisplayReservation();
            LoadOccupantData();
            LoadApartmentData();
        }

        private void LoadApartmentData()
        {
            string query = "SELECT A_BuildingID, A_ApartmentNumber FROM Apartment WHERE A_IsRemoved = 0";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "Apartment");
            cmbApart.DisplayMember = "A_ApartmentNumber";
            cmbApart.ValueMember = "A_BuildingID";
            cmbApart.DataSource = ds.Tables["Apartment"];
            con.Close();
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
