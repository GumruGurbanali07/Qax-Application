// using statements...

namespace QaxMobileApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Teacher_Login(object sender, EventArgs e)
        {
            // Your logic for Teacher_Login
        }

        private void Parent_Login(object sender, EventArgs e)
        {
            // Your logic for Parent_Login
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
