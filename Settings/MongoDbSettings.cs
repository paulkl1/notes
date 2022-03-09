namespace Notes.Settings
{
    public class MongoDbSettings
    {
        public string Host { get; set; }
        public int Port { get; set; }
        
        //TODO add db auth   
        public string User { get;set; }
        public string Password { get; set; }

        public string ConnectionString
        {
            get 
            {
                return $"mongodb://{Host}:{Port}";
            }
        }
    }
}