using Soons.Base;
using Soons.Models;
using Soons.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Soons.ViewModels
{
    public class ModelViewStock : ViewModelBase
    {

        private ServiceSoons service;
       
        public ModelViewStock(ServiceSoons service)
        {
            this.service = service;
            //numero que tiene que ser dinamico
            //carga el stock
            Task.Run(async () => { await this.AllStock(4); });
        }

        private ObservableCollection<Stock> _Stock;
        public ObservableCollection<Stock> Stock
        {
            get { return this._Stock; }
            set
            {
                this._Stock = value;
                OnPropertyChanged("Stock");
            }
        }
        public async Task AllStock(int id)
        {
            List<Stock> s=await this.service.GetStockById(id);
            this.Stock = new ObservableCollection<Stock>(s);
           
        }
        public async Task<int> TotalSizes()
        {
            return await this.service.GetTotalSizes();
        }

    }
}
