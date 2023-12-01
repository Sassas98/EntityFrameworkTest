namespace EntityFrameworkTest.Models {
    public class City {
        public int CityId { get; set; }
        public string CityName { get; set; }
        virtual public IEnumerable<People> Peoples { get; set; }
        public int CountryId { get; set; }
        virtual public Country Country { get; set; }
    }
}
