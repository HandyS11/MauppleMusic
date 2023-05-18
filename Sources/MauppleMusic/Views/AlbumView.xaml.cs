using System.Diagnostics;

namespace MauppleMusic.Views;

public partial class AlbumView : ContentView
{
    private const int MaxY = 350;

    public AlbumView()
	{
		InitializeComponent();
	}

    private bool isShown = false;
    private bool isRunning = false;
    private void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
    {
        if (isRunning)
        {
            return;
        }
        isRunning = true;

        try
        {
            Debug.WriteLine(e.ScrollY);

            if (e.ScrollY < MaxY)
            {
                if (isShown)
                {
                    ShowOrNot(sender, false);
                    isShown = false;
                }
            }
            else if (e.ScrollY >= MaxY)
            {
                if (!isShown)
                {
                    ShowOrNot(sender, true);
                    isShown = true;
                }
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine("I knew I shouldn't to code this shit..");
            Debug.WriteLine(ex.Message);
        }
        finally
        {
            isRunning = false;
        }
    }

    private void ShowOrNot(object obj, bool show)
    {
        VerticalStackLayout stackLayout = (((obj as ScrollView).Parent as Grid).Children.First() as ContentView).Children.First() as VerticalStackLayout;
        ((stackLayout.Children.First() as Grid).Children[1] as Label).IsVisible = show;
        (stackLayout.Children.Last() as SeparatorBoxView).IsVisible = show;
    }
}