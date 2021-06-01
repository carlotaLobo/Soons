using Soons.Services;
using Soons.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("Montserrat-Bold.ttf",Alias="Montserrat-Bold")]
     [assembly: ExportFont("Montserrat-Medium.ttf", Alias = "Montserrat-Medium")]
     [assembly: ExportFont("Montserrat-Regular.ttf", Alias = "Montserrat-Regular")]
     [assembly: ExportFont("Montserrat-SemiBold.ttf", Alias = "Montserrat-SemiBold")]
     [assembly: ExportFont("UIFontIcons.ttf", Alias = "FontIcons")]
namespace Soons
{
    public partial class App : Application
    {
        public static string ImageServerPath { get; } = "https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/";
        private static ServiceIoC _ServiceLocator;
        public static ServiceIoC ServiceLocator
        {
            get { return _ServiceLocator = _ServiceLocator ?? new ServiceIoC(); }
        }
        public App()
        {
            InitializeComponent();
            
            XF.Material.Forms.Material.Init(this);

            MainPage = new NavigationPage(new BottomNavigationPage());
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
