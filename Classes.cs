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
    public partial class frmClasses : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        Master master = new Master();
        ApartmentTypeClass apartmentTypeClass = new ApartmentTypeClass();
        ConnectionClass connectionClass = new ConnectionClass();

        public frmClasses()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Visible = true;
            this.Visible = false;
        }

        private void frmClasses_Load(object sender, EventArgs e)
        {
            string connectionstring = connectionClass.connection;
            con = new SqlConnection(connectionstring);
            cmd = new SqlCommand();
            cmd.Connection = con;
            DisplayApartmentTypes();
            dgvClasses.ReadOnly = true;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            DisplayApartmentTypes();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvClasses.DataSource = GetApartmentsTypesByTitle();
        }

        public DataTable GetApartmentsTypesByTitle()
        {
            var datatable = new DataTable();
            con.Open();
            using (SqlCommand com = new SqlCommand(apartmentTypeClass.SearchQuery, con))
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

        private void DisplayApartmentTypes()
        {
            dgvClasses.DataSource = GetApartmentTypes();
        }

        public DataTable GetApartmentTypes()
        {
            var datatable = new DataTable();
            con.Open();
            using (SqlCommand com = new SqlCommand(apartmentTypeClass.SelectQuery, con))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                {
                    adapter.Fill(datatable);
                }
            }
            con.Close();
            return datatable;
        }
    }
}
