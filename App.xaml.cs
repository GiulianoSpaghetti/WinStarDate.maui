namespace WinStarDate.maui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

#if WINDOWS
        MainPage = new AppShellWindows();
#else
        MainPage = new AppShell();
#endif
    }
}
