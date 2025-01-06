
namespace E_Apartments
{
    partial class frmApartments
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
            this.chkAvailable = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtDepAmt = new System.Windows.Forms.TextBox();
            this.txtMaxAllP = new System.Windows.Forms.TextBox();
            this.txtAptNumber = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblApartments = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblPark = new System.Windows.Forms.Label();
            this.lblAptType = new System.Windows.Forms.Label();
            this.lblAptNumber = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtResFee = new System.Windows.Forms.TextBox();
            this.cmbPark = new System.Windows.Forms.ComboBox();
            this.cmbAptType = new System.Windows.Forms.ComboBox();
            this.lblMaxPerson = new System.Windows.Forms.Label();
            this.lblDepAmt = new System.Windows.Forms.Label();
            this.lblReservationFee = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dgvApartment = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartment)).BeginInit();
            this.SuspendLayout();
            // 
            // chkAvailable
            // 
            this.chkAvailable.AutoSize = true;
            this.chkAvailable.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkAvailable.Location = new System.Drawing.Point(25, 294);
            this.chkAvailable.Name = "chkAvailable";
            this.chkAvailable.Size = new System.Drawing.Size(134, 26);
            this.chkAvailable.TabIndex = 20;
            this.chkAvailable.Text = "Is Available";
            this.chkAvailable.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(120, 338);
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
            this.btnUpdate.Location = new System.Drawing.Point(223, 338);
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
            this.btnDelete.Location = new System.Drawing.Point(324, 338);
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
            this.btnSave.Location = new System.Drawing.Point(17, 338);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 42);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLocation.Location = new System.Drawing.Point(183, 141);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(237, 26);
            this.txtLocation.TabIndex = 12;
            // 
            // txtDepAmt
            // 
            this.txtDepAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDepAmt.Location = new System.Drawing.Point(183, 181);
            this.txtDepAmt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDepAmt.Name = "txtDepAmt";
            this.txtDepAmt.Size = new System.Drawing.Size(237, 26);
            this.txtDepAmt.TabIndex = 11;
            // 
            // txtMaxAllP
            // 
            this.txtMaxAllP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaxAllP.Location = new System.Drawing.Point(183, 220);
            this.txtMaxAllP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaxAllP.Name = "txtMaxAllP";
            this.txtMaxAllP.Size = new System.Drawing.Size(237, 26);
            this.txtMaxAllP.TabIndex = 10;
            // 
            // txtAptNumber
            // 
            this.txtAptNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAptNumber.Location = new System.Drawing.Point(183, 17);
            this.txtAptNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAptNumber.Name = "txtAptNumber";
            this.txtAptNumber.Size = new System.Drawing.Size(237, 26);
            this.txtAptNumber.TabIndex = 9;
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
            this.btnHome.TabIndex = 44;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblApartments
            // 
            this.lblApartments.AutoSize = true;
            this.lblApartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApartments.Location = new System.Drawing.Point(82, 10);
            this.lblApartments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApartments.Name = "lblApartments";
            this.lblApartments.Size = new System.Drawing.Size(174, 33);
            this.lblApartments.TabIndex = 41;
            this.lblApartments.Text = "Apartments";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFind.Location = new System.Drawing.Point(817, 18);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(88, 32);
            this.btnFind.TabIndex = 45;
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
            this.btnShowAll.TabIndex = 48;
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
            this.txtSearch.TabIndex = 46;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLocation.Location = new System.Drawing.Point(21, 147);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(78, 20);
            this.lblLocation.TabIndex = 4;
            this.lblLocation.Text = "Location";
            // 
            // lblPark
            // 
            this.lblPark.AutoSize = true;
            this.lblPark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPark.Location = new System.Drawing.Point(21, 106);
            this.lblPark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPark.Name = "lblPark";
            this.lblPark.Size = new System.Drawing.Size(45, 20);
            this.lblPark.TabIndex = 3;
            this.lblPark.Text = "Park";
            // 
            // lblAptType
            // 
            this.lblAptType.AutoSize = true;
            this.lblAptType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAptType.Location = new System.Drawing.Point(21, 64);
            this.lblAptType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAptType.Name = "lblAptType";
            this.lblAptType.Size = new System.Drawing.Size(136, 20);
            this.lblAptType.TabIndex = 2;
            this.lblAptType.Text = "Apartment Type";
            // 
            // lblAptNumber
            // 
            this.lblAptNumber.AutoSize = true;
            this.lblAptNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAptNumber.Location = new System.Drawing.Point(21, 20);
            this.lblAptNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAptNumber.Name = "lblAptNumber";
            this.lblAptNumber.Size = new System.Drawing.Size(160, 20);
            this.lblAptNumber.TabIndex = 1;
            this.lblAptNumber.Text = "Apartment Number";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.txtResFee);
            this.panel1.Controls.Add(this.cmbPark);
            this.panel1.Controls.Add(this.cmbAptType);
            this.panel1.Controls.Add(this.lblMaxPerson);
            this.panel1.Controls.Add(this.lblDepAmt);
            this.panel1.Controls.Add(this.lblReservationFee);
            this.panel1.Controls.Add(this.chkAvailable);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtLocation);
            this.panel1.Controls.Add(this.txtDepAmt);
            this.panel1.Controls.Add(this.txtMaxAllP);
            this.panel1.Controls.Add(this.txtAptNumber);
            this.panel1.Controls.Add(this.lblLocation);
            this.panel1.Controls.Add(this.lblPark);
            this.panel1.Controls.Add(this.lblAptType);
            this.panel1.Controls.Add(this.lblAptNumber);
            this.panel1.Location = new System.Drawing.Point(5, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 395);
            this.panel1.TabIndex = 42;
            // 
            // txtResFee
            // 
            this.txtResFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResFee.Location = new System.Drawing.Point(183, 259);
            this.txtResFee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtResFee.Name = "txtResFee";
            this.txtResFee.Size = new System.Drawing.Size(237, 26);
            this.txtResFee.TabIndex = 26;
            // 
            // cmbPark
            // 
            this.cmbPark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbPark.FormattingEnabled = true;
            this.cmbPark.Location = new System.Drawing.Point(183, 98);
            this.cmbPark.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbPark.Name = "cmbPark";
            this.cmbPark.Size = new System.Drawing.Size(237, 28);
            this.cmbPark.TabIndex = 25;
            // 
            // cmbAptType
            // 
            this.cmbAptType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbAptType.FormattingEnabled = true;
            this.cmbAptType.Location = new System.Drawing.Point(183, 56);
            this.cmbAptType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbAptType.Name = "cmbAptType";
            this.cmbAptType.Size = new System.Drawing.Size(237, 28);
            this.cmbAptType.TabIndex = 24;
            // 
            // lblMaxPerson
            // 
            this.lblMaxPerson.AutoSize = true;
            this.lblMaxPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaxPerson.Location = new System.Drawing.Point(8, 226);
            this.lblMaxPerson.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxPerson.Name = "lblMaxPerson";
            this.lblMaxPerson.Size = new System.Drawing.Size(169, 20);
            this.lblMaxPerson.TabIndex = 23;
            this.lblMaxPerson.Text = "Max Allowed Person";
            // 
            // lblDepAmt
            // 
            this.lblDepAmt.AutoSize = true;
            this.lblDepAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDepAmt.Location = new System.Drawing.Point(21, 184);
            this.lblDepAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepAmt.Name = "lblDepAmt";
            this.lblDepAmt.Size = new System.Drawing.Size(138, 20);
            this.lblDepAmt.TabIndex = 22;
            this.lblDepAmt.Text = "Deposit Amount";
            // 
            // lblReservationFee
            // 
            this.lblReservationFee.AutoSize = true;
            this.lblReservationFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReservationFee.Location = new System.Drawing.Point(21, 262);
            this.lblReservationFee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReservationFee.Name = "lblReservationFee";
            this.lblReservationFee.Size = new System.Drawing.Size(141, 20);
            this.lblReservationFee.TabIndex = 21;
            this.lblReservationFee.Text = "Reservation Fee";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(330, 25);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(116, 23);
            this.txtID.TabIndex = 47;
            this.txtID.Visible = false;
            // 
            // dgvApartment
            // 
            this.dgvApartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApartment.Location = new System.Drawing.Point(454, 55);
            this.dgvApartment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvApartment.Name = "dgvApartment";
            this.dgvApartment.Size = new System.Drawing.Size(548, 395);
            this.dgvApartment.TabIndex = 43;
            this.dgvApartment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApartment_CellContentClick);
            // 
            // frmApartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 456);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblApartments);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dgvApartment);
            this.Name = "frmApartments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apartments";
            this.Load += new System.EventHandler(this.frmApartments_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkAvailable;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtDepAmt;
        private System.Windows.Forms.TextBox txtMaxAllP;
        private System.Windows.Forms.TextBox txtAptNumber;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblApartments;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblPark;
        private System.Windows.Forms.Label lblAptType;
        private System.Windows.Forms.Label lblAptNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dgvApartment;
        private System.Windows.Forms.Label lblMaxPerson;
        private System.Windows.Forms.Label lblDepAmt;
        private System.Windows.Forms.Label lblReservationFee;
        private System.Windows.Forms.TextBox txtResFee;
        private System.Windows.Forms.ComboBox cmbPark;
        private System.Windows.Forms.ComboBox cmbAptType;
    }
}