namespace MauppleMusic.Views;

public partial class AlbumDetailView : ContentView
{
	public string Image
	{
		get => "";
		set => imageAvatarView.Text = value;
    }

	public string Title
	{
		get => "";
		set => titleLabel.Text = value;
    }

	public string Author
	{
		get => "";
		set => authorLabel.Text = value;
	}

	public string Theme
	{
		get => "";
		set => themeLabel.Text = value;
	}

	public string Year
	{
		get => "";
		set => yearLabel.Text = value;
	}

	public string Quality
	{
		get => "";
		set=> qualityLabel.Text = value;
	}

	public AlbumDetailView()
	{
		InitializeComponent();
	}
}