using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Model
{
    public class Stub
    {
        public static List<Album> LoadAlbums()
        {
            return new List<Album>()
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
                        new Song(1, "Witch Hunt", new TimeSpan(0, 8, 11), true, false),
                        new Song(2, "Fee-Fi-Fo-Fum", new TimeSpan(0, 5, 54), false, false),
                        new Song(3, "Dance Cadaverous", new TimeSpan(0, 6, 45), false, false),
                        new Song(4, "Speak No Evil", new TimeSpan(0, 8, 23), false, false),
                        new Song(5, "Infant Eyes", new TimeSpan(0, 6, 54), false, false),
                        new Song(6, "Wild Flower", new TimeSpan(0, 6, 6), false, false),
                        new Song(7, "Dance Cadaverous (alternated)", new TimeSpan(0, 6, 35), false, false)
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
                        new Song(1, "Waltz for Debby", new TimeSpan(0, 5, 12), true, false),
                        new Song(2, "Goodbye", new TimeSpan(0, 6, 13), true, false),
                        new Song(3, "Who Cares? (Take 5)", new TimeSpan(0, 5, 55), false, false),
                        new Song(4, "Who Cares? (Take 4)", new TimeSpan(0, 5, 55), true, false),
                        new Song(5, "Venice", new TimeSpan(0, 2, 52), false, false),
                        new Song(6, "Toy", new TimeSpan(0, 5, 6), false, false),
                        new Song(7, "Elsa", new TimeSpan(0, 5, 50), false, false),
                        new Song(8, "Nancy (With the Laughing Face)", new TimeSpan(0, 4, 5), false, false),
                        new Song(9, "Know What I Mean? (Take 7)", new TimeSpan(0, 4, 53), false, false),
                        new Song(10, "Know What I Mean? (Take 12)", new TimeSpan(0, 7, 1), false, false)
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
                        new Song(1, "Tide of Hyacinth", new TimeSpan(0, 8, 19), false, false),
                        new Song(2, "Yessss", new TimeSpan(0, 5, 44), false, false),
                        new Song(3, "Cynical Sideliners", new TimeSpan(0, 2, 21), false, false),
                        new Song(4, "Mr. Roscoe (consider the simultaneous)", new TimeSpan(0, 5, 57), false, false),
                        new Song(5, "An Interlude (that get' more intense)", new TimeSpan(0, 6, 38), false, false),
                        new Song(6, "reset (quiet victories & celebrated defeats)", new TimeSpan(0, 3, 25), false, false),
                        new Song(7, "Moon (the return amplifies the unity)", new TimeSpan(0, 3, 44), false, false),
                        new Song(8, "4623", new TimeSpan(0, 0, 31), false, false),
                        new Song(9, "Roy", new TimeSpan(0, 2, 40), true, false),
                        new Song(10, "Blues (We measure the hearth with a fist)", new TimeSpan(0, 5, 29), false, false),
                        new Song(11, "Hooded procession (read the names outloud)", new TimeSpan(0, 3, 18), false, false),
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
                        new Song(1, "Pharaoh's Dance (feat. Wayne Shorter, ...)", new TimeSpan(0, 20, 06), true, false),
                        new Song(2, "Bitches Brew (feat. Wayne Shorter, ...)", new TimeSpan(0, 27, 0), true, false),
                        new Song(3, "Spanish Key (feat. Wayne Shorter, ...)", new TimeSpan(0, 17, 34), false, false),
                        new Song(4, "Jhon McLaughlin (feat. Wayne Shorter, ...)", new TimeSpan(0, 4, 26), false, false),
                        new Song(5, "Miles Runs The Voodoo Down", new TimeSpan(0, 14, 4), false, false),
                        new Song(6, "Sanctuary (feat. Wayne Shorter, ...)", new TimeSpan(0, 11, 1), false, false),
                        new Song(7, "Feio (feat. Wayne Shorter, ...)", new TimeSpan(0, 11, 51), false, false),
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
                        new Song(1, "Search for the New Land", new TimeSpan(0, 15, 47), false, false),
                        new Song(2, "The Joker", new TimeSpan(0, 5, 4), false, false),
                        new Song(3, "Mr. Kenyatta", new TimeSpan(0, 8, 45), true, false),
                        new Song(4, "Melancholee", new TimeSpan(0, 6 ,16), false, false),
                        new Song(5, "Morgan the Pirate", new TimeSpan(0, 6, 31), false, false),
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
                        new Song(1, "Demain les kids", new TimeSpan(0, 5 ,22), true, false),
                        new Song(2, "Pogosur la deadline", new TimeSpan(0, 4, 32), false, false),
                        new Song(3, "Auautomne à tanger (Antinoüs Nostalgia)", new TimeSpan(0, 4 ,45), false, false),
                        new Song(4, "Caméra terminues", new TimeSpan(0, 3, 37), false, false),
                        new Song(5, "542 lunes et 7 jours environ", new TimeSpan(0, 4, 46), true, false),
                        new Song(6, "Zoo zumains zébus", new TimeSpan(0, 3, 59), false, false),
                        new Song(7, "Portrait de femme en 1992", new TimeSpan(0, 6, 15), false, false),
                        new Song(8, "Misty Dog in Love", new TimeSpan(0, 4, 56), false, false),
                        new Song(9, "Villes natales et frenchitude", new TimeSpan(0, 7, 6), false, false),
                    }
                },
                new Album()
                {
                    Cover = "cover7.png",
                    Name = "Minutes to Midnight",
                    Author = "Linkin Park",
                    Theme = "Hard rock",
                    Quality = "Lossless",
                    Date = new DateTime(2007, 05, 14),
                    IsCopyright = true,
                    CopyrightYear = "1998",
                    CopyrightName = "Some big company",
                    Songs = new List<Song>()
                    {
                        new Song(1, "Wake", new TimeSpan(0, 1, 41), false, false),
                        new Song(2, "Given Up", new TimeSpan(0, 3, 9), true, false),
                        new Song(3, "Leave Out All the Rest", new TimeSpan(0, 3, 29), false, false),
                        new Song(4, "Bleed It Out", new TimeSpan(0, 2, 44), false, false),
                        new Song(5, "Shadow of the Day", new TimeSpan(0, 4, 50), false, false),
                        new Song(6, "What I\'ve Done", new TimeSpan(0, 3, 26), true, true),
                        new Song(7, "Hands Held High", new TimeSpan(0, 3, 53), false, false),
                        new Song(8, "No More Sorrow", new TimeSpan(0, 3, 42), false, false),
                        new Song(9, "Valentine\'s Day", new TimeSpan(0, 3, 17), false, false),
                        new Song(10, "In Between", new TimeSpan(0, 3, 17), false, false),
                        new Song(11, "In Pieces", new TimeSpan(0, 3, 38), false, false),
                        new Song(12, "The Little Things You Give you Away", new TimeSpan(0, 6, 24), false, false), 
                    }
                }
            };
        }
    }
}
