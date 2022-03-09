using Notes.Dtos;
using Notes.Entites;

namespace Notes
{
    public static class Extensions
    {
        public static NoteDto AsDto(this Note note) => new NoteDto
            {
                Id = note.Id,
                Name = note.Name,
                Text = note.Text,
                CreatedDate = note.CreatedDate,
                LastUpdatedDate = note.LastUpdatedDate
            };
    }
}