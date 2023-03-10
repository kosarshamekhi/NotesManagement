using Microsoft.EntityFrameworkCore;
using NotesManagement.Model.Notes.Entities;
using NotesManagement.Model.Users.Entities;

namespace NotesManagement.DAL.DbContexts;

public class NoteDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Note> Notes { get; set; }


    public NoteDbContext(DbContextOptions<NoteDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);

        modelBuilder.Seed();
    }
}
