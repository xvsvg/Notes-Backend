using Microsoft.EntityFrameworkCore;
using Notes.Application.Interfaces;
using Notes.Domain;
using Notes.Persistence.EntityTypeConfigurations;

namespace Notes.Persistence;

public sealed class NotesDatabaseContext : DbContext, INotesDatabaseContext
{
    public NotesDatabaseContext(DbContextOptions<NotesDatabaseContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new NoteConfiguration());
        base.OnModelCreating(builder);
    }

    public DbSet<Note> Notes { get; set; }
}
