//using QaxMobileApp.Repository.Abstract;

namespace QaxMobileApp;

public partial class ParentLogin : ContentPage
{
	//private readonly IParentLoginService _parentLoginService;
	public ParentLogin(/*IParentLoginService parentLoginService*/)
	{
		InitializeComponent();
		//_parentLoginService = parentLoginService;
	}

	private async void Login_ParentPageClicked(object sender, EventArgs e)
	{
        string username = Name.Text;
        string password = Password.Text;
        //var user = await _parentLoginService.Login(username, password);

        //if (user != null)
        //{
        //    // Successful login, navigate to the next page
        //    await Navigation.PushAsync(new ParentPage());
        //}
        //else
        //{
        //    ErrorLabel.Text = "İstifadəçi adı və ya şifrə yalnışdır.Yenidən yoxlayın";
        //}
    }
}