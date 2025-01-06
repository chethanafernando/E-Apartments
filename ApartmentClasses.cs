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
    public partial class frmApartmentClasses : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        Master master = new Master();
        ApartmentTypeClass aptTypeClass = new ApartmentTypeClass();
        ConnectionClass connectionClass = new ConnectionClass();

        public frmApartmentClasses()
        {
            InitializeComponent();
        }

        private void frmApartmentClasses_Load(object sender, EventArgs e)
        {
            string connectionstring = connectionClass.connection;
            con = new SqlConnection(connectionstring);
            cmd = new SqlCommand();
            cmd.Connection = con;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            DisplayClasses();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvApartmentType.DataSource = GetClassesByTitle();
        }

        public DataTable GetClassesByTitle()
        {
            var datatable = new DataTable();
            con.Open();
            using (SqlCommand com = new SqlCommand(aptTypeClass.SearchQuery, con))
            {
                com.Parameters.AddWithValue("@Title", txtSearch.Text);
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
            DisplayClasses();
        }

        private void dgvApartmentType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvApartmentType.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            PopulateClasses();
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void PopulateClasses()
        {
            txtTitle.Text = dgvApartmentType.CurrentRow.Cells["Title"].Value.ToString();
            chkBedRoom.Checked = bool.Parse(dgvApartmentType.CurrentRow.Cells["IsBedroom"].Value.ToString());
            txtBedroomCount.Text = dgvApartmentType.CurrentRow.Cells["BedroomCount"].Value.ToString();
            chkAttachedBathroom.Checked = bool.Parse(dgvApartmentType.CurrentRow.Cells["IsAttachedBathroom"].Value.ToString());
            txtAttachedBathroomCount.Text = dgvApartmentType.CurrentRow.Cells["AttachedBathroomsCount"].Value.ToString();
            chkCommonBathroom.Checked = bool.Parse(dgvApartmentType.CurrentRow.Cells["IsCommonBathroom"].Value.ToString());
            chkIsServentRoom.Checked = bool.Parse(dgvApartmentType.CurrentRow.Cells["IsServantsRoom"].Value.ToString());
            chkIsServantsToilet.Checked = bool.Parse(dgvApartmentType.CurrentRow.Cells["IsServantsToilet"].Value.ToString());
            chkDiningArea.Checked = bool.Parse(dgvApartmentType.CurrentRow.Cells["IsDiningArea"].Value.ToString());
            chkLivingArea.Checked = bool.Parse(dgvApartmentType.CurrentRow.Cells["IsLivingArea"].Value.ToString());
            chkIsKitchen.Checked = bool.Parse(dgvApartmentType.CurrentRow.Cells["IsKitchen"].Value.ToString());
            chkIsBalcony.Checked = bool.Parse(dgvApartmentType.CurrentRow.Cells["IsBalcony"].Value.ToString());
            chkTelCon.Checked = bool.Parse(dgvApartmentType.CurrentRow.Cells["IsTelephoneConnection"].Value.ToString());
            chkIsInternetCon.Checked = bool.Parse(dgvApartmentType.CurrentRow.Cells["IsInternetConnection"].Value.ToString());
            chkTVCon.Checked = bool.Parse(dgvApartmentType.CurrentRow.Cells["IsTVConnection"].Value.ToString());
            chkIsParking.Checked = bool.Parse(dgvApartmentType.CurrentRow.Cells["IsParking"].Value.ToString());
            chkGymnasium.Checked = bool.Parse(dgvApartmentType.CurrentRow.Cells["IsGymnasium"].Value.ToString());
            chkSwimPool.Checked = bool.Parse(dgvApartmentType.CurrentRow.Cells["IsSwimmingPool"].Value.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                aptTypeClass.AT_Title = txtTitle.Text;
                aptTypeClass.AT_IsBedroom = chkBedRoom.Checked;
                aptTypeClass.AT_BedroomCount = int.Parse(txtBedroomCount.Text);
                aptTypeClass.AT_IsAttachedBathroom = chkAttachedBathroom.Checked;
                aptTypeClass.AT_IsAttachedBathroomCount = int.Parse(txtAttachedBathroomCount.Text);
                aptTypeClass.AT_IsCommonBathroom = chkCommonBathroom.Checked;
                aptTypeClass.AT_IsServantsRoom = chkIsServentRoom.Checked;
                aptTypeClass.AT_IsServantsToilet = chkIsServantsToilet.Checked;
                aptTypeClass.AT_IsDiningArea = chkDiningArea.Checked;
                aptTypeClass.AT_IsLivingArea = chkLivingArea.Checked;
                aptTypeClass.AT_IsKitchen = chkIsKitchen.Checked;
                aptTypeClass.AT_IsBalcony = chkIsBalcony.Checked;
                aptTypeClass.AT_IsTelephoneConnection = chkTelCon.Checked;
                aptTypeClass.AT_IsInternetConnection = chkIsInternetCon.Checked;
                aptTypeClass.AT_IsTVConnection = chkTVCon.Checked;
                aptTypeClass.AT_IsParking = chkIsParking.Checked;
                aptTypeClass.AT_IsGymnasium = chkGymnasium.Checked;
                aptTypeClass.AT_IsSwimmingPool = chkSwimPool.Checked;
                var success = InsertClasses(aptTypeClass);
                if (success)
                {
                    ClearData();
                    DisplayClasses();
                    MessageBox.Show("Data Inserted Successfully!");
                }
                else
                {
                    MessageBox.Show("Error occured. Please try again...");
                }
            }
        }

        public bool InsertClasses(ApartmentTypeClass aptTypeClass)
        {
            int rows;
            con.Open();
            using (SqlCommand com = new SqlCommand(aptTypeClass.InsertQuery, con))
            {
                com.Parameters.AddWithValue("@Title", aptTypeClass.AT_Title);
                com.Parameters.AddWithValue("@IsBedroom", aptTypeClass.AT_IsBedroom);
                com.Parameters.AddWithValue("@BedroomCount", aptTypeClass.AT_BedroomCount);
                com.Parameters.AddWithValue("@IsAttachedBathroom", aptTypeClass.AT_IsAttachedBathroom);
                com.Parameters.AddWithValue("@IsAttachedBathroomCount", aptTypeClass.AT_IsAttachedBathroomCount);
                com.Parameters.AddWithValue("@IsCommonBathroom", aptTypeClass.AT_IsCommonBathroom);
                com.Parameters.AddWithValue("@IsServantsRoom", aptTypeClass.AT_IsServantsRoom);
                com.Parameters.AddWithValue("@IsServantsToilet", aptTypeClass.AT_IsServantsToilet);
                com.Parameters.AddWithValue("@IsDiningArea", aptTypeClass.AT_IsDiningArea);
                com.Parameters.AddWithValue("@IsLivingArea", aptTypeClass.AT_IsLivingArea);
                com.Parameters.AddWithValue("@IsKitchen", aptTypeClass.AT_IsKitchen);
                com.Parameters.AddWithValue("@IsBalcony", aptTypeClass.AT_IsBalcony);
                com.Parameters.AddWithValue("@IsTelephoneConnection", aptTypeClass.AT_IsTelephoneConnection);
                com.Parameters.AddWithValue("@IsInternetConnection", aptTypeClass.AT_IsInternetConnection);
                com.Parameters.AddWithValue("@IsTVConnection", aptTypeClass.AT_IsTVConnection);
                com.Parameters.AddWithValue("@IsParking", aptTypeClass.AT_IsParking);
                com.Parameters.AddWithValue("@IsGymnasium", aptTypeClass.AT_IsGymnasium);
                com.Parameters.AddWithValue("@IsSwimmingPool", aptTypeClass.AT_IsSwimmingPool);
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
            txtTitle.Clear();
            chkBedRoom.Checked = false;
            txtBedroomCount.Clear();
            chkAttachedBathroom.Checked = false;
            txtAttachedBathroomCount.Clear();
            chkCommonBathroom.Checked = false;
            chkIsServentRoom.Checked = false;
            chkIsServantsToilet.Checked = false;
            chkDiningArea.Checked = false;
            chkLivingArea.Checked = false;
            chkIsKitchen.Checked = false;
            chkIsBalcony.Checked = false;
            chkTelCon.Checked = false;
            chkIsInternetCon.Checked = false;
            chkTVCon.Checked = false;
            chkIsParking.Checked = false;
            chkGymnasium.Checked = false;
            chkSwimPool.Checked = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                aptTypeClass.AT_ID = int.Parse(txtID.Text);
                aptTypeClass.AT_Title = txtTitle.Text;
                aptTypeClass.AT_IsBedroom = chkBedRoom.Checked;
                aptTypeClass.AT_BedroomCount = int.Parse(txtBedroomCount.Text);
                aptTypeClass.AT_IsAttachedBathroom = chkAttachedBathroom.Checked;
                aptTypeClass.AT_IsAttachedBathroomCount = int.Parse(txtAttachedBathroomCount.Text);
                aptTypeClass.AT_IsCommonBathroom = chkCommonBathroom.Checked;
                aptTypeClass.AT_IsServantsRoom = chkIsServentRoom.Checked;
                aptTypeClass.AT_IsServantsToilet = chkIsServantsToilet.Checked;
                aptTypeClass.AT_IsDiningArea = chkDiningArea.Checked;
                aptTypeClass.AT_IsLivingArea = chkLivingArea.Checked;
                aptTypeClass.AT_IsKitchen = chkIsKitchen.Checked;
                aptTypeClass.AT_IsBalcony = chkIsBalcony.Checked;
                aptTypeClass.AT_IsTelephoneConnection = chkTelCon.Checked;
                aptTypeClass.AT_IsInternetConnection = chkIsInternetCon.Checked;
                aptTypeClass.AT_IsTVConnection = chkTVCon.Checked;
                aptTypeClass.AT_IsParking = chkIsParking.Checked;
                aptTypeClass.AT_IsGymnasium = chkGymnasium.Checked;
                aptTypeClass.AT_IsSwimmingPool = chkSwimPool.Checked;
                var success = UpdateClasses(aptTypeClass);
                if (success)
                {
                    ClearData();
                    DisplayClasses();
                    MessageBox.Show("Data Updated Successfully!");
                    btnSave.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error occured. Please try again...");
                }
            }
        }

        public bool UpdateClasses(ApartmentTypeClass aptTypeClass)
        {
            int rows;
            con.Open();
            using (SqlCommand com = new SqlCommand(aptTypeClass.UpdateQuery, con))
            {
                com.Parameters.AddWithValue("@Title", aptTypeClass.AT_Title);
                com.Parameters.AddWithValue("@IsBedroom", aptTypeClass.AT_IsBedroom);
                com.Parameters.AddWithValue("@BedroomCount", aptTypeClass.AT_BedroomCount);
                com.Parameters.AddWithValue("@IsAttachedBathroom", aptTypeClass.AT_IsAttachedBathroom);
                com.Parameters.AddWithValue("@IsAttachedBathroomCount", aptTypeClass.AT_IsAttachedBathroomCount);
                com.Parameters.AddWithValue("@IsCommonBathroom", aptTypeClass.AT_IsCommonBathroom);
                com.Parameters.AddWithValue("@IsServantsRoom", aptTypeClass.AT_IsServantsRoom);
                com.Parameters.AddWithValue("@IsServantsToilet", aptTypeClass.AT_IsServantsToilet);
                com.Parameters.AddWithValue("@IsDiningArea", aptTypeClass.AT_IsDiningArea);
                com.Parameters.AddWithValue("@IsLivingArea", aptTypeClass.AT_IsLivingArea);
                com.Parameters.AddWithValue("@IsKitchen", aptTypeClass.AT_IsKitchen);
                com.Parameters.AddWithValue("@IsBalcony", aptTypeClass.AT_IsBalcony);
                com.Parameters.AddWithValue("@IsTelephoneConnection", aptTypeClass.AT_IsTelephoneConnection);
                com.Parameters.AddWithValue("@IsInternetConnection", aptTypeClass.AT_IsInternetConnection);
                com.Parameters.AddWithValue("@IsTVConnection", aptTypeClass.AT_IsTVConnection);
                com.Parameters.AddWithValue("@IsParking", aptTypeClass.AT_IsParking);
                com.Parameters.AddWithValue("@IsGymnasium", aptTypeClass.AT_IsGymnasium);
                com.Parameters.AddWithValue("@IsSwimmingPool", aptTypeClass.AT_IsSwimmingPool);
                com.Parameters.AddWithValue("@ID", aptTypeClass.AT_ID);
                rows = com.ExecuteNonQuery();
            }
            con.Close();
            return (rows > 0) ? true : false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            aptTypeClass.AT_ID = int.Parse(txtID.Text);
            var success = DeleteClasses(aptTypeClass);
            if (success)
            {
                ClearData();
                DisplayClasses();
                MessageBox.Show("Data Deleted Successfully!");
                btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error occured. Please try again...");
            }
        }

        public bool DeleteClasses(ApartmentTypeClass aptTypeClass)
        {
            int rows;
            con.Open();
            using (SqlCommand com = new SqlCommand(aptTypeClass.DeleteQuery, con))
            {
                com.Parameters.AddWithValue("@ID", aptTypeClass.AT_ID);
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

        private void DisplayClasses()
        {
            dgvApartmentType.DataSource = GetClasses();
        }

        public DataTable GetClasses()
        {
            var datatable = new DataTable();
            con.Open();
            using (SqlCommand com = new SqlCommand(aptTypeClass.SelectQuery, con))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                {
                    adapter.Fill(datatable);
                }
            }
            con.Close();
            return datatable;
        }

        private bool ValidateData()
        {
            bool boo = true;
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                MessageBox.Show("Title is required!");
                boo = false;
            }
            if (string.IsNullOrEmpty(txtBedroomCount.Text))
            {
                MessageBox.Show("Bedroom count is required!");
                boo = false;
            }
            if (string.IsNullOrEmpty(txtAttachedBathroomCount.Text))
            {
                MessageBox.Show("Attached bathroom count is required!");
                boo = false;
            }
            if (string.IsNullOrEmpty(chkBedRoom.Text))
            {
                MessageBox.Show("Bedroom is required!");
                boo = false;
            }
            if (string.IsNullOrEmpty(chkAttachedBathroom.Text))
            {
                MessageBox.Show("Attached Bathroom is required!");
                boo = false;
            }
            return boo;
        }
    }
}
