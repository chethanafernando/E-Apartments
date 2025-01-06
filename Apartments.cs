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
    public partial class frmApartments : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        Master master = new Master();
        ApartmentClass apartmentClass = new ApartmentClass();
        ConnectionClass connectionClass = new ConnectionClass();

        public frmApartments()
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
            dgvApartment.DataSource = GetApartmentByNumber();
        }

        public DataTable GetApartmentByNumber()
        {
            var datatable = new DataTable();
            con.Open();
            using (SqlCommand com = new SqlCommand(apartmentClass.SearchQuery, con))
            {
                com.Parameters.AddWithValue("@Number", txtSearch.Text);
                com.Parameters.AddWithValue("@Location", txtSearch.Text);
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
            DisplayApartments();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                apartmentClass.A_ApartmentNumber = int.Parse(txtAptNumber.Text);
                apartmentClass.A_ApartmentTypeID = int.Parse(cmbAptType.SelectedValue.ToString());
                apartmentClass.A_IsAvailable = chkAvailable.Checked;
                apartmentClass.A_ParkID = int.Parse(cmbPark.SelectedValue.ToString());
                apartmentClass.A_Location = txtLocation.Text;
                apartmentClass.A_DepositAmount = Decimal.Parse(txtDepAmt.Text);
                apartmentClass.A_MaxAllowedPerson = int.Parse(txtMaxAllP.Text);
                apartmentClass.A_ReservationFee = Decimal.Parse(txtResFee.Text);
                var success = InsertApartment(apartmentClass);
                if (success)
                {
                    ClearData();
                    DisplayApartments();
                    MessageBox.Show("Data Inserted Successfully!");
                }
                else
                {
                    MessageBox.Show("Error occured. Please try again...");
                }
            }
        }

        public bool InsertApartment(ApartmentClass apartmentClass)
        {
            int rows;
            con.Open();
            using (SqlCommand com = new SqlCommand(apartmentClass.InsertQuery, con))
            {
                com.Parameters.AddWithValue("@ApartmentNumber", apartmentClass.A_ApartmentNumber);
                com.Parameters.AddWithValue("@ApartmentType", apartmentClass.A_ApartmentTypeID);
                com.Parameters.AddWithValue("@IsAvailable", apartmentClass.A_IsAvailable);
                com.Parameters.AddWithValue("@ParkID", apartmentClass.A_ParkID);
                com.Parameters.AddWithValue("@Location", apartmentClass.A_Location);
                com.Parameters.AddWithValue("@DepositAmount", apartmentClass.A_DepositAmount);
                com.Parameters.AddWithValue("@MaxAllowedPerson", apartmentClass.A_MaxAllowedPerson);
                com.Parameters.AddWithValue("@ReservationFee", apartmentClass.A_ReservationFee);
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
            txtAptNumber.Clear();
            txtResFee.Clear();
            txtMaxAllP.Clear();
            txtDepAmt.Clear();
            txtLocation.Clear();
            cmbAptType.Text = "";
            cmbPark.Text = "";
            chkAvailable.Checked = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                apartmentClass.A_BuildingID = int.Parse(txtID.Text);
                apartmentClass.A_ApartmentNumber = int.Parse(txtAptNumber.Text);
                apartmentClass.A_ApartmentTypeID = int.Parse(cmbAptType.SelectedValue.ToString());
                apartmentClass.A_IsAvailable = chkAvailable.Checked;
                apartmentClass.A_ParkID = int.Parse(cmbPark.SelectedValue.ToString());
                apartmentClass.A_Location = txtLocation.Text;
                apartmentClass.A_DepositAmount = Decimal.Parse(txtDepAmt.Text);
                apartmentClass.A_MaxAllowedPerson = int.Parse(txtMaxAllP.Text);
                apartmentClass.A_ReservationFee = Decimal.Parse(txtResFee.Text);
                var success = UpdateApartments(apartmentClass);
                if (success)
                {
                    ClearData();
                    DisplayApartments();
                    MessageBox.Show("Data Updated Successfully!");
                    btnSave.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error occured. Please try again...");
                }
            }
        }

        public bool UpdateApartments(ApartmentClass apartmentClass)
        {
            int rows;
            con.Open();
            using (SqlCommand com = new SqlCommand(apartmentClass.UpdateQuery, con))
            {
                com.Parameters.AddWithValue("@ApartmentNumber", apartmentClass.A_ApartmentNumber);
                com.Parameters.AddWithValue("@ApartmentType", apartmentClass.A_ApartmentTypeID);
                com.Parameters.AddWithValue("@IsAvailable", apartmentClass.A_IsAvailable);
                com.Parameters.AddWithValue("@ParkID", apartmentClass.A_ParkID);
                com.Parameters.AddWithValue("@Location", apartmentClass.A_Location);
                com.Parameters.AddWithValue("@DepositAmount", apartmentClass.A_DepositAmount);
                com.Parameters.AddWithValue("@MaxAllowedPerson", apartmentClass.A_MaxAllowedPerson);
                com.Parameters.AddWithValue("@ReservationFee", apartmentClass.A_ReservationFee);
                com.Parameters.AddWithValue("@ID", apartmentClass.A_BuildingID);
                rows = com.ExecuteNonQuery();
            }
            con.Close();
            return (rows > 0) ? true : false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            apartmentClass.A_BuildingID = int.Parse(txtID.Text);
            var success = DeleteApartment(apartmentClass);
            if (success)
            {
                ClearData();
                DisplayApartments();
                MessageBox.Show("Data Deleted Successfully!");
                btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error occured. Please try again...");
            }
        }

        public bool DeleteApartment(ApartmentClass apartmentClass)
        {
            int rows;
            con.Open();
            using (SqlCommand com = new SqlCommand(apartmentClass.DeleteQuery, con))
            {
                com.Parameters.AddWithValue("@ID", apartmentClass.A_BuildingID);
                rows = com.ExecuteNonQuery();
            }
            con.Close();
            return (rows > 0) ? true : false;
        }

        private void frmApartments_Load(object sender, EventArgs e)
        {
            string connectionstring = connectionClass.connection;
            con = new SqlConnection(connectionstring);
            cmd = new SqlCommand();
            cmd.Connection = con;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            DisplayApartments();
            LoadApartmentTypeData();
            LoadParkData();
        }

        private void DisplayApartments()
        {
            dgvApartment.DataSource = GetApartments();
        }

        public DataTable GetApartments()
        {
            var datatable = new DataTable();
            con.Open();
            using (SqlCommand com = new SqlCommand(apartmentClass.SelectQuery2, con))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                {
                    adapter.Fill(datatable);
                }
            }
            con.Close();
            return datatable;
        }

        private void dgvApartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvApartment.Rows[e.RowIndex].Cells["BuildingID"].Value.ToString();
            PopulateApartments();
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void PopulateApartments()
        {
            txtID.Text = dgvApartment.CurrentRow.Cells["BuildingID"].Value.ToString();
            txtAptNumber.Text = dgvApartment.CurrentRow.Cells["ApartmentNumber"].Value.ToString();
            txtLocation.Text = dgvApartment.CurrentRow.Cells["Location"].Value.ToString();
            txtDepAmt.Text = dgvApartment.CurrentRow.Cells["DepositAmount"].Value.ToString();
            txtMaxAllP.Text = dgvApartment.CurrentRow.Cells["MaxAllowedPerson"].Value.ToString();
            txtResFee.Text = dgvApartment.CurrentRow.Cells["ReservationFee"].Value.ToString();
            chkAvailable.Checked = bool.Parse(dgvApartment.CurrentRow.Cells["Available"].Value.ToString());
            cmbAptType.Text = dgvApartment.CurrentRow.Cells["Class"].Value.ToString();
            cmbPark.Text = dgvApartment.CurrentRow.Cells["ParkArea"].Value.ToString();
        }

        private bool ValidateData()
        {
            bool boo = true;
            if (string.IsNullOrEmpty(txtAptNumber.Text))
            {
                MessageBox.Show("Apartment number is required!");
                boo = false;
            }
            if (string.IsNullOrEmpty(cmbAptType.Text))
            {
                MessageBox.Show("Apartment type is required!");
                boo = false;
            }
            if (string.IsNullOrEmpty(cmbPark.Text))
            {
                MessageBox.Show("Park is required!");
                boo = false;
            }
            if (string.IsNullOrEmpty(txtLocation.Text))
            {
                MessageBox.Show("Location is required!");
                boo = false;
            }
            if (string.IsNullOrEmpty(txtDepAmt.Text))
            {
                MessageBox.Show("Deposit amount is required!");
                boo = false;
            }
            if (string.IsNullOrEmpty(txtMaxAllP.Text))
            {
                MessageBox.Show("Max allowed person is required!");
                boo = false;
            }
            if (string.IsNullOrEmpty(txtResFee.Text))
            {
                MessageBox.Show("Reservation fee is required!");
                boo = false;
            }
            return boo;
        }

        private void LoadApartmentTypeData()
        {
            string query = "SELECT AT_ID, AT_Title FROM ApartmentType WHERE AT_IsRemoved = 0";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "ApartmentType");
            cmbAptType.DisplayMember = "AT_Title";
            cmbAptType.ValueMember = "AT_ID";
            cmbAptType.DataSource = ds.Tables["ApartmentType"];
            con.Close();
        }

        private void LoadParkData()
        {
            string query = "SELECT P_ID, P_Title FROM Park WHERE P_IsRemoved = 0 AND P_IsAvailable = 0";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "Park");
            cmbPark.DisplayMember = "P_Title";
            cmbPark.ValueMember = "P_ID";
            cmbPark.DataSource = ds.Tables["Park"];
            con.Close();
        }
    }
}
