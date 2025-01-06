using System;
using System.Collections.Generic;
using System.Text;

namespace E_Apartments
{
    public class RefundRequestClass
    {
        public int RR_ID { get; set; }

        public string RR_Reason { get; set; }

        public decimal RR_Amount { get; set; }

        public decimal RR_DueAmount { get; set; }

        public DateTime RR_Date { get; set; }

        public DateTime RR_AmountRefundedDate { get; set; }

        public bool RR_Approved { get; set; }

        public int RR_ApprovedBy { get; set; }

        public bool RR_IsRemoved { get; set; }

        public string InsertQuery = "INSERT INTO RefundRequest (RR_Reason, RR_Amount, RR_DueAmount, RR_Date, RR_AmountRefundedDate, RR_IsRemoved) VALUES (@Reason, @Amount, @DueAmount, @Date, @RefDate, @Removed)";

        public string UpdateQuery = "UPDATE RefundRequest SET RR_Reason=@Reason, RR_Amount=@Amount, RR_DueAmount=@DueAmount, RR_Date=@Date, RR_AmountRefundedDate=@AmoundRefundedDate , RR_Approved=@Approved , RR_ApprovedBy=@ApprovedBy WHERE RR_ID=@ID";

        public string DeleteQuery = "UPDATE RefundRequest SET RR_IsRemoved = 1 WHERE RR_ID=@ID";

        public string SelectQuery = "SELECT r.RR_ID As ID, r.RR_Reason As Reason, r.RR_Amount As Amount, r.RR_DueAmount As DueAmount, r.RR_Date As Date, r.RR_AmountRefundedDate As RefundedDate, r.RR_Approved As Approved, u.U_Username As ApproveBy FROM RefundRequest r INNER JOIN [dbo].[User] u ON r.RR_ApprovedBy = u.U_ID WHERE r.RR_IsRemoved = 0";

        public string SearchQuery = "SELECT r.RR_ID As ID, r.RR_Reason As Reason, r.RR_Amount As Amount, r.RR_DueAmount As DueAmount, r.RR_Date As Date, r.RR_AmountRefundedDate As RefundedDate, r.RR_Approved As Approved, u.U_Username As ApproveBy FROM RefundRequest r INNER JOIN [dbo].[User] u ON r.RR_ApprovedBy = u.U_ID WHERE r.RR_IsRemoved = 0 AND r.RR_Date = @Date";
    }
}
