using System;
using System.Collections.Generic;
using System.Text;

namespace E_Apartments
{
    public class DependentClass
    {
        public int D_ID { get; set; }

        public string D_Name { get; set; }

        public int D_Contact { get; set; }

        public string D_NICorPassport { get; set; }

        public string D_Address { get; set; }

        public bool D_IsServant { get; set; }

        public bool D_Removed { get; set; }

        public string InsertQuery = "INSERT INTO Dependent (D_Name, D_Contact, D_NICorPassport, D_Address, D_IsServant, D_Removed) VALUES (@Name, @Contact, @NIC, @Address, @IsServant, @Removed)";

        public string UpdateQuery = "UPDATE Dependent SET D_Name=@Name, D_Contact=@Contact, D_NICorPassport=@NIC, D_Address=@Address, D_IsServant=@IsServant WHERE D_ID=@ID";

        public string DeleteQuery = "UPDATE Dependent SET D_Removed = 1 WHERE D_ID=@ID";

        public string SelectQuery = "SELECT d.D_ID As ID, d.D_Name As Name, d.D_Contact As Contact, d.D_NICorPassport As NICorPassport, d.D_Address As Address, d.D_IsServant As IsServant FROM Dependent d WHERE d.D_Removed = 0";

        public string SearchQuery = "SELECT d.D_ID As ID, d.D_Name As Name, d.D_Contact As Contact, d.D_NICorPassport As NICorPassport, d.D_Address As Address, d.D_IsServant As IsServant FROM Dependent d INNER JOIN Occupant o ON o.O_DependentID = d.D_ID WHERE d.D_Removed = 0 AND o.O_Removed = 0 AND d.D_Name = @DName OR o.O_Name = @OName";
    }
}
