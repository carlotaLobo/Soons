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
    public class DetailsTallaDataService
    {
        #region fields

        private static DetailsTallaDataService detailsTallaDataService;

        private DetailsTallaViewModel detailsTallaModelService;

        #endregion

        #region Properties

        /// <summary>
        /// Gets an instance of the <see cref="DetailsTallaDataService"/>.
        /// </summary>
        public static DetailsTallaDataService Instance => detailsTallaDataService ?? (detailsTallaDataService = new DetailsTallaDataService());

        /// <summary>
        /// Gets or sets the value of movie page view model.
        /// </summary>
        public DetailsTallaViewModel DetailsTallaViewModel =>
            this.detailsTallaModelService ??
            (this.detailsTallaModelService = PopulateData<DetailsTallaViewModel>("navigation.json"));

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
