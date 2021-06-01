using Soons.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Soons.Views
{
    /// <summary>
    /// Page to show the payment success.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagoTerminado : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PagoTerminado" /> class.
        /// </summary>
        public PagoTerminado()
        {
            this.InitializeComponent();
            this.BindingContext = ScannerStarterViewModel.BindingContext;
        }
    }
}