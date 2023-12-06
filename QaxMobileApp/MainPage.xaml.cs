using QaxMobileApp.Repository.Abstract;
using QaxMobileApp.Repository.Concrete;

namespace QaxMobileApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
          
        }

        public void Teacher_Login(object sender, EventArgs e)
        {
            ILoginService loginService = new LoginService(); 

            Navigation.PushAsync(new TeacherLogin(loginService));
        }

        public void Parent_Login(object sender, EventArgs e)
        {
            IParentLoginService parentLoginService = new ParentLoginService();
            Navigation.PushAsync(new ParentLogin(parentLoginService));
        }

        private void Success_PageClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OurSuccessesPage());
        }

        private void Achievements_PageClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OurAchievementsPage());
        }

        private void Services_PageClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ServicesPage());
        }

        private void Contact_PageClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContactPage());
        }
    }
}