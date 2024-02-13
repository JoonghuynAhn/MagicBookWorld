namespace MagicBookWorld;

public partial class Hockey : ContentPage
{
    private int currentImageIndex = 0;
    private List<string> imagePaths;
    private List<string> dialogs;
    public Hockey() // constructor
    {
        InitializeComponent();
        imagePaths = new List<string>
        {
            "skate1.png",
            "skate2.png",
            "skate3.png",
            "skate4.png",
            "skate5.png",
            "skate6.png",
            "skate7.png",
            "skate8.png"
        };

        dialogs = new List<string>
        {
            "Christopher received a special surprise, a pair of shiny new skates." +
            "Excitement filled him as he couldn't wait to try them on.",
            "Stepping on to the ice, Christopher trying to find his balance." +
            "The slippery ice made him a bit wobbly.",
            "With a little push, Christopher moved forward, taking his first cautious glides." +
            "He felt a mix of nervousness and thrill.",
            "Christopher attempted to balance on one foot, arms out wide." +
            "He focused hard, trying to glide smoothly while maintaining his balance.",
            "As Christopher's confidence grew, he skated a bit faster." +
            "Feeling the chilly breeze on his face, a smile beamed across his face.",
            "Practing, shifting his weight, Christopher managed to execute a smooth turn on the ice." +
            "Feeling accomplished.",
            "Feeling adventurous, Christopher tried small jumps with a little hop. He landed back on the ice," +
            "laughing with excitement.",
            "With new found confidence, Christopher skated across the rink, relishing every moment." +
            "He felt immensely proud of his progress on the ice."
        };
        mainImg.Source = imagePaths[0];
        dialog.Text = dialogs[0];
    }

    private void ImgHomeBtn_Clicked(object sender, EventArgs e)
    {
        //Navigation.PopToRootAsync();
        Navigation.PushAsync(new MainPage());
    }

    private void ImgNextBtn_Clicked(object sender, EventArgs e)
    {
        currentImageIndex++;

        if (imagePaths.Count > 0 && currentImageIndex < imagePaths.Count)
        {
            mainImg.Source = imagePaths[currentImageIndex];
            dialog.Text = dialogs[currentImageIndex];

        }
    }

    private void ImgbackBtn_Clicked(object sender, EventArgs e)
    {
        currentImageIndex--;
        if (currentImageIndex >= 0)
        {
            if (imagePaths.Count > 0 && currentImageIndex < imagePaths.Count)
            {
                mainImg.Source = imagePaths[currentImageIndex];
                dialog.Text = dialogs[currentImageIndex];

            }
        }
    }
}