using Soons.Models;
using Soons.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;
using Button = Xamarin.Forms.Button;

namespace Soons.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResumenView : ContentPage
    {
     
        public ResumenView()
        {
           
            InitializeComponent();
            //Task.Run(async () => { await this.DinamicGrid();});
        }
        //public async Task DinamicGrid()
        //{
        //    //devolver Stock de un modelo en concreto, no todo
        //    List<Stock> stock = await this.model.AllStock(4);
        //    //var d = stock.Take(3).Select(s => s.Size).ToString();
        //    //tallas totales
        //    //int sizes = await this.model.TotalSizes();
        //    //declaro las columnas
        //        this.grid.ColumnDefinitions.Add(new ColumnDefinition());
        //        this.grid.ColumnDefinitions.Add(new ColumnDefinition());
        //        this.grid.ColumnDefinitions.Add(new ColumnDefinition());
        //    int filas = 9;
        //    for (int i = 0; i < filas; i++)
        //    { 
        //        //declaro las filas, tantas como tallas (sin repetir) haya
        //        this.grid.RowDefinitions.Add(new RowDefinition());
        //        for (int x=0; x< 3; x++)
        //        {
        //            //var d = stock.Take(x).Select(s => s.Size).ToString();
        //            //añado por cada fila, boton, x(columna), i(fila)
        //            this.grid.Children.Add(
        //                new Label {Text= "hola" }, x, i
        //                );
        //        }

        //    }



        //}
    }
}