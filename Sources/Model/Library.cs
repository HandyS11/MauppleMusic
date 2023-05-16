namespace Model
{
    public class Library
    {
        public List<Album> Albums { get; set; }

        public Library()
        {
            Albums = new List<Album>()
            {
                new Album()
                {
                    Cover = "cover1.png",
                    Name = "Speak No Evil (Rudy Van Gelder Edition)",
                    Author = "Wayne Shorter",
                    Theme = "Jazz",
                    Quality = "Lossless",
                    Date = new DateTime(1959, 01, 31),
                    CopyrightYear = "1999",
                    CopyrightName = "Blue Note Records",
                    Songs = new List<Song>()
                    {
                        new Song(1, "Witch Hunt", 2.30, true, false),
                        new Song(2, "Fee-Fi-Fo-Fum", 2.30, false, false),
                        new Song(3, "Dance Cadaverous", 2.30, false, false),
                        new Song(4, "Speak No Evil", 2.30, false, false),
                        new Song(5, "Infant Eyes", 2.30, false, false),
                        new Song(6, "Wild Flower", 2.30, false, false),
                        new Song(7, "Dance Cadaverous (alternated)", 2.30, false, false),
                    }
                },
                new Album()
                {
                    Cover = "cover2.png",
                    Name = "",
                    Author = "",
                    Theme = "",
                    Quality = "",
                    Date = new DateTime(2000, 01, 01),
                    CopyrightYear = "",
                    CopyrightName = "",
                    Songs = new List<Song>()
                    {
                        new Song(1, "A", 2.30, true, false),
                        new Song(2, "B", 2.30, false, false),
                        new Song(3, "C", 2.30, false, false),
                        new Song(4, "D", 2.30, false, false),
                        new Song(5, "E", 2.30, false, false),
                        new Song(6, "F", 2.30, false, false),
                        new Song(7, "G", 2.30, false, false),
                    }
                },
                new Album()
                {
                    Cover = "cover3.png",
                    Name = "",
                    Author = "",
                    Theme = "",
                    Quality = "",
                    Date = new DateTime(2000, 01, 01),
                    CopyrightYear = "",
                    CopyrightName = "",
                    Songs = new List<Song>()
                    {
                        new Song(1, "A", 2.30, true, false),
                        new Song(2, "B", 2.30, false, false),
                        new Song(3, "C", 2.30, false, false),
                        new Song(4, "D", 2.30, false, false),
                        new Song(5, "E", 2.30, false, false),
                        new Song(6, "F", 2.30, false, false),
                        new Song(7, "G", 2.30, false, false),
                    }
                },
                new Album()
                {
                    Cover = "cover4.png",
                    Name = "",
                    Author = "",
                    Theme = "",
                    Quality = "",
                    Date = new DateTime(2000, 01, 01),
                    CopyrightYear = "",
                    CopyrightName = "",
                    Songs = new List<Song>()
                    {
                        new Song(1, "A", 2.30, true, false),
                        new Song(2, "B", 2.30, false, false),
                        new Song(3, "C", 2.30, false, false),
                        new Song(4, "D", 2.30, false, false),
                        new Song(5, "E", 2.30, false, false),
                        new Song(6, "F", 2.30, false, false),
                        new Song(7, "G", 2.30, false, false),
                    }
                },
                new Album()
                {
                    Cover = "cover5.png",
                    Name = "",
                    Author = "",
                    Theme = "",
                    Quality = "",
                    Date = new DateTime(2000, 01, 01),
                    CopyrightYear = "",
                    CopyrightName = "",
                    Songs = new List<Song>()
                    {
                        new Song(1, "A", 2.30, true, false),
                        new Song(2, "B", 2.30, false, false),
                        new Song(3, "C", 2.30, false, false),
                        new Song(4, "D", 2.30, false, false),
                        new Song(5, "E", 2.30, false, false),
                        new Song(6, "F", 2.30, false, false),
                        new Song(7, "G", 2.30, false, false),
                    }
                },
                new Album()
                {
                    Cover = "cover6.png",
                    Name = "",
                    Author = "",
                    Theme = "",
                    Quality = "",
                    Date = new DateTime(2000, 01, 01),
                    CopyrightYear = "",
                    CopyrightName = "",
                    Songs = new List<Song>()
                    {
                        new Song(1, "A", 2.30, true, false),
                        new Song(2, "B", 2.30, false, false),
                        new Song(3, "C", 2.30, false, false),
                        new Song(4, "D", 2.30, false, false),
                        new Song(5, "E", 2.30, false, false),
                        new Song(6, "F", 2.30, false, false),
                        new Song(7, "G", 2.30, false, false),
                    }
                },
                new Album()
                {
                    Cover = "cover7.png",
                    Name = "",
                    Author = "",
                    Theme = "",
                    Quality = "",
                    Date = new DateTime(2000, 01, 01),
                    CopyrightYear = "",
                    CopyrightName = "",
                    Songs = new List<Song>()
                    {
                        new Song(1, "A", 2.30, true, false),
                        new Song(2, "B", 2.30, false, false),
                        new Song(3, "C", 2.30, false, false),
                        new Song(4, "D", 2.30, false, false),
                        new Song(5, "E", 2.30, false, false),
                        new Song(6, "F", 2.30, false, false),
                        new Song(7, "G", 2.30, false, false),
                    }
                },
                new Album()
                {
                    Cover = "cover8.png",
                    Name = "",
                    Author = "",
                    Theme = "",
                    Quality = "",
                    Date = new DateTime(2000, 01, 01),
                    CopyrightYear = "",
                    CopyrightName = "",
                    Songs = new List<Song>()
                    {
                        new Song(1, "A", 2.30, true, false),
                        new Song(2, "B", 2.30, false, false),
                        new Song(3, "C", 2.30, false, false),
                        new Song(4, "D", 2.30, false, false),
                        new Song(5, "E", 2.30, false, false),
                        new Song(6, "F", 2.30, false, false),
                        new Song(7, "G", 2.30, false, false),
                    }
                }
            };
        }
    }
}
