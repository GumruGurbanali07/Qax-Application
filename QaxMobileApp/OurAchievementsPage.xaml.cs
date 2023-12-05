using QaxMobileApp.StudentImages;

namespace QaxMobileApp;

public partial class OurAchievementsPage : ContentPage
{
	public OurAchievementsPage()
	{
		InitializeComponent();

		List<StudentImage> images = new List<StudentImage>()
		{
            new StudentImage(){Url = "studentimage.jpeg"},
            new StudentImage(){Url = "campingimage.jpg"},
            new StudentImage(){Url = "slider2.jpg"},
            new StudentImage(){Url = "studentimage.jpeg"},
            new StudentImage(){Url = "slider4.jpg"},
            new StudentImage(){Url = "slider5.jpg"},
            new StudentImage(){Url = "slider6.jpg"},
            new StudentImage(){Url = "slider7.jpg"},
            new StudentImage(){Url = "slider8.jpg"},
            new StudentImage(){Url = "slider9.jpg"}

        };

		Carousel.ItemsSource = images;
	}
}