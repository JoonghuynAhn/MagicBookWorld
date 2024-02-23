using CommunityToolkit.Maui.Views;
using Plugin.Maui.Audio;

namespace MagicBookWorld;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        hockey.Source = "hockey0.png";
        scientist.Source = "femalescientist2.png";
        tomadventure.Source = "tomadventure2.png";

        //hockey.Source = "company.png";
        //scientist.Source = "company.png";
        //tomadventure.Source = "company.png";


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

