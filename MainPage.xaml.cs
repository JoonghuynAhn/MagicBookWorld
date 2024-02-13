using Plugin.Maui.Audio;

namespace MagicBookWorld;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		//imgButton1.Source = ImageSource.FromFile("dog.png");
		imgButton1.Source = "dog.png";
		hockey.Source = "hockey0.png";
		scientist.Source = "femalescientist1.png";
		tomadventure.Source = "tomadventure1.png";



    }

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

