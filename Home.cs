using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static E_Apartments.frmLogin;

namespace E_Apartments
{
    public partial class frmHome : Form
    {
        public string role = LoginInfo.Role;
        SqlConnection con;
        SqlCommand cmd;
        public static string invid;
        public int userid = int.Parse(LoginInfo.UserID);
        ConnectionClass connectionClass = new ConnectionClass();

        public frmHome()
        {
            string connectionstring = connectionClass.connection;
            con = new SqlConnection(connectionstring);
            cmd = new SqlCommand();
            cmd.Connection = con;
            InitializeComponent();
            if (role == "Manager")
            {
                userToolStripMenuItem.Visible = false;
            }
            else if (role == "Accountant")
            {
                userToolStripMenuItem.Visible = false;
                manageRefundsToolStripMenuItem.Visible = false;
                manageExtensionsToolStripMenuItem.Visible = false;
                apartmentsToolStripMenuItem.Visible = false;
                classesToolStripMenuItem.Visible = false;
                parkToolStripMenuItem.Visible = false;
            }
            else if (role == "Receptionist")
            {
                userToolStripMenuItem.Visible = false;
                manageRefundsToolStripMenuItem.Visible = false;
                manageExtensionsToolStripMenuItem.Visible = false;
                apartmentsToolStripMenuItem.Visible = false;
                classesToolStripMenuItem.Visible = false;
                parkToolStripMenuItem.Visible = false;
                paymentToolStripMenuItem.Visible = false;
                leaseToolStripMenuItem.Visible = false;
                leaseAgreementToolStripMenuItem.Visible = false;
            }
            else
            {
                userToolStripMenuItem.Visible = true;
            }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser frmuser = new frmUser();
            frmuser.Visible = true;
            this.Visible = false;
        }

        private void loginDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginDetails frmLoginDetails = new frmLoginDetails();
            frmLoginDetails.Visible = true;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Visible = true;
            this.Visible = false;
        }

        private void occupantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOccupant frmOccupant = new frmOccupant();
            frmOccupant.Visible = true;
            this.Visible = false;
        }

        private void dependentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDependent frmDependent = new frmDependent();
            frmDependent.Visible = true;
            this.Visible = false;
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPayment frmPayment = new frmPayment();
            frmPayment.Visible = true;
            this.Visible = false;
        }

        private void leaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLease frmLease = new frmLease();
            frmLease.Visible = true;
            this.Visible = false;
        }

        private void leaseAgreementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLeaseAgreement frmLeaseAgreement = new frmLeaseAgreement();
            frmLeaseAgreement.Visible = true;
            this.Visible = false;
        }

        private void manageRefundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRefunds frmRefunds = new frmRefunds();
            frmRefunds.Visible = true;
            this.Visible = false;
        }

        private void manageExtensionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRequestExtension frmExtensions = new frmRequestExtension();
            frmExtensions.Visible = true;
            this.Visible = false;
        }

        private void apartmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApartments frmApartments = new frmApartments();
            frmApartments.Visible = true;
            this.Visible = false;
        }

        private void classesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApartmentClasses frmApartmentClasses = new frmApartmentClasses();
            frmApartmentClasses.Visible = true;
            this.Visible = false;
        }

        private void parkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPark frmPark = new frmPark();
            frmPark.Visible = true;
            this.Visible = false;
        }

        private void btnAptModule_Click(object sender, EventArgs e)
        {
            frmAvailableApartments frmAvailableApartments = new frmAvailableApartments();
            frmAvailableApartments.Visible = true;
            this.Visible = false;
        }

        private void btnAptClasses_Click(object sender, EventArgs e)
        {
            frmClasses frmClasses = new frmClasses();
            frmClasses.Visible = true;
            this.Visible = false;
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            frmReservation frmReservation = new frmReservation();
            frmReservation.Visible = true;
            this.Visible = false;
        }

        private void btnWaitingList_Click(object sender, EventArgs e)
        {
            frmWaitingList frmWaitingList = new frmWaitingList();
            frmWaitingList.Visible = true;
            this.Visible = false;
        }

        private void btnRefundRequest_Click(object sender, EventArgs e)
        {
            frmRefundRequest frmRefundRequest = new frmRefundRequest();
            frmRefundRequest.Visible = true;
        }

        private void btnExtension_Click(object sender, EventArgs e)
        {
            frmExtensions frmRequestExtension = new frmExtensions();
            frmRequestExtension.Visible = true;
        }
    }
}
