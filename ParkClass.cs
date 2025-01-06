using System;
using System.Collections.Generic;
using System.Text;

namespace E_Apartments
{
    public class ParkClass
    {
        public int P_ID { get; set; }

        public string P_Title { get; set; }

        public bool P_IsAvailable { get; set; }

        public bool P_IsRemoved { get; set; }

        public string InsertQuery = "INSERT INTO Park (P_Title, P_IsAvailable, P_IsRemoved) VALUES (@Title, @IsAvailable, @Removed)";

        public string UpdateQuery = "UPDATE Park SET P_Title=@Title, P_IsAvailable=@IsAvailable WHERE P_ID=@ID";

        public string DeleteQuery = "UPDATE Park SET P_IsRemoved = 1 WHERE P_ID=@ID";

        public string SelectQuery = "SELECT p.P_ID As ID, p.P_Title As Title, p.P_IsAvailable As IsAvailable FROM Park p WHERE p.P_IsRemoved = 0";

        public string SearchQuery = "SELECT p.P_ID As ID, p.P_Title As Title, p.P_IsAvailable As IsAvailable FROM Park p WHERE p.P_IsRemoved = 0 AND p.P_Title = @Title";
    }
}
