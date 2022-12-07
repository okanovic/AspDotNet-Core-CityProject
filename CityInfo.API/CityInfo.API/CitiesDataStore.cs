using System;
using CityInfo.API.Controllers.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }

        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park",
                    PointOfInterest = new List<PointOfInterestDto>()
                    {
                     new PointOfInterestDto()   {
                         Id = 1,
                         Name = "Test-1",
                         Description = "The one with that big park"
                     },
                     new PointOfInterestDto()   {
                         Id = 2,
                         Name = "Test-2",
                         Description = "The one with that big park"
                     },
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "İstanbul",
                    Description = "Crowdest city in Turkey",
                         PointOfInterest = new List<PointOfInterestDto>()
                    {
                     new PointOfInterestDto()   {
                         Id = 1,
                         Name = "Kadıköy",
                         Description = "The one with that big park"
                     },
                     new PointOfInterestDto()   {
                         Id = 2,
                         Name = "Beyoğlu",
                         Description = "The one with that big park"
                     },
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Aydın",
                    Description = "Land of Ephesians",
                         PointOfInterest = new List<PointOfInterestDto>()
                    {
                     new PointOfInterestDto()   {
                         Id = 1,
                         Name = "Didim",
                         Description = "Altınkum"
                     },
                     new PointOfInterestDto()   {
                         Id = 2,
                         Name = "Kuşadası",
                         Description = "Aquapark"
                     },
                    }
                },
            };
        }
    }
}

