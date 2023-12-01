using EntityFrameworkTest.Data;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkTest {
    public class Program {
        public static void Main(string[] args) {
            /*
            var ctx = new PgContext();
            //var pg = new Models.PG(){Nome="Agave", LV = 1, EXP=0};
            //ctx.PGs.Add(pg);
            ctx.SaveChanges();
            var pgs = ctx.PGs.ToList();
            pgs.ForEach(pg => Console.WriteLine(pg.EXP));
            */
            var ctx = new PeopleContext();
            //LoadWithEeagerLoading(ctx);
            //LoadWithExplicitLoading(ctx);
            //LoadWithLazyLoading(ctx);
        }

        public static void LoadWithEeagerLoading(PeopleContext ctx) {
            var persona = ctx.Peoples
                .Include(i => i.City)
                .Where(w => w.PeopleId == 2).First();
            Console.WriteLine(persona.City.CityName);
        }

        public static void LoadWithExplicitLoading(PeopleContext ctx) {
            var persona = ctx.Peoples
                .Where(w => w.PeopleId == 1).First();

            ctx.Entry(persona).Reference(i => i.City).Load();
            Console.WriteLine(persona.City.CityName);
        }

        public static void LoadWithLazyLoading(PeopleContext ctx) {
            var persona = ctx.Peoples
                .Where(w => w.PeopleId == 1).First();

            Console.WriteLine(persona.City.Country.CountryName);
        }
    }
}

/*
public void LoadWithLazyLoading(MyDbContext ctx)
{
    var dipendente = ctx.Dipendenti
        .Where(w => w.IdDipendente == 1).First();

    var nomeCittaAzienda = dipendente.AziendaDoveLavora.Citta;
}

public void LoadWithExplicitLoading(MyDbContext ctx)
{
    var dipendente = ctx.Dipendenti
        .Where(w => w.IdDipendente == 1).First();

    ctx.Entry(dipendente)
        .Reference(i => i.AziendaDoveLavora)
        .Load();
}

public void LoadWithEeagerLoading(MyDbContext ctx)
{
    var dipendente = ctx.Dipendenti
        .Include(i => i.AziendaDoveLavora)
        .Where(w => w.IdDipendente == 1).First();
}
*/