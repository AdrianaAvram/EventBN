using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EventBN
{
    public partial class App : Application
    {
        static DbService dbUtils;
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static DbService DBUtil
        {
            get
            {
                if (dbUtils == null)
                {
                    dbUtils = new DbService();
                }
                return dbUtils;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
