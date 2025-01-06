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
    public partial class frmPark : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        Master master = new Master();
        ParkClass parkClass = new ParkClass();
        ConnectionClass connectionClass = new ConnectionClass();

        public frmPark()
        {
            InitializeComponent();
        }

        private void dgvPark_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvPark.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            PopulatePark();
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void PopulatePark()
        {
            txtTitle.Text = dgvPark.CurrentRow.Cells["Title"].Value.ToString();
            chkAvailable.Checked = bool.Parse(dgvPark.CurrentRow.Cells["IsAvailable"].Value.ToString());
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
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                MessageBox.Show("Title is required!");
                boo = false;
            }
            if (string.IsNullOrEmpty(chkAvailable.Text))
            {
                MessageBox.Show("Park availability is required!");
                boo = false;
            }
            return boo;
        }

        private void frmPark_Load(object sender, EventArgs e)
        {
            string connectionstring = connectionClass.connection;
            con = new SqlConnection(connectionstring);
            cmd = new SqlCommand();
            cmd.Connection = con;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            DisplayPark();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvPark.DataSource = GetParkByTitle();
        }

        public DataTable GetParkByTitle()
        {
            var datatable = new DataTable();
            con.Open();
            using (SqlCommand com = new SqlCommand(parkClass.SearchQuery, con))
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
            DisplayPark();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                parkClass.P_Title = txtTitle.Text;
                parkClass.P_IsAvailable = chkAvailable.Checked;
                var success = InsertPark(parkClass);
                if (success)
                {
                    ClearData();
                    DisplayPark();
                    MessageBox.Show("Data Inserted Successfully!");
                }
                else
                {
                    MessageBox.Show("Error occured. Please try again...");
                }
            }
        }

        public bool InsertPark(ParkClass parkClass)
        {
            int rows;
            con.Open();
            using (SqlCommand com = new SqlCommand(parkClass.InsertQuery, con))
            {
                com.Parameters.AddWithValue("@Title", parkClass.P_Title);
                com.Parameters.AddWithValue("@IsAvailable", parkClass.P_IsAvailable);
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
            chkAvailable.Checked = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                parkClass.P_ID = int.Parse(txtID.Text);
                parkClass.P_Title = txtTitle.Text;
                parkClass.P_IsAvailable = chkAvailable.Checked;
                var success = UpdatePark(parkClass);
                if (success)
                {
                    ClearData();
                    DisplayPark();
                    MessageBox.Show("Data Updated Successfully!");
                    btnSave.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error occured. Please try again...");
                }
            }
        }

        public bool UpdatePark(ParkClass parkClass)
        {
            int rows;
            con.Open();
            using (SqlCommand com = new SqlCommand(parkClass.UpdateQuery, con))
            {
                com.Parameters.AddWithValue("@Title", parkClass.P_Title);
                com.Parameters.AddWithValue("@IsAvailable", parkClass.P_IsAvailable);
                com.Parameters.AddWithValue("@ID", parkClass.P_ID);
                rows = com.ExecuteNonQuery();
            }
            con.Close();
            return (rows > 0) ? true : false;
        }

        private void DisplayPark()
        {
            dgvPark.DataSource = GetPark();
        }

        public DataTable GetPark()
        {
            var datatable = new DataTable();
            con.Open();
            using (SqlCommand com = new SqlCommand(parkClass.SelectQuery, con))
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
            parkClass.P_ID = int.Parse(txtID.Text);
            var success = DeletePark(parkClass);
            if (success)
            {
                ClearData();
                DisplayPark();
                MessageBox.Show("Data Deleted Successfully!");
                btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error occured. Please try again...");
            }
        }

        public bool DeletePark(ParkClass parkClass)
        {
            int rows;
            con.Open();
            using (SqlCommand com = new SqlCommand(parkClass.DeleteQuery, con))
            {
                com.Parameters.AddWithValue("@ID", parkClass.P_ID);
                rows = com.ExecuteNonQuery();
            }
            con.Close();
            return (rows > 0) ? true : false;
        }
    }
}
