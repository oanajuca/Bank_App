using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;
using Bank_App.Data;
using System.IO;

namespace Bank_App
{
    public partial class App : Application
    {
        static BankDatabase database;
        public static BankDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new
                   BankDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                   LocalApplicationData), "Bank.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage =  new NavigationPage(new CardEntryPage());
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
