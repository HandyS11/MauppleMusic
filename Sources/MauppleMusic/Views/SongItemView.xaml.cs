namespace MauppleMusic.Views;

public partial class SongItemView : ContentView
{
	public int Number
	{
		get => -1;
		set => numberLabel.Text = value.ToString();
	}

	public string Title
	{
		get => "";
		set => songNameLabel.Text = value;
    }

	public SongItemView()
	{
		InitializeComponent();
	}
}