using CommunityToolkit.Maui.Views;

namespace MagicBookWorld;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		//imgButton1.Source = ImageSource.FromFile("dog.png");
		//imgButton1.Source = "dog.png";
		hockey.Source = "hockey0.png";
		scientist.Source = "femalescientist2.png";
		tomadventure.Source = "tomadventure1.png";

        //PlaySound(correctMediaElement);


    }
    //internal static void PlaySound(MediaElement me)
    //{
    //    var preset = MauiProgram.CreateMauiApp;
    //    if (me.CurrentState != CommunityToolkit.Maui.Core.Primitives.MediaElementState.Stopped &&
    //        me.CurrentState != CommunityToolkit.Maui.Core.Primitives.MediaElementState.Paused)
    //    {
    //        me.Stop();
    //    }
    //    if (preset != null)
    //    {
    //        switch (preset.BuzzerVolume)
    //        {
    //            case Volume.Off:
    //                me.Volume = 0.0;
    //                break;
    //            case Volume.Low:
    //                me.Volume = 0.2;
    //                break;
    //            case Volume.Medium:
    //                me.Volume = 0.7;
    //                break;
    //            case Volume.High:
    //                me.Volume = 1.0;
    //                break;
    //            default:
    //                break;
    //        }
    //    }

    //    if (me.Position != TimeSpan.Zero)
    //    {
    //        //Will Play sound here
    //        me.SeekTo(TimeSpan.Zero);
    //    }
    //    else if (me.CurrentState != CommunityToolkit.Maui.Core.Primitives.MediaElementState.Playing)
    //    {
    //        me.Play();
    //    }
    //}
    //private void OnCounterClicked(object sender, EventArgs e)
    //{
    //	count++;

    //	if (count == 1)
    //		CounterBtn.Text = $"Clicked {count} time";
    //	else
    //		CounterBtn.Text = $"Clicked {count} times";

    //	SemanticScreenReader.Announce(CounterBtn.Text);
    //}

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

