using System.Security.Cryptography.X509Certificates;

namespace QaxMobileApp;

public partial class TeacherPage : ContentPage
{
	public TeacherPage()
	{
		InitializeComponent();

		
	}

    private void Abituriyent_Page(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AbituriyentPage());
    }
}