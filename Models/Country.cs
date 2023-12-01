namespace EntityFrameworkTest.Models {
    public class Country {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        virtual public IEnumerable<City> Cities { get; set; }
    }
}
