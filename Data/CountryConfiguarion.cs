using EntityFrameworkTest.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTest.Data {
    internal class CountryConfiguarion : IEntityTypeConfiguration<Country> {
        public void Configure(EntityTypeBuilder<Country> builder) {
            builder.ToTable("Country");
            builder.HasKey(k => k.CountryId);
        }
    }
}
