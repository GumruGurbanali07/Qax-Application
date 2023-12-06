using QaxMobileApp.Repository.Abstract;

namespace QaxMobileApp;

public partial class TeacherLogin : ContentPage
{
    private readonly ILoginService _loginService;

    public TeacherLogin(ILoginService loginService)
    {
        InitializeComponent();
        _loginService = loginService;
    }

    private async void Login_TeacherPageClicked(object sender, EventArgs e)
    {
        string username = UserName.Text;
        string password = Password.Text;
       
       
            var user = await _loginService.Login(username, password);

            if (user != null)
            {
                // Successful login, navigate to the next page
                await Navigation.PushAsync(new TeacherPage());
            }
            else
            {
                ErrorLabel.Text = "İstifadəçi adı və ya şifrə yalnışdır.Yenidən yoxlayın";
            }
        }
   


}