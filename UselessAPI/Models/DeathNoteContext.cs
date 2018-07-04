using Microsoft.EntityFrameworkCore;

namespace UselessAPI.Models
{
    public class DeathNoteContext : DbContext
    {
        public DeathNoteContext(DbContextOptions<DeathNoteContext> opt) : base(opt) { }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Person> Persons { get; set; }
    }
}