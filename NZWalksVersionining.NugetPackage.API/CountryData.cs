using NZWalks.API.Versioning.Models.Domain;

namespace NZWalks.API.Versioning
{
    public class CountryData
    {
        public async Task<List<Country>> GetAllCountryData()
        {
            var listOfCountry = new List<Country>
            {
                new Country()
                {
                    Id = Guid.NewGuid(),
                    Name = "India",
                },
                new Country()
                {
                    Id = Guid.NewGuid(),
                    Name = "Spain",
                },
                new Country()
                {
                    Id = Guid.NewGuid(),
                    Name = "England",
                },
                new Country()
                {
                    Id = Guid.NewGuid(),
                    Name = "Colunmbia",
                },
                new Country()
                {
                    Id = Guid.NewGuid(),
                    Name = "Egypt",
                },
                new Country()
                {
                    Id = Guid.NewGuid(),
                    Name = "Brazil",
                },
                new Country()
                {
                    Id = Guid.NewGuid(),
                    Name = "Argentina",
                },
                new Country()
                {
                    Id = Guid.NewGuid(),
                    Name = "France",
                },

            };
            return listOfCountry;
        }
    }
}
