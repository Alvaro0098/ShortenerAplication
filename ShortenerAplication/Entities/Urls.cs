using SQLiteNetExtensions.Attributes;

namespace ShortenerAplication.Entities

{
    public class Urls
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UrlShort { get; set; }
        public string UrlLong { get; set; }
        public int Clicks { get; set; }
        public int CategoryId { get; set; }

        public int UserId { get; set; }
    }
}
