namespace MauppleMusic.Views;

public partial class SongListView : ContentView
{
	public string Date
	{
		get => "";
		set => dateLabel.Text = value;
	}

	public string Infos
	{
		get => "";
		set => songsInfoLabel.Text = value;
    }

	public string Copyright
	{
		get => "";
		set => copyrightLabel.Text = value;
    }

	public SongListView()
	{
		InitializeComponent();
	}
}