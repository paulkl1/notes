using Microsoft.AspNetCore.Mvc;
using Notes.Dtos;
using Notes.Entites;
using Notes.Repositories;

namespace Notes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotesController : ControllerBase 
    {
        private readonly INotesRepository repository;

        public NotesController(INotesRepository repository) 
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<NoteDto>> GetNotesAsync()
        {
            var notes = (await repository.GetNotesAsync())
                .Select(note => note.AsDto());
            
            return notes;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<NoteDto>> GetNoteAsync(Guid id)
        {
            var note = await repository.GetNoteAsync(id);

            if (note is null)
            {
                return NotFound();
            }

            return Ok(note.AsDto());
        }

        [HttpPost]
        public async Task<ActionResult<NoteDto>> CreateNoteAsync(CreateNoteDto noteDto)
        {
            Note note = new Note() 
            {
                Id = Guid.NewGuid(),
                Name = noteDto.Name,
                Text = noteDto.Text,
                CreatedDate = DateTimeOffset.UtcNow
            };

            await repository.CreateNoteAsync(note);

            return CreatedAtAction(nameof(GetNoteAsync), new { id = note.Id }, note.AsDto());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateNoteAsync(Guid id, UpdateNoteDto noteDto)
        {
            var existingNote = await repository.GetNoteAsync(id);

            if (existingNote is null)
            {
                return NotFound();
            }

            Note updatedNote = existingNote with 
            {
                Name = noteDto.Name,
                Text = noteDto.Text,
                LastUpdatedDate = DateTimeOffset.UtcNow
            };

            await repository.UpdateNoteAsync(updatedNote);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteNoteAsync(Guid id)
        {
            var existingNote = await repository.GetNoteAsync(id);

            if (existingNote is null)
            {
                return NotFound();
            }

            await repository.DeleteNoteAsync(id);

            return NoContent();
        }
    }
}