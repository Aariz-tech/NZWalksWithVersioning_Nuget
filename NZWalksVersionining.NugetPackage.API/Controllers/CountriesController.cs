using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Versioning.Models.DTOs;

namespace NZWalks.API.Versioning.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]

    public class CountriesController : ControllerBase
    {
        [HttpGet]
        [MapToApiVersion("1.0")]
        public async Task<IActionResult> GetAllCountryDataV1()
        {
            CountryData countryData = new CountryData();
            var listOfCountries = await countryData.GetAllCountryData();
            List<CountryDtoV1> response = new List<CountryDtoV1>();
            foreach (var country in listOfCountries)
            {
                
                response.Add(new CountryDtoV1
                {
                    Id = country.Id,
                    Name = country.Name,
                });
            }
            return Ok(response);
        }
        [HttpGet]
        [MapToApiVersion("2.0")]
        public async Task<IActionResult> GetAllCountryDataV2()
        {
            CountryData countryData = new CountryData();
            var listOfCountries = await countryData.GetAllCountryData();
            List<CountryDtoV2> response = new List<CountryDtoV2>();
            foreach (var country in listOfCountries)
            {

                response.Add(new CountryDtoV2
                {
                    Id = country.Id,
                    CountryName = country.Name,
                });
            }
            return Ok(response);
        }
    }
}
