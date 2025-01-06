using System;
using System.Collections.Generic;
using System.Text;

namespace E_Apartments
{
    public class OccupantClass
    {
        public int O_ID { get; set; }

        public string O_Name { get; set; }

        public string O_Address { get; set; }

        public string O_NICorPassport { get; set; }

        public int O_Contact { get; set; }

        public int O_DependentID { get; set; }

        public bool O_Removed { get; set; }

        public string InsertQuery = "INSERT INTO Occupant (O_Name, O_Address, O_NICorPassport, O_Contact, O_DependentID, O_Removed) VALUES (@Name, @Address, @NIC, @Contact, @DependentID, @Removed)";

        public string UpdateQuery = "UPDATE Occupant SET O_Name=@Name, O_Address=@Address, O_NICorPassport=@NIC, O_Contact=@Contact, O_DependentID=@DependentID WHERE O_ID=@ID";

        public string DeleteQuery = "UPDATE Occupant SET O_Removed = 1 WHERE O_ID=@ID";

        public string SelectQuery = "SELECT o.O_ID As ID, o.O_Name As Name, o.O_Address As Address, o.O_NICorPassport As NICorPassport, o.O_Contact As Contact, o.O_DependentID As Dependent FROM Occupant o WHERE o.O_Removed = 0";

        public string SearchQuery = "SELECT o.O_ID As ID, o.O_Name As Name, o.O_Address As Address, o.O_NICorPassport As NICorPassport, o.O_Contact As Contact, o.O_DependentID As Dependent FROM Occupant o WHERE o.O_Removed = 0 AND o.O_Name = @Name OR o.O_NICorPassport = @NIC";
    }
}
