using Microsoft.EntityFrameworkCore;
using Notes.Domain;

namespace Notes.Application.Interfaces;

public interface INotesDatabaseContext
{
    DbSet<Note> Notes { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
