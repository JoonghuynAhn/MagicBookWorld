using Plugin.Maui.Audio;

namespace MagicBookWorld;

public partial class MainPage : ContentPage
{
    private readonly IAudioManager audioManager;

    public MainPage(IAudioManager audioManager)
	{
        InitializeComponent();

        this.audioManager = audioManager;


        hockey.Source = "hockey0.png";
        scientist.Source = "femalescientist2.png";
        tomadventure.Source = "tomadventure2.png";

        BackgroundMusicPlayer();

    }
    public async void PlayAudio()
    {
        //var player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("WakeUp.wav"));
        var player = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("sample.mp3"));
        player.Play();
    }


    public async void BackgroundMusicPlayer()
    {
        var player = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("sample.mp3"));
        player.Play();
    }

    async void Hockey_Clicked(object sender, EventArgs e)
    {
        PlayAudio();

        await Task.WhenAny(scientist.FadeTo(0, 50));
        await Task.WhenAny(tomadventure.FadeTo(0, 50));

        //double screenWidth = DeviceDisplay.MainDisplayInfo.Width;
        //double screenHeight = DeviceDisplay.MainDisplayInfo.Height;

        //await Task.WhenAny(hockey.TranslateTo(screenWidth/2, screenHeight/2, 500));

        await Navigation.PushAsync(new Hockey());
        await Task.WhenAny(scientist.FadeTo(1, 100));
        await Task.WhenAny(tomadventure.FadeTo(1, 100));
    }

    async void Scientist_Clicked(object sender, EventArgs e)
    {
        BackgroundMusicPlayer();
        await Task.WhenAny(hockey.FadeTo(0, 100));
        await Task.WhenAny(tomadventure.FadeTo(0, 100));

        await Navigation.PushAsync(new FemaleScientist());
        await Task.WhenAny(hockey.FadeTo(1, 100));
        await Task.WhenAny(tomadventure.FadeTo(1, 100));
    }

    async void Tomadventure_Clicked(object sender, EventArgs e)
    {
        await Task.WhenAny(hockey.FadeTo(0, 100));
        await Task.WhenAny(tomadventure.FadeTo(0, 100));

        await Navigation.PushAsync(new TomAdventure());

        await Task.WhenAny(hockey.FadeTo(1, 100));
        await Task.WhenAny(tomadventure.FadeTo(1, 100));
    }
}

