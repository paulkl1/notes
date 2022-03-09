using Notes.Entites;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Notes.Repositories
{
    public class MongoDbNotesRepository : INotesRepository
    {
        private const string databaseName = "Notes";
        
        private const string collectionName = "notes";

        private readonly IMongoCollection<Note> notesCollection;

        private readonly FilterDefinitionBuilder<Note> filterBuilder = Builders<Note>.Filter;
        
        public MongoDbNotesRepository(IMongoClient mongoClient)
        {
            IMongoDatabase database = mongoClient.GetDatabase(databaseName);
            notesCollection = database.GetCollection<Note>(collectionName);
        }

        public  async Task CreateNoteAsync(Note note)
        {
            await notesCollection.InsertOneAsync(note);
        }

        public async Task DeleteNoteAsync(Guid id)
        {
            var filter = filterBuilder.Eq(note => note.Id, id);
            await notesCollection.DeleteOneAsync(filter);
        }

        public async Task<Note> GetNoteAsync(Guid id)
        {
            var filter = filterBuilder.Eq(note => note.Id, id);
            return await notesCollection.Find(filter).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<Note>> GetNotesAsync()
        {
            return await notesCollection.Find(new BsonDocument()).ToListAsync();
        }

        public async Task UpdateNoteAsync(Note note)
        {
            var filter = filterBuilder.Eq(existingItem => existingItem .Id, note.Id);
            await notesCollection.ReplaceOneAsync(filter, note);
        }
    }
}