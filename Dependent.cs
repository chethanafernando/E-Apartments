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
    public partial class frmDependent : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        Master master = new Master();
        DependentClass dependentClass = new DependentClass();
        ConnectionClass connectionClass = new ConnectionClass();

        public frmDependent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                dependentClass.D_Name = txtName.Text;
                dependentClass.D_Address = txtAddress.Text;
                dependentClass.D_NICorPassport = txtNIC.Text;
                dependentClass.D_Contact = int.Parse(txtContact.Text);
                dependentClass.D_IsServant = chkServant.Checked;
                var success = InsertDependent(dependentClass);
                if (success)
                {
                    ClearData();
                    DisplayDependents();
                    MessageBox.Show("Data Inserted Successfully!");
                }
                else
                {
                    MessageBox.Show("Error occured. Please try again...");
                }
            }
        }

        public bool InsertDependent(DependentClass dependentClass)
        {
            int rows;
            con.Open();
            using (SqlCommand com = new SqlCommand(dependentClass.InsertQuery, con))
            {
                com.Parameters.AddWithValue("@Name", dependentClass.D_Name);
                com.Parameters.AddWithValue("@Address", dependentClass.D_Address);
                com.Parameters.AddWithValue("@NIC", dependentClass.D_NICorPassport);
                com.Parameters.AddWithValue("@Contact", dependentClass.D_Contact);
                com.Parameters.AddWithValue("@IsServant", dependentClass.D_IsServant);
                com.Parameters.AddWithValue("@Removed", 0);
                rows = com.ExecuteNonQuery();
            }
            con.Close();
            return (rows > 0) ? true : false;
        }

        private void frmDependent_Load(object sender, EventArgs e)
        {
            string connectionstring = connectionClass.connection;
            con = new SqlConnection(connectionstring);
            cmd = new SqlCommand();
            cmd.Connection = con;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            DisplayDependents();
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
            chkServant.Checked = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                dependentClass.D_ID = int.Parse(txtID.Text);
                dependentClass.D_Name = txtName.Text;
                dependentClass.D_Address = txtAddress.Text;
                dependentClass.D_NICorPassport = txtNIC.Text;
                dependentClass.D_Contact = int.Parse(txtContact.Text);
                dependentClass.D_IsServant = chkServant.Checked;
                var success = UpdateDependent(dependentClass);
                if (success)
                {
                    ClearData();
                    DisplayDependents();
                    MessageBox.Show("Data Updated Successfully!");
                    btnSave.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error occured. Please try again...");
                }
            }
        }

        public bool UpdateDependent(DependentClass dependentClass)
        {
            int rows;
            con.Open();
            using (SqlCommand com = new SqlCommand(dependentClass.UpdateQuery, con))
            {
                com.Parameters.AddWithValue("@Name", dependentClass.D_Name);
                com.Parameters.AddWithValue("@Address", dependentClass.D_Address);
                com.Parameters.AddWithValue("@NIC", dependentClass.D_NICorPassport);
                com.Parameters.AddWithValue("@Contact", dependentClass.D_Contact);
                com.Parameters.AddWithValue("@IsServant", dependentClass.D_IsServant ? true : false);
                com.Parameters.AddWithValue("@ID", dependentClass.D_ID);
                rows = com.ExecuteNonQuery();
            }
            con.Close();
            return (rows > 0) ? true : false;
        }

        private void DisplayDependents()
        {
            dgvdependent.DataSource = GetDependents();
        }

        public DataTable GetDependents()
        {
            var datatable = new DataTable();
            con.Open();
            using (SqlCommand com = new SqlCommand(dependentClass.SelectQuery, con))
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
            dependentClass.D_ID = int.Parse(txtID.Text);
            var success = DeleteDependent(dependentClass);
            if (success)
            {
                ClearData();
                DisplayDependents();
                MessageBox.Show("Data Deleted Successfully!");
                btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error occured. Please try again...");
            }
        }

        public bool DeleteDependent(DependentClass dependentClass)
        {
            int rows;
            con.Open();
            using (SqlCommand com = new SqlCommand(dependentClass.DeleteQuery, con))
            {
                com.Parameters.AddWithValue("@ID", dependentClass.D_ID);
                rows = com.ExecuteNonQuery();
            }
            con.Close();
            return (rows > 0) ? true : false;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvdependent.DataSource = GetDependentByName();
        }

        public DataTable GetDependentByName()
        {
            var datatable = new DataTable();
            con.Open();
            using (SqlCommand com = new SqlCommand(dependentClass.SearchQuery, con))
            {
                com.Parameters.AddWithValue("@OName", txtSearch.Text);
                com.Parameters.AddWithValue("@DName", txtSearch.Text);
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
            DisplayDependents();
        }

        private void dgvOccupant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvdependent.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            PopulateDependents();
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void PopulateDependents()
        {
            txtName.Text = dgvdependent.CurrentRow.Cells["Name"].Value.ToString();
            txtAddress.Text = dgvdependent.CurrentRow.Cells["Address"].Value.ToString();
            txtNIC.Text = dgvdependent.CurrentRow.Cells["NICorPassport"].Value.ToString();
            txtContact.Text = dgvdependent.CurrentRow.Cells["Contact"].Value.ToString();
            chkServant.Checked = bool.Parse(dgvdependent.CurrentRow.Cells["IsServant"].Value.ToString());
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
    }
}
