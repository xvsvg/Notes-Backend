namespace Notes.Domain;

public class Note
{
    public Guid UserId { get; private set; }
    public Guid NoteId { get; private set; }
    public string NoteName { get; private set; }
    public string Details { get; private set; }
    public DateTime CreationDate { get; private set; }
    public DateTime? EditionDate { get; private set; }

}
