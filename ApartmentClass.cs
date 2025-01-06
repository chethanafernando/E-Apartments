using System;
using System.Collections.Generic;
using System.Text;

namespace E_Apartments
{
    public class ApartmentClass
    {
        public int A_BuildingID { get; set; }

        public int A_ApartmentNumber { get; set; }

        public int A_ApartmentTypeID { get; set; }

        public bool A_IsAvailable { get; set; }

        public string A_Location { get; set; }

        public decimal A_DepositAmount { get; set; }

        public int A_MaxAllowedPerson { get; set; }

        public decimal A_ReservationFee { get; set; }

        public bool A_IsRemoved { get; set; }

        public int A_ParkID { get; set; }

        public string SelectQuery1 = "SELECT a.A_BuildingID As BuildingID, a.A_ApartmentNumber As ApartmentNumber, at.AT_Title As Class, a.A_IsAvailable As Available, p.P_Title As ParkArea, a.A_Location As Location, a.A_DepositAmount As DepositAmount, " +
            "a.A_MaxAllowedPerson As MaxAllowedPerson, a.A_ReservationFee As ReservationFee FROM Apartment a INNER JOIN ApartmentType at ON a.A_ApartmentTypeID = at.AT_ID INNER JOIN Park p ON p.P_ID = a.A_ParkID " +
            "WHERE p.P_IsRemoved = 0 AND at.AT_IsRemoved = 0 AND a.A_IsRemoved = 0 AND a.A_IsAvailable = 1";

        public string SelectQuery2 = "SELECT a.A_BuildingID As BuildingID, a.A_ApartmentNumber As ApartmentNumber, at.AT_Title As Class, a.A_IsAvailable As Available, p.P_Title As ParkArea, a.A_Location As Location, a.A_DepositAmount As DepositAmount, " +
            "a.A_MaxAllowedPerson As MaxAllowedPerson, a.A_ReservationFee As ReservationFee FROM Apartment a INNER JOIN ApartmentType at ON a.A_ApartmentTypeID = at.AT_ID INNER JOIN Park p ON p.P_ID = a.A_ParkID" +
            " WHERE p.P_IsRemoved = 0 AND at.AT_IsRemoved = 0 AND a.A_IsRemoved = 0";

        public string SearchQuery = "SELECT a.A_BuildingID As BuildingID, a.A_ApartmentNumber As ApartmentNumber, at.AT_Title As Class, a.A_IsAvailable As Available, p.P_Title As ParkArea, a.A_Location As Location, a.A_DepositAmount As DepositAmount, " +
            "a.A_MaxAllowedPerson As MaxAllowedPerson, a.A_ReservationFee As ReservationFee FROM Apartment a INNER JOIN ApartmentType at ON a.A_ApartmentTypeID = at.AT_ID INNER JOIN Park p ON p.P_ID = a.A_ParkID " +
            "WHERE p.P_IsRemoved = 0 AND at.AT_IsRemoved = 0 AND a.A_IsRemoved = 0 AND a.A_ApartmentNumber = @Number OR a.A_Location = @Location";

        public string InsertQuery = "INSERT INTO Apartment (A_ApartmentNumber, A_ApartmentTypeID, A_IsAvailable, A_ParkID, A_Location, A_DepositAmount, A_MaxAllowedPerson, A_ReservationFee, A_IsRemoved) VALUES (@ApartmentNumber, @ApartmentType, @IsAvailable, @ParkID, @Location, @DepositAmount, @MaxAllowedPerson, @ReservationFee, @Removed)";

        public string UpdateQuery = "UPDATE Apartment SET A_ApartmentNumber=@ApartmentNumber, A_ApartmentTypeID=@ApartmentType, A_IsAvailable=@IsAvailable, A_ParkID=@ParkID, A_Location=@Location, A_DepositAmount=@DepositAmount, A_MaxAllowedPerson=@MaxAllowedPerson, A_ReservationFee=@ReservationFee WHERE A_BuildingID=@ID";

        public string DeleteQuery = "UPDATE Apartment SET A_IsRemoved = 1 WHERE A_BuildingID=@ID";
    }
}
