namespace Model
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }
        public bool IsFavorite { get; set; }
        public bool IsDownload { get; set; }

        public Song(int id, string name, TimeSpan duration, bool isFavorite, bool isDownload)
        {
            Id = id;
            Name = name;
            Duration = duration;
            IsFavorite = isFavorite;
            IsDownload = isDownload;
        }
    }
}
