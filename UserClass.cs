using System;
using System.Collections.Generic;
using System.Text;

namespace E_Apartments
{
    public class UserClass
    {
        public int U_ID { get; set; }

        public string U_Username { get; set; }

        public string U_Password { get; set; }

        public string U_Email { get; set; }

        public string U_Designation { get; set; }

        public string U_Role { get; set; }

        public bool U_Removed { get; set; }

        public string InsertQuery = "INSERT INTO [dbo].[User] (U_Username, U_Password, U_Email, U_Designation, U_Role, U_Removed) VALUES (@Username, @Password, @Email, @Designation, @Role, @Removed)";

        public string UpdateQuery = "UPDATE [dbo].[User] SET U_Password=@Password, U_Email=@Email, U_Designation=@Designation, U_Role=@Role WHERE U_ID=@ID";

        public string DeleteQuery = "UPDATE [dbo].[User] SET U_Removed = 1 WHERE U_ID=@ID";

        public string SelectQuery = "SELECT u.U_ID As ID, u.U_Username As Username, u.U_Password As Password, u.U_Email As Email, u.U_Designation As Designation, u.U_Role As Role FROM [dbo].[User] u WHERE u.U_Removed = 0";

        public string SearchQuery = "SELECT u.U_ID As ID, u.U_Username As Username, u.U_Password As Password, u.U_Email As Email, u.U_Designation As Designation, u.U_Role As Role FROM [dbo].[User] u WHERE u.U_Removed = 0 AND u.U_Username = @Username OR u.U_Email = @Email";
    }
}
