namespace MDM.Server.Models
{
    public class Song
    {
        //Primary key
        public int SongId { get; set; }
        public string Name { get; set; }
        public string Artist { get; set;}
        public string Album { get; set; }

        public string AddedBy { get; set; }
        public string AddedDate { get; set; }
    }
}
