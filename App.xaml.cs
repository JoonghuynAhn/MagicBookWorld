using Plugin.Maui.Audio;

namespace MagicBookWorld;

public partial class App : Application
{
    readonly IAudioManager audioManager;

    public App()
	{
		InitializeComponent();
		
		MainPage = new NavigationPage(new MainPage(audioManager));
    }
}
