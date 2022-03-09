using System.ComponentModel.DataAnnotations;

namespace Notes.Dtos
{
    public record UpdateNoteDto
    {
        [Required]
        public string Name { get; init; }

        [Required]
        public string Text { get; init; }
    }
}