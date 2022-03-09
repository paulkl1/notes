namespace Notes.Dtos
{
    public record NoteDto
    {
        public Guid Id { get; init; }

        public string Name { get; init; }

        public string Text { get; init; }

        public DateTimeOffset CreatedDate { get; init; }

        public DateTimeOffset LastUpdatedDate { get; init; }
    }
}