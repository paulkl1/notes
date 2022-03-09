using Notes.Entites;

namespace Notes.Repositories
{
    public interface INotesRepository
    {
        Task<Note> GetNoteAsync(Guid id);

        Task<IEnumerable<Note>> GetNotesAsync();

        Task CreateNoteAsync(Note note);

        Task UpdateNoteAsync(Note note);

        Task DeleteNoteAsync(Guid id);
    }
}