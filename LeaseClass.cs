using System;
using System.Collections.Generic;
using System.Text;

namespace E_Apartments
{
    public class LeaseClass
    {
        public int L_ID { get; set; }

        public int L_OccupantID { get; set; }

        public int L_ApartmentID { get; set; }

        public int L_AgreementID { get; set; }

        public bool L_IsAgreed { get; set; }

        public DateTime L_CreatedDate { get; set; }

        public DateTime L_ExpiryDate { get; set; }

        public int L_CreatedBy { get; set; }

        public bool L_IsApproved { get; set; }

        public int L_IsApprovedBy { get; set; }

        public bool L_IsRemoved { get; set; }

        public bool L_IsFinished { get; set; }

        public int L_PaymentID { get; set; }

        public int L_RefundRequestID { get; set; }

        public int L_IsExtensionID { get; set; }

        //public string InsertQuery = "INSERT INTO [dbo].[User] (U_Username, U_Password, U_Email, U_Designation, U_Role, U_Removed) VALUES (@Username, @Password, @Email, @Designation, @Role, @Removed)";

        //public string UpdateQuery = "UPDATE [dbo].[User] SET U_Password=@Password, U_Email=@Email, U_Designation=@Designation, U_Role=@Role WHERE U_ID=@ID";

        //public string DeleteQuery = "UPDATE [dbo].[User] SET U_Removed = 1 WHERE U_ID=@ID";

        //public string SelectQuery = "SELECT u.U_ID As ID, u.U_Username As Username, u.U_Password As Password, u.U_Email As Email, u.U_Designation As Designation, u.U_Role As Role FROM [dbo].[User] u WHERE u.U_Removed = 0";

        //public string SearchQuery = "SELECT u.U_ID As ID, u.U_Username As Username, u.U_Password As Password, u.U_Email As Email, u.U_Designation As Designation, u.U_Role As Role FROM [dbo].[User] u WHERE u.U_Removed = 0 AND u.U_Username = @Username OR u.U_Email = @Email";
    }
}
