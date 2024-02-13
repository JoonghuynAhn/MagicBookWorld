namespace MagicBookWorld;

public partial class NewPage : ContentPage
{
    private int currentImageIndex = 0;
    private List<string> imagePaths;
	public NewPage() // constructor
	{
		InitializeComponent();
        imagePaths = new List<string>
        {
            "dog.png",
            //"img2.png",
            //"img3.png",
            //"img4.png",
            //"img5.png",
            //"img6.png"
            // Add more image paths as needed
            //"/book1/img1.png",
            //"/book1/img2.png",
            //"/book1/img3.png",
            //"/book1/img4.png",
            //"/book1/img5.png",
            //"/book1/img6.png"
        };
        mainImg.Source = imagePaths[0];
    }

    private void ImgHomeBtn_Clicked(object sender, EventArgs e)
    {
		//Navigation.PopToRootAsync();
        Navigation.PushAsync(new MainPage());
    }

    private void ImgNextBtn_Clicked(object sender, EventArgs e)
    {
        currentImageIndex++;

        if(imagePaths.Count > 0 && currentImageIndex < imagePaths.Count)
        {
            mainImg.Source = imagePaths[currentImageIndex];
        }
    }

    private void ImgbackBtn_Clicked(object sender, EventArgs e)
    {
        currentImageIndex--;
        if(currentImageIndex >= 0)
        {
            if (imagePaths.Count > 0 && currentImageIndex < imagePaths.Count)
            {
                mainImg.Source = imagePaths[currentImageIndex];
            }
        }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}