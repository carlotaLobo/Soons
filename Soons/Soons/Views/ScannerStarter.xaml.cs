using Soons.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace Soons.Views
{
    /// <summary>
    /// Page to show the payment failure.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScannerStarter : ContentPage
    {
        ZXingScannerPage scanPage;
        /// <summary>
        /// Initializes a new instance of the <see cref="ScannerStarter" /> class.
        /// </summary>
        public ScannerStarter()
        {
            this.InitializeComponent();
            this.BindingContext = ScannerStarterViewModel.BindingContext;
            ButtonScanDefault.Clicked += ButtonScanDefault_Clicked;
        }

        private async void ButtonScanDefault_Clicked(object sender, EventArgs e)
        {
            scanPage = new ZXingScannerPage();
            scanPage.OnScanResult += (result) =>
            {
                scanPage.IsScanning = false;

                Device.BeginInvokeOnMainThread(async () =>
                {
                    // Details con tallaje
                    String codigo = result.Text;
                    DetailsTalla vistaTalla = new DetailsTalla("91883939");
                    await Navigation.PushAsync(vistaTalla, false);
                });
            };
            
                await Navigation.PushAsync(scanPage);
            
        }
    }
}