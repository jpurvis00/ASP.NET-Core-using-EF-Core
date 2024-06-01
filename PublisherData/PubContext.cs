using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PublisherDomain;

namespace PublisherData
{
    public class PubContext : DbContext
    {
        /* Authors/Books were used to create the table names in the db.
         * Should have switched them.  DbSet<Authors> Author
         */
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Cover> Covers { get; set; }

        public PubContext(DbContextOptions<PubContext> options) : base(options)
        {
        }

    }
}
