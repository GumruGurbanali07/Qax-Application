namespace QaxMobileApp;

public partial class ParentLogin : ContentPage
{
	public ParentLogin()
	{
		InitializeComponent();
	}

	public void Login_ParentPageClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new ParentPage());
	}
}