using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Notes.Domain;

namespace Notes.Persistence.EntityTypeConfigurations;

public class NoteConfiguration : IEntityTypeConfiguration<Note>
{
    public const int MaxNoteNameLength = 250;

    public void Configure(EntityTypeBuilder<Note> builder)
    {
        builder.HasKey(note => note.NoteId);
        builder.HasIndex(note => note.NoteId).IsUnique();
        builder.Property(note => note.NoteName).HasMaxLength(MaxNoteNameLength);
    }
}
