namespace Notes.Persistence;

public class DatabaseInitializer
{
    public static void Initialize(NotesDatabaseContext context)
    {
        context.Database.EnsureCreated();
    }
}
