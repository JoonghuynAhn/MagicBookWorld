using MagicBookWorld.Services;
using Microsoft.Maui.Controls;
using Plugin.Maui.Audio;
using System.Diagnostics;

namespace MagicBookWorld;

public partial class App : Application
{
    readonly IAudioManager audioManager;

    public App()
	{
		InitializeComponent();
		
		MainPage = new NavigationPage(new MainPage());

        App.Current.PageAppearing += Current_PageAppearing;
        App.Current.PageDisappearing += Current_PageDisappearing;
    }


    private void Current_ChildRemoved(object sender, ElementEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void Current_PageDisappearing(object sender, Page e)
    {
        MusicPlayerService.Dispose();

        Debug.WriteLine($"Current_PageDisappearing {e}");
    }

    private void Current_PageAppearing(object sender, Page e)
    {
        Debug.WriteLine($"Current_PageAppearing {e}");
    }
}
