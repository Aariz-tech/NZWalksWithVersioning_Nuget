namespace NZWalks.API.Versioning.Models.DTOs
{
    public class CountryDtoV1
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
    public class CountryDtoV2
    {
        public Guid Id { get; set; }
        public string CountryName { get; set; }
    }
}
