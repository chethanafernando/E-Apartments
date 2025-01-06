
namespace E_Apartments
{
    partial class frmReservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbApart = new System.Windows.Forms.ComboBox();
            this.txtPayID = new System.Windows.Forms.TextBox();
            this.lblPayID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblOccupant = new System.Windows.Forms.Label();
            this.lblapartmentID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblReservation = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvReservation = new System.Windows.Forms.DataGridView();
            this.cmbOccu = new System.Windows.Forms.ComboBox();
            this.chkAddPark = new System.Windows.Forms.CheckBox();
            this.chkReserved = new System.Windows.Forms.CheckBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.chkReserved);
            this.panel1.Controls.Add(this.chkAddPark);
            this.panel1.Controls.Add(this.cmbOccu);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.cmbApart);
            this.panel1.Controls.Add(this.txtPayID);
            this.panel1.Controls.Add(this.lblPayID);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblOccupant);
            this.panel1.Controls.Add(this.lblapartmentID);
            this.panel1.Location = new System.Drawing.Point(5, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 309);
            this.panel1.TabIndex = 33;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(123, 223);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 42);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(226, 223);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 42);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(327, 223);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 42);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(20, 223);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 42);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbApart
            // 
            this.cmbApart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbApart.FormattingEnabled = true;
            this.cmbApart.Items.AddRange(new object[] {
            "Administrator",
            "Manager",
            "Accountant",
            "Receptionist"});
            this.cmbApart.Location = new System.Drawing.Point(168, 17);
            this.cmbApart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbApart.Name = "cmbApart";
            this.cmbApart.Size = new System.Drawing.Size(250, 28);
            this.cmbApart.TabIndex = 15;
            // 
            // txtPayID
            // 
            this.txtPayID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPayID.Location = new System.Drawing.Point(168, 141);
            this.txtPayID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPayID.Name = "txtPayID";
            this.txtPayID.Size = new System.Drawing.Size(250, 26);
            this.txtPayID.TabIndex = 12;
            // 
            // lblPayID
            // 
            this.lblPayID.AutoSize = true;
            this.lblPayID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPayID.Location = new System.Drawing.Point(21, 147);
            this.lblPayID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayID.Name = "lblPayID";
            this.lblPayID.Size = new System.Drawing.Size(102, 20);
            this.lblPayID.TabIndex = 4;
            this.lblPayID.Text = "Payment ID";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(21, 106);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(119, 20);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Reserve Date";
            // 
            // lblOccupant
            // 
            this.lblOccupant.AutoSize = true;
            this.lblOccupant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOccupant.Location = new System.Drawing.Point(21, 64);
            this.lblOccupant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOccupant.Name = "lblOccupant";
            this.lblOccupant.Size = new System.Drawing.Size(86, 20);
            this.lblOccupant.TabIndex = 2;
            this.lblOccupant.Text = "Occupant";
            // 
            // lblapartmentID
            // 
            this.lblapartmentID.AutoSize = true;
            this.lblapartmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblapartmentID.Location = new System.Drawing.Point(21, 20);
            this.lblapartmentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblapartmentID.Name = "lblapartmentID";
            this.lblapartmentID.Size = new System.Drawing.Size(98, 20);
            this.lblapartmentID.TabIndex = 1;
            this.lblapartmentID.Text = "Apartment ";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(330, 25);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(116, 23);
            this.txtID.TabIndex = 38;
            this.txtID.Visible = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Red;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(5, 6);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(70, 43);
            this.btnHome.TabIndex = 35;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblReservation
            // 
            this.lblReservation.AutoSize = true;
            this.lblReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReservation.Location = new System.Drawing.Point(82, 10);
            this.lblReservation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReservation.Name = "lblReservation";
            this.lblReservation.Size = new System.Drawing.Size(182, 33);
            this.lblReservation.TabIndex = 32;
            this.lblReservation.Text = "Reservation";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFind.Location = new System.Drawing.Point(817, 18);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(88, 32);
            this.btnFind.TabIndex = 36;
            this.btnFind.Text = "Search";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowAll.Location = new System.Drawing.Point(906, 18);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(96, 33);
            this.btnShowAll.TabIndex = 39;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(454, 20);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(360, 29);
            this.txtSearch.TabIndex = 37;
            // 
            // dgvReservation
            // 
            this.dgvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservation.Location = new System.Drawing.Point(454, 55);
            this.dgvReservation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvReservation.Name = "dgvReservation";
            this.dgvReservation.Size = new System.Drawing.Size(548, 309);
            this.dgvReservation.TabIndex = 34;
            this.dgvReservation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservation_CellClick);
            // 
            // cmbOccu
            // 
            this.cmbOccu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbOccu.FormattingEnabled = true;
            this.cmbOccu.Items.AddRange(new object[] {
            "Administrator",
            "Manager",
            "Accountant",
            "Receptionist"});
            this.cmbOccu.Location = new System.Drawing.Point(168, 59);
            this.cmbOccu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbOccu.Name = "cmbOccu";
            this.cmbOccu.Size = new System.Drawing.Size(250, 28);
            this.cmbOccu.TabIndex = 20;
            // 
            // chkAddPark
            // 
            this.chkAddPark.AutoSize = true;
            this.chkAddPark.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkAddPark.Location = new System.Drawing.Point(21, 184);
            this.chkAddPark.Name = "chkAddPark";
            this.chkAddPark.Size = new System.Drawing.Size(148, 22);
            this.chkAddPark.TabIndex = 21;
            this.chkAddPark.Text = "Additional Park";
            this.chkAddPark.UseVisualStyleBackColor = true;
            // 
            // chkReserved
            // 
            this.chkReserved.AutoSize = true;
            this.chkReserved.Checked = true;
            this.chkReserved.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReserved.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkReserved.Location = new System.Drawing.Point(189, 184);
            this.chkReserved.Name = "chkReserved";
            this.chkReserved.Size = new System.Drawing.Size(122, 22);
            this.chkReserved.TabIndex = 22;
            this.chkReserved.Text = "Is Reserved";
            this.chkReserved.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(168, 103);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(250, 23);
            this.dtpDate.TabIndex = 23;
            // 
            // frmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 370);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblReservation);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvReservation);
            this.Name = "frmReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.frmReservation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkReserved;
        private System.Windows.Forms.CheckBox chkAddPark;
        private System.Windows.Forms.ComboBox cmbOccu;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbApart;
        private System.Windows.Forms.TextBox txtPayID;
        private System.Windows.Forms.Label lblPayID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblOccupant;
        private System.Windows.Forms.Label lblapartmentID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblReservation;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvReservation;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}