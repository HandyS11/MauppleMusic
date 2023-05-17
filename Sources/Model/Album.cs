namespace Model
{
    public class Album
    {
        public string Cover { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Theme { get; set; }
        public string Quality { get; set; }
        public DateTime Date { get; set; }
        public bool IsCopyright { get; set; }
        public string CopyrightYear { get; set; }
        public string CopyrightName { get; set; }

        public List<Song> Songs { get; set; }

        public int SongNumber
        {
            get
            {
                if (Songs == null)
                    return 0;
                return Songs.Count;
            }
        }

        public int SongDuration
        {
            get
            {
                if (Songs == null)
                    return 0;
                double duration = 0;
                foreach (Song song in Songs)
                {
                    duration += song.Duration;
                }
                return Convert.ToInt32(duration);
            }
        }

        public Album(string cover, string name, string author, string theme, string quality, DateTime date, string copyrightYear, string copyrightName, List<Song> songs)
        {
            Cover = cover;
            Name = name;
            Author = author;
            Theme = theme;
            Quality = quality;
            Date = date;
            CopyrightYear = copyrightYear;
            CopyrightName = copyrightName;
            Songs = songs;
        }

        public Album() { }
    }
}
