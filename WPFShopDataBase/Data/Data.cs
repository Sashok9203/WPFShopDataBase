using System.Data.Common;
using System.Diagnostics;
using System.Net;
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
            new(){ Id=1,Name="IvorShop",Address="17451 Starling Park",CityId=1,ParkingArea = null },
            new(){ Id=2,Name="HomeShop",Address="532 Crownhardt Park",CityId=2   ,ParkingArea = 5 },
            new(){ Id=3,Name="Marinna",Address="0 Declaration Lane",CityId=3     ,ParkingArea = 8 },
            new(){ Id=4,Name="Zero",Address="3 SouthrIdge Terrace",CityId=4      ,ParkingArea = 12 },
            new(){ Id=5,Name="Kearney",Address="8 Charing Cross Plaza",CityId=7  ,ParkingArea = 13 },
        };

        public static readonly Category[] Categories = 
        {
            new(){ Id = 1, Name = "Food"},
            new(){ Id = 2, Name = "Beverages"},
            new(){ Id = 3, Name = "Clothing"},
            new(){ Id = 4, Name = "Footwear"},
            new(){ Id = 5, Name = "Household Goods"},
            new(){ Id = 6, Name = "Electronics"},
            new(){ Id = 7, Name = "Cosmetics"},
            new(){ Id = 8, Name = "Personal Hygiene"},
        };

        public static readonly Position[] Positions =
        {
            new(){ Id = 1, Name = "Sales Associate"},
            new(){ Id = 2, Name = "Cashier"},
            new(){ Id = 3, Name = "Delivery Driver"},
            new(){ Id = 4, Name = "Sales Manager"},
            new(){ Id = 5, Name = "Stock Clerk"},
        };

        public static readonly Product[] Products =
        {
            new(){ Id=1,Name="Meat",Price=100,Discount=8,CategoryId=1,Quantity=14,IsLnStock = true },
            new(){ Id=2,Name="Vegetable",Price=25.56M,Discount=3,CategoryId=1,Quantity=16 ,IsLnStock = false },
            new(){ Id=3,Name="Fruit",Price=30.32M,Discount=4,CategoryId=1,Quantity=9 ,IsLnStock = true },
            new(){ Id=4,Name="Bread",Price=25.86M,Discount=3,CategoryId=1,Quantity=73 ,IsLnStock = true },
            new(){ Id=5,Name="Dairy product",Price=13.37M,Discount=4,CategoryId=1,Quantity=24 ,IsLnStock = false },

            new(){ Id=6,Name="Water",Price=20.79M,Discount=9,CategoryId=2,Quantity=53 ,IsLnStock = true },
            new(){ Id=7,Name="Juice",Price=32.60M,Discount=8,CategoryId=2,Quantity=73 ,IsLnStock = true },
            new(){ Id=8,Name="Soft drink",Price=24.86M,Discount=8,CategoryId=2,Quantity=62 ,IsLnStock = false },
            new(){ Id=9,Name="Coffee",Price=83.9M,Discount=3,CategoryId=2,Quantity=57 ,IsLnStock = true },
            new(){ Id=10,Name="Tea",Price=152,Discount=7,CategoryId=2,Quantity=14,IsLnStock = true },

            new(){ Id=11,Name="T-shirt",Price=810,Discount=7,CategoryId=3,Quantity=84 ,IsLnStock = false },
            new(){ Id=12,Name="Skirt",Price=626,Discount=9,CategoryId=3,Quantity=15 ,IsLnStock = true },
            new(){ Id=13,Name="Pant",Price=1607,Discount=4,CategoryId=3,Quantity=76 ,IsLnStock = true },
            new(){ Id=14,Name="Dress",Price=871,Discount=8,CategoryId=3,Quantity=35 ,IsLnStock = true },

            new(){ Id=15,Name="Shoes",Price=1506,Discount=6,CategoryId=4,Quantity=87  ,IsLnStock = false },
            new(){ Id=16,Name="Sneaker",Price=1289,Discount=1,CategoryId=4,Quantity=99 ,IsLnStock = true },
            new(){ Id=17,Name="Sandals",Price=1822,Discount=10,CategoryId=4,Quantity=3  ,IsLnStock = true },

            new(){ Id=18,Name="Washing machine",Price=5804,Discount=5,CategoryId=5,Quantity=51 ,IsLnStock = true },
            new(){ Id=19,Name="Refrigerator",Price=4855,Discount=3,CategoryId=5,Quantity=22  ,IsLnStock = true },
            new(){ Id=20,Name="Microwaves",Price=2846,Discount=6,CategoryId=5,Quantity=81  ,IsLnStock = true },
            new(){ Id=21,Name="Plate",Price=534,Discount=1,CategoryId=5,Quantity=100  ,IsLnStock = true },
            new(){ Id=22,Name="Cutlery",Price=1474,Discount=3,CategoryId=5,Quantity=9 ,IsLnStock = true },
            new(){ Id=23,Name="Pot",Price=967,Discount=3,CategoryId=5,Quantity=80  ,IsLnStock = true },


            new(){ Id=24,Name="Smartphone",Price=4269,Discount=9,CategoryId=6,Quantity=16  ,IsLnStock = true },
            new(){ Id=25,Name="Tablet",Price=5556,Discount=3,CategoryId=6,Quantity=88  ,IsLnStock = true },
            new(){ Id=26,Name="TV",Price=3491,Discount=7,CategoryId=6,Quantity=5  ,IsLnStock = true },
            new(){ Id=27,Name="Laptop",Price=4461,Discount=7,CategoryId=6,Quantity=97 ,IsLnStock = false },
            new(){ Id=28,Name="Camera",Price=3971,Discount=3,CategoryId=6,Quantity=79 ,IsLnStock = true },
            new(){ Id=29,Name="Headphones",Price=847,Discount=2,CategoryId=6,Quantity=32,IsLnStock = true },
            new(){ Id=30,Name="Speakers",Price=1188,Discount=8,CategoryId=6,Quantity=57,IsLnStock = false },

            new(){ Id=31,Name="Lipstick",Price=371,Discount=3,CategoryId=7,Quantity=79 ,IsLnStock = true },
            new(){ Id=32,Name="Mascara",Price=847,Discount=2,CategoryId=7,Quantity=32 ,IsLnStock = true },
            new(){ Id=33,Name="Powder",Price=188,Discount=8,CategoryId=7,Quantity=57,IsLnStock = false },

            new(){ Id=34,Name="Toothpaste",Price=371,Discount=3,CategoryId=8,Quantity=79 ,IsLnStock = true },
            new(){ Id=35,Name="Soap",Price=847,Discount=2,CategoryId=8,Quantity=32 ,IsLnStock = true },
            new(){ Id=36,Name="Shampoos",Price=188,Discount=8,CategoryId=8,Quantity=57,IsLnStock = false },
        };

        public static readonly Worker[] Workers  =
        {
           new(){ Id=1,Name="Lissy",Surname="Saffe",Salary=6258,Email="lsaffe0@engadget.com",PhoneNumber="569-449-3023",PositionId=1,ShopId=1 },
           new(){ Id=2,Name="Scotti",Surname="Bende",Salary=6972,Email="sbende1@plala.or.jp",PhoneNumber="570-385-2650",PositionId=1,ShopId=2  },
           new(){ Id=3,Name="Bessie",Surname="Scahill",Salary=6417,Email="bscahill2@over-blog.com",PhoneNumber="270-467-1778",PositionId=1,ShopId=3 },
           new(){ Id=4,Name="LIdia",Surname="Habbin",Salary=6399,Email="lhabbin3@rambler.ru",PhoneNumber="613-314-4434",PositionId=1,ShopId=4  },
           new(){ Id=5,Name="Kingsley",Surname="Attrey",Salary=5165,Email="kattrey4@fc2.com",PhoneNumber="323-196-8937",PositionId=1,ShopId=5  },
           new(){ Id=6,Name="Kym",Surname="Willingale",Salary=5413,Email="kwillingale5@samsung.com",PhoneNumber="618-228-5154",PositionId=2,ShopId=1 },
           new(){ Id=7,Name="Katheryn",Surname="Delve",Salary=4713,Email="kdelve6@symantec.com",PhoneNumber="832-243-5980",PositionId=2,ShopId=2 },
           new(){ Id=8,Name="Roxanne",Surname="Edson",Salary=4595,Email="redson7@hexun.com",PhoneNumber="645-959-5070",PositionId=2,ShopId=3},
           new(){ Id=9,Name="Lorant",Surname="Helks",Salary=5381,Email="lhelks8@arstechnica.com",PhoneNumber="503-571-3258",PositionId=2,ShopId=4  },
           new(){ Id=10,Name="Banky",Surname="Albro",Salary=5681,Email="balbro9@wunderground.com",PhoneNumber="424-677-7301",PositionId=2,ShopId=5 },
           new(){ Id=11,Name="Eddy",Surname="Allgood",Salary=4097,Email="eallgooda@jigsy.com",PhoneNumber="207-930-5949",PositionId=3,ShopId=1  },
           new(){ Id=12,Name="Meryl",Surname="Beckwith",Salary=6664,Email="mbeckwithb@gravatar.com",PhoneNumber="737-921-2464",PositionId=3,ShopId=2 },
           new(){ Id=13,Name="Braden",Surname="Cuthbert",Salary=5602,Email="bcuthbertc@example.com",PhoneNumber="492-625-3599",PositionId=3,ShopId=3 },
           new(){ Id=14,Name="Laurena",Surname="Angric",Salary=5867,Email="langricd@bbc.co.uk",PhoneNumber="427-242-8999",PositionId=3,ShopId=4 },
           new(){ Id=15,Name="Tad",Surname="Secombe",Salary=5975,Email="tsecombee@zdnet.com",PhoneNumber="493-572-9986",PositionId=3,ShopId=5  },
           new(){ Id=16,Name="Audrie",Surname="McAvey",Salary=6800,Email="amcaveyf@about.com",PhoneNumber="513-263-6328",PositionId=4,ShopId=1 },
           new(){ Id=17,Name="Robin",Surname="Wessing",Salary=4192,Email="rwessingg@biblegateway.com",PhoneNumber="842-955-5620",PositionId=4,ShopId=2 },
           new(){ Id=18,Name="Prinz",Surname="Leele",Salary=5711,Email="pleeleh@noaa.gov",PhoneNumber="722-295-5538",PositionId=4,ShopId=3 },
           new(){ Id=19,Name="Nickie",Surname="Borkett",Salary=4400,Email="nborketti@t.co",PhoneNumber="260-533-0220",PositionId=4,ShopId=4 },
           new(){ Id=20,Name="Ardeen",Surname="Djekovic",Salary=4498,Email="adjekovicj@mozilla.org",PhoneNumber="369-226-6151",PositionId=4,ShopId=5 },
           new(){ Id=21,Name="Alexis",Surname="Feitosa",Salary=5567,Email="afeitosak@techcrunch.com",PhoneNumber="620-134-9428",PositionId=5,ShopId=1 },
           new(){ Id=22,Name="Johnathan",Surname="Kelland",Salary=4753,Email="jkellandl@dropbox.com",PhoneNumber="435-308-1532",PositionId=5,ShopId=2 },
           new(){ Id=23,Name="Kelley",Surname="DavIds",Salary=5899,Email="kdavIdsm@gov.uk",PhoneNumber="336-500-0646",PositionId=5,ShopId=3  },
           new(){ Id=24,Name="Stanleigh",Surname="FIdilis",Salary=5090,Email="sfIdilisn@google.com",PhoneNumber="562-142-4364",PositionId=5,ShopId=4 },
           new(){ Id=25,Name="Concettina",Surname="Assante",Salary=6861,Email="cassanteo@wired.com",PhoneNumber="268-399-2776",PositionId=5,ShopId=5}
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
