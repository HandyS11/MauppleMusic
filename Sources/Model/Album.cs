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
                return Convert.ToInt32(Songs.Select(s => s.Duration.Minutes).Sum());
            }
        }

        public Album(string cover, string name, string author, string theme, string quality, DateTime date, bool isCopyright, string copyrightYear, string copyrightName, List<Song> songs)
        {
            Cover = cover;
            Name = name;
            Author = author;
            Theme = theme;
            Quality = quality;
            Date = date;
            IsCopyright = isCopyright;
            CopyrightYear = copyrightYear;
            CopyrightName = copyrightName;
            Songs = songs;
        }

        public Album() { }
    }
}
