
namespace E_Apartments
{
    partial class frmWaitingList
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
            this.dgvWaitingList = new System.Windows.Forms.DataGridView();
            this.dtpResDate = new System.Windows.Forms.DateTimePicker();
            this.cmbOccu = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblWaitingList = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lblReqDate = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblOccupant = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblQueue = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpReqDate = new System.Windows.Forms.DateTimePicker();
            this.txtQueue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaitingList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvWaitingList
            // 
            this.dgvWaitingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWaitingList.Location = new System.Drawing.Point(454, 55);
            this.dgvWaitingList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvWaitingList.Name = "dgvWaitingList";
            this.dgvWaitingList.Size = new System.Drawing.Size(548, 309);
            this.dgvWaitingList.TabIndex = 42;
            this.dgvWaitingList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWaitingList_CellClick);
            // 
            // dtpResDate
            // 
            this.dtpResDate.Location = new System.Drawing.Point(168, 103);
            this.dtpResDate.Name = "dtpResDate";
            this.dtpResDate.Size = new System.Drawing.Size(250, 23);
            this.dtpResDate.TabIndex = 23;
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
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(123, 186);
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
            this.btnUpdate.Location = new System.Drawing.Point(226, 186);
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
            this.btnDelete.Location = new System.Drawing.Point(327, 186);
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
            this.btnSave.Location = new System.Drawing.Point(20, 186);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 42);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(330, 25);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(116, 23);
            this.txtID.TabIndex = 46;
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
            this.btnHome.TabIndex = 43;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblWaitingList
            // 
            this.lblWaitingList.AutoSize = true;
            this.lblWaitingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWaitingList.Location = new System.Drawing.Point(82, 10);
            this.lblWaitingList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWaitingList.Name = "lblWaitingList";
            this.lblWaitingList.Size = new System.Drawing.Size(178, 33);
            this.lblWaitingList.TabIndex = 40;
            this.lblWaitingList.Text = "Waiting List";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFind.Location = new System.Drawing.Point(817, 18);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(88, 32);
            this.btnFind.TabIndex = 44;
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
            this.btnShowAll.TabIndex = 47;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // lblReqDate
            // 
            this.lblReqDate.AutoSize = true;
            this.lblReqDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReqDate.Location = new System.Drawing.Point(21, 147);
            this.lblReqDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReqDate.Name = "lblReqDate";
            this.lblReqDate.Size = new System.Drawing.Size(126, 20);
            this.lblReqDate.TabIndex = 4;
            this.lblReqDate.Text = "Required Date";
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
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(454, 20);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(360, 29);
            this.txtSearch.TabIndex = 45;
            // 
            // lblQueue
            // 
            this.lblQueue.AutoSize = true;
            this.lblQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQueue.Location = new System.Drawing.Point(21, 20);
            this.lblQueue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(129, 20);
            this.lblQueue.TabIndex = 1;
            this.lblQueue.Text = "Queue Number";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.txtQueue);
            this.panel1.Controls.Add(this.dtpReqDate);
            this.panel1.Controls.Add(this.dtpResDate);
            this.panel1.Controls.Add(this.cmbOccu);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblReqDate);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblOccupant);
            this.panel1.Controls.Add(this.lblQueue);
            this.panel1.Location = new System.Drawing.Point(5, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 309);
            this.panel1.TabIndex = 41;
            // 
            // dtpReqDate
            // 
            this.dtpReqDate.Location = new System.Drawing.Point(168, 144);
            this.dtpReqDate.Name = "dtpReqDate";
            this.dtpReqDate.Size = new System.Drawing.Size(250, 23);
            this.dtpReqDate.TabIndex = 24;
            // 
            // txtQueue
            // 
            this.txtQueue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQueue.Location = new System.Drawing.Point(168, 15);
            this.txtQueue.Name = "txtQueue";
            this.txtQueue.Size = new System.Drawing.Size(250, 29);
            this.txtQueue.TabIndex = 25;
            // 
            // frmWaitingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 370);
            this.Controls.Add(this.dgvWaitingList);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblWaitingList);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Name = "frmWaitingList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Waiting List";
            this.Load += new System.EventHandler(this.frmWaitingList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaitingList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWaitingList;
        private System.Windows.Forms.DateTimePicker dtpResDate;
        private System.Windows.Forms.ComboBox cmbOccu;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblWaitingList;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label lblReqDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblOccupant;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpReqDate;
        private System.Windows.Forms.TextBox txtQueue;
    }
}