using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace Soons.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Camara : ContentPage
    {
        ZXingScannerPage scanPage;
        public Camara()
        {
            InitializeComponent();
            ButtonScanDefault.Clicked += ButtonScanDefault_Clicked;
        }

        private async void ButtonScanDefault_Clicked(object sender, EventArgs e)
        {
            scanPage = new ZXingScannerPage();
            scanPage.OnScanResult += (result) =>
            {
                scanPage.IsScanning = false;

                Device.BeginInvokeOnMainThread(() =>
                {
                    Navigation.PopAsync();
                    DisplayAlert("Scanned Barcode", result.Text, "Ok");
                });
            };

            await Navigation.PushAsync(scanPage);
        }
    }
}