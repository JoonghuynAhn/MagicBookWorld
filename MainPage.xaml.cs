using CommunityToolkit.Maui.Views;

namespace MagicBookWorld;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
        mediaElement.Source = null;
        //imgButton1.Source = ImageSource.FromFile("dog.png");
        //imgButton1.Source = "dog.png";
        hockey.Source = "hockey0.png";
		scientist.Source = "femalescientist2.png";
		tomadventure.Source = "tomadventure2.png";

        if (DeviceInfo.Platform == DevicePlatform.Android)
        {
            mediaElement.Source = MediaSource.FromUri("https://www.youtube.com/watch?v=G9H2aliqkq8");
        }
        else if (DeviceInfo.Platform == DevicePlatform.WinUI)
        {
            //mediaElement.Source = MediaSource.FromUri("https://www.youtube.com/watch?v=G9H2aliqkq8");
            mediaElement.Source = MediaSource.FromFile("LittleSamba.mp3");

        }
        //mediaElement.Source = MediaSource.FromResource("LittleSamba.mp3");

    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        // Navigate to a new page
        Navigation.PushAsync(new NavigationPage(new NewPage()));
    }

    private void hockey_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NavigationPage(new Hockey()));
    }

    private void scientist_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NavigationPage(new FemaleScientist()));

    }

    private void tomadventure_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new NavigationPage(new TomAdventure()));
    }
}

