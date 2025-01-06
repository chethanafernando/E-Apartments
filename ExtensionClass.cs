using System;
using System.Collections.Generic;
using System.Text;

namespace E_Apartments
{
    public class ExtensionClass
    {
        public int E_ID { get; set; }

        public string E_Description { get; set; }

        public int E_Period { get; set; }

        public DateTime E_Date { get; set; }

        public DateTime E_ApprovedDate { get; set; }

        public int E_ApprovedBy { get; set; }

        public bool E_Approved { get; set; }

        public bool E_Removed { get; set; }

        public string InsertQuery = "INSERT INTO Extension (E_Description, E_Period, E_Date, E_Approved, E_Removed) VALUES (@Description, @Period, @Date, @Approved, @Removed)";

        public string UpdateQuery = "UPDATE Extension SET E_Description=@Description, E_Period=@Period, E_Date=@Date, E_ApprovedDate=@ApprovedDate, E_Approved=@Approved , E_ApprovedBy=@ApprovedBy  WHERE E_ID=@ID";

        public string DeleteQuery = "UPDATE Extension SET E_Removed = 1 WHERE E_ID=@ID";

        public string SelectQuery = "SELECT e.E_ID As ID, e.E_Description As Description, e.E_Period As Period, e.E_Date As Date, e.E_ApprovedDate As ApprovedDate, e.E_Approved As Approved, u.U_Username As ApproveBy  FROM Extension e INNER JOIN [dbo].[User] u ON e.E_ApprovedBy = u.U_ID WHERE e.E_Removed = 0";

        public string SearchQuery = "SELECT e.E_ID As ID, e.E_Description As Description, e.E_Period As Period, e.E_Date As Date, e.E_ApprovedDate As ApprovedDate, e.E_Approved As Approved, u.U_Username As ApproveBy  FROM Extension e INNER JOIN [dbo].[User] u ON e.E_ApprovedBy = u.U_ID WHERE e.E_Removed = 0 AND e.E_Date = @Date ";
    }
}
