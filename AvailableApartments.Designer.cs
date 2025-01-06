
namespace E_Apartments
{
    partial class frmAvailableApartments
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
            this.btnHome = new System.Windows.Forms.Button();
            this.lblApartments = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAvailable = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvApart = new System.Windows.Forms.DataGridView();
            this.btnAllApart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApart)).BeginInit();
            this.SuspendLayout();
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
            this.btnFind.Location = new System.Drawing.Point(760, 56);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(88, 32);
            this.btnFind.TabIndex = 45;
            this.btnFind.Text = "Search";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAvailable
            // 
            this.btnAvailable.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAvailable.Location = new System.Drawing.Point(5, 55);
            this.btnAvailable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAvailable.Name = "btnAvailable";
            this.btnAvailable.Size = new System.Drawing.Size(187, 33);
            this.btnAvailable.TabIndex = 48;
            this.btnAvailable.Text = "Available Apartments";
            this.btnAvailable.UseVisualStyleBackColor = false;
            this.btnAvailable.Click += new System.EventHandler(this.btnAvailable_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(395, 57);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(357, 29);
            this.txtSearch.TabIndex = 46;
            // 
            // dgvApart
            // 
            this.dgvApart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApart.Location = new System.Drawing.Point(5, 94);
            this.dgvApart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvApart.Name = "dgvApart";
            this.dgvApart.Size = new System.Drawing.Size(842, 309);
            this.dgvApart.TabIndex = 43;
            // 
            // btnAllApart
            // 
            this.btnAllApart.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAllApart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAllApart.Location = new System.Drawing.Point(200, 55);
            this.btnAllApart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAllApart.Name = "btnAllApart";
            this.btnAllApart.Size = new System.Drawing.Size(187, 33);
            this.btnAllApart.TabIndex = 49;
            this.btnAllApart.Text = "All Apartments";
            this.btnAllApart.UseVisualStyleBackColor = false;
            this.btnAllApart.Click += new System.EventHandler(this.btnAllApart_Click);
            // 
            // frmAvailableApartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 408);
            this.Controls.Add(this.btnAllApart);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblApartments);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnAvailable);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvApart);
            this.Name = "frmAvailableApartments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Available Apartments";
            this.Load += new System.EventHandler(this.frmAvailableApartments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblApartments;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAvailable;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvApart;
        private System.Windows.Forms.Button btnAllApart;
    }
}