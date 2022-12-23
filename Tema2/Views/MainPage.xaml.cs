namespace Tema2.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void NextPage(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(MusicPage));
    }
}

