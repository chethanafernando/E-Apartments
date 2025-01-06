
namespace E_Apartments
{
    partial class frmRefundRequest
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
            this.txtReason = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDueAmount = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDueAccount = new System.Windows.Forms.TextBox();
            this.dtpRefDate = new System.Windows.Forms.DateTimePicker();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.lblAmoRefundedDate = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblRefundRequest = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtReason
            // 
            this.txtReason.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtReason.Location = new System.Drawing.Point(168, 15);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(250, 29);
            this.txtReason.TabIndex = 25;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(168, 144);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(250, 23);
            this.dtpDate.TabIndex = 24;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(21, 147);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 20);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
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
            this.lblReason.Size = new System.Drawing.Size(135, 20);
            this.lblReason.TabIndex = 1;
            this.lblReason.Text = "Refund Reason";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(225, 228);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 42);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.txtDueAccount);
            this.panel1.Controls.Add(this.dtpRefDate);
            this.panel1.Controls.Add(this.txtAccount);
            this.panel1.Controls.Add(this.lblAmoRefundedDate);
            this.panel1.Controls.Add(this.txtReason);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblDueAmount);
            this.panel1.Controls.Add(this.lblAmount);
            this.panel1.Controls.Add(this.lblReason);
            this.panel1.Location = new System.Drawing.Point(5, 54);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 292);
            this.panel1.TabIndex = 49;
            // 
            // txtDueAccount
            // 
            this.txtDueAccount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDueAccount.Location = new System.Drawing.Point(168, 101);
            this.txtDueAccount.Name = "txtDueAccount";
            this.txtDueAccount.Size = new System.Drawing.Size(250, 29);
            this.txtDueAccount.TabIndex = 29;
            // 
            // dtpRefDate
            // 
            this.dtpRefDate.Location = new System.Drawing.Point(168, 185);
            this.dtpRefDate.Name = "dtpRefDate";
            this.dtpRefDate.Size = new System.Drawing.Size(250, 23);
            this.dtpRefDate.TabIndex = 28;
            // 
            // txtAccount
            // 
            this.txtAccount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAccount.Location = new System.Drawing.Point(168, 59);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(250, 29);
            this.txtAccount.TabIndex = 27;
            // 
            // lblAmoRefundedDate
            // 
            this.lblAmoRefundedDate.AutoSize = true;
            this.lblAmoRefundedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAmoRefundedDate.Location = new System.Drawing.Point(21, 187);
            this.lblAmoRefundedDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmoRefundedDate.Name = "lblAmoRefundedDate";
            this.lblAmoRefundedDate.Size = new System.Drawing.Size(132, 20);
            this.lblAmoRefundedDate.TabIndex = 26;
            this.lblAmoRefundedDate.Text = "Refunded Date";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(111, 228);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 42);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblRefundRequest
            // 
            this.lblRefundRequest.AutoSize = true;
            this.lblRefundRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRefundRequest.Location = new System.Drawing.Point(5, 9);
            this.lblRefundRequest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRefundRequest.Name = "lblRefundRequest";
            this.lblRefundRequest.Size = new System.Drawing.Size(238, 33);
            this.lblRefundRequest.TabIndex = 48;
            this.lblRefundRequest.Text = "Refund Request";
            // 
            // frmRefundRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 352);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblRefundRequest);
            this.Name = "frmRefundRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Refund Request";
            this.Load += new System.EventHandler(this.frmRefundRequest_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDueAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblRefundRequest;
        private System.Windows.Forms.TextBox txtDueAccount;
        private System.Windows.Forms.DateTimePicker dtpRefDate;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label lblAmoRefundedDate;
    }
}