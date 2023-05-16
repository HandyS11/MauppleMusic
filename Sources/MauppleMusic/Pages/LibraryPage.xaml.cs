using Model;

namespace MauppleMusic.Pages;

public partial class LibraryPage : ContentPage
{
    public Library Library { get; set; } = new Library();

    public LibraryPage()
	{
		InitializeComponent();

		BindingContext = Library;
	}
}