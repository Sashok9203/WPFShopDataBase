using WPFShopDataBase.Entities;

namespace WPFShopDataBase.Data
{
    public static class Data
    {

        public static readonly City[] Cities =
        {
            new(){ Id = 1, CountryId =  1, Name = "Stockholm" },
            new(){ Id = 2, CountryId =  2, Name = "Wuhan" },
            new(){ Id = 3, CountryId =  3, Name = "Tokyo" },
            new(){ Id = 4, CountryId =  4, Name = "Paris" },
            new(){ Id = 5, CountryId =  5, Name = "Warsaw" },
            new(){ Id = 6, CountryId =  6, Name = "Berlin" },
            new(){ Id = 7, CountryId =  7, Name = "Rivne" },
        };

        public static readonly Shop[] Shops =
        {

        };

        public static readonly Category[] Categories = 
        { 

        };

        public static readonly Position[] Positions =
        {
        };

        public static readonly Product[] Products =
        {
        };

        public static readonly Worker[] Workers  =
        {
        };


        public static readonly Country[] Countries =
        {
            new(){Id = 1,  Name ="Sweden" },
            new(){Id = 2,  Name ="China" },
            new(){Id = 3,  Name ="Japan" },
            new(){Id = 4,  Name ="France"},
            new(){Id = 5,  Name ="Poland"},
            new(){Id = 6,  Name ="Germany"},
            new(){Id = 7,  Name = "Ukraine"}
        } ;

       
    }
}
