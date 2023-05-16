namespace MauppleMusic.Views;

public partial class AlbumFakeButtonView : ContentView
{
	private string _title;
	public string Text
	{
		get => _title;
        set
		{
			_title = value;
            buttonLabel.Text = Text;
        }
	}

	private string _image;
	public string Image
	{
		get => _image;
		set
		{
			_image = value;
            buttonImage.Source = Image;
        }
	}

	public AlbumFakeButtonView()
	{
		InitializeComponent();
    }
}