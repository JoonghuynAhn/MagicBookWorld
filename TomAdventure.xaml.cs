namespace MagicBookWorld;

public partial class TomAdventure : ContentPage
{
    private int currentImageIndex = 0;
    private List<string> imagePaths;
    private List<string> dialogs;

    public TomAdventure()
	{
        InitializeComponent();
        imagePaths = new List<string>
        {
            "tomadventure1.png",
            "tomadventure2.png",
            "tomadventure3.png",
            "tomadventure4.png",
            "tomadventure5.png",
            "tomadventure6.png"
        };
        mainImg.Source = imagePaths[0];

        dialogs = new List<string>
        {
            "In the small village, there lived a curious boy named Tom." +
            "While cleaning his room one day, Tom discovered an old book tucked away on the shelf.",
            "Tom stumbled upon a map inside the book that revealed the location of a hidden cave near the village.",
            "Fueled by curiosity, Tom sprinted toward the caves' enterance.",
            "Inside the cave, Tom found shimmering treasures, small, sparkling jewels, filling the caves' cracks. Tom was left in awe at the site.",
            "Emerging from the cave with the treasure in hand, Tom made his way toward the sunlight." +
            "His face beaming with excitement over the discovery.",
            "As Tom gazes at the map, he dreams of his next adventure. What will his next expedition hold?"
        };
        dialog.Text = dialogs[0];
    }


    private async void ImgHomeBtn_Clicked(object sender, EventArgs e)
    {
        //var current = Application.Current.MainPage;
        //var parent = Application.Current.Parent;
        //await Navigation.PopToRootAsync();
        //await Navigation.PopAsync();
        await Navigation.PushAsync(new MainPage());
    }


    async void ImgNextBtn_Clicked(object sender, EventArgs e)
    {
        currentImageIndex++;
        if (currentImageIndex >= 0)
        {
            if (imagePaths.Count > 0 && currentImageIndex < imagePaths.Count)
            {
                await Task.WhenAny(mainImg.FadeTo(0, 100));

                mainImg.Source = imagePaths[currentImageIndex];
                dialog.Text = dialogs[currentImageIndex];

                await Task.WhenAny(mainImg.FadeTo(1, 100));
            }
        }
    }



    async void ImgbackBtn_Clicked(object sender, EventArgs e)
    {
        currentImageIndex--;
        if (currentImageIndex >= 0)
        {
            if (imagePaths.Count > 0 && currentImageIndex < imagePaths.Count)
            {
                await Task.WhenAny(mainImg.FadeTo(0, 100));

                mainImg.Source = imagePaths[currentImageIndex];
                dialog.Text = dialogs[currentImageIndex];

                await Task.WhenAny(mainImg.FadeTo(1, 100));
            }
        }
    }

    private async void TapHome_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PopAsync();

    }

}