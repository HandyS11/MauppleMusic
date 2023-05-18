namespace Model
{
    public class Library
    {
        public List<Album> Albums { get; set; }

        public Library()
        {
            Albums = Stub.LoadAlbums();
        }
    }
}
