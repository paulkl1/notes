namespace Notes.Entites
{
    public record Note
    {
        public Guid Id { get; init; }

        public string Name { get; init; }

        public string Text { get; init; }

        public DateTimeOffset CreatedDate { get; init; }

        public DateTimeOffset LastUpdatedDate { get; init; }
    }
}