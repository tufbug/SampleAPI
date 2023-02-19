using Microsoft.EntityFrameworkCore;
using Puffin.DataAccess.Entities;

namespace Puffin.DataAccess.Data
{
	public class PuffinDbContext : DbContext
	{
		public PuffinDbContext(DbContextOptions<PuffinDbContext> options)
			: base(options) { }

        public DbSet<Feather> Feathers => Set<Feather>();
    }
}
