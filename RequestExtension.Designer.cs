
namespace E_Apartments
{
    partial class frmRequestExtension
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
            this.btnShowAll = new System.Windows.Forms.Button();
            this.chkApproved = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpExtensionDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblExtensionDate = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblExtension = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dgvExtension = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtension)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowAll.Location = new System.Drawing.Point(907, 19);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(96, 33);
            this.btnShowAll.TabIndex = 56;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // chkApproved
            // 
            this.chkApproved.AutoSize = true;
            this.chkApproved.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkApproved.Location = new System.Drawing.Point(21, 141);
            this.chkApproved.Name = "chkApproved";
            this.chkApproved.Size = new System.Drawing.Size(213, 26);
            this.chkApproved.TabIndex = 20;
            this.chkApproved.Text = "Extension Approved";
            this.chkApproved.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.dtpExtensionDate);
            this.panel1.Controls.Add(this.chkApproved);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.txtPeriod);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.lblExtensionDate);
            this.panel1.Controls.Add(this.lblPeriod);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Location = new System.Drawing.Point(6, 56);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 238);
            this.panel1.TabIndex = 50;
            // 
            // dtpExtensionDate
            // 
            this.dtpExtensionDate.Location = new System.Drawing.Point(167, 99);
            this.dtpExtensionDate.Name = "dtpExtensionDate";
            this.dtpExtensionDate.Size = new System.Drawing.Size(250, 23);
            this.dtpExtensionDate.TabIndex = 21;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(115, 183);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 42);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(219, 183);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 42);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtPeriod
            // 
            this.txtPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPeriod.Location = new System.Drawing.Point(168, 58);
            this.txtPeriod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(250, 26);
            this.txtPeriod.TabIndex = 10;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.Location = new System.Drawing.Point(168, 17);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(250, 26);
            this.txtDescription.TabIndex = 9;
            // 
            // lblExtensionDate
            // 
            this.lblExtensionDate.AutoSize = true;
            this.lblExtensionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExtensionDate.Location = new System.Drawing.Point(21, 102);
            this.lblExtensionDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExtensionDate.Name = "lblExtensionDate";
            this.lblExtensionDate.Size = new System.Drawing.Size(48, 20);
            this.lblExtensionDate.TabIndex = 4;
            this.lblExtensionDate.Text = "Date";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPeriod.Location = new System.Drawing.Point(21, 64);
            this.lblPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(60, 20);
            this.lblPeriod.TabIndex = 2;
            this.lblPeriod.Text = "Period";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(21, 20);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 20);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Red;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(6, 7);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(70, 43);
            this.btnHome.TabIndex = 52;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExtension.Location = new System.Drawing.Point(83, 11);
            this.lblExtension.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(340, 33);
            this.lblExtension.TabIndex = 49;
            this.lblExtension.Text = "Extension Management";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFind.Location = new System.Drawing.Point(818, 19);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(88, 32);
            this.btnFind.TabIndex = 53;
            this.btnFind.Text = "Search";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(455, 21);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(360, 29);
            this.txtSearch.TabIndex = 54;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(331, 26);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(116, 23);
            this.txtID.TabIndex = 55;
            this.txtID.Visible = false;
            // 
            // dgvExtension
            // 
            this.dgvExtension.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExtension.Location = new System.Drawing.Point(455, 56);
            this.dgvExtension.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvExtension.Name = "dgvExtension";
            this.dgvExtension.Size = new System.Drawing.Size(548, 238);
            this.dgvExtension.TabIndex = 51;
            this.dgvExtension.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExtension_CellContentClick);
            // 
            // frmRequestExtension
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 301);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblExtension);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dgvExtension);
            this.Name = "frmRequestExtension";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Request Extension";
            this.Load += new System.EventHandler(this.frmRequestExtension_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtension)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.CheckBox chkApproved;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpExtensionDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblExtensionDate;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dgvExtension;
    }
}