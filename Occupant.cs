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
    public partial class frmOccupant : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        Master master = new Master();
        OccupantClass occupantClass = new OccupantClass();
        ConnectionClass connectionClass = new ConnectionClass();

        public frmOccupant()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Visible = true;
            this.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                occupantClass.O_Name = txtName.Text;
                occupantClass.O_Address = txtAddress.Text;
                occupantClass.O_NICorPassport = txtNIC.Text;
                occupantClass.O_Contact = int.Parse(txtContact.Text);
                if(cmbDependent.SelectedItem != null || cmbDependent.Text != "")
                {
                    occupantClass.O_DependentID = int.Parse(cmbDependent.SelectedValue.ToString());
                }
                var success = InsertOccupant(occupantClass);
                if (success)
                {
                    ClearData();
                    DisplayOccupants();
                    MessageBox.Show("Data Inserted Successfully!");
                }
                else
                {
                    MessageBox.Show("Error occured. Please try again...");
                }
            }
        }

        public bool InsertOccupant(OccupantClass occupantClass)
        {
            int rows;
            con.Open();
            using (SqlCommand com = new SqlCommand(occupantClass.InsertQuery, con))
            {
                com.Parameters.AddWithValue("@Name", occupantClass.O_Name);
                com.Parameters.AddWithValue("@Address", occupantClass.O_Address);
                com.Parameters.AddWithValue("@NIC", occupantClass.O_NICorPassport);
                com.Parameters.AddWithValue("@Contact", occupantClass.O_Contact);
                com.Parameters.AddWithValue("@DependentID", occupantClass.O_DependentID);
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
            txtName.Clear();
            txtAddress.Clear();
            txtNIC.Clear();
            txtContact.Clear();
            cmbDependent.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                occupantClass.O_ID = int.Parse(txtID.Text);
                occupantClass.O_Name = txtName.Text;
                occupantClass.O_Address = txtAddress.Text;
                occupantClass.O_NICorPassport = txtNIC.Text;
                occupantClass.O_Contact = int.Parse(txtContact.Text);
                occupantClass.O_DependentID = int.Parse(cmbDependent.SelectedValue.ToString());
                var success = UpdateOccupant(occupantClass);
                if (success)
                {
                    ClearData();
                    DisplayOccupants();
                    MessageBox.Show("Data Updated Successfully!");
                    btnSave.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error occured. Please try again...");
                }
            }
        }

        public bool UpdateOccupant(OccupantClass occupantClass)
        {
            int rows;
            con.Open();
            using (SqlCommand com = new SqlCommand(occupantClass.UpdateQuery, con))
            {
                com.Parameters.AddWithValue("@Name", occupantClass.O_Name);
                com.Parameters.AddWithValue("@Address", occupantClass.O_Address);
                com.Parameters.AddWithValue("@NIC", occupantClass.O_NICorPassport);
                com.Parameters.AddWithValue("@Contact", occupantClass.O_Contact);
                com.Parameters.AddWithValue("@DependentID", occupantClass.O_DependentID);
                com.Parameters.AddWithValue("@ID", occupantClass.O_ID);
                rows = com.ExecuteNonQuery();
            }
            con.Close();
            return (rows > 0) ? true : false;
        }

        private void DisplayOccupants()
        {
            dgvOccupant.DataSource = GetOccupants();
            this.dgvOccupant.Columns["Dependent"].Visible = false;
        }

        public DataTable GetOccupants()
        {
            var datatable = new DataTable();
            con.Open();
            using (SqlCommand com = new SqlCommand(occupantClass.SelectQuery, con))
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
            occupantClass.O_ID = int.Parse(txtID.Text);
            var success = DeleteOccupant(occupantClass);
            if (success)
            {
                ClearData();
                DisplayOccupants();
                MessageBox.Show("Data Deleted Successfully!");
                btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error occured. Please try again...");
            }
        }

        public bool DeleteOccupant(OccupantClass occupantClass)
        {
            int rows;
            con.Open();
            using (SqlCommand com = new SqlCommand(occupantClass.DeleteQuery, con))
            {
                com.Parameters.AddWithValue("@ID", occupantClass.O_ID);
                rows = com.ExecuteNonQuery();
            }
            con.Close();
            return (rows > 0) ? true : false;
        }

        public DataTable GetOccupantsByNameOrNIC()
        {
            var datatable = new DataTable();
            con.Open();
            using (SqlCommand com = new SqlCommand(occupantClass.SearchQuery, con))
            {
                com.Parameters.AddWithValue("@Name", txtSearch.Text);
                com.Parameters.AddWithValue("@NIC", txtSearch.Text);
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
            dgvOccupant.DataSource = GetOccupantsByNameOrNIC();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DisplayOccupants();
            this.dgvOccupant.Columns["Dependent"].Visible = false;
        }

        private void dgvOccupant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvOccupant.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            PopulateOccupants();
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void PopulateOccupants()
        {
            txtName.Text = dgvOccupant.CurrentRow.Cells["Name"].Value.ToString();
            txtAddress.Text = dgvOccupant.CurrentRow.Cells["Address"].Value.ToString();
            txtNIC.Text = dgvOccupant.CurrentRow.Cells["NICorPassport"].Value.ToString();
            txtContact.Text = dgvOccupant.CurrentRow.Cells["Contact"].Value.ToString();
            cmbDependent.Text = dgvOccupant.CurrentRow.Cells["Dependent"].Value.ToString();
        }

        private void frmOccupant_Load(object sender, EventArgs e)
        {
            string connectionstring = connectionClass.connection;
            con = new SqlConnection(connectionstring);
            cmd = new SqlCommand();
            cmd.Connection = con;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            DisplayOccupants();
            LoadDependentData();
        }

        private bool ValidateData()
        {
            bool boo = true;
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name is required!");
                boo = false;
            }
            if (string.IsNullOrEmpty(txtNIC.Text))
            {
                MessageBox.Show("NIC or Passport number is required!");
                boo = false;
            }
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Address is required!");
                boo = false;
            }
            if (string.IsNullOrEmpty(txtContact.Text))
            {
                MessageBox.Show("Contact is required!");
                boo = false;
            }
            return boo;
        }

        private void LoadDependentData()
        {
            string query = "SELECT D_ID, D_Name FROM Dependent WHERE D_Removed = 0";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "Dependent");
            cmbDependent.DisplayMember = "D_Name";
            cmbDependent.ValueMember = "D_ID";
            cmbDependent.DataSource = ds.Tables["Dependent"];
            con.Close();
        }
    }
}
