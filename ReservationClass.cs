using System;
using System.Collections.Generic;
using System.Text;

namespace E_Apartments
{
    public class ReservationClass
    {
        public int R_ID { get; set; }

        public int R_ApartmentID { get; set; }

        public int R_OccupantID { get; set; }

        public DateTime R_Date { get; set; }

        public int R_PaymentID { get; set; }

        public bool R_IsAdditonalPark { get; set; }

        public DateTime R_ForDate { get; set; }

        public bool R_IsReserved { get; set; }

        public int R_ReservedBy { get; set; }

        public bool R_Removed { get; set; }

        public string InsertQuery = "INSERT INTO Reservation (R_ApartmentID, R_OccupantID, R_Date, R_PaymentID, R_IsAdditonalPark, R_ForDate, R_IsReserved, R_ReservedBy, R_Removed) VALUES (@AptID, " +
            "@OccID, @Date, @PayID, @AddPark, @ForDate, @IsReserved, @ReservedBy, @Removed)";

        public string UpdateQuery = "UPDATE Reservation SET R_ApartmentID=@AptID, R_OccupantID=@OccID, R_Date=@Date, R_PaymentID=@PayID, R_IsAdditonalPark=@AddPark, R_ForDate=@ForDate, " +
            "R_IsReserved=@IsReserved, R_ReservedBy=@ReservedBy  WHERE R_ID=@ID";

        public string DeleteQuery = "UPDATE Reservation SET R_Removed = 1 WHERE R_ID=@ID";

        public string SelectQuery = "SELECT a.A_ApartmentNumber As ApartmentNumber, o.O_Name As Occupant, r.R_Date As Date, r.R_PaymentID As PayID, r.R_IsAdditonalPark As AdditionalParking, " +
            "r.R_ForDate As CreatedDate, r.R_IsReserved As IsReserved, u.U_Username As ReservedBy FROM Reservation r INNER JOIN Apartment a ON a.A_BuildingID = r.R_ApartmentID INNER JOIN " +
            "Occupant o ON o.O_ID = r.R_OccupantID INNER JOIN [dbo].[User] u ON u.U_ID = r.R_ReservedBy WHERE u.U_Removed = 0 AND r.R_Removed = 0 AND a.A_IsRemoved = 0";

        public string SearchQuery = "SELECT a.A_ApartmentNumber As ApartmentNumber, o.O_Name As Occupant, r.R_Date As Date, r.R_PaymentID As PayID, r.R_IsAdditonalPark As AdditionalParking, " +
            "r.R_ForDate As CreatedDate, r.R_IsReserved As IsReserved, u.U_Username As ReservedBy FROM Reservation r INNER JOIN Apartment a ON a.A_BuildingID = r.R_ApartmentID INNER JOIN " +
            "Occupant o ON o.O_ID = r.R_OccupantID INNER JOIN [dbo].[User] u ON u.U_ID = r.R_ReservedBy WHERE u.U_Removed = 0 AND r.R_Removed = 0 AND a.A_IsRemoved = 0 AND r.R_Date = @Date";
    }
}
