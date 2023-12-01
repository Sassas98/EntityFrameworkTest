using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTest.Models {
    public class People {
        public int PeopleId { get; set; }
        public string PeopleName { get; set; }
        public int CityId { get; set; }
        virtual public City City { get; set; }

    }
}
