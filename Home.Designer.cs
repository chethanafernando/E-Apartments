
namespace E_Apartments
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.btnAptModule = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.occuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.occupantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dependentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaseAgreementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRefundsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageExtensionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apartmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAptClasses = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnWaitingList = new System.Windows.Forms.Button();
            this.btnRefundRequest = new System.Windows.Forms.Button();
            this.btnExtension = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAptModule
            // 
            this.btnAptModule.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAptModule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAptModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAptModule.ForeColor = System.Drawing.Color.Black;
            this.btnAptModule.Location = new System.Drawing.Point(33, 68);
            this.btnAptModule.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAptModule.Name = "btnAptModule";
            this.btnAptModule.Size = new System.Drawing.Size(175, 173);
            this.btnAptModule.TabIndex = 0;
            this.btnAptModule.Text = "Available Apartments";
            this.btnAptModule.UseVisualStyleBackColor = false;
            this.btnAptModule.Click += new System.EventHandler(this.btnAptModule_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.occuToolStripMenuItem,
            this.accountantToolStripMenuItem,
            this.managerToolStripMenuItem,
            this.serviceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(859, 29);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "TabControl";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginDataToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // loginDataToolStripMenuItem
            // 
            this.loginDataToolStripMenuItem.Name = "loginDataToolStripMenuItem";
            this.loginDataToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.loginDataToolStripMenuItem.Text = "Login Details";
            this.loginDataToolStripMenuItem.Click += new System.EventHandler(this.loginDataToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(118, 25);
            this.adminToolStripMenuItem.Text = "Administrator";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.userToolStripMenuItem.Text = "System User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // occuToolStripMenuItem
            // 
            this.occuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.occupantToolStripMenuItem,
            this.dependentToolStripMenuItem});
            this.occuToolStripMenuItem.Name = "occuToolStripMenuItem";
            this.occuToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.occuToolStripMenuItem.Text = "Customer";
            // 
            // occupantToolStripMenuItem
            // 
            this.occupantToolStripMenuItem.Name = "occupantToolStripMenuItem";
            this.occupantToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.occupantToolStripMenuItem.Text = "Occupant";
            this.occupantToolStripMenuItem.Click += new System.EventHandler(this.occupantToolStripMenuItem_Click);
            // 
            // dependentToolStripMenuItem
            // 
            this.dependentToolStripMenuItem.Name = "dependentToolStripMenuItem";
            this.dependentToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.dependentToolStripMenuItem.Text = "Dependent";
            this.dependentToolStripMenuItem.Click += new System.EventHandler(this.dependentToolStripMenuItem_Click);
            // 
            // accountantToolStripMenuItem
            // 
            this.accountantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paymentToolStripMenuItem,
            this.leaseToolStripMenuItem,
            this.leaseAgreementToolStripMenuItem});
            this.accountantToolStripMenuItem.Name = "accountantToolStripMenuItem";
            this.accountantToolStripMenuItem.Size = new System.Drawing.Size(100, 25);
            this.accountantToolStripMenuItem.Text = "Accountant";
            this.accountantToolStripMenuItem.Visible = false;
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.paymentToolStripMenuItem.Text = "Payment";
            this.paymentToolStripMenuItem.Click += new System.EventHandler(this.paymentToolStripMenuItem_Click);
            // 
            // leaseToolStripMenuItem
            // 
            this.leaseToolStripMenuItem.Name = "leaseToolStripMenuItem";
            this.leaseToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.leaseToolStripMenuItem.Text = "Lease";
            this.leaseToolStripMenuItem.Click += new System.EventHandler(this.leaseToolStripMenuItem_Click);
            // 
            // leaseAgreementToolStripMenuItem
            // 
            this.leaseAgreementToolStripMenuItem.Name = "leaseAgreementToolStripMenuItem";
            this.leaseAgreementToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.leaseAgreementToolStripMenuItem.Text = "Lease Agreement";
            this.leaseAgreementToolStripMenuItem.Click += new System.EventHandler(this.leaseAgreementToolStripMenuItem_Click);
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageRefundsToolStripMenuItem,
            this.manageExtensionsToolStripMenuItem});
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.managerToolStripMenuItem.Text = "Manager";
            // 
            // manageRefundsToolStripMenuItem
            // 
            this.manageRefundsToolStripMenuItem.Name = "manageRefundsToolStripMenuItem";
            this.manageRefundsToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.manageRefundsToolStripMenuItem.Text = "Manage Refunds";
            this.manageRefundsToolStripMenuItem.Click += new System.EventHandler(this.manageRefundsToolStripMenuItem_Click);
            // 
            // manageExtensionsToolStripMenuItem
            // 
            this.manageExtensionsToolStripMenuItem.Name = "manageExtensionsToolStripMenuItem";
            this.manageExtensionsToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.manageExtensionsToolStripMenuItem.Text = "Manage Extensions";
            this.manageExtensionsToolStripMenuItem.Click += new System.EventHandler(this.manageExtensionsToolStripMenuItem_Click);
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apartmentsToolStripMenuItem,
            this.classesToolStripMenuItem,
            this.parkToolStripMenuItem});
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(72, 25);
            this.serviceToolStripMenuItem.Text = "Service";
            // 
            // apartmentsToolStripMenuItem
            // 
            this.apartmentsToolStripMenuItem.Name = "apartmentsToolStripMenuItem";
            this.apartmentsToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.apartmentsToolStripMenuItem.Text = "Apartments";
            this.apartmentsToolStripMenuItem.Click += new System.EventHandler(this.apartmentsToolStripMenuItem_Click);
            // 
            // classesToolStripMenuItem
            // 
            this.classesToolStripMenuItem.Name = "classesToolStripMenuItem";
            this.classesToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.classesToolStripMenuItem.Text = "Classes";
            this.classesToolStripMenuItem.Click += new System.EventHandler(this.classesToolStripMenuItem_Click);
            // 
            // parkToolStripMenuItem
            // 
            this.parkToolStripMenuItem.Name = "parkToolStripMenuItem";
            this.parkToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.parkToolStripMenuItem.Text = "Park";
            this.parkToolStripMenuItem.Click += new System.EventHandler(this.parkToolStripMenuItem_Click);
            // 
            // btnAptClasses
            // 
            this.btnAptClasses.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAptClasses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAptClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAptClasses.ForeColor = System.Drawing.Color.Black;
            this.btnAptClasses.Location = new System.Drawing.Point(236, 68);
            this.btnAptClasses.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAptClasses.Name = "btnAptClasses";
            this.btnAptClasses.Size = new System.Drawing.Size(175, 173);
            this.btnAptClasses.TabIndex = 5;
            this.btnAptClasses.Text = "Apartment Classes";
            this.btnAptClasses.UseVisualStyleBackColor = false;
            this.btnAptClasses.Click += new System.EventHandler(this.btnAptClasses_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnReserve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReserve.ForeColor = System.Drawing.Color.Black;
            this.btnReserve.Location = new System.Drawing.Point(441, 69);
            this.btnReserve.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(179, 172);
            this.btnReserve.TabIndex = 6;
            this.btnReserve.Text = "Reservation";
            this.btnReserve.UseVisualStyleBackColor = false;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnWaitingList
            // 
            this.btnWaitingList.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnWaitingList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWaitingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWaitingList.ForeColor = System.Drawing.Color.Black;
            this.btnWaitingList.Location = new System.Drawing.Point(649, 69);
            this.btnWaitingList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnWaitingList.Name = "btnWaitingList";
            this.btnWaitingList.Size = new System.Drawing.Size(175, 172);
            this.btnWaitingList.TabIndex = 7;
            this.btnWaitingList.Text = "Waiting List";
            this.btnWaitingList.UseVisualStyleBackColor = false;
            this.btnWaitingList.Click += new System.EventHandler(this.btnWaitingList_Click);
            // 
            // btnRefundRequest
            // 
            this.btnRefundRequest.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRefundRequest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefundRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefundRequest.ForeColor = System.Drawing.Color.Black;
            this.btnRefundRequest.Location = new System.Drawing.Point(33, 269);
            this.btnRefundRequest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRefundRequest.Name = "btnRefundRequest";
            this.btnRefundRequest.Size = new System.Drawing.Size(378, 57);
            this.btnRefundRequest.TabIndex = 8;
            this.btnRefundRequest.Text = "Refund Request";
            this.btnRefundRequest.UseVisualStyleBackColor = false;
            this.btnRefundRequest.Click += new System.EventHandler(this.btnRefundRequest_Click);
            // 
            // btnExtension
            // 
            this.btnExtension.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExtension.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExtension.ForeColor = System.Drawing.Color.Black;
            this.btnExtension.Location = new System.Drawing.Point(441, 269);
            this.btnExtension.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExtension.Name = "btnExtension";
            this.btnExtension.Size = new System.Drawing.Size(383, 57);
            this.btnExtension.TabIndex = 9;
            this.btnExtension.Text = "Request Extension";
            this.btnExtension.UseVisualStyleBackColor = false;
            this.btnExtension.Click += new System.EventHandler(this.btnExtension_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(859, 620);
            this.Controls.Add(this.btnExtension);
            this.Controls.Add(this.btnRefundRequest);
            this.Controls.Add(this.btnWaitingList);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.btnAptClasses);
            this.Controls.Add(this.btnAptModule);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAptModule;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem occuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem occupantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dependentToolStripMenuItem;
        private System.Windows.Forms.Button btnAptClasses;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnWaitingList;
        private System.Windows.Forms.ToolStripMenuItem accountantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaseAgreementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRefundsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageExtensionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apartmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parkToolStripMenuItem;
        private System.Windows.Forms.Button btnRefundRequest;
        private System.Windows.Forms.Button btnExtension;
    }
}