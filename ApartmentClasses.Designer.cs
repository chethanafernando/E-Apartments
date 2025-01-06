
namespace E_Apartments
{
    partial class frmApartmentClasses
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkAttachedBathroom = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBedroomCount = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblAptTitle = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblApartmentTypes = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dgvApartmentType = new System.Windows.Forms.DataGridView();
            this.chkBedRoom = new System.Windows.Forms.CheckBox();
            this.txtAttachedBathroomCount = new System.Windows.Forms.TextBox();
            this.chkTVCon = new System.Windows.Forms.CheckBox();
            this.chkIsServantsToilet = new System.Windows.Forms.CheckBox();
            this.chkLivingArea = new System.Windows.Forms.CheckBox();
            this.chkTelCon = new System.Windows.Forms.CheckBox();
            this.chkIsInternetCon = new System.Windows.Forms.CheckBox();
            this.chkDiningArea = new System.Windows.Forms.CheckBox();
            this.chkIsKitchen = new System.Windows.Forms.CheckBox();
            this.chkGymnasium = new System.Windows.Forms.CheckBox();
            this.chkIsParking = new System.Windows.Forms.CheckBox();
            this.chkIsBalcony = new System.Windows.Forms.CheckBox();
            this.chkIsServentRoom = new System.Windows.Forms.CheckBox();
            this.chkCommonBathroom = new System.Windows.Forms.CheckBox();
            this.chkSwimPool = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartmentType)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(454, 19);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(618, 29);
            this.txtSearch.TabIndex = 54;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.chkSwimPool);
            this.panel1.Controls.Add(this.chkCommonBathroom);
            this.panel1.Controls.Add(this.chkIsServentRoom);
            this.panel1.Controls.Add(this.chkIsBalcony);
            this.panel1.Controls.Add(this.chkIsParking);
            this.panel1.Controls.Add(this.chkGymnasium);
            this.panel1.Controls.Add(this.chkIsKitchen);
            this.panel1.Controls.Add(this.chkDiningArea);
            this.panel1.Controls.Add(this.chkIsInternetCon);
            this.panel1.Controls.Add(this.chkIsServantsToilet);
            this.panel1.Controls.Add(this.chkTelCon);
            this.panel1.Controls.Add(this.chkLivingArea);
            this.panel1.Controls.Add(this.chkTVCon);
            this.panel1.Controls.Add(this.txtAttachedBathroomCount);
            this.panel1.Controls.Add(this.chkBedRoom);
            this.panel1.Controls.Add(this.chkAttachedBathroom);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtBedroomCount);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.lblAptTitle);
            this.panel1.Location = new System.Drawing.Point(5, 54);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 581);
            this.panel1.TabIndex = 50;
            // 
            // chkAttachedBathroom
            // 
            this.chkAttachedBathroom.AutoSize = true;
            this.chkAttachedBathroom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkAttachedBathroom.Location = new System.Drawing.Point(25, 81);
            this.chkAttachedBathroom.Name = "chkAttachedBathroom";
            this.chkAttachedBathroom.Size = new System.Drawing.Size(229, 26);
            this.chkAttachedBathroom.TabIndex = 20;
            this.chkAttachedBathroom.Text = "Is Attached Bathroom";
            this.chkAttachedBathroom.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(127, 529);
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
            this.btnUpdate.Location = new System.Drawing.Point(230, 529);
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
            this.btnDelete.Location = new System.Drawing.Point(331, 529);
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
            this.btnSave.Location = new System.Drawing.Point(24, 529);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 42);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBedroomCount
            // 
            this.txtBedroomCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBedroomCount.Location = new System.Drawing.Point(256, 49);
            this.txtBedroomCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBedroomCount.Name = "txtBedroomCount";
            this.txtBedroomCount.Size = new System.Drawing.Size(61, 26);
            this.txtBedroomCount.TabIndex = 12;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.Location = new System.Drawing.Point(183, 17);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(237, 26);
            this.txtTitle.TabIndex = 9;
            // 
            // lblAptTitle
            // 
            this.lblAptTitle.AutoSize = true;
            this.lblAptTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAptTitle.Location = new System.Drawing.Point(21, 20);
            this.lblAptTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAptTitle.Name = "lblAptTitle";
            this.lblAptTitle.Size = new System.Drawing.Size(43, 20);
            this.lblAptTitle.TabIndex = 1;
            this.lblAptTitle.Text = "Title";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Red;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(5, 5);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(70, 43);
            this.btnHome.TabIndex = 52;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblApartmentTypes
            // 
            this.lblApartmentTypes.AutoSize = true;
            this.lblApartmentTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApartmentTypes.Location = new System.Drawing.Point(82, 9);
            this.lblApartmentTypes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApartmentTypes.Name = "lblApartmentTypes";
            this.lblApartmentTypes.Size = new System.Drawing.Size(279, 33);
            this.lblApartmentTypes.TabIndex = 49;
            this.lblApartmentTypes.Text = "Apartment Classes";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFind.Location = new System.Drawing.Point(1080, 17);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(88, 32);
            this.btnFind.TabIndex = 53;
            this.btnFind.Text = "Search";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowAll.Location = new System.Drawing.Point(1176, 17);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(96, 33);
            this.btnShowAll.TabIndex = 56;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(330, 24);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(116, 23);
            this.txtID.TabIndex = 55;
            this.txtID.Visible = false;
            // 
            // dgvApartmentType
            // 
            this.dgvApartmentType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApartmentType.Location = new System.Drawing.Point(454, 54);
            this.dgvApartmentType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvApartmentType.Name = "dgvApartmentType";
            this.dgvApartmentType.Size = new System.Drawing.Size(818, 581);
            this.dgvApartmentType.TabIndex = 51;
            this.dgvApartmentType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApartmentType_CellContentClick);
            // 
            // chkBedRoom
            // 
            this.chkBedRoom.AutoSize = true;
            this.chkBedRoom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkBedRoom.Location = new System.Drawing.Point(25, 49);
            this.chkBedRoom.Name = "chkBedRoom";
            this.chkBedRoom.Size = new System.Drawing.Size(134, 26);
            this.chkBedRoom.TabIndex = 27;
            this.chkBedRoom.Text = "Is Bedroom";
            this.chkBedRoom.UseVisualStyleBackColor = true;
            // 
            // txtAttachedBathroomCount
            // 
            this.txtAttachedBathroomCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAttachedBathroomCount.Location = new System.Drawing.Point(256, 81);
            this.txtAttachedBathroomCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAttachedBathroomCount.Name = "txtAttachedBathroomCount";
            this.txtAttachedBathroomCount.Size = new System.Drawing.Size(61, 26);
            this.txtAttachedBathroomCount.TabIndex = 28;
            // 
            // chkTVCon
            // 
            this.chkTVCon.AutoSize = true;
            this.chkTVCon.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkTVCon.Location = new System.Drawing.Point(25, 401);
            this.chkTVCon.Name = "chkTVCon";
            this.chkTVCon.Size = new System.Drawing.Size(183, 26);
            this.chkTVCon.TabIndex = 29;
            this.chkTVCon.Text = "Is TV Connection";
            this.chkTVCon.UseVisualStyleBackColor = true;
            // 
            // chkIsServantsToilet
            // 
            this.chkIsServantsToilet.AutoSize = true;
            this.chkIsServantsToilet.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkIsServantsToilet.Location = new System.Drawing.Point(25, 177);
            this.chkIsServantsToilet.Name = "chkIsServantsToilet";
            this.chkIsServantsToilet.Size = new System.Drawing.Size(187, 26);
            this.chkIsServantsToilet.TabIndex = 30;
            this.chkIsServantsToilet.Text = "Is Servants Toilet";
            this.chkIsServantsToilet.UseVisualStyleBackColor = true;
            // 
            // chkLivingArea
            // 
            this.chkLivingArea.AutoSize = true;
            this.chkLivingArea.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkLivingArea.Location = new System.Drawing.Point(25, 241);
            this.chkLivingArea.Name = "chkLivingArea";
            this.chkLivingArea.Size = new System.Drawing.Size(153, 26);
            this.chkLivingArea.TabIndex = 31;
            this.chkLivingArea.Text = "Is Living Area";
            this.chkLivingArea.UseVisualStyleBackColor = true;
            // 
            // chkTelCon
            // 
            this.chkTelCon.AutoSize = true;
            this.chkTelCon.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkTelCon.Location = new System.Drawing.Point(25, 337);
            this.chkTelCon.Name = "chkTelCon";
            this.chkTelCon.Size = new System.Drawing.Size(253, 26);
            this.chkTelCon.TabIndex = 32;
            this.chkTelCon.Text = "Is Telephone Connection";
            this.chkTelCon.UseVisualStyleBackColor = true;
            // 
            // chkIsInternetCon
            // 
            this.chkIsInternetCon.AutoSize = true;
            this.chkIsInternetCon.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkIsInternetCon.Location = new System.Drawing.Point(25, 369);
            this.chkIsInternetCon.Name = "chkIsInternetCon";
            this.chkIsInternetCon.Size = new System.Drawing.Size(230, 26);
            this.chkIsInternetCon.TabIndex = 33;
            this.chkIsInternetCon.Text = "Is Internet Connection";
            this.chkIsInternetCon.UseVisualStyleBackColor = true;
            // 
            // chkDiningArea
            // 
            this.chkDiningArea.AutoSize = true;
            this.chkDiningArea.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkDiningArea.Location = new System.Drawing.Point(25, 209);
            this.chkDiningArea.Name = "chkDiningArea";
            this.chkDiningArea.Size = new System.Drawing.Size(157, 26);
            this.chkDiningArea.TabIndex = 34;
            this.chkDiningArea.Text = "Is Dining Area";
            this.chkDiningArea.UseVisualStyleBackColor = true;
            // 
            // chkIsKitchen
            // 
            this.chkIsKitchen.AutoSize = true;
            this.chkIsKitchen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkIsKitchen.Location = new System.Drawing.Point(25, 273);
            this.chkIsKitchen.Name = "chkIsKitchen";
            this.chkIsKitchen.Size = new System.Drawing.Size(120, 26);
            this.chkIsKitchen.TabIndex = 35;
            this.chkIsKitchen.Text = "Is Kitchen";
            this.chkIsKitchen.UseVisualStyleBackColor = true;
            // 
            // chkGymnasium
            // 
            this.chkGymnasium.AutoSize = true;
            this.chkGymnasium.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkGymnasium.Location = new System.Drawing.Point(25, 465);
            this.chkGymnasium.Name = "chkGymnasium";
            this.chkGymnasium.Size = new System.Drawing.Size(157, 26);
            this.chkGymnasium.TabIndex = 36;
            this.chkGymnasium.Text = "Is Gymnasium";
            this.chkGymnasium.UseVisualStyleBackColor = true;
            // 
            // chkIsParking
            // 
            this.chkIsParking.AutoSize = true;
            this.chkIsParking.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkIsParking.Location = new System.Drawing.Point(25, 433);
            this.chkIsParking.Name = "chkIsParking";
            this.chkIsParking.Size = new System.Drawing.Size(121, 26);
            this.chkIsParking.TabIndex = 37;
            this.chkIsParking.Text = "Is Parking";
            this.chkIsParking.UseVisualStyleBackColor = true;
            // 
            // chkIsBalcony
            // 
            this.chkIsBalcony.AutoSize = true;
            this.chkIsBalcony.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkIsBalcony.Location = new System.Drawing.Point(25, 305);
            this.chkIsBalcony.Name = "chkIsBalcony";
            this.chkIsBalcony.Size = new System.Drawing.Size(123, 26);
            this.chkIsBalcony.TabIndex = 38;
            this.chkIsBalcony.Text = "Is Balcony";
            this.chkIsBalcony.UseVisualStyleBackColor = true;
            // 
            // chkIsServentRoom
            // 
            this.chkIsServentRoom.AutoSize = true;
            this.chkIsServentRoom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkIsServentRoom.Location = new System.Drawing.Point(25, 145);
            this.chkIsServentRoom.Name = "chkIsServentRoom";
            this.chkIsServentRoom.Size = new System.Drawing.Size(189, 26);
            this.chkIsServentRoom.TabIndex = 39;
            this.chkIsServentRoom.Text = "Is Servants Room";
            this.chkIsServentRoom.UseVisualStyleBackColor = true;
            // 
            // chkCommonBathroom
            // 
            this.chkCommonBathroom.AutoSize = true;
            this.chkCommonBathroom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkCommonBathroom.Location = new System.Drawing.Point(25, 113);
            this.chkCommonBathroom.Name = "chkCommonBathroom";
            this.chkCommonBathroom.Size = new System.Drawing.Size(226, 26);
            this.chkCommonBathroom.TabIndex = 40;
            this.chkCommonBathroom.Text = "Is Common Bathroom";
            this.chkCommonBathroom.UseVisualStyleBackColor = true;
            // 
            // chkSwimPool
            // 
            this.chkSwimPool.AutoSize = true;
            this.chkSwimPool.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkSwimPool.Location = new System.Drawing.Point(25, 497);
            this.chkSwimPool.Name = "chkSwimPool";
            this.chkSwimPool.Size = new System.Drawing.Size(190, 26);
            this.chkSwimPool.TabIndex = 41;
            this.chkSwimPool.Text = "Is Swimming Pool";
            this.chkSwimPool.UseVisualStyleBackColor = true;
            // 
            // frmApartmentClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 641);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblApartmentTypes);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dgvApartmentType);
            this.Name = "frmApartmentClasses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apartment Classes";
            this.Load += new System.EventHandler(this.frmApartmentClasses_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartmentType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkAttachedBathroom;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBedroomCount;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblAptTitle;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblApartmentTypes;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dgvApartmentType;
        private System.Windows.Forms.TextBox txtAttachedBathroomCount;
        private System.Windows.Forms.CheckBox chkBedRoom;
        private System.Windows.Forms.CheckBox chkSwimPool;
        private System.Windows.Forms.CheckBox chkCommonBathroom;
        private System.Windows.Forms.CheckBox chkIsServentRoom;
        private System.Windows.Forms.CheckBox chkIsBalcony;
        private System.Windows.Forms.CheckBox chkIsParking;
        private System.Windows.Forms.CheckBox chkGymnasium;
        private System.Windows.Forms.CheckBox chkIsKitchen;
        private System.Windows.Forms.CheckBox chkDiningArea;
        private System.Windows.Forms.CheckBox chkIsInternetCon;
        private System.Windows.Forms.CheckBox chkIsServantsToilet;
        private System.Windows.Forms.CheckBox chkTelCon;
        private System.Windows.Forms.CheckBox chkLivingArea;
        private System.Windows.Forms.CheckBox chkTVCon;
    }
}