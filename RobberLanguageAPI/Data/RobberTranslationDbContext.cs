using Microsoft.EntityFrameworkCore;
using RobberLanguageAPI.Model;

namespace RobberLanguageAPI.Data
{
    public class RobberTranslationDbContext : DbContext
    {
        public RobberTranslationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Translation> Translations { get; set; }
    }
}
