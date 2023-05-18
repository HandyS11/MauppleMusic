namespace MauppleMusic.Views;

public partial class AlbumFakeNavigationBarView : ContentView
{
	public AlbumFakeNavigationBarView()
	{
		InitializeComponent();
	}

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}