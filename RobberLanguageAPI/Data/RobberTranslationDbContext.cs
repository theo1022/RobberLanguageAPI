using Microsoft.EntityFrameworkCore;

namespace RobberLanguageAPI.Data
{
    public class RobberTranslationDbContext : DbContext
    {
        public RobberTranslationDbContext(DbContextOptions options) : base(options) { }
    }
}
