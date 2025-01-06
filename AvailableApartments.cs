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
    public partial class frmAvailableApartments : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        Master master = new Master();
        ApartmentClass apartmentClass= new ApartmentClass();
        ConnectionClass connectionClass = new ConnectionClass();

        public frmAvailableApartments()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Visible = true;
            this.Visible = false;
        }

        private void btnAvailable_Click(object sender, EventArgs e)
        {
            dgvApart.DataSource = GetAvailableApartments();
        }

        public DataTable GetAvailableApartments()
        {
            var datatable = new DataTable();
            con.Open();
            using (SqlCommand com = new SqlCommand(apartmentClass.SelectQuery1, con))
            {
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
            dgvApart.DataSource = GetApartmentsByNumberAndLocation();
        }

        public DataTable GetApartmentsByNumberAndLocation()
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


        private void DisplayApartments()
        {
            dgvApart.DataSource = GetApartments();
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

        private void btnAllApart_Click(object sender, EventArgs e)
        {
            DisplayApartments();
        }

        private void frmAvailableApartments_Load(object sender, EventArgs e)
        {
            string connectionstring = connectionClass.connection;
            con = new SqlConnection(connectionstring);
            cmd = new SqlCommand();
            cmd.Connection = con;
            DisplayApartments();
            dgvApart.ReadOnly = true;
        }
    }
}
