using System.ComponentModel.DataAnnotations;

namespace Notes.Dtos
{
    public record CreateNoteDto
    {
        [Required]
        public string Name { get; init; }

        public string Text { get; init; }
    }
}