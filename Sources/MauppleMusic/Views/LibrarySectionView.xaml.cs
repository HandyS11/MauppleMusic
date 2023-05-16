namespace MauppleMusic.Views;

public partial class LibrarySectionView : ContentView
{
	public string IconImage
	{
		get => "";
		set => iconImage.Source = value;
	}

	public string Name
	{
		get => "";
		set => sectionLabel.Text = value;
	}

	public LibrarySectionView()
	{
		InitializeComponent();
	}
}