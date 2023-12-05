namespace QaxMobileApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navpage = new NavigationPage( new MainPage());

            navpage.BarBackgroundColor = Color.FromHex("#407c87");
            navpage.BarTextColor = Colors.White;
            

            MainPage = navpage;
        }
    }
}