using SAwatch.Data;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SAwatch
{
    public partial class App : Application
    {
        static FilmsDB filmsDB;
        static SerialsDB serialsDB;
        public static FilmsDB FilmsDB
        {
            get
            {
                if (filmsDB == null)
                {
                    filmsDB = new FilmsDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "FilmsDatabase.db3"));
                }
                return filmsDB;
            }
        }
        public static SerialsDB SerialsDB
        {
            get
            {
                if (serialsDB == null)
                {
                    serialsDB = new SerialsDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SerialsDatabase.db3"));
                }
                return serialsDB;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
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
