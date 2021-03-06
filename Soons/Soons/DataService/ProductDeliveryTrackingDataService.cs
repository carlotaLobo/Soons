using System.Reflection;
using System.Runtime.Serialization.Json;
using Soons.ViewModels;
using Xamarin.Forms.Internals;

namespace Soons.DataService
{
    /// <summary>
    /// Data service to load the data from json file.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class ProductDeliveryTrackingDataService
    {
        #region fields

        private static ProductDeliveryTrackingDataService productDeliveryTrackingDataService;

        private TrackingEstadoViewModel productDeliveryTrackingViewModel;

        #endregion

        #region Constructor

        /// <summary>
        /// Creates an instance for the <see cref="ProductDeliveryTrackingDataService"/> class.
        /// </summary>
        private ProductDeliveryTrackingDataService()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets an instance of the <see cref="ProductDeliveryTrackingDataService"/>.
        /// </summary>
        public static ProductDeliveryTrackingDataService Instance => productDeliveryTrackingDataService ?? (productDeliveryTrackingDataService = new ProductDeliveryTrackingDataService());

        /// <summary>
        /// Gets or sets the value of product delivery tracking page view model.
        /// </summary>
        public TrackingEstadoViewModel TrackingEstadoViewModel =>
            this.productDeliveryTrackingViewModel = PopulateData<TrackingEstadoViewModel>("deliverytracking.json");

        #endregion

        #region Methods

        /// <summary>
        /// Populates the data for view model from json file.
        /// </summary>
        /// <typeparam name="T">Type of view model.</typeparam>
        /// <param name="fileName">Json file to fetch data.</param>
        /// <returns>Returns the view model object.</returns>
        private static T PopulateData<T>(string fileName)
        {
            var file = "Soons.Data." + fileName;

            var assembly = typeof(App).GetTypeInfo().Assembly;

            T data;

            using (var stream = assembly.GetManifestResourceStream(file))
            {
                var serializer = new DataContractJsonSerializer(typeof(T));
                data = (T)serializer.ReadObject(stream);
            }

            return data;
        }

        #endregion
    }
}
