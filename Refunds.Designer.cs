
namespace E_Apartments
{
    partial class frmRefunds
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDueAmount = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblRefunds = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblAmountRefundededDate = new System.Windows.Forms.Label();
            this.lblDueAmount = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dgvRefunds = new System.Windows.Forms.DataGridView();
            this.chkApproved = new System.Windows.Forms.CheckBox();
            this.dtpRefundedDate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefunds)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(105, 218);
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
            this.btnDelete.Location = new System.Drawing.Point(209, 218);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 42);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDueAmount
            // 
            this.txtDueAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDueAmount.Location = new System.Drawing.Point(168, 100);
            this.txtDueAmount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDueAmount.Name = "txtDueAmount";
            this.txtDueAmount.Size = new System.Drawing.Size(250, 26);
            this.txtDueAmount.TabIndex = 11;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAmount.Location = new System.Drawing.Point(168, 58);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(250, 26);
            this.txtAmount.TabIndex = 10;
            // 
            // txtReason
            // 
            this.txtReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtReason.Location = new System.Drawing.Point(168, 17);
            this.txtReason.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(250, 26);
            this.txtReason.TabIndex = 9;
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
            // lblRefunds
            // 
            this.lblRefunds.AutoSize = true;
            this.lblRefunds.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRefunds.Location = new System.Drawing.Point(82, 10);
            this.lblRefunds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRefunds.Name = "lblRefunds";
            this.lblRefunds.Size = new System.Drawing.Size(302, 33);
            this.lblRefunds.TabIndex = 41;
            this.lblRefunds.Text = "Refund Management";
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
            // lblAmountRefundededDate
            // 
            this.lblAmountRefundededDate.AutoSize = true;
            this.lblAmountRefundededDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAmountRefundededDate.Location = new System.Drawing.Point(21, 147);
            this.lblAmountRefundededDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmountRefundededDate.Name = "lblAmountRefundededDate";
            this.lblAmountRefundededDate.Size = new System.Drawing.Size(132, 20);
            this.lblAmountRefundededDate.TabIndex = 4;
            this.lblAmountRefundededDate.Text = "Refunded Date";
            // 
            // lblDueAmount
            // 
            this.lblDueAmount.AutoSize = true;
            this.lblDueAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDueAmount.Location = new System.Drawing.Point(21, 106);
            this.lblDueAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDueAmount.Name = "lblDueAmount";
            this.lblDueAmount.Size = new System.Drawing.Size(109, 20);
            this.lblDueAmount.TabIndex = 3;
            this.lblDueAmount.Text = "Due Amount";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAmount.Location = new System.Drawing.Point(21, 64);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(71, 20);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Amount";
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReason.Location = new System.Drawing.Point(21, 20);
            this.lblReason.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(71, 20);
            this.lblReason.TabIndex = 1;
            this.lblReason.Text = "Reason";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.dtpRefundedDate);
            this.panel1.Controls.Add(this.chkApproved);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.txtDueAmount);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.txtReason);
            this.panel1.Controls.Add(this.lblAmountRefundededDate);
            this.panel1.Controls.Add(this.lblDueAmount);
            this.panel1.Controls.Add(this.lblAmount);
            this.panel1.Controls.Add(this.lblReason);
            this.panel1.Location = new System.Drawing.Point(5, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 281);
            this.panel1.TabIndex = 42;
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
            // dgvRefunds
            // 
            this.dgvRefunds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRefunds.Location = new System.Drawing.Point(454, 55);
            this.dgvRefunds.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvRefunds.Name = "dgvRefunds";
            this.dgvRefunds.Size = new System.Drawing.Size(548, 281);
            this.dgvRefunds.TabIndex = 43;
            this.dgvRefunds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRefunds_CellContentClick);
            // 
            // chkApproved
            // 
            this.chkApproved.AutoSize = true;
            this.chkApproved.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkApproved.Location = new System.Drawing.Point(21, 186);
            this.chkApproved.Name = "chkApproved";
            this.chkApproved.Size = new System.Drawing.Size(189, 26);
            this.chkApproved.TabIndex = 20;
            this.chkApproved.Text = "Refund Approved";
            this.chkApproved.UseVisualStyleBackColor = true;
            // 
            // dtpRefundedDate
            // 
            this.dtpRefundedDate.Location = new System.Drawing.Point(168, 147);
            this.dtpRefundedDate.Name = "dtpRefundedDate";
            this.dtpRefundedDate.Size = new System.Drawing.Size(250, 23);
            this.dtpRefundedDate.TabIndex = 21;
            // 
            // frmRefunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 342);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblRefunds);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dgvRefunds);
            this.Name = "frmRefunds";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Refunds";
            this.Load += new System.EventHandler(this.frmRefunds_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefunds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDueAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblRefunds;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblAmountRefundededDate;
        private System.Windows.Forms.Label lblDueAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpRefundedDate;
        private System.Windows.Forms.CheckBox chkApproved;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dgvRefunds;
    }
}