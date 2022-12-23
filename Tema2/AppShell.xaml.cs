using Tema2.Views;

namespace Tema2;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(MusicPage), typeof(MusicPage));
	}
}
