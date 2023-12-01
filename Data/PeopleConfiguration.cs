using EntityFrameworkTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkTest.Data {
    internal class PeopleConfiguration : IEntityTypeConfiguration<People> {
        public void Configure(EntityTypeBuilder<People> builder) {
            builder.ToTable("People");
            builder.HasKey(k => k.PeopleId);
            builder.HasOne(x => x.City)
                .WithMany(x => x.Peoples)
                .HasForeignKey(x => x.CityId);
        }
    }
}