using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Not_Defteri
{
    public partial class App : Application
    {
        public static string FilePath;
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new ContentsPage());
        }
        public App(string filePath)
        {
            InitializeComponent();
            MainPage = new NavigationPage(new ContentsPage());
            FilePath = filePath;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
