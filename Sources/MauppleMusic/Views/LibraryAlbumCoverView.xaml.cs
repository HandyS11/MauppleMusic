using MauppleMusic.Pages;
using Model;

namespace MauppleMusic.Views;

public partial class LibraryAlbumCoverView : ContentView
{
	public LibraryAlbumCoverView()
	{
		InitializeComponent();
	}

    private async void GoToAlbum(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new AlbumPage(BindingContext as Album));
    }
}