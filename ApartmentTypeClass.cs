using System;
using System.Collections.Generic;
using System.Text;

namespace E_Apartments
{
    public class ApartmentTypeClass
    {
        public int AT_ID { get; set; }

        public string AT_Title { get; set; }

        public bool AT_IsBedroom { get; set; }

        public int AT_BedroomCount { get; set; }

        public bool AT_IsAttachedBathroom { get; set; }

        public int AT_IsAttachedBathroomCount { get; set; }

        public bool AT_IsCommonBathroom { get; set; }

        public bool AT_IsServantsRoom { get; set; }

        public bool AT_IsServantsToilet { get; set; }

        public bool AT_IsDiningArea { get; set; }

        public bool AT_IsLivingArea { get; set; }

        public bool AT_IsKitchen { get; set; }

        public bool AT_IsBalcony { get; set; }

        public bool AT_IsTelephoneConnection { get; set; }

        public bool AT_IsInternetConnection { get; set; }

        public bool AT_IsTVConnection { get; set; }

        public bool AT_IsParking { get; set; }

        public bool AT_IsGymnasium { get; set; }

        public bool AT_IsSwimmingPool { get; set; }

        public bool AT_IsRemoved { get; set; }

        public string InsertQuery = "INSERT INTO ApartmentType (AT_Title, AT_IsBedroom, AT_BedroomCount, AT_IsAttachedBathroom, AT_IsAttachedBathroomCount, AT_IsCommonBathroom, AT_IsServantsRoom, AT_IsServantsToilet, AT_IsDiningArea, AT_IsLivingArea, AT_IsKitchen, AT_IsBalcony, AT_IsTelephoneConnection, AT_IsInternetConnection, AT_IsTVConnection, AT_IsParking, AT_IsGymnasium, AT_IsSwimmingPool, AT_IsRemoved) VALUES (@Title, @IsBedroom, @BedroomCount, @IsAttachedBathroom, @IsAttachedBathroomCount, @IsCommonBathroom, @IsServantsRoom, @IsServantsToilet, @IsDiningArea, @IsLivingArea, @IsKitchen, @IsBalcony, @IsTelephoneConnection, @IsInternetConnection, @IsTVConnection, @IsParking, @IsGymnasium, @IsSwimmingPool, @Removed)";

        public string UpdateQuery = "UPDATE ApartmentType SET AT_Title=@Title, AT_IsBedroom=@IsBedroom, AT_BedroomCount=@BedroomCount, AT_IsAttachedBathroom=@IsAttachedBathroom, AT_IsAttachedBathroomCount=@IsAttachedBathroomCount , AT_IsCommonBathroom=@IsCommonBathroom , AT_IsServantsRoom=@IsServantsRoom , AT_IsServantsToilet=@IsServantsToilet , AT_IsDiningArea=@IsDiningArea , AT_IsLivingArea=@IsLivingArea , AT_IsKitchen=@IsKitchen , AT_IsBalcony=@IsBalcony , AT_IsTelephoneConnection=@IsTelephoneConnection , AT_IsInternetConnection=@IsInternetConnection , AT_IsTVConnection=@IsTVConnection , AT_IsParking=@IsParking , AT_IsGymnasium=@IsGymnasium , AT_IsSwimmingPool=@IsSwimmingPool  WHERE AT_ID=@ID";

        public string DeleteQuery = "UPDATE ApartmentType SET AT_IsRemoved = 1 WHERE AT_ID=@ID";

        public string SelectQuery = "SELECT AT_ID As ID, AT_Title As Title, AT_IsBedroom As IsBedroom, AT_BedroomCount As BedroomCount, AT_IsAttachedBathroom As IsAttachedBathroom, AT_IsAttachedBathroomCount As AttachedBathroomsCount, AT_IsCommonBathroom As IsCommonBathroom, AT_IsServantsRoom As IsServantsRoom, AT_IsServantsToilet As IsServantsToilet, AT_IsDiningArea As IsDiningArea, AT_IsLivingArea As IsLivingArea, AT_IsKitchen As IsKitchen, AT_IsBalcony As IsBalcony, AT_IsTelephoneConnection As IsTelephoneConnection, AT_IsInternetConnection As IsInternetConnection, AT_IsTVConnection As IsTVConnection, AT_IsParking As IsParking, AT_IsGymnasium As IsGymnasium, AT_IsSwimmingPool As IsSwimmingPool FROM ApartmentType WHERE AT_IsRemoved = 0";

        public string SearchQuery = "SELECT AT_ID As ID, AT_Title As Title, AT_IsBedroom As IsBedroom, AT_BedroomCount As BedroomCount, AT_IsAttachedBathroom As IsAttachedBathroom, AT_IsAttachedBathroomCount As AttachedBathroomsCount, AT_IsCommonBathroom As IsCommonBathroom, AT_IsServantsRoom As IsServantsRoom, AT_IsServantsToilet As IsServantsToilet, AT_IsDiningArea As IsDiningArea, AT_IsLivingArea As IsLivingArea, AT_IsKitchen As IsKitchen, AT_IsBalcony As IsBalcony, AT_IsTelephoneConnection As IsTelephoneConnection, AT_IsInternetConnection As IsInternetConnection, AT_IsTVConnection As IsTVConnection, AT_IsParking As IsParking, AT_IsGymnasium As IsGymnasium, AT_IsSwimmingPool As IsSwimmingPool FROM ApartmentType WHERE AT_IsRemoved = 0 AND AT_Title = @Title";
    }
}
