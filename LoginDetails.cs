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
    public partial class frmLoginDetails : Form
    {
        public int userid = int.Parse(LoginInfo.UserID);
        public string username = LoginInfo.Username;
        public string role = LoginInfo.Role;

        public frmLoginDetails()
        {
            InitializeComponent();
        }

        private void frmLoginDetails_Load(object sender, EventArgs e)
        {
            lblUserID.Text = userid.ToString();
            lblName.Text = username;
            lblLoggedDate.Text = DateTime.Now.ToString();
            lblUserRole.Text = role;
        }
    }
}
