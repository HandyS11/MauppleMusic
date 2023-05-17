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
                    IsCopyright = true,
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
                    Name = "Know What I Mean? (Remastered)",
                    Author = "Cannonball Adderley & Bill Evans",
                    Theme = "Jazz",
                    Quality = "Lossless",
                    Date = new DateTime(1960, 12, 31),
                    IsCopyright = false,
                    CopyrightYear = "1961",
                    CopyrightName = "",
                    Songs = new List<Song>()
                    {
                        new Song(1, "Waltz for Debby", 2.30, true, false),
                        new Song(2, "Goodbye", 2.30, true, false),
                        new Song(3, "Who Cares? (Take 5)", 2.30, false, false),
                        new Song(4, "Who Cares? (Take 4)", 2.30, true, false),
                        new Song(5, "Venice", 2.30, false, false),
                        new Song(6, "Toy", 2.30, false, false),
                        new Song(7, "Elsa", 2.30, false, false),
                        new Song(8, "Nancy (With the Laughing...)", 2.30, false, false),
                        new Song(9, "Know What I Mean? (Take...)", 2.30, false, false),
                        new Song(10, "Know What I Mean? (Take...)", 2.30, false, false),
                    }
                },
                new Album()
                {
                    Cover = "cover3.png",
                    Name = "on the tender spot of every calloused moment",
                    Author = "Ambrose Akinmusire",
                    Theme = "Jazz",
                    Quality = "Lossless haute qualité",
                    Date = new DateTime(2020, 06, 11),
                    IsCopyright = true,
                    CopyrightYear = "2020",
                    CopyrightName = "Capitol Reccords, LLC",
                    Songs = new List<Song>()
                    {
                        new Song(1, "Tide of Hyacinth", 2.30, false, false),
                        new Song(2, "Some song", 2.30, false, false),
                        new Song(3, "Some song", 2.30, false, false),
                        new Song(4, "Mr. Roscoe (consider the ...)", 2.30, false, false),
                        new Song(5, "An Interlude (that get' mo...)", 2.30, false, false),
                        new Song(6, "reset (quiet victories&cele...)", 2.30, false, false),
                        new Song(7, "Moon (the return amplifie...)", 2.30, false, false),
                        new Song(8, "4623", 2.30, false, false),
                        new Song(9, "Roy", 2.30, true, false),
                        new Song(10, "Blues (We measure the he...)", 2.30, false, false),
                        new Song(11, "Hooded procession (read...)", 2.30, false, false),
                    }
                },
                new Album()
                {
                    Cover = "cover4.png",
                    Name = "Bitches Brew",
                    Author = "Miles Davis",
                    Theme = "Jazz",
                    Quality = "Lossless",
                    Date = new DateTime(1970, 03, 31),
                    IsCopyright = true,
                    CopyrightYear = "1970",
                    CopyrightName = "Sony Music Entertainment Inc.",
                    Songs = new List<Song>()
                    {
                        new Song(1, "Pharaoh's Dance (feat. Wayne...)", 2.30, true, false),
                        new Song(2, "Bitches Brew (feat. Wayne...)", 2.30, true, false),
                        new Song(3, "Spanish Key (feat. Wayne...)", 2.30, false, false),
                        new Song(4, "Jhon McLaughlin (feat. Wayne...)", 2.30, false, false),
                        new Song(5, "Miles Runs The Voodoo D...", 2.30, false, false),
                        new Song(6, "Sanctuary (feat. Wayne S...)", 2.30, false, false),
                        new Song(7, "Feio (feat. Wayne Shorter, ...)", 2.30, false, false),
                    }
                },
                new Album()
                {
                    Cover = "cover5.png",
                    Name = "Search for the New Land (The Rudy Van Gelder Edition Remastered)",
                    Author = "Lee Morgan",
                    Theme = "Hard Bop",
                    Quality = "Lossless",
                    Date = new DateTime(1964, 02, 14),
                    IsCopyright = true,
                    CopyrightYear = "2007",
                    CopyrightName = "The Blue Note Label Group",
                    Songs = new List<Song>()
                    {
                        new Song(1, "Search for the New Land", 2.30, false, false),
                        new Song(2, "The Joker", 2.30, false, false),
                        new Song(3, "Mr. Kenyatta", 2.30, true, false),
                        new Song(4, "Melancholee", 2.30, false, false),
                        new Song(5, "Morgan the Pirate", 2.30, false, false),
                    }
                },
                new Album()
                {
                    Cover = "cover6.png",
                    Name = "Chroniques bluesymentales",
                    Author = "Hubert-Félix Thiéfaine",
                    Theme = "French Pop",
                    Quality = "Lossless",
                    Date = new DateTime(1990, 10, 13),
                    IsCopyright = true,
                    CopyrightYear = "1990",
                    CopyrightName = "Sony Music Entertainment (France) S.A.",
                    Songs = new List<Song>()
                    {
                        new Song(1, "Deamin les kids", 2.30, true, false),
                        new Song(2, "Pogosur la deadline", 2.30, false, false),
                        new Song(3, "Auautomne à tanger (Ant...)", 2.30, false, false),
                        new Song(4, "Caméra terminues", 2.30, false, false),
                        new Song(5, "542 lunes et 7 jours environ", 2.30, true, false),
                        new Song(6, "Zoo zumains zébus", 2.30, false, false),
                        new Song(7, "Portrait de femme en 1992", 2.30, false, false),
                        new Song(8, "Misty Dog in Love", 2.30, false, false),
                        new Song(9, "Villes natales et frenchitude", 2.30, false, false),
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
