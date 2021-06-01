using Soons.DataService;
using Soons.Models;
using Soons.Services;
using Soons.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Soons.Views
{
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsTalla
    {
        ServiceSoons serviceSoons = new ServiceSoons();
        DetailsTallaViewModel detailsTallaViewModel;
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsTalla" /> class.
        /// </summary>
        public DetailsTalla(string codigo)
        {
            this.InitializeComponent();
            detailsTallaViewModel = new DetailsTallaViewModel();
            Task.Run(async () =>
            {
                await this.DevolverTallas(codigo);
            });
        }

        public async Task DevolverTallas(string codigo)
        {
            Prod producto = await this.detailsTallaViewModel.ObtenerProductoPorSku(codigo);
            List<Stock> listadoStock = await this.detailsTallaViewModel.ObtenerListadoStock(producto.Id); 
        }
    }
}