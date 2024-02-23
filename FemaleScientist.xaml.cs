namespace MagicBookWorld;

public partial class FemaleScientist : ContentPage
{
    private int currentImageIndex = 0;
    private List<string> imagePaths;
    private List<string> dialogs;
    public FemaleScientist()
	{
        InitializeComponent();
        imagePaths = new List<string>
        {
            "FemaleScientist1.png",
            "FemaleScientist2.png",
            "FemaleScientist3.png",
            "FemaleScientist4.png",
            "FemaleScientist5.png",
            "FemaleScientist6.png",
            "FemaleScientist7.png"
        };

        dialogs = new List<string>
        {
            "Visualize a Renaissance era library in Italy.",
            "Within it, a woman disguised as a man was conducting scientific research." +
            "This woman was Sophia Cavaletier.",
            "Portraits of female scientists from the Renaissance still captivate many to this day.",
            "She exhibited exceptional skill in observing celestial bodies." +
            "The woman with a telescope symbolizes her remarkable observational abilities.",
            "Sophia conducted remarkable research in medicine as well." +
            "Depicted is her study and medicinal use of plants.",
            "Sophia's influence resonates even today. Here you see modern female scientists embodying her courage and passion.",
            "Sophia Cavaletier stands among the women who transcended scientific barriers during the Renaissance." +
            "Her achievement will be remembered forever."
        };
        mainImg.Source = imagePaths[0];
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