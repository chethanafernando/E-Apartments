using System;
using System.Collections.Generic;
using System.Text;

namespace E_Apartments
{
    public class WaitingListClass
    {
        public int W_ID { get; set; }

        public int W_QueueNumber { get; set; }

        public int W_OccupantID { get; set; }

        public DateTime W_CreatedDate { get; set; }

        public int W_CreatedBy { get; set; }

        public DateTime W_ReservationDate { get; set; }

        public DateTime W_RequiredDate { get; set; }

        public bool W_Removed { get; set; }

        public string InsertQuery = "INSERT INTO WaitingList (W_QueueNumber, W_OccupantID, W_CreatedDate, W_CreatedBy, W_ReservationDate, W_RequiredDate, W_Removed) VALUES (@Queue, @OccID, @CreatedDate, @CreatedBy, @ResDate, @ReqDate, @Removed)";

        public string UpdateQuery = "UPDATE WaitingList SET W_QueueNumber=@Queue, W_OccupantID=@OccID, W_CreatedDate=@CreatedDate, W_CreatedBy=@CreatedBy, W_ReservationDate=@ResDate, W_RequiredDate=@ReqDate WHERE W_ID=@ID";

        public string DeleteQuery = "UPDATE WaitingList SET W_Removed = 1 WHERE W_ID=@ID";

        public string SelectQuery = "SELECT w.W_ID As ID, w.W_QueueNumber As Queue, o.O_Name As Occupant, w.W_CreatedDate As CreatedDate, u.U_Username As CreatedBy, w.W_ReservationDate As ReservationDate, w.W_RequiredDate As RequiredDate FROM WaitingList w INNER JOIN Occupant o ON o.O_ID = w.W_OccupantID INNER JOIN [dbo].[User] u ON u.U_ID = w.W_CreatedBy WHERE u.U_Removed = 0 AND w.W_Removed = 0 AND o.O_Removed = 0";

        public string SearchQuery = "SELECT w.W_ID As ID, w.W_QueueNumber As Queue, o.O_Name As Occupant, w.W_CreatedDate As CreatedDate, u.U_Username As CreatedBy, w.W_ReservationDate As ReservationDate, w.W_RequiredDate As RequiredDate FROM WaitingList w INNER JOIN Occupant o ON o.O_ID = w.W_OccupantID INNER JOIN [dbo].[User] u ON u.U_ID = w.W_CreatedBy WHERE u.U_Removed = 0 AND w.W_Removed = 0 AND o.O_Removed = 0 AND o.W_QueueNumber = @Number";
    }
}
 