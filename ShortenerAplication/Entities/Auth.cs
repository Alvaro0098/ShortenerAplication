using SQLite;
using SQLiteNetExtensions.Attributes;

namespace ShortenerAplication.Entities
{
    public class Auth
    {
        [PrimaryKey]
        [ForeignKey(typeof(User))]
        public int Id { get; set; }
        public String Password { get; set; }
        public String Role { get; set; }
    }
}
