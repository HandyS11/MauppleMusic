namespace Model
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Duration { get; set; }
        public bool IsFavorite { get; set; }
        public bool IsDownload { get; set; }

        public Song(int id, string name, double duration, bool isFavorite, bool isDownload)
        {
            Id = id;
            Name = name;
            Duration = duration;
            IsFavorite = isFavorite;
            IsDownload = isDownload;
        }

        public Song() { }
    }
}
