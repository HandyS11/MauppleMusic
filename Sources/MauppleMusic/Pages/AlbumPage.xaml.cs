using Model;

namespace MauppleMusic.Pages;

public partial class AlbumPage : ContentPage
{
	public Album Album { get; set; }

	public AlbumPage(Album album)
	{
		InitializeComponent();

		Album = album;
		BindingContext = Album;
	}
}