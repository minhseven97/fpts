using fpts.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fpts
{
    public partial class App : Application
    {
        public static MasterDetailMainviewDetail MasterDetailPagee { get; internal set; }

        public App()
        {
            InitializeComponent();
            
            MainPage = new MasterDetailMainview();
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
