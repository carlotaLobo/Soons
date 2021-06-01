using Soons.DataService;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Soons.Views
{
    /// <summary>
    /// Page to show the product delivery tracking.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrackingEstado
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingEstado" /> class.
        /// </summary>
        public TrackingEstado()
        {
            this.InitializeComponent();
            this.BindingContext = ProductDeliveryTrackingDataService.Instance.TrackingEstadoViewModel;
        }
    }
}