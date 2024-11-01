using MDM.Server.Models;

namespace MDM.Server.DataService
{
    public class DBHelper
    {
        public static List<Song> GetSongs(int? id = null)
        {
            return new List<Song>
            {
                new Song { SongId = 1, Name = "Bohemian Rhapsody", Artist = "Queen", Album = "A Night at the Opera" },
                new Song { SongId = 2, Name = "Imagine", Artist = "John Lennon", Album = "Imagine" },
                new Song { SongId = 3, Name = "Hotel California", Artist = "Eagles", Album = "Hotel California" },
                new Song { SongId = 4, Name = "Stairway to Heaven", Artist = "Led Zeppelin", Album = "Led Zeppelin IV" },
                new Song { SongId = 5, Name = "Billie Jean", Artist = "Michael Jackson", Album = "Thriller" },
                new Song { SongId = 6, Name = "Hey Jude", Artist = "The Beatles", Album = "Hey Jude" },
                new Song { SongId = 7, Name = "Like a Rolling Stone", Artist = "Bob Dylan", Album = "Highway 61 Revisited" },
                new Song { SongId = 8, Name = "Smells Like Teen Spirit", Artist = "Nirvana", Album = "Nevermind" },
                new Song { SongId = 9, Name = "What's Going On", Artist = "Marvin Gaye", Album = "What's Going On" },
                new Song { SongId = 10, Name = "Sweet Child o' Mine", Artist = "Guns N' Roses", Album = "Appetite for Destruction" }
            };
        }

        internal static void DeleteSong(int id)
        {
            //throw new NotImplementedException();
        }

        internal static Song? FindSongById(int id)
        {
            try
            {
                var song = GetSongs().Where(a => a.SongId == id).FirstOrDefault();
                return song;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
